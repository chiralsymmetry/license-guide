## SPDX-License-Identifier: BSD-2-Clause-Patent
## Copyright (c) 2023 Chiral Symmetry
## 
## Use of this source code is governed by a BSD-style
## license that can be found in the LICENSE file or at
## https://opensource.org/licenses/BSDplusPatent
##
## generate_html.py version 0.1.0
##
## This file is for generating an HTML version of
## the Licence Guide application. Set the culture
## variable to generate a culture specific version.
##
## TODO: Make it prettier.
##
import xml.etree.ElementTree as ET
import html, pathlib, re

## E.g.: culture = "en-US"
culture = None

mainwindow_resx = "../LicenseGuide/Resources/MainWindow.resx"
code_resx = "../LicenseGuide/Resources/Code.resx"
font_resx = "../LicenseGuide/Resources/Font.resx"
content_resx = "../LicenseGuide/Resources/Content.resx"
qanda_resx = "../LicenseGuide/Resources/QAndA.resx"

def get_resx(resx_path):
    tree = ET.parse(resx_path)
    root = tree.getroot()
    output = dict()
    for data in root.findall("./data"):
        name = data.get("name")
        value = data.find(".value").text
        output[name] = value
    return output

def get_cultured_resx(resx_path, culture = None):
    if not culture:
        return get_resx(resx_path)
    base = get_resx(resx_path)
    cultured = get_resx(resx_path.replace(".resx", f".{culture}.resx"))
    for key in base:
        if key not in cultured:
            cultured[key] = base[key]
    return cultured

mainwindow_resx = get_cultured_resx(mainwindow_resx, culture)
code_resx = get_cultured_resx(code_resx, culture)
font_resx = get_cultured_resx(font_resx, culture)
content_resx = get_cultured_resx(content_resx, culture)
qanda_resx = get_cultured_resx(qanda_resx, culture)

def htmlize_text(text, replace_linebreaks=True):
    text = html.escape(text, quote=True)
    if replace_linebreaks:
        text = text.replace("\r\n", "<br/>").replace("\n", "<br/>")
    return text

def extract_qa_resource_names(method_name):
    source_file = "../LicenseGuide/QAPairs.cs"
    with open(source_file, 'r', encoding='utf-8') as file:
        source_code = file.read()
    method_index = source_code.index(method_name)
    match = re.search(r'new string\[\]\s*\{\s*([^\}]+)\}', source_code[method_index:], re.DOTALL)
    resource_names = match.group(1)
    resource_names = [name.strip().strip('"') for name in resource_names.split(',') if name.strip() != ""]
    return resource_names

def get_qandas(tag):
    header = qanda_resx[f"group_{tag.lower()}"]
    resource_names = extract_qa_resource_names(f"{tag.capitalize()}Pairs()")
    qandas = list()
    for resource_name in resource_names:
        question = htmlize_text(qanda_resx[f"{resource_name}_question"])
        answer = htmlize_text(qanda_resx[f"{resource_name}_answer"])
        qandas.append([question, answer])
    return [header, qandas]

def extract_questionnaire_data(method_name):
    source_file = "../LicenseGuide/Questionnaire.cs"
    with open(source_file, 'r', encoding='utf-8') as file:
        source_code = file.read()
    method_index = source_code.index(method_name)
    source_code = source_code[method_index:]
    source_code = source_code[:source_code.index("}")]
    # Variable names don't necessarily reflect resource names.
    return_var = None
    answer_vars = dict()
    question_vars = dict()
    for line in source_code.split("\n"):
        # return foo;
        rtrn_ptrn = r'\s+return\s+([^;]+);'
        # var foo = new BarAnswer("baz");
        avar_ptrn = r'var\s+([^ ]+)\s+=\s+new\s+[^\(]*Answer\("([^"]+)"\)'
        # var foo = new Question(something, 123, "bar", baz, qux);
        qvar_ptrn = r'var\s+([^ ]+)\s+=\s+new\s+Question\([^,]+,\s+(\d+),\s+\"([^"]*)\",\s+([^,]+),\s+([^,]+)\);'
        r_match = re.search(rtrn_ptrn, line)
        a_match = re.search(avar_ptrn, line)
        q_match = re.search(qvar_ptrn, line)
        if r_match:
            return_var = r_match.group(1)
        if a_match:
            a_var, a_name = a_match.groups()
            answer_vars[a_var] = a_name
        if q_match:
            q_var, q_id, q_name, yes_var, no_var = q_match.groups()
            question_vars[q_var] = (q_id, q_name, yes_var, no_var)
    return return_var, answer_vars, question_vars
##    def var_to_name(var):
##        if var in answer_vars:
##            return answer_vars[var]
##        elif var in question_vars:
##            _, _, q_name, _, _ = question_vars[var]
##            return q_name
##    return_name = var_to_name(return_var)
##    answer_names = list(answer_vars.values())
##    question_names = list()
##    for val in question_vars.values():
##        q_id, q_name, yes_var, no_var = val
##        yes_name = var_to_name(yes_var)
##        no_name = var_to_name(no_var)
##        question_names.append((q_id, q_name, yes_name, no_name))
##    return return_name, answer_names, question_names

def get_questionnaire(tag, resx, textarea_label_names, textarea_tags):
    method_name = f"First{tag.capitalize()}Question()"
    return_var, answer_vars, question_vars = extract_questionnaire_data(method_name)
    output = dict()
    output["question_header"] = htmlize_text(resx["question_header"])
    output["textareas"] = []
    for name in textarea_label_names:
        label = htmlize_text(resx[name])
        output["textareas"].append(label)
    output["firstQuestion"] = return_var
    answers = dict()
    questions = dict()
    output["answers"] = answers
    output["questions"] = questions
    for a_var in answer_vars:
        a_name = answer_vars[a_var]
        answer = dict()
        answer["answerTitle"] = htmlize_text(resx[f"{a_name}_title"])
        answer["answerExplanation"] = htmlize_text(resx[f"{a_name}_explanation"])
        answer["textareas"] = []
        for tag in textarea_tags:
            text = htmlize_text(resx[f"{a_name}_{tag}"], replace_linebreaks=False)
            answer["textareas"].append(text)
        answers[a_var] = answer
    for q_var in question_vars:
        q_id, q_name, yes_var, no_var = question_vars[q_var]
        question = dict()
        question["qId"] = q_id
        question["question"] = htmlize_text(resx[f"{q_name}_question"])
        question["yesButton"] = htmlize_text(resx[f"{q_name}_yes"])
        question["noButton"] = htmlize_text(resx[f"{q_name}_no"])
        question["yes"] = yes_var
        question["no"] = no_var
        questions[q_var] = question
    return output

def get_code_questionnaire():
    return get_questionnaire("code", code_resx, ["short_text_label", "full_text_label"], ["short_text", "full_text"])

def get_font_questionnaire():
    return get_questionnaire("font", font_resx, ["license_label"], ["text"])

def get_content_questionnaire():
    return get_questionnaire("content", content_resx, ["notice_label"], ["notice"])

def generate_html(template, file_name="license-guide.html"):
    code_questionnaire = get_code_questionnaire()
    font_questionnaire = get_font_questionnaire()
    content_questionnaire = get_content_questionnaire()
    general_qanda = get_qandas("general")
    code_qanda = get_qandas("code")
    font_qanda = get_qandas("font")
    template = template.replace('const codeQuestionnaire = {};', f'const codeQuestionnaire = {code_questionnaire};')
    template = template.replace('const fontsQuestionnaire = {};', f'const fontsQuestionnaire = {font_questionnaire};')
    template = template.replace('const contentQuestionnaire = {};', f'const contentQuestionnaire = {content_questionnaire};')
    template = template.replace('const generalQAndAs = ["", []];', f'const generalQAndAs = {general_qanda};')
    template = template.replace('const codeQAndAs = ["", []];', f'const codeQAndAs = {code_qanda};')
    template = template.replace('const fontsQAndAs = ["", []];', f'const fontsQAndAs = {font_qanda};')
    page_title = htmlize_text(mainwindow_resx["window_title"])
    template = template.replace("<title>page_title</title>", f'<title>{page_title}</title>');
    template = template.replace("<legend>radio_legend</legend>", f'<legend>{page_title}</legend>')
    radiobutton_code = htmlize_text(mainwindow_resx["radiobutton_code"])
    radiobutton_font = htmlize_text(mainwindow_resx["radiobutton_font"])
    radiobutton_content = htmlize_text(mainwindow_resx["radiobutton_content"])
    radiobutton_qanda = htmlize_text(mainwindow_resx["radiobutton_qanda"])
    template = template.replace('<label for="code-section">code-section</label>', f'<label for="code-section">{radiobutton_code}</label>')
    template = template.replace('<label for="fonts-section">fonts-section</label>', f'<label for="fonts-section">{radiobutton_font}</label>')
    template = template.replace('<label for="other-materials-section">other-materials-section</label>', f'<label for="other-materials-section">{radiobutton_content}</label>')
    template = template.replace('<label for="q-and-a-section">q-and-a-section</label>', f'<label for="q-and-a-section">{radiobutton_qanda}</label>')
    with open(file_name, 'w', encoding='utf-8') as file:
        file.write(template)

html_template = """<!DOCTYPE html>
<html>
	<head>
		<title>page_title</title>
		<style>
			.container {
				display: flex;
				flex-direction: column;
				align-items: center;
				text-align: center;
				margin: 20px;
			}

			.header {
				font-size: 24px;
				font-weight: bold;
				text-align: center;
			}
			
			.section {
				max-width: 700px;
			}

			.section-selector {
				display: flex;
				justify-content: center;
				margin-bottom: 20px;
			}

			.section-selector label {
				font-size: 18px;
				cursor: pointer;
				margin-right: 20px;
			}

			.question {
				display: block;
			}

			.answer {
				display: none;
				text-align: left;
				margin-top: 20px;
			}

			qanda {
				display: none;
				margin-top: 20px;
			}

			.yes-no-btns {
				margin-top: 20px;
				display: block;
				justify-content: center;
			}

			.yes-no-btns button {
				max-width: 500px;
				min-width: 100px;
				min-height: 40px;
				margin: 0 10px;
				padding: 10px 40px;
				white-space: normal;
				word-wrap: break-word;
			}

			.green-btn {
				background-color: #d9ead3;
				color: black;
			}

			.red-btn {
				background-color: #f4cccc;
				color: black;
			}

			#textareas {
				margin-top: 20px;
			}

			.textarea {
				width: 600px;
				height: 300px;
				margin-bottom: 20px;
				resize: none;
			}

			.textarea-label {
				font-weight: bold;
			}

			fieldset {
				max-width: 600px;
				text-align: left;
			}

			details {
				margin-bottom: 20px;
			}

			details > summary {
				cursor: pointer;
			}

			details > p {
				margin-left: 20px;
			}

			footer {
				position: fixed;
				left: 0;
				bottom: 0;
				width: 100%;
				background-color: #333;
				color: #fff;
				text-align: center;
				font-size: 12px;
				padding: 10px 0;
			}

			footer a {
				color: #fff;
				text-decoration: underline;
			}
		</style>
	</head>
	<body>
		<div class="container">
			<div class="section-selector">
				<fieldset>
					<legend>radio_legend</legend>
					
					<input type="radio" id="code-section" name="section" checked>
					<label for="code-section">code-section</label>
					
					<input type="radio" id="fonts-section" name="section">
					<label for="fonts-section">fonts-section</label>
					
					<input type="radio" id="other-materials-section" name="section">
					<label for="other-materials-section">other-materials-section</label>
					
					<input type="radio" id="q-and-a-section" name="section">
					<label for="q-and-a-section">q-and-a-section</label>
				</fieldset>
			</div>
			<div id="questionnaire" class="section">
				<div id="qId" class="header">qId</div>
				<div id="question">question</div>
				<div class="yes-no-btns">
					<button id="yesButton" class="green-btn">yesButton</button><br/><br/>
					<button id="noButton" class="red-btn">noButton</button>
				</div>
			</div>
			<div id="general-answer" class="answer section">
				<div id="answerTitle" class="header">answerTitle</div>
				<div id="answerExplanation">answerExplanation</div>
				<div id="textareas"></div>
			</div>
			<div id="qanda" class="section">
				<fieldset>
					<legend id="group_general">group_general</legend>
					<div id="general_questions"></div>
				</fieldset>
				<fieldset>
					<legend id="group_code">group_code</legend>
					<div id="code_questions"></div>
				</fieldset>
				<fieldset>
					<legend id="group_fonts">group_fonts</legend>
					<div id="fonts_questions"></div>
				</fieldset>
			</div>
		</div>
		<script>
			"use strict";
			// SPDX-License-Identifier: BSD-2-Clause-Patent
			/* 
			 * Copyright (c) 2023 Chiral Symmetry
			 * 
			 * Use of this source code is governed by a BSD-style
			 * license that can be found in the LICENSE file or at
			 * https://opensource.org/licenses/BSDplusPatent
			 */
			
			function connectRadioButtons() {
				const triples = [
					["code-section", showQuestion, codeQuestionnaire],
					["fonts-section", showQuestion, fontsQuestionnaire],
					["other-materials-section", showQuestion, contentQuestionnaire],
					["q-and-a-section", showQAndA, undefined],
				];
				for (let i in triples) {
					const triple = triples[i];
					const radioButton = document.getElementById(triple[0]);
					const fun = triple[1];
					const arg = triple[2];
					radioButton.addEventListener("click", function() {
						fun(arg);
					});
				}
			}
			
			function hideSections() {
				const sections = document.getElementsByClassName("section");
				for (let section of sections) {
					section.style.display = "none";
				}
			}
			
			function showQAndA() {
				populateQAndA("general", generalQAndAs);
				populateQAndA("code", codeQAndAs);
				populateQAndA("fonts", fontsQAndAs);
				hideSections();
				document.getElementById("qanda").style.display = "block";
			}
			
			function showDefaultQuestion() {
				document.getElementById("code-section").checked = true;
				showQuestion(codeQuestionnaire);
			}
			
			function showAnswer(questionnaire, answerName) {
				const answer = questionnaire["answers"][answerName];
				for (let rId of ["answerTitle", "answerExplanation"]) {
					const element = document.getElementById(rId);
					element.innerHTML = answer[rId];
				}
				const textareas = document.getElementById("textareas");
				let new_html = "";
				for (let i = 0; i < questionnaire["textareas"].length; i++) {
					const label = questionnaire["textareas"][i];
					const textarea_content = answer["textareas"][i];
					new_html += `
					<label for="textarea_${i}" class="textarea-label">${label}</label><br/>
					<textarea id="textarea_${i}" class="textarea" disabled>${textarea_content}</textarea><br/>
`;
				}
				textareas.innerHTML = new_html;
				hideSections();
				const answerSection = document.getElementById("general-answer");
				answerSection.style.display = "block";
			}
			
			function showQuestion(questionnaire, questionName) {
				if (questionName == null) {
					questionName = questionnaire["firstQuestion"];
				}
				const question = questionnaire["questions"][questionName];
				document.getElementById("qId").innerHTML = questionnaire["question_header"].replace("{0}", question["qId"]);
				for (let id of ["question", "yesButton", "noButton"]) {
					const element = document.getElementById(id);
					element.innerHTML = question[id];
				}
				changeEventListener("yesButton", questionnaire, question["yes"]);
				changeEventListener("noButton", questionnaire, question["no"]);
				hideSections();
				document.getElementById("questionnaire").style.display = "block";
			}
			
			function changeEventListener(buttonId, questionnaire, destination) {
				const old_button = document.getElementById(buttonId);
				const new_button = old_button.cloneNode(true);
				old_button.parentNode.replaceChild(new_button, old_button);
				if (destination in questionnaire["questions"]) {
					new_button.addEventListener("click", function() {
						showQuestion(questionnaire, destination);
					});
				} else if (destination in questionnaire["answers"]) {
					new_button.addEventListener("click", function() {
						showAnswer(questionnaire, destination);
					});
				} else {
					throw new Error(`Got bad destination: ${destination}`);
				}
			}
			
			function populateQAndA(tag, qAndAs) {
				const header = qAndAs[0];
				document.getElementById(`group_${tag}`).innerHTML = header;
				const detailsContainer = document.getElementById(`${tag}_questions`);
				let new_html = "";
				for (let qAndA of qAndAs[1]) {
					const q = qAndA[0];
					const a = qAndA[1];
					new_html += `
						<details><summary>${q}</summary><p>${a}</p></details>
`;
				}
				detailsContainer.innerHTML = new_html;
			}
			
			const codeQuestionnaire = {};
			
			const fontsQuestionnaire = {};
			
			const contentQuestionnaire = {};
			
			const generalQAndAs = ["", []];
			const codeQAndAs = ["", []];
			const fontsQAndAs = ["", []];
			
			connectRadioButtons();
			showDefaultQuestion();
		</script>
		<footer>
			Copyright &copy; 2023 Chiral Symmetry.
			This work is mainly licensed under a <a href="https://creativecommons.org/licenses/by/4.0/">CC BY 4.0</a>.
			To see the specifics <a href="https://github.com/chiralsymmetry/license-guide">visit us on GitHub</a>.
		</footer>
	</body>
</html>"""

generate_html(html_template)

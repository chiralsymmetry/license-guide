﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LicenseGuide.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class QAndA {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QAndA() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LicenseGuide.Resources.QAndA", typeof(QAndA).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No, that&apos;s usually a bad idea. If your goal is to place specific restrictions on what others can do with your code, you should be aware that it is difficult to be unambiguous; if you write something wrong, you may inadvertently introduce a loophole that allows code-receiving developers to do something you explicitly meant to forbid (or to refrain from doing something you explicitly meant to force them to do). And if your goal is to make things easier for other developers who want use your code, a custom lic [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_custom_license_answer {
            get {
                return ResourceManager.GetString("code_custom_license_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No license does exactly what I want. Can&apos;t I just write my own license?.
        /// </summary>
        public static string code_custom_license_question {
            get {
                return ResourceManager.GetString("code_custom_license_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a contentious issue that arises particularly in the context of GPL-style licenses that require the derivative work to be licensed under the same license as the original work.
        ///
        ///Pretty much everyone agrees that if you take someone else&apos;s source code and make a few small changes, you are creating a derivative work, and that if in a project you write almost all of the source code yourself but copy and paste someone else&apos;s function (e.g., for some special mathematical calculation), you are also creatin [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_derivative_works_limit_answer {
            get {
                return ResourceManager.GetString("code_derivative_works_limit_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Where is the line drawn for derivative works within source code/software? Will my source code have to be licensed as GPL?.
        /// </summary>
        public static string code_derivative_works_limit_question {
            get {
                return ResourceManager.GetString("code_derivative_works_limit_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Combining source code means creating a derivative work. To create or distribute a derivative work, you must have permission from the creators. If the permission comes conditionally through a license, you must comply with all the terms of the license in order to create or distribute the combination.
        ///
        ///The GPL allows free modification for personal use, i.e. you may modify code and use it privately; the code modifications create a derivative work consisting of GPL-licensed code and “proprietary” code under pu [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_gpl_mixing_answer {
            get {
                return ResourceManager.GetString("code_gpl_mixing_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What happens if I combine GPL code with code under a different license?.
        /// </summary>
        public static string code_gpl_mixing_question {
            get {
                return ResourceManager.GetString("code_gpl_mixing_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No, copyright generally does not apply to output, just as Microsoft does not own the text document you create in Microsoft Word. An exception, of course, is when the output must be considered a derivative work, such as a GPL-licensed program that prints its own source code. A recording of a play session of a computer game with GPL-licensed graphical resources would also reasonably be a GPL-licensed derivative work.
        ///
        ///The guiding principle is that the output is protected by the same copyright as the input.  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_gpl_output_answer {
            get {
                return ResourceManager.GetString("code_gpl_output_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Does the GPL license extend to the output of a program?.
        /// </summary>
        public static string code_gpl_output_question {
            get {
                return ResourceManager.GetString("code_gpl_output_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A license contains conditions that must be met if use is to be granted. Two licenses are incompatible if their terms cannot be complied with at the same time, e.g. if one license prohibits commercial use while the other license prohibits non-commercial use: there is no conceivable situation in which software under such a license combination can be used by a licensee.
        ///
        ///Another form of incompatibility concerns the fact that licenses may also provide legal guarantees: one license may provide guarantees that  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_license_compatibility_answer {
            get {
                return ResourceManager.GetString("code_license_compatibility_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is license compatibility? What is GPL compatibility?.
        /// </summary>
        public static string code_license_compatibility_question {
            get {
                return ResourceManager.GetString("code_license_compatibility_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creators with full rights to a work can offer their work to other people not only under a single license to use the work, but also a choice: “You may use my work under license A, or B, or C”. This means that it is up to the user to choose which terms are most appropriate.
        ///
        ///The creators can also use the word “and” instead of “or”, as in “you may use my source code under license A, and B, and C”. This means that all conditions of all licenses together must be met for the use to be legal. Of course, this can [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_multiple_licenses_answer {
            get {
                return ResourceManager.GetString("code_multiple_licenses_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How does offering your source code under multiple licenses work?.
        /// </summary>
        public static string code_multiple_licenses_question {
            get {
                return ResourceManager.GetString("code_multiple_licenses_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no major difference from mixing source code under different licenses: licensees must comply with all terms at the same time. Unlicensed source code may be mixed with material that does not explicitly prohibit the use of closed code, such as any Creative Commons license. The same is true for source code under a permissive license, such as “BSD+Patent”.
        ///
        ///However, complications may arise when any part is under a “copyleft” license, such as the GPL: if a GPL-licensed work is used together with a GPL- [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_noncode_mix_answer {
            get {
                return ResourceManager.GetString("code_noncode_mix_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How does licensing work when source code is mixed with other types of material, such as graphical resources in a computer game?.
        /// </summary>
        public static string code_noncode_mix_question {
            get {
                return ResourceManager.GetString("code_noncode_mix_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Software Package Data Exchange, or SPDX, is a standard made by the Linux Foundation for providing information on software, such as applicable licenses. It allows for tools to find legal problems when combining code. Even if you aren&apos;t going to use such tools, it serves as an extra point of clarity for others.
        ///
        ///The format allows for situations with multiple licenses in single files:
        ///// SPDX-License-Identifier: Apache-2.0 AND GPL-3.0-only
        ///
        ///The format also allows for when the developer wants to allow  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_spdx_answer {
            get {
                return ResourceManager.GetString("code_spdx_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is SPDX-License-Identifier?.
        /// </summary>
        public static string code_spdx_question {
            get {
                return ResourceManager.GetString("code_spdx_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are ways to legally circumvent the GPL, and copyright in general. One way is called “clean room design”, where you hire developers who have no knowledge of the original implementation, and give them only specifications of what you want them to build. In other words, the only thing the developers are allowed to know is the public API of the original. (If you didn&apos;t have to study the original to get the specs, you might be able to legally create the work yourself.)
        ///
        ///A more GPL-specific solution if you [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_use_gpl_without_gpl_answer {
            get {
                return ResourceManager.GetString("code_use_gpl_without_gpl_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can you use GPL code without having to license your own code as GPL? Can you circumvent someone else&apos;s license?.
        /// </summary>
        public static string code_use_gpl_without_gpl_question {
            get {
                return ResourceManager.GetString("code_use_gpl_without_gpl_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In addition to the fact that software may be subject to special legal treatment in many countries, e.g. in restrictions on private copying that would be legal for other kinds of works, there may also be other complications, such as when defining “derivative work” in relation to source code: compiling source code into binary form could be considered legally the same as translating a novel from English into German, which might require explicit permission from the author. Even the simple execution of compiled  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string code_why_license_answer {
            get {
                return ResourceManager.GetString("code_why_license_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Why are licenses needed specifically for software/source code (rather than using those for cultural works)?.
        /// </summary>
        public static string code_why_license_question {
            get {
                return ResourceManager.GetString("code_why_license_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A “typeface” is an author&apos;s design of letters, while a “font” is a specific variation of a typeface, such as bold in size 10 point. The word “font” also refers to a specific digitization of a font, i.e. a font file for use on a computer.
        ///
        ///In some countries, both typefaces and font files are protected by copyright, but many countries have decided that typefaces should not be protected by copyright (while still protecting font files). In such a country, it would be a crime to distribute someone else&apos;s font  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string font_fonts_typefaces_answer {
            get {
                return ResourceManager.GetString("font_fonts_typefaces_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is the difference between typefaces and fonts?.
        /// </summary>
        public static string font_fonts_typefaces_question {
            get {
                return ResourceManager.GetString("font_fonts_typefaces_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fonts can legally function as something between software and cultural works, as fonts are intended to be used as building blocks in other works (e.g. text on a billboard), while their design may require artistic ability. It is possible that in some countries the normal use of a typeface or font would result in something that could be considered a derivative work. This is rarely the intention of the people who create font files. For clarity and legal certainty, it may therefore be best to use a license speci [rest of string was truncated]&quot;;.
        /// </summary>
        public static string font_why_font_license_answer {
            get {
                return ResourceManager.GetString("font_why_font_license_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Why are fonts a separate category?.
        /// </summary>
        public static string font_why_font_license_question {
            get {
                return ResourceManager.GetString("font_why_font_license_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No, copyright applies even if you publish your work under a pseudonym (an assumed name) or anonymously (no name).
        ///
        ///However, there are times when anonymous or pseudonymous publication may present a legal obstacle. For example, if you want to defend your work against copyright infringement, you must be able to prove that you are the creator of the work, and in the absence of public knowledge about whether the creator is alive or not, the copyright of the work will expire based on the year the work was publi [rest of string was truncated]&quot;;.
        /// </summary>
        public static string general_anonymous_answer {
            get {
                return ResourceManager.GetString("general_anonymous_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do I have to use my real name in copyright notices?.
        /// </summary>
        public static string general_anonymous_question {
            get {
                return ResourceManager.GetString("general_anonymous_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Most countries have agreed that a work should have a minimum protection period of at least 50 years after all the creators of the work have died, which is usually referred to as “life + 50 years”. Many countries have “life + 70 years”, and some countries have “life + 120 years”. However, if the public cannot determine who the creators of the work are (i.e. if they are alive or not), the minimum term of protection is 50 years from the date the work was made available to the public.
        ///
        ///Some types of works may [rest of string was truncated]&quot;;.
        /// </summary>
        public static string general_copyright_length_answer {
            get {
                return ResourceManager.GetString("general_copyright_length_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How long does copyright last?.
        /// </summary>
        public static string general_copyright_length_question {
            get {
                return ResourceManager.GetString("general_copyright_length_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No, copyright applies regardless of whether you use the copyright symbol or not, but it is customary to do so anyway, and to write something like “(c)” in cases where you cannot write “©”. It is always best to be clear..
        /// </summary>
        public static string general_copyright_symbol_answer {
            get {
                return ResourceManager.GetString("general_copyright_symbol_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do I have to use the copyright symbol, ©?.
        /// </summary>
        public static string general_copyright_symbol_question {
            get {
                return ResourceManager.GetString("general_copyright_symbol_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright in a work applies whether or not you include a copyright notice, and regardless of the particular form of the notice. If you do include a notice, it&apos;s a good idea to include the year. The years are mainly there to help other people tell whether the copyright on the work has expired — and, if it has not, to make it even clearer that the creators are asserting their rights. So if you want to be clear, you can write the year when you first made the work available to the public. For example, if you wr [rest of string was truncated]&quot;;.
        /// </summary>
        public static string general_copyright_years_answer {
            get {
                return ResourceManager.GetString("general_copyright_years_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How do years work in copyright notices?.
        /// </summary>
        public static string general_copyright_years_question {
            get {
                return ResourceManager.GetString("general_copyright_years_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A derivative work is a work created based on someone else&apos;s work, in the broadest sense of the term. Performing someone else&apos;s song creates a derivative work; creating subtitles to someone else&apos;s film creates a derivative work; creating a collage of pictures that includes a detail from someone else&apos;s picture creates a derivative work. In many countries, it is considered a violation of copyright law to create a derivative work without the permission of the original creator, even for private use (e.g., transl [rest of string was truncated]&quot;;.
        /// </summary>
        public static string general_derivative_works_answer {
            get {
                return ResourceManager.GetString("general_derivative_works_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is a derivative work? What applies to derivative works?.
        /// </summary>
        public static string general_derivative_works_question {
            get {
                return ResourceManager.GetString("general_derivative_works_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It depends on which countries are involved, and what agreements they have with each other, but a rule of thumb might be that if a work is published in another country, you can treat it as if it were published in your own country. What constitutes a copyright infringement therefore depends on where the infringement occurs (a question that can be complicated in the case of infringements that take place over the Internet, for example)..
        /// </summary>
        public static string general_international_answer {
            get {
                return ResourceManager.GetString("general_international_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to How does copyright — and copyright infringement — work internationally?.
        /// </summary>
        public static string general_international_question {
            get {
                return ResourceManager.GetString("general_international_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In general, copyright can be said to consist of economic rights and moral rights. Economic rights are the right to control the distribution and use of your work. The economic right to a work can usually be sold so that the author no longer has the right to control its distribution and use.
        ///
        ///The moral right is primarily the right to be recognized as the author of the work, but also the right to object to (perceived) defamatory treatment of the work. In many countries, moral rights cannot be sold, transferr [rest of string was truncated]&quot;;.
        /// </summary>
        public static string general_moral_rights_answer {
            get {
                return ResourceManager.GetString("general_moral_rights_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What are moral rights?.
        /// </summary>
        public static string general_moral_rights_question {
            get {
                return ResourceManager.GetString("general_moral_rights_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It generally refers to the right to control the distribution and use of images, videos, and sound recordings in which you are personally identifiable, especially for commercial use. It is not a right that exists in all countries, but where it does, it is something to be considered separately from copyright..
        /// </summary>
        public static string general_publicity_rights_answer {
            get {
                return ResourceManager.GetString("general_publicity_rights_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is the right of publicity / right of personality / right of privacy?.
        /// </summary>
        public static string general_publicity_rights_question {
            get {
                return ResourceManager.GetString("general_publicity_rights_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When a person creates a work, it may cross the threshold of originality, which means that it is legally protected under copyright law. This protection applies as soon as the work crosses the threshold, “as soon as the pen leaves the paper”, without anyone else having to see the work or even be notified that it has been created. What is required for the work to cross the threshold of originality varies depending on where the work is created: in some countries the threshold is very low, while others may requi [rest of string was truncated]&quot;;.
        /// </summary>
        public static string general_what_is_originality_answer {
            get {
                return ResourceManager.GetString("general_what_is_originality_answer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is the “threshold of originality”? When is something protected by copyright?.
        /// </summary>
        public static string general_what_is_originality_question {
            get {
                return ResourceManager.GetString("general_what_is_originality_question", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source Code.
        /// </summary>
        public static string group_code {
            get {
                return ResourceManager.GetString("group_code", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fonts.
        /// </summary>
        public static string group_font {
            get {
                return ResourceManager.GetString("group_font", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General.
        /// </summary>
        public static string group_general {
            get {
                return ResourceManager.GetString("group_general", resourceCulture);
            }
        }
    }
}
//------------------------------------------------------------------------------
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
    public class MainWindow {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MainWindow() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LicenseGuide.Resources.MainWindow", typeof(MainWindow).Assembly);
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
        ///   Looks up a localized string similar to Source Code.
        /// </summary>
        public static string radiobutton_code {
            get {
                return ResourceManager.GetString("radiobutton_code", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Other Materials.
        /// </summary>
        public static string radiobutton_content {
            get {
                return ResourceManager.GetString("radiobutton_content", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fonts.
        /// </summary>
        public static string radiobutton_font {
            get {
                return ResourceManager.GetString("radiobutton_font", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Questions &amp; Answers.
        /// </summary>
        public static string radiobutton_qanda {
            get {
                return ResourceManager.GetString("radiobutton_qanda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to License Guide.
        /// </summary>
        public static string window_title {
            get {
                return ResourceManager.GetString("window_title", resourceCulture);
            }
        }
    }
}

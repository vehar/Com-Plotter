﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComPlotter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ComPlotter.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About.
        /// </summary>
        internal static string AboutDialogTitle {
            get {
                return ResourceManager.GetString("AboutDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serial grabber , Valentyn Korniienko, 2018.
        /// </summary>
        internal static string Author {
            get {
                return ResourceManager.GetString("Author", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string Error_Caption_FailureWithOpenSerialConnection {
            get {
                return ResourceManager.GetString("Error_Caption_FailureWithOpenSerialConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occured when trying to open Serial.
        /// </summary>
        internal static string Error_FailureWithOpenSerialConnection {
            get {
                return ResourceManager.GetString("Error_FailureWithOpenSerialConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text files(*.txt )|*.txt;.
        /// </summary>
        internal static string FilesExtensionsFilter {
            get {
                return ResourceManager.GetString("FilesExtensionsFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Average:.
        /// </summary>
        internal static string TitleAverageBlockValue {
            get {
                return ResourceManager.GetString("TitleAverageBlockValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /***************************/.
        /// </summary>
        internal static string TitleForBlockEnd {
            get {
                return ResourceManager.GetString("TitleForBlockEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /********BLOCK_%**********/.
        /// </summary>
        internal static string TitleForBlockStart {
            get {
                return ResourceManager.GetString("TitleForBlockStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OneBits:.
        /// </summary>
        internal static string TitleOneBitsCount {
            get {
                return ResourceManager.GetString("TitleOneBitsCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ZeroBits:.
        /// </summary>
        internal static string TitleZeroBitsCount {
            get {
                return ResourceManager.GetString("TitleZeroBitsCount", resourceCulture);
            }
        }
    }
}

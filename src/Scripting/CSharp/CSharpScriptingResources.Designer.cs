﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.CSharp.Scripting {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CSharpScriptingResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CSharpScriptingResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.CSharp.Scripting.CSharp.CSharpScriptingResources", typeof(CSharpScriptingResources).Assembly);
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
        ///   Looks up a localized string similar to Usage: csi [option] ... [script-file.csx] [script-argument] ...
        ///
        ///Executes script-file.csx if specified, otherwise launches an interactive REPL (Read Eval Print Loop).
        ///
        ///Options:
        ///  /help                          Display this usage message (alternative form: /?)
        ///  /i                             Drop to REPL after executing the specified script.
        ///  /r:&lt;file&gt;                      Reference metadata from the specified assembly file (alternative form: /reference)
        ///  /r:&lt;file list&gt;                 Reference m [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InteractiveHelp {
            get {
                return ResourceManager.GetString("InteractiveHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft (R) Visual C# Interactive Compiler version {0}.
        /// </summary>
        internal static string LogoLine1 {
            get {
                return ResourceManager.GetString("LogoLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright (C) Microsoft Corporation. All rights reserved..
        /// </summary>
        internal static string LogoLine2 {
            get {
                return ResourceManager.GetString("LogoLine2", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Greatt.DAL.Resource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorEntityResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorEntityResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Greatt.DAL.Resource.ErrorEntityResource", typeof(ErrorEntityResource).Assembly);
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
        ///   Looks up a localized string similar to Erreur : La liste d&apos;entité est null ou vide.
        /// </summary>
        public static string NoEntities {
            get {
                return ResourceManager.GetString("NoEntities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erreur : La liste d&apos;identifiant d&apos;entité est null ou vide.
        /// </summary>
        public static string NoEntitiesId {
            get {
                return ResourceManager.GetString("NoEntitiesId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erreur : L&apos;entité est null ou vide.
        /// </summary>
        public static string NoEntity {
            get {
                return ResourceManager.GetString("NoEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erreur : L&apos;identifiant d&apos;entité n&apos;est pas valide.
        /// </summary>
        public static string NoEntityId {
            get {
                return ResourceManager.GetString("NoEntityId", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherService.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WeatherService.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;id&quot;: 707860,
        ///    &quot;name&quot;: &quot;Hurzuf&quot;,
        ///    &quot;country&quot;: &quot;UA&quot;,
        ///    &quot;coord&quot;: {
        ///      &quot;lon&quot;: 34.283333,
        ///      &quot;lat&quot;: 44.549999
        ///    }
        ///  },
        ///  {
        ///    &quot;id&quot;: 519188,
        ///    &quot;name&quot;: &quot;Novinki&quot;,
        ///    &quot;country&quot;: &quot;RU&quot;,
        ///    &quot;coord&quot;: {
        ///      &quot;lon&quot;: 37.666668,
        ///      &quot;lat&quot;: 55.683334
        ///    }
        ///  },
        ///  {
        ///    &quot;id&quot;: 1283378,
        ///    &quot;name&quot;: &quot;Gorkhā&quot;,
        ///    &quot;country&quot;: &quot;NP&quot;,
        ///    &quot;coord&quot;: {
        ///      &quot;lon&quot;: 84.633331,
        ///      &quot;lat&quot;: 28
        ///    }
        ///  },
        ///  {
        ///    &quot;id&quot;: 1270260,
        ///    &quot;name&quot;: &quot;State of Haryāna&quot;,
        ///    &quot;country&quot;: &quot;IN&quot;,
        ///    &quot;coord&quot;: {
        ///      &quot;lon [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string city_list_json {
            get {
                return ResourceManager.GetString("city.list.json", resourceCulture);
            }
        }
    }
}

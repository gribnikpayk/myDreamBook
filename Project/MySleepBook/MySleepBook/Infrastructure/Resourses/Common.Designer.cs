﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySleepBook.Infrastructure.Resourses {
    using System;
    using System.Reflection;
    
    
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
    internal class Common {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Common() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySleepBook.Infrastructure.Resourses.Common", typeof(Common).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to У Вас пока нет данных, чтобы отобразить график сновидений.
        ///Нажмите на дату в календаре и заполните форму..
        /// </summary>
        internal static string txt_noStatistic {
            get {
                return ResourceManager.GetString("txt_noStatistic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to К сожалению мы ничего не можем найти по Вашему запросу.
        ///Попробуйте ввести похожее слово или поищите что-нибудь другое.
        /// </summary>
        internal static string txt_NotFound {
            get {
                return ResourceManager.GetString("txt_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Введите в поисковую строку то, что Вам приснилось.
        ///Например &quot;девушка&quot; или &quot;дом&quot;..
        /// </summary>
        internal static string txt_SearchDescription {
            get {
                return ResourceManager.GetString("txt_SearchDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Добро пожаловать!
        ///В этом приложении Вы сможете толковать свои сны, делиться ими со всеми, а также получать ответы на свои вопросы от экспертов.
        ///Поделитесь своими снами прямо сейчас!.
        /// </summary>
        internal static string txt_Welcom {
            get {
                return ResourceManager.GetString("txt_Welcom", resourceCulture);
            }
        }
    }
}

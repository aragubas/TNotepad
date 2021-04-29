﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Installer.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Installer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon app_icon {
            get {
                object obj = ResourceManager.GetObject("app_icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Language file for ChargerPlugEvent Installer
        ///# -- File linked inside the installer executable
        ///LanguageLink;english
        ///
        ///# -- Window
        ///WindowTitle;TNotepad Installer
        ///
        ///# -- Load LangFile Screen
        ///LoadLangFile_LoadingLabel;Loading language file...
        ///
        ///# -- Main Screen
        ///MainPage_TitleLabel;Instalation -&gt; Set Up
        ///MainPage_InstallingTitle;Instalation -&gt; Installing
        ///
        ///# -- About Install
        ///AboutInstall_Title;Instalation -&gt; Set Up -&gt; About TNotepad
        ///
        ///# -- Instalation Complete
        ///InstalationComplete_Title;Instalation  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string English {
            get {
                return ResourceManager.GetString("English", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ChargerPlugEvent.exe.
        /// </summary>
        internal static string ExecutableName {
            get {
                return ResourceManager.GetString("ExecutableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] InstalationPackpage {
            get {
                object obj = ResourceManager.GetObject("InstalationPackpage", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Arquivo de linguagem para TNotepad
        ///# -- Arquivo de Idioma linkado no executavel
        ///LanguageLink;portugues
        ///
        ///# -- Janela
        ///WindowTitle;Instalador do TabNotepad
        /// 
        ///# -- Tela de Carregamento do Idioma
        ///LoadLangFile_LoadingLabel;Carregando Arquivo de Idioma...
        ///
        ///# -- Tela Principal
        ///MainPage_TitleLabel;Instalação -&gt; Configurar
        ///MainPage_InstallingTitle;Instalação -&gt; Instalando
        ///
        ///# -- Sobre Instalação
        ///AboutInstall_Title;Instalação -&gt; Configurar -&gt; Sobre TabNotepad
        ///
        ///# -- Instalação Completa
        ///InstalationCom [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Portugues {
            get {
                return ResourceManager.GetString("Portugues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap TabbedNotpadIcon {
            get {
                object obj = ResourceManager.GetObject("TabbedNotpadIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #!VERSION=1.0
        ///name=TNotepad
        ///subname=ARAGUBAS-TAIYOU-TNOTEPAD
        ///version=1.57
        ///by=Aragubas.
        /// </summary>
        internal static string TNotepad {
            get {
                return ResourceManager.GetString("TNotepad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #############################
        ///# Theme file for TabNotepad
        ///# Dark Theme
        ///# Theme data works like:
        ///# &lt;key&gt;;A,R,G,B
        ///# Alpha transparency can maybe be supported
        ///
        ///# = Forms
        ///Form_BackgroundColor;255, 42, 42, 58
        ///Form_ForegroundColor;255, 240, 240, 230
        ///Form_CloseButton_BackgroundColor; 255, 235, 120, 120
        ///Form_CloseButton_ForegroundColor; 255, 220, 220, 230
        ///Form_CloseButton_MouseDownColor; 255, 200, 100, 100
        ///Form_MaximizeButton_BackgroundColor; 255, 100, 100, 100
        ///Form_MaximizeButton_ForegroundColor; 255 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UITheme {
            get {
                return ResourceManager.GetString("UITheme", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18444
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoApp.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DemoApp.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на All Customers.
        /// </summary>
        public static string AllCustomersViewModel_DisplayName {
            get {
                return ResourceManager.GetString("AllCustomersViewModel_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Companies have no last name.
        /// </summary>
        public static string Customer_Error_CompanyHasNoLastName {
            get {
                return ResourceManager.GetString("Customer_Error_CompanyHasNoLastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на E-mail address is invalid.
        /// </summary>
        public static string Customer_Error_InvalidEmail {
            get {
                return ResourceManager.GetString("Customer_Error_InvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на E-mail address is missing.
        /// </summary>
        public static string Customer_Error_MissingEmail {
            get {
                return ResourceManager.GetString("Customer_Error_MissingEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на First name is missing.
        /// </summary>
        public static string Customer_Error_MissingFirstName {
            get {
                return ResourceManager.GetString("Customer_Error_MissingFirstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Last name is missing.
        /// </summary>
        public static string Customer_Error_MissingLastName {
            get {
                return ResourceManager.GetString("Customer_Error_MissingLastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Company.
        /// </summary>
        public static string CustomerViewModel_CustomerTypeOption_Company {
            get {
                return ResourceManager.GetString("CustomerViewModel_CustomerTypeOption_Company", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на (Not Specified).
        /// </summary>
        public static string CustomerViewModel_CustomerTypeOption_NotSpecified {
            get {
                return ResourceManager.GetString("CustomerViewModel_CustomerTypeOption_NotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Person.
        /// </summary>
        public static string CustomerViewModel_CustomerTypeOption_Person {
            get {
                return ResourceManager.GetString("CustomerViewModel_CustomerTypeOption_Person", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на New Customer.
        /// </summary>
        public static string CustomerViewModel_DisplayName {
            get {
                return ResourceManager.GetString("CustomerViewModel_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Customer type must be selected.
        /// </summary>
        public static string CustomerViewModel_Error_MissingCustomerType {
            get {
                return ResourceManager.GetString("CustomerViewModel_Error_MissingCustomerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cannot save an invalid customer..
        /// </summary>
        public static string CustomerViewModel_Exception_CannotSave {
            get {
                return ResourceManager.GetString("CustomerViewModel_Exception_CannotSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create new customer.
        /// </summary>
        public static string MainWindowViewModel_Command_CreateNewCustomer {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_CreateNewCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на View all customers.
        /// </summary>
        public static string MainWindowViewModel_Command_ViewAllCustomers {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_ViewAllCustomers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на MVVM Demo App.
        /// </summary>
        public static string MainWindowViewModel_DisplayName {
            get {
                return ResourceManager.GetString("MainWindowViewModel_DisplayName", resourceCulture);
            }
        }
    }
}

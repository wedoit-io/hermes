//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apexnet.Dispatch.Api.Client.Configuration
{
    
    
    /// <summary>
    /// The DispatchApi Configuration Section.
    /// </summary>
    public partial class DispatchApi : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the DispatchApi Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string DispatchApiSectionName = "dispatchApi";
        
        /// <summary>
        /// The XML path of the DispatchApi Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string DispatchApiSectionPath = "dispatchApi";
        
        /// <summary>
        /// Gets the DispatchApi instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi Instance
        {
            get
            {
                return ((global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi)(global::System.Configuration.ConfigurationManager.GetSection(global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi.DispatchApiSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Url Property
        /// <summary>
        /// The XML name of the <see cref="Url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string UrlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Url.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi.UrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Url
        {
            get
            {
                return ((string)(base[global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi.UrlPropertyName]));
            }
            set
            {
                base[global::Apexnet.Dispatch.Api.Client.Configuration.DispatchApi.UrlPropertyName] = value;
            }
        }
        #endregion
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace CDON.Marketplace.Product {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IsNullable=false)]
    public partial class variantBySize {
        
        private identity identityField;
        
        private untranslatable sizeField;
        
        /// <remarks/>
        public identity identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        public untranslatable size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class identity {
        
        private string idField;
        
        private string gtinField;
        
        private string mpnField;
        
        private string skuField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string gtin {
            get {
                return this.gtinField;
            }
            set {
                this.gtinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string mpn {
            get {
                return this.mpnField;
            }
            set {
                this.mpnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string sku {
            get {
                return this.skuField;
            }
            set {
                this.skuField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class variants {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("variantByColor", typeof(variantByColor))]
        [System.Xml.Serialization.XmlElementAttribute("variantByFlavor", typeof(variantByFlavor))]
        [System.Xml.Serialization.XmlElementAttribute("variantBySize", typeof(variantBySize))]
        [System.Xml.Serialization.XmlElementAttribute("variantBySizeColor", typeof(variantBySizeColor))]
        [System.Xml.Serialization.XmlElementAttribute("variantBySizeFlavor", typeof(variantBySizeFlavor))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IsNullable=false)]
    public partial class variantByColor {
        
        private identity identityField;
        
        private translatable colorField;
        
        /// <remarks/>
        public identity identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        public translatable color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class translatable {
        
        private string defaultField;
        
        private string seField;
        
        private string dkField;
        
        private string noField;
        
        private string fiField;
        
        private string frField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string se {
            get {
                return this.seField;
            }
            set {
                this.seField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string dk {
            get {
                return this.dkField;
            }
            set {
                this.dkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string no {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string fi {
            get {
                return this.fiField;
            }
            set {
                this.fiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string fr {
            get {
                return this.frField;
            }
            set {
                this.frField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IsNullable=false)]
    public partial class variantByFlavor {
        
        private identity identityField;
        
        private untranslatable flavorField;
        
        /// <remarks/>
        public identity identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        public untranslatable flavor {
            get {
                return this.flavorField;
            }
            set {
                this.flavorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class untranslatable {
        
        private string defaultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IsNullable=false)]
    public partial class variantBySizeColor {
        
        private identity identityField;
        
        private untranslatable sizeField;
        
        private translatable colorField;
        
        /// <remarks/>
        public identity identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        public untranslatable size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        public translatable color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IsNullable=false)]
    public partial class variantBySizeFlavor {
        
        private identity identityField;
        
        private untranslatable sizeField;
        
        private untranslatable flavorField;
        
        /// <remarks/>
        public identity identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        public untranslatable size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        public untranslatable flavor {
            get {
                return this.flavorField;
            }
            set {
                this.flavorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class mass {
        
        private decimal valueField;
        
        private massUnit unitField;
        
        /// <remarks/>
        public decimal value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public massUnit unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public enum massUnit {
        
        /// <remarks/>
        mcg,
        
        /// <remarks/>
        µg,
        
        /// <remarks/>
        mg,
        
        /// <remarks/>
        g,
        
        /// <remarks/>
        hg,
        
        /// <remarks/>
        kg,
        
        /// <remarks/>
        t,
        
        /// <remarks/>
        gr,
        
        /// <remarks/>
        oz,
        
        /// <remarks/>
        lb,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class size {
        
        private decimal valueField;
        
        private sizeUnit unitField;
        
        /// <remarks/>
        public decimal value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public sizeUnit unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public enum sizeUnit {
        
        /// <remarks/>
        um,
        
        /// <remarks/>
        µm,
        
        /// <remarks/>
        mm,
        
        /// <remarks/>
        cm,
        
        /// <remarks/>
        dm,
        
        /// <remarks/>
        m,
        
        /// <remarks/>
        km,
        
        /// <remarks/>
        @in,
        
        /// <remarks/>
        ft,
        
        /// <remarks/>
        yd,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class dimensions {
        
        private size heightField;
        
        private size widthField;
        
        private size lengthField;
        
        private mass weightField;
        
        /// <remarks/>
        public size height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        public size width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        public size length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public mass weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class energyClassification {
        
        private energyClass classField;
        
        private string labelField;
        
        private string arrowField;
        
        private string sheetField;
        
        /// <remarks/>
        public energyClass @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string arrow {
            get {
                return this.arrowField;
            }
            set {
                this.arrowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string sheet {
            get {
                return this.sheetField;
            }
            set {
                this.sheetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public enum energyClass {
        
        /// <remarks/>
        APlusPlusPlus,
        
        /// <remarks/>
        APlusPlus,
        
        /// <remarks/>
        APlus,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class uspValue {
        
        private string defaultField;
        
        private string seField;
        
        private string dkField;
        
        private string noField;
        
        private string fiField;
        
        private string frField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string se {
            get {
                return this.seField;
            }
            set {
                this.seField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string dk {
            get {
                return this.dkField;
            }
            set {
                this.dkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string no {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string fi {
            get {
                return this.fiField;
            }
            set {
                this.fiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string fr {
            get {
                return this.frField;
            }
            set {
                this.frField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class category {
        
        private string itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private System.Xml.XmlElement attributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cdon", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("google", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        public System.Xml.XmlElement attributes {
            get {
                return this.attributesField;
            }
            set {
                this.attributesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        cdon,
        
        /// <remarks/>
        google,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class description {
        /// <remarks/>
        [XmlIgnore]
        public string @default { get; set; }

        [XmlElement("default")]
        public System.Xml.XmlCDataSection defaultCDATA {
            get {
                return @default == null ? null : new System.Xml.XmlDocument().CreateCDataSection(@default);
            }
            set {
                @default = value.Value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore]
        public string se { get; set; }

        [XmlElement("se")]
        public System.Xml.XmlCDataSection seCDATA
        {
            get
            {
                return se == null ? null : new System.Xml.XmlDocument().CreateCDataSection(se);
            }
            set
            {
                se = value.Value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore]
        public string dk { get; set; }

        [XmlElement("dk")]
        public System.Xml.XmlCDataSection dkCDATA
        {
            get
            {
                return dk == null ? null : new System.Xml.XmlDocument().CreateCDataSection(dk);
            }
            set
            {
                dk = value.Value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore]
        public string no { get; set; }

        [XmlElement("no")]
        public System.Xml.XmlCDataSection noCDATA
        {
            get
            {
                return no == null ? null : new System.Xml.XmlDocument().CreateCDataSection(no);
            }
            set
            {
                no = value.Value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore]
        public string fi { get; set; }

        [XmlElement("fi")]
        public System.Xml.XmlCDataSection fiCDATA
        {
            get
            {
                return fi == null ? null : new System.Xml.XmlDocument().CreateCDataSection(fi);
            }
            set
            {
                fi = value.Value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore]
        public string fr { get; set; }

        [XmlElement("fr")]
        public System.Xml.XmlCDataSection frCDATA
        {
            get
            {
                return fr == null ? null : new System.Xml.XmlDocument().CreateCDataSection(fr);
            }
            set
            {
                fr = value.Value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class title {
        
        private string defaultField;
        
        private string seField;
        
        private string dkField;
        
        private string noField;
        
        private string fiField;
        
        private string frField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string se {
            get {
                return this.seField;
            }
            set {
                this.seField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string dk {
            get {
                return this.dkField;
            }
            set {
                this.dkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string no {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string fi {
            get {
                return this.fiField;
            }
            set {
                this.fiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string fr {
            get {
                return this.frField;
            }
            set {
                this.frField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    public partial class product {
        
        private identity identityField;
        
        private title titleField;
        
        private description descriptionField;
        
        private category categoryField;
        
        private string brandField;
        
        private uspValue[] uspField;
        
        private energyClassification energyField;
        
        private dimensions dimensionsField;
        
        private System.DateTime releaseDateField;
        
        private bool releaseDateFieldSpecified;
        
        private bool isAdultField;
        
        private bool isAdultFieldSpecified;
        
        private bool isDrugField;
        
        private bool isDrugFieldSpecified;
        
        private bool isPreOwnedField;
        
        private bool isPreOwnedFieldSpecified;
        
        private variants variantsField;
        
        /// <remarks/>
        public identity identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        public title title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public description description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public category category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("value", IsNullable=false)]
        public uspValue[] usp {
            get {
                return this.uspField;
            }
            set {
                this.uspField = value;
            }
        }
        
        /// <remarks/>
        public energyClassification energy {
            get {
                return this.energyField;
            }
            set {
                this.energyField = value;
            }
        }
        
        /// <remarks/>
        public dimensions dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime releaseDate {
            get {
                return this.releaseDateField;
            }
            set {
                this.releaseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified {
            get {
                return this.releaseDateFieldSpecified;
            }
            set {
                this.releaseDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isAdult {
            get {
                return this.isAdultField;
            }
            set {
                this.isAdultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultSpecified {
            get {
                return this.isAdultFieldSpecified;
            }
            set {
                this.isAdultFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isDrug {
            get {
                return this.isDrugField;
            }
            set {
                this.isDrugField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDrugSpecified {
            get {
                return this.isDrugFieldSpecified;
            }
            set {
                this.isDrugFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool isPreOwned {
            get {
                return this.isPreOwnedField;
            }
            set {
                this.isPreOwnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPreOwnedSpecified {
            get {
                return this.isPreOwnedFieldSpecified;
            }
            set {
                this.isPreOwnedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public variants variants {
            get {
                return this.variantsField;
            }
            set {
                this.variantsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://schemas.cdon.com/product/4.0/4.9.0/product", IsNullable=false)]
    public partial class marketplace {
        
        private product[] productField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("product")]
        public product[] product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
    }
}

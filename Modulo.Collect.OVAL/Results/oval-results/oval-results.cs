// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.5.0.14890
//    <NameSpace>Modulo.Collect.OVAL.Results</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings>Modulo.Collect.OVAL.Common.XmlSignatures;Modulo.Collect.OVAL.Common;Modulo.Collect.OVAL.Definitions;Modulo.Collect.OVAL.SystemCharacteristics</CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Modulo.Collect.OVAL.Results
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using Modulo.Collect.OVAL.Common.XmlSignatures;
    using Modulo.Collect.OVAL.Common;
    using Modulo.Collect.OVAL.Definitions;
    using Modulo.Collect.OVAL.SystemCharacteristics;
    
    
    /// <summary>
    /// The oval_results element is the root of an OVAL Results Document. Its purpose is to bind together the four major sections of a results document - generator, directives, oval_definitions, and results - which are the children of the root element. It must contain exactly one generator section, one directives section, and one results section.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=false)]
    public partial class oval_results {
        
        private GeneratorType generatorField;
        
        private DefaultDirectivesType directivesField;
        
        private ClassDirectivesType[] class_directivesField;
        
        private oval_definitions oval_definitionsField;
        
        private List<SystemType> resultsField = new List<SystemType>();
        
        private SignatureType signatureField;
        
        /// <summary>
        /// The required generator section provides information about when the results document was compiled and under what version.
        /// </summary>
        public GeneratorType generator {
            get {
                return this.generatorField;
            }
            set {
                this.generatorField = value;
            }
        }
        
        /// <summary>
        /// The required directives section presents flags describing what information has been included in the results document. This element represents the default set of directives. These directives apply to all classes of definitions for which there is not a class specific set of directives.
        /// </summary>
        public DefaultDirectivesType directives {
            get {
                return this.directivesField;
            }
            set {
                this.directivesField = value;
            }
        }
        
        /// <summary>
        /// The optional class_directives section presents flags describing what information has been included in the results document for a specific OVAL Definition class. The directives for a particlar class override the default directives. Using OVAL Results class_directives, an OVAL Results document dealing with vulnerabilities might by default include only minimal information and then include full details for all vulnerability definitions that evaluated to true.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("class_directives")]
        public ClassDirectivesType[] class_directives {
            get {
                return this.class_directivesField;
            }
            set {
                this.class_directivesField = value;
            }
        }
        
        /// <summary>
        /// The oval_definitions section is optional and dependent on the include_source_definitions attribute of the directives element. Its purpose is to provide an exact copy of the definitions evaluated for the results document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        public oval_definitions oval_definitions {
            get {
                return this.oval_definitionsField;
            }
            set {
                this.oval_definitionsField = value;
            }
        }
        
        /// <summary>
        /// The required results section holds all the results of the evaluated definitions.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("system", IsNullable=false)]
        public List<SystemType> results {
            get {
                return this.resultsField;
            }
            set {
                this.resultsField = value;
            }
        }
        
        /// <summary>
        /// The optional Signature element allows an XML Signature as defined by the W3C to be attached to the document. This allows authentication and data integrity to be provided to the user. Enveloped signatures are supported. More information about the official W3C Recommendation regarding XML digital signatures can be found at http://www.w3.org/TR/xmldsig-core/.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class TestedVariableType {
        
        private string variable_idField;
        
        private string valueField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string variable_id {
            get {
                return this.variable_idField;
            }
            set {
                this.variable_idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class TestedItemType {
        
        private List<MessageType> messageField = new List<MessageType>();
        
        private string item_idField;
        
        private ResultEnumeration resultField;
        
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public List<MessageType> message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string item_id {
            get {
                return this.item_idField;
            }
            set {
                this.item_idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultEnumeration result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=false)]
    public enum ResultEnumeration {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
        
        /// <remarks/>
        unknown,
        
        /// <remarks/>
        error,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("not evaluated")]
        notevaluated,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("not applicable")]
        notapplicable,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TestType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("TestType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class TestType {
        
        private MessageType[] messageField;
        
        private List<TestedItemType> tested_itemField = new List<TestedItemType>();
        
        private List<TestedVariableType> tested_variableField = new List<TestedVariableType>();
        
        private string test_idField;
        
        private string versionField;
        
        private string variable_instanceField;
        
        private ExistenceEnumeration check_existenceField;
        
        private CheckEnumeration checkField;
        
        private OperatorEnumeration state_operatorField;
        
        private ResultEnumeration resultField;
        
        public TestType() {
            this.variable_instanceField = "1";
            this.check_existenceField = ExistenceEnumeration.at_least_one_exists;
            this.state_operatorField = OperatorEnumeration.AND;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public MessageType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("tested_item")]
        public List<TestedItemType> tested_item {
            get {
                return this.tested_itemField;
            }
            set {
                this.tested_itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("tested_variable")]
        public List<TestedVariableType> tested_variable {
            get {
                return this.tested_variableField;
            }
            set {
                this.tested_variableField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string test_id {
            get {
                return this.test_idField;
            }
            set {
                this.test_idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ExistenceEnumeration.at_least_one_exists)]
        public ExistenceEnumeration check_existence {
            get {
                return this.check_existenceField;
            }
            set {
                this.check_existenceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CheckEnumeration check {
            get {
                return this.checkField;
            }
            set {
                this.checkField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(OperatorEnumeration.AND)]
        public OperatorEnumeration state_operator {
            get {
                return this.state_operatorField;
            }
            set {
                this.state_operatorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultEnumeration result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ExtendDefinitionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("ExtendDefinitionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class ExtendDefinitionType {
        
        private bool applicability_checkField;
        
        private bool applicability_checkFieldSpecified;
        
        private string definition_refField;
        
        private string versionField;
        
        private string variable_instanceField;
        
        private bool negateField;
        
        private ResultEnumeration resultField;
        
        public ExtendDefinitionType() {
            this.variable_instanceField = "1";
            this.negateField = false;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applicability_check {
            get {
                return this.applicability_checkField;
            }
            set {
                this.applicability_checkField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applicability_checkSpecified {
            get {
                return this.applicability_checkFieldSpecified;
            }
            set {
                this.applicability_checkFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string definition_ref {
            get {
                return this.definition_refField;
            }
            set {
                this.definition_refField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negate {
            get {
                return this.negateField;
            }
            set {
                this.negateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultEnumeration result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CriterionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("CriterionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class CriterionType {
        
        private bool applicability_checkField;
        
        private bool applicability_checkFieldSpecified;
        
        private string test_refField;
        
        private string versionField;
        
        private string variable_instanceField;
        
        private bool negateField;
        
        private ResultEnumeration resultField;
        
        public CriterionType() {
            this.variable_instanceField = "1";
            this.negateField = false;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applicability_check {
            get {
                return this.applicability_checkField;
            }
            set {
                this.applicability_checkField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applicability_checkSpecified {
            get {
                return this.applicability_checkFieldSpecified;
            }
            set {
                this.applicability_checkFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string test_ref {
            get {
                return this.test_refField;
            }
            set {
                this.test_refField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negate {
            get {
                return this.negateField;
            }
            set {
                this.negateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultEnumeration result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="CriteriaType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("CriteriaType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class CriteriaType {
        
        private List<object> itemsField = new List<object>();
        
        private bool applicability_checkField;
        
        private bool applicability_checkFieldSpecified;
        
        private OperatorEnumeration operatorField;
        
        private bool negateField;
        
        private ResultEnumeration resultField;
        
        public CriteriaType() {
            this.negateField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("criteria", typeof(CriteriaType))]
        [System.Xml.Serialization.XmlElementAttribute("criterion", typeof(CriterionType))]
        [System.Xml.Serialization.XmlElementAttribute("extend_definition", typeof(ExtendDefinitionType))]
        public List<object> Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applicability_check {
            get {
                return this.applicability_checkField;
            }
            set {
                this.applicability_checkField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applicability_checkSpecified {
            get {
                return this.applicability_checkFieldSpecified;
            }
            set {
                this.applicability_checkFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OperatorEnumeration @operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negate {
            get {
                return this.negateField;
            }
            set {
                this.negateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultEnumeration result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DefinitionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("DefinitionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class DefinitionType {
        
        private MessageType[] messageField;
        
        private CriteriaType criteriaField;
        
        private string definition_idField;
        
        private string versionField;
        
        private string variable_instanceField;
        
        private ClassEnumeration classField;
        
        private bool classFieldSpecified;
        
        private ResultEnumeration resultField;
        
        public DefinitionType() {
            this.variable_instanceField = "1";
        }
        
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public MessageType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        public CriteriaType criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string definition_id {
            get {
                return this.definition_idField;
            }
            set {
                this.definition_idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ClassEnumeration @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool classSpecified {
            get {
                return this.classFieldSpecified;
            }
            set {
                this.classFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ResultEnumeration result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class SystemType {
        
        private List<DefinitionType> definitionsField = new List<DefinitionType>();
        
        private List<TestType> testsField = new List<TestType>();
        
        private oval_system_characteristics oval_system_characteristicsField;
        
        [System.Xml.Serialization.XmlArrayItemAttribute("definition", IsNullable=false)]
        public List<DefinitionType> definitions {
            get {
                return this.definitionsField;
            }
            set {
                this.definitionsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("test", IsNullable=false)]
        public List<TestType> tests {
            get {
                return this.testsField;
            }
            set {
                this.testsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
        public oval_system_characteristics oval_system_characteristics {
            get {
                return this.oval_system_characteristicsField;
            }
            set {
                this.oval_system_characteristicsField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class DirectiveType {
        
        private bool reportedField;
        
        private ContentEnumeration contentField;
        
        public DirectiveType() {
            this.contentField = ContentEnumeration.full;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool reported {
            get {
                return this.reportedField;
            }
            set {
                this.reportedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ContentEnumeration.full)]
        public ContentEnumeration content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=false)]
    public enum ContentEnumeration {
        
        /// <remarks/>
        thin,
        
        /// <remarks/>
        full,
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClassDirectivesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefaultDirectivesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class DirectivesType {
        
        private DirectiveType definition_trueField;
        
        private DirectiveType definition_falseField;
        
        private DirectiveType definition_unknownField;
        
        private DirectiveType definition_errorField;
        
        private DirectiveType definition_not_evaluatedField;
        
        private DirectiveType definition_not_applicableField;
        
        public DirectiveType definition_true {
            get {
                return this.definition_trueField;
            }
            set {
                this.definition_trueField = value;
            }
        }
        
        public DirectiveType definition_false {
            get {
                return this.definition_falseField;
            }
            set {
                this.definition_falseField = value;
            }
        }
        
        public DirectiveType definition_unknown {
            get {
                return this.definition_unknownField;
            }
            set {
                this.definition_unknownField = value;
            }
        }
        
        public DirectiveType definition_error {
            get {
                return this.definition_errorField;
            }
            set {
                this.definition_errorField = value;
            }
        }
        
        public DirectiveType definition_not_evaluated {
            get {
                return this.definition_not_evaluatedField;
            }
            set {
                this.definition_not_evaluatedField = value;
            }
        }
        
        public DirectiveType definition_not_applicable {
            get {
                return this.definition_not_applicableField;
            }
            set {
                this.definition_not_applicableField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class ClassDirectivesType : DirectivesType {
        
        private ClassEnumeration classField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ClassEnumeration @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class DefaultDirectivesType : DirectivesType {
        
        private bool include_source_definitionsField;
        
        public DefaultDirectivesType() {
            this.include_source_definitionsField = true;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool include_source_definitions {
            get {
                return this.include_source_definitionsField;
            }
            set {
                this.include_source_definitionsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class ResultsType {
        
        private SystemType[] systemField;
        
        [System.Xml.Serialization.XmlElementAttribute("system")]
        public SystemType[] system {
            get {
                return this.systemField;
            }
            set {
                this.systemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DefinitionsType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("DefinitionsType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class DefinitionsType {
        
        private DefinitionType[] definitionField;
        
        [System.Xml.Serialization.XmlElementAttribute("definition")]
        public DefinitionType[] definition {
            get {
                return this.definitionField;
            }
            set {
                this.definitionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TestsType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [System.Xml.Serialization.XmlRootAttribute("TestsType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=true)]
    public partial class TestsType {
        
        private TestType[] testField;
        
        [System.Xml.Serialization.XmlElementAttribute("test")]
        public TestType[] test {
            get {
                return this.testField;
            }
            set {
                this.testField = value;
            }
        }
    }
}

// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.5.0.14890
//    <NameSpace>Modulo.Collect.OVAL.SystemCharacteristics.Solaris</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings>Modulo.Collect.OVAL.Common;Modulo.Collect.OVAL.SystemCharacteristics</CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Modulo.Collect.OVAL.SystemCharacteristics.Solaris {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using Modulo.Collect.OVAL.Common;
    using Modulo.Collect.OVAL.SystemCharacteristics;
    
    
    /// <summary>
    /// The isainfo_item was originally developed by Robert L. Hollis at ThreatGuard, Inc. Many thanks for their support of the OVAL project.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public partial class isainfo_item : ItemType {
        
        private EntityItemIntType bitsField;
        
        private EntityItemStringType kernel_isaField;
        
        private EntityItemStringType application_isaField;
        
        /// <summary>
        /// This is the number of bits in the address space of the native instruction set (isainfo -b).
        /// </summary>
        public EntityItemIntType bits {
            get {
                return this.bitsField;
            }
            set {
                this.bitsField = value;
            }
        }
        
        /// <summary>
        /// This is the name of the instruction set used by kernel components (isainfo -k).
        /// </summary>
        public EntityItemStringType kernel_isa {
            get {
                return this.kernel_isaField;
            }
            set {
                this.kernel_isaField = value;
            }
        }
        
        /// <summary>
        /// This is the name of the instruction set used by portable applications (isainfo -n).
        /// </summary>
        public EntityItemStringType application_isa {
            get {
                return this.application_isaField;
            }
            set {
                this.application_isaField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=true)]
    public partial class EntityItemSmfServiceStateType : EntityItemStringType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=true)]
    public partial class EntityItemSmfProtocolType : EntityItemStringType {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=true)]
    public partial class EntityItemPermissionCompareType : EntityItemStringType {
    }
    
    /// <summary>
    /// This item represents data collected by the ndd command.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public partial class ndd_item : ItemType {
        
        private EntityItemStringType deviceField;
        
        private EntityItemIntType instanceField;
        
        private EntityItemStringType parameterField;
        
        private EntityItemAnySimpleType valueField;
        
        /// <summary>
        /// The name of the device for which the parameter was collected.
        /// </summary>
        public EntityItemStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
            }
        }
        
        /// <summary>
        /// The instance of the device to examine. Certain devices may have multiple instances on a system. If multiple instances exist, this entity should be populated with its respective instance value. If only a single instance exists, this entity should not be collected.
        /// </summary>
        public EntityItemIntType instance {
            get {
                return this.instanceField;
            }
            set {
                this.instanceField = value;
            }
        }
        
        /// <summary>
        /// The name of a parameter for example, ip_forwarding
        /// </summary>
        public EntityItemStringType parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <summary>
        /// The observed value of the named parameter.
        /// </summary>
        public EntityItemAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <summary>
    /// Output of /usr/bin/pkginfo. See pkginfo(1).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public partial class package_item : ItemType {
        
        private EntityItemStringType pkginstField;
        
        private EntityItemStringType nameField;
        
        private EntityItemStringType categoryField;
        
        private EntityItemStringType versionField;
        
        private EntityItemStringType vendorField;
        
        private EntityItemStringType descriptionField;
        
        public EntityItemStringType pkginst {
            get {
                return this.pkginstField;
            }
            set {
                this.pkginstField = value;
            }
        }
        
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        public EntityItemStringType category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        public EntityItemStringType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        public EntityItemStringType vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
        
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <summary>
    /// The packagecheck_item holds verification information about an individual file that is part of a installed package. Each packagecheck_item contains a package designation, filepath, whether the checksum differs, whether the size differs, whether the modfication time differs, and how the actual permissions differ from the expected permissions. For more information, see pkgchk(1M).  It extends the standard ItemType as defined in the oval-system-characteristics schema and one should refer to the ItemType description for more information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public partial class packagecheck_item : ItemType {
        
        private EntityItemStringType pkginstField;
        
        private EntityItemStringType filepathField;
        
        private EntityItemBoolType checksum_differsField;
        
        private EntityItemBoolType size_differsField;
        
        private EntityItemBoolType mtime_differsField;
        
        private EntityItemPermissionCompareType ureadField;
        
        private EntityItemPermissionCompareType uwriteField;
        
        private EntityItemPermissionCompareType uexecField;
        
        private EntityItemPermissionCompareType greadField;
        
        private EntityItemPermissionCompareType gwriteField;
        
        private EntityItemPermissionCompareType gexecField;
        
        private EntityItemPermissionCompareType oreadField;
        
        private EntityItemPermissionCompareType owriteField;
        
        private EntityItemPermissionCompareType oexecField;
        
        /// <summary>
        /// The pkginst entity is a string that represents a package designation by its instance. An instance can be the package abbreviation or a specific instance (for example, inst.1 or inst.2).
        /// </summary>
        public EntityItemStringType pkginst {
            get {
                return this.pkginstField;
            }
            set {
                this.pkginstField = value;
            }
        }
        
        /// <summary>
        /// The filepath element specifies the absolute path for a file in the specified package. A directory cannot be specified as a filepath.
        /// </summary>
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        
        /// <summary>
        /// Has the file's checksum changed? A value of true indicates that the file's checksum has changed. A value of false indicates that the file's checksum has not changed.
        /// </summary>
        public EntityItemBoolType checksum_differs {
            get {
                return this.checksum_differsField;
            }
            set {
                this.checksum_differsField = value;
            }
        }
        
        /// <summary>
        /// Has the file's size changed? A value of true indicates that the file's size has changed. A value of false indicates that the file's size has not changed.
        /// </summary>
        public EntityItemBoolType size_differs {
            get {
                return this.size_differsField;
            }
            set {
                this.size_differsField = value;
            }
        }
        
        /// <summary>
        /// Has the file's modified time changed? A value of true indicates that the file's modified time has changed. A value of false indicates that the file's modified time has not changed.
        /// </summary>
        public EntityItemBoolType mtime_differs {
            get {
                return this.mtime_differsField;
            }
            set {
                this.mtime_differsField = value;
            }
        }
        
        /// <summary>
        /// Has the actual user read permission changed from the expected user read permission?
        /// </summary>
        public EntityItemPermissionCompareType uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        
        /// <summary>
        /// Has the actual user write permission changed from the expected user write permission?
        /// </summary>
        public EntityItemPermissionCompareType uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        
        /// <summary>
        /// Has the actual user exec permission changed from the expected user exec permission?
        /// </summary>
        public EntityItemPermissionCompareType uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        
        /// <summary>
        /// Has the actual group read permission changed from the expected group read permission?
        /// </summary>
        public EntityItemPermissionCompareType gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        
        /// <summary>
        /// Has the actual group write permission changed from the expected group write permission?
        /// </summary>
        public EntityItemPermissionCompareType gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        
        /// <summary>
        /// Has the actual group exec permission changed from the expected group exec permission?
        /// </summary>
        public EntityItemPermissionCompareType gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        
        /// <summary>
        /// Has the actual others read permission changed from the expected others read permission?
        /// </summary>
        public EntityItemPermissionCompareType oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        
        /// <summary>
        /// Has the actual others read permission changed from the expected others read permission?
        /// </summary>
        public EntityItemPermissionCompareType owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        
        /// <summary>
        /// Has the actual others read permission changed from the expected others read permission?
        /// </summary>
        public EntityItemPermissionCompareType oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
    }
    
    /// <summary>
    /// Patches are identified by unique alphanumeric strings, with the patch base code first, a hyphen, and a number that represents the patch revision number. The information can be obtained using /usr/bin/showrev -p. Please see showrev(1M).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public partial class patch_item : ItemType {
        
        private EntityItemIntType baseField;
        
        private EntityItemIntType versionField;
        
        /// <summary>
        /// The base entity reresents a patch base code found before the hyphen.
        /// </summary>
        public EntityItemIntType @base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
        
        /// <summary>
        /// The version entity represents a patch version number found after the hyphen.
        /// </summary>
        public EntityItemIntType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <summary>
    /// The smf_item is used to hold information related to service management facility controlled services
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.5.0.14895")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public partial class smf_item : ItemType {
        
        private EntityItemStringType fmriField;
        
        private EntityItemStringType service_nameField;
        
        private EntityItemSmfServiceStateType service_stateField;
        
        private EntityItemSmfProtocolType protocolField;
        
        private EntityItemStringType server_executableField;
        
        private EntityItemStringType server_arguementsField;
        
        private EntityItemStringType exec_as_userField;
        
        /// <summary>
        /// The FMRI (Fault Managed Resource Identifier) entity holds the identifier associated with a service.  Services managed by SMF are assigned FMRI URIs prefixed with the scheme name "svc".  FMRIs used by SMF can be expressed in three ways: first as an absolute path including a location path such as "localhost"  (eg svc://localhost/system/system-log:default), second as a path relative to the local machine (eg svc:/system/system-log:default), and third as simply the service identifier with the string prefixes implied (eg system/system-log:default).  For OVAL, the absolute path version (first choice) should be used.
        /// </summary>
        public EntityItemStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
            }
        }
        
        /// <summary>
        /// The service_name entity is usually an abbreviated form of the FMRI.  In the example svc://localhost/system/system-log:default, the name would be system-log.
        /// </summary>
        public EntityItemStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        
        /// <summary>
        /// The service_state entity describes the state that the service is in.  Each service instance is always in a well-defined state based on its dependencies, the results of the execution of its methods, and its potential receipt of events from the contracts filesystem.  The service_state values are UNINITIALIZED, OFFLINE, ONLINE, DEGRADED, MAINTENANCE, DISABLED, and LEGACY-RUN.
        /// </summary>
        public EntityItemSmfServiceStateType service_state {
            get {
                return this.service_stateField;
            }
            set {
                this.service_stateField = value;
            }
        }
        
        /// <summary>
        /// The protocol entity describes the protocol supported by the service.  Possible values are tcp, tcp6, tcp6only, udp, udp6, and udp6only
        /// </summary>
        public EntityItemSmfProtocolType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        
        /// <summary>
        /// The entity server_executable is a string representing the listening daemon on the server side.  An example being 'svcprop ftp' which might show 'inetd/start/exec astring /usr/sbin/in.ftpd\ -a'
        /// </summary>
        public EntityItemStringType server_executable {
            get {
                return this.server_executableField;
            }
            set {
                this.server_executableField = value;
            }
        }
        
        /// <summary>
        /// The server_arguments entity describes the parameters that are passed to the service.
        /// </summary>
        public EntityItemStringType server_arguements {
            get {
                return this.server_arguementsField;
            }
            set {
                this.server_arguementsField = value;
            }
        }
        
        /// <summary>
        /// The exec_as_user entity is a string pulled from svcprop in the following format:  inetd_start/user astring root
        /// </summary>
        public EntityItemStringType exec_as_user {
            get {
                return this.exec_as_userField;
            }
            set {
                this.exec_as_userField = value;
            }
        }
    }
}

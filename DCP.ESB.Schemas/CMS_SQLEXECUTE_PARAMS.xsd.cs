namespace DCP.ESB.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS",@"root")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SQLSTATEMENT", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']/*[local-name()='SQLSTATEMENT' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PARAMETERSCHEMA", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']/*[local-name()='PARAMETERSCHEMA' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PARAMETER", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']/*[local-name()='PARAMETER' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"root"})]
    public sealed class CMS_SQLEXECUTE_PARAMS : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']/*[local-name()='SQLSTATEMENT' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']/*[local-name()='PARAMETERSCHEMA' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']/*[local-name()='PARAMETER' and namespace-uri()='http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SQLSTATEMENT"" type=""xs:string"" />
        <xs:element name=""PARAMETERSCHEMA"" type=""xs:string"" />
        <xs:element name=""PARAMETER"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CMS_SQLEXECUTE_PARAMS() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "root";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}

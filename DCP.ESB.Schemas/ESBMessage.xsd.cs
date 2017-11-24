namespace DCP.ESB.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://DCP.ESB.Schemas.ESBMessage",@"root")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "status", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']/*[local-name()='status' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "description", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']/*[local-name()='description' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "id", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']/*[local-name()='id' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"root"})]
    public sealed class ESBMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DCP.ESB.Schemas.ESBMessage"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""http://DCP.ESB.Schemas.ESBMessage"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']/*[local-name()='status' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']/*[local-name()='description' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']/*[local-name()='id' and namespace-uri()='http://DCP.ESB.Schemas.ESBMessage']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""status"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""description"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""id"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ESBMessage() {
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

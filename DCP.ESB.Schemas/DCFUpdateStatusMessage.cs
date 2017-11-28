namespace DCP.ESB.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://DCP.ESB.Schemas.DCFUpdateStatusMessage",@"root")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::DCP.ESB.Schemas.PropertySchema.id), XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='id' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "operation", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='operation' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "xml", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='xml' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "id", XPath = @"/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='id' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"root"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.PropertySchema.PropertySchema", typeof(global::DCP.ESB.Schemas.PropertySchema.PropertySchema))]
    public sealed class DCFMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://DCP.ESB.Schemas.DCFUpdateStatusMessage"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://DCP.ESB.Schemas.PropertySchema"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""http://DCP.ESB.Schemas.DCFUpdateStatusMessage"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://DCP.ESB.Schemas.PropertySchema"" location=""DCP.ESB.Schemas.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:id"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='id' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='operation' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='xml' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='root' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']/*[local-name()='id' and namespace-uri()='http://DCP.ESB.Schemas.DCFUpdateStatusMessage']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""operation"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""xml"" type=""xs:string"" />
        <xs:element name=""id"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DCFMessage() {
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

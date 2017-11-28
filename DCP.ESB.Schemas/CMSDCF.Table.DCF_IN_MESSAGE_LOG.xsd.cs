namespace DCP.ESB.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DCF_IN_MESSAGE_LOGRECORDINSERT", @"ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT", @"Insert", @"InsertResponse"})]
    public sealed class CMSDCF_Table_DCF_IN_MESSAGE_LOG : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">DCF.Table.DCF_IN_MESSAGE_LOG</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""DCF_IN_MESSAGE_LOGRECORDINSERT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ID"" nillable=""true"" type=""tns:ID__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MESG_TYPE"" nillable=""true"" type=""tns:MESG_TYPE__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""STATUS"" nillable=""true"" type=""tns:STATUS__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""STATUS_TIME"" nillable=""true"" type=""tns:STATUS_TIME__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ERROR_MESG"" nillable=""true"" type=""tns:ERROR_MESG__COMPLEX_TYPE"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DATA_ID"" nillable=""true"" type=""tns:DATA_ID__COMPLEX_TYPE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""DCF_IN_MESSAGE_LOGRECORDINSERT"" nillable=""true"" type=""tns:DCF_IN_MESSAGE_LOGRECORDINSERT"" />
  <xs:simpleType name=""ID__SIMPLE_TYPE"">
    <xs:restriction base=""xs:decimal"">
      <xs:totalDigits value=""20"" />
      <xs:fractionDigits value=""0"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ID__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:ID__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""MESG_TYPE__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""100"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""MESG_TYPE__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:MESG_TYPE__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""STATUS__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""20"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""STATUS__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:STATUS__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""STATUS_TIME__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""xs:dateTime"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""ERROR_MESG__SIMPLE_TYPE"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""4000"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ERROR_MESG__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:ERROR_MESG__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""DATA_ID__SIMPLE_TYPE"">
    <xs:restriction base=""xs:decimal"">
      <xs:totalDigits value=""20"" />
      <xs:fractionDigits value=""0"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""DATA_ID__COMPLEX_TYPE"">
    <xs:simpleContent>
      <xs:extension base=""tns:DATA_ID__SIMPLE_TYPE"">
        <xs:attribute name=""InlineValue"" type=""xs:string"" use=""optional"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DCF_IN_MESSAGE_LOGRECORDINSERT"" type=""tns:DCF_IN_MESSAGE_LOGRECORDINSERT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT"" nillable=""true"" type=""tns:ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT"" />
  <xs:element name=""Insert"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG/Insert</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RECORDSET"" nillable=""true"" type=""tns:ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""COLUMN_NAMES"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QUERY"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InsertResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG/Insert/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""InsertResult"" type=""xs:integer"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CMSDCF_Table_DCF_IN_MESSAGE_LOG() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "DCF_IN_MESSAGE_LOGRECORDINSERT";
                _RootElements[1] = "ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT";
                _RootElements[2] = "Insert";
                _RootElements[3] = "InsertResponse";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG",@"DCF_IN_MESSAGE_LOGRECORDINSERT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DCF_IN_MESSAGE_LOGRECORDINSERT"})]
        public sealed class DCF_IN_MESSAGE_LOGRECORDINSERT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DCF_IN_MESSAGE_LOGRECORDINSERT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DCF_IN_MESSAGE_LOGRECORDINSERT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG",@"ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT"})]
        public sealed class ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfDCF_IN_MESSAGE_LOGRECORDINSERT";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG",@"Insert")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Insert"})]
        public sealed class Insert : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Insert() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Insert";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG",@"InsertResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InsertResponse"})]
        public sealed class InsertResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InsertResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InsertResponse";
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
}

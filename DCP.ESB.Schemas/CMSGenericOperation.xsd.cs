namespace DCP.ESB.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PARAMETERDATA", @"ArrayOfPARAMETERDATA", @"GenRecordRow", @"GenRecordColumn", @"ArrayOfGenRecordColumn", @"ArrayOfGenRecordRow"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.CMSSimpleTypeArray", typeof(global::DCP.ESB.Schemas.CMSSimpleTypeArray))]
    public sealed class CMSGenericOperation : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://Microsoft.LobServices.OracleDB/2007/03"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.OracleDB/2007/03"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""DCP.ESB.Schemas.CMSSimpleTypeArray"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">GenericOperation</fileNameHint>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""PARAMETERDATA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PARAMETER"" nillable=""true"" type=""array:ArrayOfstring"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""PARAMETERDATA"" nillable=""true"" type=""ns3:PARAMETERDATA"" />
  <xs:complexType name=""ArrayOfPARAMETERDATA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PARAMETERDATA"" type=""ns3:PARAMETERDATA"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPARAMETERDATA"" nillable=""true"" type=""ns3:ArrayOfPARAMETERDATA"" />
  <xs:complexType name=""GenRecordRow"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GenRecordColumn"" nillable=""true"" type=""ns3:ArrayOfGenRecordColumn"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""GenRecordRow"" nillable=""true"" type=""ns3:GenRecordRow"" />
  <xs:complexType name=""GenRecordColumn"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ColumnName"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ColumnValue"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ColumnType"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""GenRecordColumn"" nillable=""true"" type=""ns3:GenRecordColumn"" />
  <xs:complexType name=""ArrayOfGenRecordColumn"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GenRecordColumn"" type=""ns3:GenRecordColumn"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfGenRecordColumn"" nillable=""true"" type=""ns3:ArrayOfGenRecordColumn"" />
  <xs:complexType name=""ArrayOfGenRecordRow"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GenRecordRow"" type=""ns3:GenRecordRow"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfGenRecordRow"" nillable=""true"" type=""ns3:ArrayOfGenRecordRow"" />
</xs:schema>";
        
        public CMSGenericOperation() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "PARAMETERDATA";
                _RootElements[1] = "ArrayOfPARAMETERDATA";
                _RootElements[2] = "GenRecordRow";
                _RootElements[3] = "GenRecordColumn";
                _RootElements[4] = "ArrayOfGenRecordColumn";
                _RootElements[5] = "ArrayOfGenRecordRow";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03",@"PARAMETERDATA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PARAMETERDATA"})]
        public sealed class PARAMETERDATA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PARAMETERDATA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PARAMETERDATA";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03",@"ArrayOfPARAMETERDATA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPARAMETERDATA"})]
        public sealed class ArrayOfPARAMETERDATA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPARAMETERDATA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPARAMETERDATA";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03",@"GenRecordRow")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GenRecordRow"})]
        public sealed class GenRecordRow : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GenRecordRow() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GenRecordRow";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03",@"GenRecordColumn")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GenRecordColumn"})]
        public sealed class GenRecordColumn : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GenRecordColumn() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GenRecordColumn";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03",@"ArrayOfGenRecordColumn")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfGenRecordColumn"})]
        public sealed class ArrayOfGenRecordColumn : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfGenRecordColumn() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfGenRecordColumn";
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
        
        [Schema(@"http://Microsoft.LobServices.OracleDB/2007/03",@"ArrayOfGenRecordRow")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfGenRecordRow"})]
        public sealed class ArrayOfGenRecordRow : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfGenRecordRow() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfGenRecordRow";
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

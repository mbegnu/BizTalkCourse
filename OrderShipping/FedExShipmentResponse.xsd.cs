namespace OrderShipping {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://OrderShipping.FedExShipmentResponse",@"FedExShipmentResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FedExShipmentResponse"})]
    public sealed class FedExShipmentResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OrderShipping.FedExShipmentResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://OrderShipping.FedExShipmentResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""FedExShipmentResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerOrderID"" type=""xs:string"" />
        <xs:element name=""CostOfShipment"" type=""xs:decimal"" />
        <xs:element name=""EstimatedDeliveryDate"" type=""xs:dateTime"" />
        <xs:element name=""TrackingNumber"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public FedExShipmentResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "FedExShipmentResponse";
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

namespace OrderShipping {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://OrderShipping.FedExShipment",@"FedExShipment")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.ShipperOrderID), XPath = @"/*[local-name()='FedExShipment' and namespace-uri()='http://OrderShipping.FedExShipment']/*[local-name()='ShipperOrderID' and namespace-uri()='']", XsdType = @"integer")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FedExShipment"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.PropertySchema.PropertySchema", typeof(global::OrderShipping.PropertySchema.PropertySchema))]
    public sealed class FedExShipment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OrderShipping.FedExShipment"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://OrderShipping.PropertySchema"" targetNamespace=""http://OrderShipping.FedExShipment"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://OrderShipping.PropertySchema"" location=""OrderShipping.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""FedExShipment"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:ShipperOrderID"" xpath=""/*[local-name()='FedExShipment' and namespace-uri()='http://OrderShipping.FedExShipment']/*[local-name()='ShipperOrderID' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ShipperOrderID"" type=""xs:integer"" />
        <xs:element name=""ShipFromName"" type=""xs:string"" />
        <xs:element name=""ShipFromAddress"" type=""xs:string"" />
        <xs:element name=""ShipFromCItyStateZip"" type=""xs:string"" />
        <xs:element name=""ShipToName"" type=""xs:string"" />
        <xs:element name=""ShipToCompany"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""ShipToAddress1"" type=""xs:string"" />
        <xs:element name=""ShipToAddress2"" type=""xs:string"" />
        <xs:element name=""ShipToCityStateZip"" type=""xs:string"" />
        <xs:element name=""OrderTotal"" type=""xs:decimal"" />
        <xs:element name=""TotalWeight"" type=""xs:decimal"" />
        <xs:element name=""FromZip"" type=""xs:integer"" />
        <xs:element name=""ToZip"" type=""xs:integer"" />
        <xs:element name=""ShippingMethod"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public FedExShipment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "FedExShipment";
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

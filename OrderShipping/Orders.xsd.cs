namespace OrderShipping {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://OrderShipping.Orders",@"Order")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.ShippingMethod), XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingMethod' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.OrderNumber), XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='OrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.ShippingCompany), XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingCompany' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ShippingCompany", XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingCompany' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ShippingMethod", XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingMethod' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "OrderNumber", XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='OrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.PropertySchema.PropertySchema", typeof(global::OrderShipping.PropertySchema.PropertySchema))]
    public sealed class Orders : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OrderShipping.Orders"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://OrderShipping.PropertySchema"" targetNamespace=""http://OrderShipping.Orders"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://OrderShipping.PropertySchema"" location=""OrderShipping.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:ShippingMethod"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingMethod' and namespace-uri()='']"" />
          <b:property name=""ns0:OrderNumber"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='OrderNumber' and namespace-uri()='']"" />
          <b:property name=""ns0:ShippingCompany"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingCompany' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingCompany' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='ShippingMethod' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Orders']/*[local-name()='OrderNumber' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderNumber"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""FirstName"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""LastName"" type=""xs:string"" />
        <xs:element name=""CompanyName"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""ShipToAddress"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""ShipToCity"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""ShipToState"" type=""xs:string"" />
        <xs:element name=""ShipToZip"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""BillToAddress"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""BillToCity"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""BillToState"" type=""xs:string"" />
        <xs:element name=""BillToZip"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""SalesTax"" type=""xs:decimal"" />
        <xs:element minOccurs=""0"" name=""ShippingCharge"" type=""xs:decimal"" />
        <xs:element minOccurs=""0"" name=""ShippingMethod"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:enumeration value=""FEDEX"" />
              <xs:enumeration value=""UPS"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""ShippingCompany"" type=""xs:string"" />
        <xs:element name=""LineItems"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""LineItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Quantity"" type=""xs:decimal"" />
                    <xs:element name=""ProductCode"" type=""xs:string"" />
                    <xs:element name=""ProductName"" type=""xs:string"" />
                    <xs:element name=""Price"" type=""xs:decimal"" />
                    <xs:element name=""Weight"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Orders() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
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

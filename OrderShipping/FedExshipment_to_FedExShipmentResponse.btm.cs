namespace OrderShipping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.FedExShipment", typeof(global::OrderShipping.FedExShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.FedExShipmentResponse", typeof(global::OrderShipping.FedExShipmentResponse))]
    public sealed class FedExshipment_to_FedExShipmentResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://OrderShipping.FedExShipment"" xmlns:ns0=""http://OrderShipping.FedExShipmentResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:FedExShipment"" />
  </xsl:template>
  <xsl:template match=""/s0:FedExShipment"">
    <xsl:variable name=""var:v2"" select=""string(ShippingMethod/text())"" />
    <xsl:variable name=""var:v3"" select=""string(FromZip/text())"" />
    <xsl:variable name=""var:v4"" select=""string(ToZip/text())"" />
    <ns0:FedExShipmentResponse>
      <CustomerOrderID>
        <xsl:value-of select=""ShipperOrderID/text()"" />
      </CustomerOrderID>
      <xsl:variable name=""var:v1"" select=""userCSharp:ComputeShippingCost(string(TotalWeight/text()) , string(FromZip/text()) , string(ToZip/text()) , string(ShippingMethod/text()))"" />
      <CostOfShipment>
        <xsl:value-of select=""$var:v1"" />
      </CostOfShipment>
      <xsl:variable name=""var:v5"" select=""userCSharp:EstimateDeliveryDate($var:v2 , $var:v3 , $var:v4)"" />
      <EstimatedDeliveryDate>
        <xsl:value-of select=""$var:v5"" />
      </EstimatedDeliveryDate>
      <xsl:variable name=""var:v6"" select=""userCSharp:GenerateTrackingNumber()"" />
      <TrackingNumber>
        <xsl:value-of select=""$var:v6"" />
      </TrackingNumber>
    </ns0:FedExShipmentResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string ComputeShippingCost(string shippingMethod, decimal totalWeight, string fromZip, string toZip)
{
     int zone = 3;
     var baseRate = 5 + totalWeight * 0.05M; // for ground shipping
     if (shippingMethod == ""OVERNIGHT"")
     {
         baseRate = baseRate * 2M;
     }
else if (shippingMethod == ""2DAY"")
{
   baseRate = baseRate * 1.25M;
}

return baseRate.ToString();
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string GenerateTrackingNumber()
{
	return Guid.NewGuid().ToString();
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public DateTime EstimateDeliveryDate(string shippingMethod, string fromZip, string toZip)
{
	int days = 3;
         if (shippingMethod == ""OVERNIGHT"")
        {
             days = 1;
        }
else if (shippingMethod == ""2DAY"")
{
    days = 2;
}

DateTime estimatedDeliveryDate = DateTime.Today.AddDays(days);
return estimatedDeliveryDate;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"OrderShipping.FedExShipment";
        
        private const global::OrderShipping.FedExShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"OrderShipping.FedExShipmentResponse";
        
        private const global::OrderShipping.FedExShipmentResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"OrderShipping.FedExShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"OrderShipping.FedExShipmentResponse";
                return _TrgSchemas;
            }
        }
    }
}

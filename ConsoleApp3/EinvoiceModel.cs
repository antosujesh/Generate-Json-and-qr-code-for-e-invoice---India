using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutoExe
{
    class EinvoiceModel
    {

    }
    public partial class EInvoice
    {
        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("TranDtls")]
        public TranDtls TranDtls { get; set; }

        [JsonProperty("DocDtls")]
        public DocDtls DocDtls { get; set; }

        [JsonProperty("SellerDtls")]
        public Seller_Dtls SellerDtls { get; set; }

        [JsonProperty("BuyerDtls")]
        public Buyer_Dtls BuyerDtls { get; set; }

        [JsonProperty("DispDtls")]
        public Disp_Dtls DispDtls { get; set; }


        [JsonProperty("ShipDtls")]
        public Shipping_Dtls ShipDtls { get; set; }

       

   

        [JsonProperty("ValDtls")]
        public ValDtls ValDtls { get; set; }

        [JsonProperty("ExpDtls")]
        public ExpDtls ExpDtls { get; set; }

        [JsonProperty("EwbDtls")]
        public EwbDtls EwbDtls { get; set; }

        [JsonProperty("ItemList")]
        public ItemList[] ItemList { get; set; }
    }
    public class ValDtls
    {
        public decimal? AssVal { get; set; }
        public decimal? IgstVal { get; set; }
        public decimal? CgstVal { get; set; }
        public decimal? SgstVal { get; set; }
        public decimal? CesVal { get; set; }
        public decimal? StCesVal { get; set; }
        public decimal? Discount { get; set; }
        public decimal? OthChrg { get; set; }
        public decimal? RndOffAmt { get; set; }
        public decimal? TotInvVal { get; set; }
    }
    public partial class Buyer_Dtls
    {
        [JsonProperty("Gstin")]
        public string Gstin { get; set; }

        [JsonProperty("LglNm")]
        public string LglNm { get; set; }

        [JsonProperty("TrdNm")]
        public object TrdNm { get; set; }

        [JsonProperty("Pos")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Pos { get; set; }

        [JsonProperty("Addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("Addr2")]
        public object Addr2 { get; set; }

        [JsonProperty("Loc")]
        public string Loc { get; set; }

        [JsonProperty("Pin")]
        public long Pin { get; set; }

        [JsonProperty("Stcd")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public object Stcd { get; set; }

        [JsonProperty("Ph")]
        public object Ph { get; set; }

        [JsonProperty("Em")]
        public object Em { get; set; }
    }
    public partial class Disp_Dtls
    {
        [JsonProperty("Nm")]
        public string Nm { get; set; }

       
        [JsonProperty("Addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("Addr2")]
        public object Addr2 { get; set; }

        [JsonProperty("Loc")]
        public string Loc { get; set; }

        [JsonProperty("Pin")]
        public long Pin { get; set; }

        [JsonProperty("Stcd")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public object Stcd { get; set; }

    }
    
    public partial class Shipping_Dtls
    {
        [JsonProperty("Gstin")]
        public string Gstin { get; set; }

        [JsonProperty("LglNm")]
        public string LglNm { get; set; }

        [JsonProperty("TrdNm")]
        public object TrdNm { get; set; }


        [JsonProperty("Addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("Addr2")]
        public object Addr2 { get; set; }

        [JsonProperty("Loc")]
        public string Loc { get; set; }

        [JsonProperty("Pin")]
        public int Pin { get; set; }

        [JsonProperty("Stcd")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public object Stcd { get; set; }

      
    }
    public partial class Seller_Dtls
    {
        [JsonProperty("Gstin")]
        public string Gstin { get; set; }

        [JsonProperty("LglNm")]
        public string LglNm { get; set; }

        [JsonProperty("TrdNm")]
        public object TrdNm { get; set; }

      
        [JsonProperty("Addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("Addr2")]
        public object Addr2 { get; set; }

        [JsonProperty("Loc")]
        public string Loc { get; set; }

        [JsonProperty("Pin")]
        public int Pin { get; set; }

        [JsonProperty("Stcd")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public object Stcd { get; set; }

        [JsonProperty("Ph")]
        public object Ph { get; set; }

        [JsonProperty("Em")]
        public object Em { get; set; }
    }

    public partial class DocDtls
    {
        [JsonProperty("Typ")]
        public string Typ { get; set; }

        [JsonProperty("No")]
        public string No { get; set; }

        [JsonProperty("Dt")]
        public string Dt { get; set; }
    }

    public partial class ExpDtls
    {
        [JsonProperty("ShipBNo")]
        public object ShipBNo { get; set; }

        [JsonProperty("ShipBDt")]
        public object ShipBDt { get; set; }

        [JsonProperty("Port")]
        public object Port { get; set; }

        [JsonProperty("RefClm")]
        public object RefClm { get; set; }

        [JsonProperty("ForCur")]
        public object ForCur { get; set; }

        [JsonProperty("CntCode")]
        public object CntCode { get; set; }

        [JsonProperty("ExpDuty")]
        public decimal ExpDuty { get; set; }
    }

    public partial class ItemList
    {
        [JsonProperty("SlNo")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string SlNo { get; set; }

        [JsonProperty("PrdDesc")]
        public string PrdDesc { get; set; }

        [JsonProperty("IsServc")]
        public string IsServc { get; set; }

        [JsonProperty("HsnCd")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string HsnCd { get; set; }

        [JsonProperty("Qty")]
        public decimal Qty { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("UnitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("TotAmt")]
        public decimal TotAmt { get; set; }

        [JsonProperty("Discount")]
        public decimal Discount { get; set; }

        [JsonProperty("PreTaxVal")]
        public decimal PreTaxVal { get; set; }

        [JsonProperty("AssAmt")]
        public decimal AssAmt { get; set; }

        [JsonProperty("GstRt")]
        public decimal GstRt { get; set; }

        [JsonProperty("IgstAmt")]
        public decimal IgstAmt { get; set; }

        [JsonProperty("CgstAmt")]
        public decimal CgstAmt { get; set; }

        [JsonProperty("SgstAmt")]
        public decimal SgstAmt { get; set; }

        [JsonProperty("CesRt")]
        public decimal CesRt { get; set; }

        [JsonProperty("CesAmt")]
        public decimal CesAmt { get; set; }

        [JsonProperty("CesNonAdvlAmt")]
        public decimal CesNonAdvlAmt { get; set; }

        [JsonProperty("StateCesRt")]
        public decimal StateCesRt { get; set; }

        [JsonProperty("StateCesAmt")]
        public decimal StateCesAmt { get; set; }

        [JsonProperty("StateCesNonAdvlAmt")]
        public decimal StateCesNonAdvlAmt { get; set; }

        [JsonProperty("OthChrg")]
        public decimal OthChrg { get; set; }

        [JsonProperty("TotItemVal")]
        public decimal TotItemVal { get; set; }

        [JsonProperty("BchDtls")]
        public BchDtls BchDtls { get; set; }
    }

    public partial class BchDtls
    {
        [JsonProperty("Nm")]
        public string Nm { get; set; }

        [JsonProperty("ExpDt")]
        public string ExpDt { get; set; }

        [JsonProperty("WrDt")]
        public string WrDt { get; set; }
    }

    public partial class TranDtls
    {
        [JsonProperty("TaxSch")]
        public string TaxSch { get; set; }

        [JsonProperty("SupTyp")]
        public string SupTyp { get; set; }

        [JsonProperty("IgstOnIntra")]
        public string IgstOnIntra { get; set; }

        [JsonProperty("RegRev")]
        public object RegRev { get; set; }

        [JsonProperty("EcmGstin")]
        public object EcmGstin { get; set; }
    }


    public class EwbDtls
    {
        public string TransId { get; set; }
        public string TransName { get; set; }
        public string TransMode { get; set; }
        public decimal Distance { get; set; }
        public string TransDocNo { get; set; }
        public string TransDocDt { get; set; }
        public string VehNo { get; set; }
        public string VehType { get; set; }
    }


    public class JsonoutRoot
    {
        public long AckNo { get; set; }
        public string AckDt { get; set; }
        public string Irn { get; set; }
        public string SignedInvoice { get; set; }
        public string SignedQRCode { get; set; }
        public string Status { get; set; }
        public object EwbNo { get; set; }
        public object EwbDt { get; set; }
        public object EwbValidTill { get; set; }
        public object Remarks { get; set; }
    }


    public class ExcelOut
    {
        public string ExInvNo { get; set; }
        public string AckNo { get; set; }
        public string AckDt { get; set; }
        public string Irn { get; set; }
        public string QRImage { get; set; }
        public string SignedQRCode { get; set; }
        public string Status { get; set; }
    }

}

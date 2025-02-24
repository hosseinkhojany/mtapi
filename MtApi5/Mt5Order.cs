using Newtonsoft.Json;
namespace MtApi5
{
    public class Mt5Order
    {
        [JsonProperty("ORDER_TICKET")]
        public long OrderTicket { get; set; }

        [JsonProperty("ORDER_TIME_SETUP")]
        private long MtOrderTimeSetup { get; set; } 
        public DateTime OrderTimeSetup => Mt5TimeConverter.ConvertFromMtTime(MtOrderTimeSetup);

        [JsonProperty("ORDER_TIME_EXPIRATION")]
        private long MtOrderTimeExpiration { get; set; }
        public DateTime OrderTimeExpiration => Mt5TimeConverter.ConvertFromMtTime(MtOrderTimeExpiration);

        [JsonProperty("ORDER_TIME_DONE")]
        private long MtOrderTimeDone { get; set; }
        public DateTime OrderTimeDone => Mt5TimeConverter.ConvertFromMtTime(MtOrderTimeDone);

        [JsonProperty("ORDER_TYPE")]
        public int OrderType { get; set; }

        [JsonProperty("ORDER_STATE")]
        public int OrderState { get; set; }
        public long OrderTimeDoneMsc { get; set; }

        [JsonProperty("ORDER_TYPE_FILLING")]
        public int OrderTypeFilling { get; set; }

        [JsonProperty("ORDER_TYPE_TIME")]
        public int OrderTypeTime { get; set; }

        [JsonProperty("ORDER_MAGIC")]
        public long OrderMagic { get; set; }

        [JsonProperty("ORDER_REASON")]
        public int OrderReason { get; set; }

        [JsonProperty("ORDER_POSITION_ID")]
        public long OrderPositionId { get; set; }

        [JsonProperty("ORDER_POSITION_BY_ID")]
        public long OrderPositionById { get; set; }

        [JsonProperty("ORDER_VOLUME_INITIAL")]
        public double OrderVolumeInitial { get; set; }

        [JsonProperty("ORDER_VOLUME_CURRENT")]
        public double OrderVolumeCurrent { get; set; }

        [JsonProperty("ORDER_PRICE_OPEN")]
        public double OrderPriceOpen { get; set; }

        [JsonProperty("ORDER_SL")]
        public double OrderSL { get; set; }

        [JsonProperty("ORDER_TP")]
        public double OrderTP { get; set; }

        [JsonProperty("ORDER_PRICE_CURRENT")]
        public double OrderPriceCurrent { get; set; }

        [JsonProperty("ORDER_PRICE_STOPLIMIT")]
        public double OrderPriceStopLimit { get; set; }

        [JsonProperty("ORDER_SYMBOL")]
        public string OrderSymbol { get; set; } = string.Empty;

        [JsonProperty("ORDER_COMMENT")]
        public string OrderComment { get; set; } = string.Empty;

        [JsonProperty("ORDER_EXTERNAL_ID")]
        public string OrderExternalId { get; set; } = string.Empty;
    }
}
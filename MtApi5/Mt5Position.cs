using Newtonsoft.Json;

namespace MtApi5
{
    public enum PositionType
    {
        POSITION_TYPE_BUY,
        POSITION_TYPE_SELL
    }

    public enum PositionReason
    {
        POSITION_REASON_CLIENT,
        POSITION_REASON_MOBILE,
        POSITION_REASON_WEB,
        POSITION_REASON_EXPERT
    }
    public class Mt5Position
    {
        [JsonProperty("POSITION_TICKET")]
        public long PositionTicket { get; set; }

        [JsonProperty("POSITION_TIME")]
        private long MtPositionTime { get; set; }
        public DateTime PositionTime => Mt5TimeConverter.ConvertFromMtTime(MtPositionTime);

        [JsonProperty("POSITION_TIME_MSC")]
        public long PositionTimeMsc { get; set; }

        [JsonProperty("POSITION_TIME_UPDATE")]
        private long MtPositionTimeUpdate { get; set; }
        public DateTime PositionTimeUpdate => Mt5TimeConverter.ConvertFromMtTime(MtPositionTimeUpdate);


        [JsonProperty("POSITION_TIME_UPDATE_MSC")]
        public long PositionTimeUpdateMsc { get; set; }

        [JsonProperty("POSITION_TYPE")]
        public PositionType PositionType { get; set; }

        [JsonProperty("POSITION_MAGIC")]
        public long PositionMagic { get; set; }

        [JsonProperty("POSITION_IDENTIFIER")]
        public long PositionIdentifier { get; set; }

        [JsonProperty("POSITION_REASON")]
        public PositionReason PositionReason { get; set; }

        [JsonProperty("POSITION_VOLUME")]
        public double PositionVolume { get; set; }

        [JsonProperty("POSITION_PRICE_OPEN")]
        public double PositionPriceOpen { get; set; }

        [JsonProperty("POSITION_SL")]
        public double PositionSL { get; set; }

        [JsonProperty("POSITION_TP")]
        public double PositionTP { get; set; }

        [JsonProperty("POSITION_PRICE_CURRENT")]
        public double PositionPriceCurrent { get; set; }

        [JsonProperty("POSITION_SWAP")]
        public double PositionSwap { get; set; }

        [JsonProperty("POSITION_PROFIT")]
        public double PositionProfit { get; set; }

        [JsonProperty("POSITION_SYMBOL")]
        public string PositionSymbol { get; set; } = string.Empty;

        [JsonProperty("POSITION_COMMENT")]
        public string PositionComment { get; set; } = string.Empty;

        [JsonProperty("POSITION_EXTERNAL_ID")]
        public string PositionExternalId { get; set; } = string.Empty;
    }
}


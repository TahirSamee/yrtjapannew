using System.ComponentModel.DataAnnotations;

namespace YRTJapan.Core.Entities
{
    public class Car
    {
        public string ID { get; set; }
        public string LOT { get; set; }
        public string AUCTION_TYPE { get; set; }
        public string AUCTION_DATE { get; set; }
        public string AUCTION { get; set; }
        public string MARKA_ID { get; set; }
        public string MODEL_ID { get; set; }
        public string MARKA_NAME { get; set; }
        public string MODEL_NAME { get; set; }
        public string YEAR { get; set; }
        public string TOWN { get; set; }
        public string ENG_V { get; set; }
        public string PW { get; set; }
        public string KUZOV { get; set; }
        public string GRADE { get; set; }
        public string COLOR { get; set; }
        public string KPP { get; set; }
        public string KPP_TYPE { get; set; }
        public string PRIV { get; set; }
        public string MILEAGE { get; set; }
        public string EQUIP { get; set; }
        public string RATE { get; set; }
        public string START { get; set; }
        public decimal PriceInUSD { get; set; }
        public decimal FOBPriceInUSD { get; set; }
        public string FINISH { get; set; }
        public string STATUS { get; set; }
        public string TIME { get; set; }
        public string AVG_PRICE { get; set; }
        public string AVG_STRING { get; set; }
        public string IMAGES { get; set; }
        public string TAG2 { get; set; }
        public List<string> IMAGES_LIST { get; set; }
    }

}

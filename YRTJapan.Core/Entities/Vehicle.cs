namespace YRTJapan.Core.Entities
{
    public class Vehicle : BaseEntity
    {


        //Custome START
        public string MODEL_NAME { get; set; }

        //Custome END
        public string INVENTORY_YEAR { get; set; }
        public string INVENTORY_NO { get; set; }
        public string CARBODY_NO { get; set; }
        public string IMAGEEXIST_FLAG1 { get; set; }
        public string IMAGEEXIST_FLAG2 { get; set; }
        // Add similar properties for all IMAGEEXIST_FLAGs up to 30

        public string IMAGEEXIST_FLAG_CAUCTION { get; set; }
        public string IMAGEEXIST_FLAG_SELF_INSPECT { get; set; }
        public string IMAGE_DATE1 { get; set; }
        public string IMAGE_DATE2 { get; set; }
        // Add similar properties for all IMAGE_DATEs up to 30

        public string IMAGE_DATE_CAUTION { get; set; }
        public string IMAGE_DATE_SELF_INSPECT { get; set; }
        public string IMAGE_DATE_EXHIBIT { get; set; }
        public int STYLE_SPECIFY_CD { get; set; }
        public int GRADE_TYPE_CD { get; set; }
        public int CARTYPE_CD { get; set; }
        public string MAKER_CD { get; set; }
        public string MAKER { get; set; }
        public string MAKER_EN { get; set; }
        public string CARNAME_WRAP { get; set; }
        public int CARNAME_CD { get; set; }
        public string CARNAME { get; set; }
        public string CARNAME_EN { get; set; }
        public string GRADE { get; set; }
        public string GRADE_SUB { get; set; }
        public string GRADE_SUB_EN { get; set; }
        public double WHOLESALE_PRICE { get; set; }
        public int NEGOTIABLE_FLAG { get; set; }
        public string REGISTRATION { get; set; }
        public string ON_REGISTRATION_FLAG { get; set; }
        public int INSPECT_EXPIRE_DATE { get; set; }
        public string NO_DEPENDS_FLAG { get; set; }
        public string LICENSE_OFFICE { get; set; }
        public string LICENSE_NO1 { get; set; }
        public string LICENSE_NO2 { get; set; }
        public string LICENSE_NO3 { get; set; }
        public string HISTORY_CD { get; set; }
        public string NO8_CD { get; set; }
        public string WELFARE_CD { get; set; }
        public string MILEAGE { get; set; }
        public string MILEAGE_FLAG { get; set; }
        public string MILEAGE_SYMBOL { get; set; }
        public int COLOR_NO { get; set; }
        public string COLOR { get; set; }
        public int COLOR_CD1 { get; set; }
        public int COLOR_CD2 { get; set; }
        public string REPAINT_FLAG { get; set; }
        public int FUEL_CD { get; set; }
        public string EXHAUST { get; set; }
        public string EXHAUST_CD { get; set; }
        public string NOXPM_CD { get; set; }
        public int NOXPM_DATE { get; set; }
        public string MODEL_CD { get; set; }
        public int CAPACITY_CD { get; set; }
        public string DRIVE_CD { get; set; }
        public string SHIFT_CD { get; set; }
        public string MISSION_CD { get; set; }
        public int GEAR_CD { get; set; }
        public int DOOR_CD { get; set; }
        public int HANDLE_CD { get; set; }
        public string ORIGIN_TYPE_CD { get; set; }
        public int IMPORT_TYPE_CD { get; set; }
        public string IMPORT_MODEL_YEAR { get; set; }
        public int IMPORT_YEAR_UNKNOWN_FLAG { get; set; }
        public string IMPORT_SERIAL_NO { get; set; }
        public double MAX_LOADING { get; set; }
        public int GUARANTEE_FLAG { get; set; }
        public int MANUAL_FLAG { get; set; }
        public int RECORD_FLAG { get; set; }
        public int NOTE_FLAG { get; set; }
        public int AIR_CONDITION { get; set; }
        public int AIRBAG { get; set; }
        public int ABS { get; set; }
        public int SUNROOF { get; set; }
        public int AW { get; set; }
        public int LEATHER_SEAT { get; set; }
        public int NAVI { get; set; }
        public int NAVI_TYPE { get; set; }
        public int TV { get; set; }
        public int TV_TYPE { get; set; }
        public int KEYLESS { get; set; }
        public int SMART_KEY { get; set; }
        public int FLOORMAT { get; set; }
        public int BACKCAMERA { get; set; }
        public int ETC { get; set; }
        public string SELLING_POINT { get; set; }
        public string SELLING_POINT_EN { get; set; }
        public string CORRECTION { get; set; }
        public string AUC_ANNOUNCEMENT { get; set; }
        public string NOTICE_INFO { get; set; }
        public string NOTICE_INFO_EN { get; set; }
        public string AUC_NOTICE_INFO { get; set; }
        public string ACCIDENT_FLAG { get; set; }
        public string AIS_SCORE_TOTAL { get; set; }
        public string AIS_SCORE_INT { get; set; }
        public string AIS_SCORE_EXT { get; set; }
        public string AIS_COMMENT01 { get; set; }
        // Add similar properties for all AIS_COMMENTs up to 20

        public string AIS_COMMENT_EN { get; set; }
        public string ESTIMATION_DATE { get; set; }
        public string ESTIMATION_EXPIRE_DATE { get; set; }
        public int SELF_SCORE_TOTAL { get; set; }
        public int SELF_SCORE_INT { get; set; }
        public int STRIKE_FLAG { get; set; }
        public string STRIKE_START_DATE { get; set; }
        public string STRIKE_END_DATE { get; set; }
        public int STRIKE_NIGHT_FLAG { get; set; }
        public int STRIKE_POINT_FLAG { get; set; }
        public double STRIKE_PRICE { get; set; }
        public string RECYCLE_FLAG { get; set; }
        public double RECYLE_DEPOSIT { get; set; }
        public string UPDATED_DATE { get; set; }
        public string REGION_NAME { get; set; }
        public int CARCATEGORY_CD { get; set; }
        public int BODYTYPE_CD { get; set; }
        public int CARBODY_LENGTH { get; set; }
        public int CARBODY_WIDTH { get; set; }
        public int CARBODY_HEIGHT { get; set; }
        public int CARBODY_LENGTH_REF { get; set; }
        public int CARBODY_WIDTH_REF { get; set; }
        public int CARBODY_HEIGHT_REF { get; set; }
        public string PREF_NAME { get; set; }
        public string SELLER_HASH_ID { get; set; }
        public int IN_STOCK_RATE { get; set; }
        public int IAUC_LOT_NO { get; set; }
        public int GOOD_VALUE_FLAG { get; set; }
        public string IMAGE1_URI { get; set; }
        public string IMAGE2_URI { get; set; }
        // Add similar properties for all IMAGE_URIs up to 30

        public string INFO_PDF_URI { get; set; }
        public string INFO_PDF_DATE { get; set; }
        public string INSPECTION_PDF_URI { get; set; }
        public string INSPECTION_PDF_DATE { get; set; }
    }

}

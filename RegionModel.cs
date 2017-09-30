namespace WheatherToDatabaseConverter{


    public class RegionModel{

        public int RegionModelId { get; set; }
        public float RegionLongitude { get; set; }
        public float RegionLatitude { get; set; }


        public int  WheatherModelId { get; set; }
        public WheatherModel WheatherModel { get; set; }

    }


}
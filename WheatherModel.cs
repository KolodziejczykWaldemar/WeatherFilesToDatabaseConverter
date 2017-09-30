namespace WheatherToDatabaseConverter{
    public class WheatherModel
    {

        public WheatherModel() {}

        public RegionModel RegionModel { get; set; }

        public int  WheatherModelId { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }       //godzina UTC (GMT Greewich Mean Time)
        public float DBT { get; set; }      //temperatura termometru suchego 
        public int RH { get; set; }         //wilgotność względna
        public float HR { get; set; }       //zawartość wilgoci
        public float WS { get; set; }       //prędkośc wiatru
        public float WD { get; set; }       //kierunek wiatru w 36 sektorach 0 - cisza, N - 36, E - 9, S - 18, W - 27, 99 - zmienny
        public float ITH { get; set; }      //całkowite natężenie promieniowania słonecznego na powierzchnię poziomą
        public float IDH { get; set; }      //bezpośrednie natężenie promieniowania słonecznego na powierzchnię poziomą
        public float ISH { get; set; }      //bezpośrednie natężenie promieniowania słonecznego na powierzchnię poziomą
        public float TSKY { get; set; }     //temperatura promieniowania nieboskłonu

        public float N_0 { get; set; }      //całkowite natężenie promieniowania słonecznego na powierzchnię poziomą (kierunek N pochylenie 0º) (N_0)

        public float N_30 { get; set; }     //całkowite natężenie promieniowania słonecznego na powierzchnie o orientacji oraz pochyleniu do poziomu
        public float NE_30 { get; set; }
        public float E_30 { get; set; }
        public float SE_30 { get; set; }
        public float S_30 { get; set; }
        public float SW_30 { get; set; }
        public float W_30 { get; set; }
        public float NW_30 { get; set; }

        public float N_45 { get; set; }
        public float NE_45 { get; set; }
        public float E_45 { get; set; }
        public float SE_45 { get; set; }
        public float S_45 { get; set; }
        public float SW_45 { get; set; }
        public float W_45 { get; set; }
        public float NW_45 { get; set; }

        public float N_60 { get; set; }
        public float NE_60 { get; set; }
        public float E_60 { get; set; }
        public float SE_60 { get; set; }
        public float S_60 { get; set; }
        public float SW_60 { get; set; }
        public float W_60 { get; set; }
        public float NW_60 { get; set; }

        public float N_90 { get; set; }
        public float NE_90 { get; set; }
        public float E_90 { get; set; }
        public float SE_90 { get; set; }
        public float S_90 { get; set; }
        public float SW_90 { get; set; }
        public float W_90 { get; set; }
        public float NW_90 { get; set; }


    }
}
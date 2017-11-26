using System;
using System.IO;
using System.Globalization;

namespace WheatherToDatabaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int generalCount = 1;
            int regionCount = 1;

            using(var db = new WheatherDataContext())
            { 
                
                string[] files = Directory.GetFiles("WheatherTxtFiles"); 

        

                foreach(string fileName in files)
                {

                    FileStream file = new FileStream(fileName, FileMode.Open);
                    StreamReader scan = new StreamReader(file);
               

                    int N = 0;
                    int D = 0;
                    int H = 0;
                    int M = 0;
                    float DBT = 0.0F;
                    int RH = 0;
                    int count = 0 ;
                    float[] restOfData;
                    restOfData = new float[40];  

                    RegionModel temporaryRegion = new RegionModel();

                    string row = scan.ReadLine();
                    string[] parts = row.Split(' ');

                    temporaryRegion.RegionModelId = regionCount;
                    regionCount++;
                    temporaryRegion.RegionLatitude = float.Parse(parts[4], NumberStyles.Any, CultureInfo.InvariantCulture);
                    temporaryRegion.RegionLongitude = float.Parse(parts[6], NumberStyles.Any, CultureInfo.InvariantCulture);
                    temporaryRegion.WheatherModelId = generalCount;
                    db.Regions.Add(temporaryRegion);

                    string nextRow = scan.ReadLine();
           


                    for(int line = 0; line<8760; line++)
                    {
                        Console.WriteLine("plik: {0}", fileName);
                        count = 0;
                        WheatherModel temporaryModel = new WheatherModel();
                        nextRow = scan.ReadLine();
                        string[] nextParts = nextRow.Split(' ');
            
        

                        while(Int32.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out N) == false)
                        {
                            count++;
                        }
                        N = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        
                        temporaryModel.WheatherModelId = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        temporaryModel.WheatherModelId = generalCount + line;

                        count++;
                        Console.WriteLine("N={0} - {1}", N, count);


                        while(Int32.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out M) == false)
                        {
                            count++;
                        }
                        M = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        temporaryModel.Month = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);

                        count++;




                        while(Int32.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out D) == false)
                        {
                            count++;
                        }
                        D = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        temporaryModel.Day = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        
                        count++;


                        while(Int32.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out H) == false)
                        {
                            count++;
                        }
                        H = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        temporaryModel.Hour = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        count++;


                        while(float.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out DBT) == false)
                        {
                            count++;
                        }
                        DBT = float.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        temporaryModel.DBT = float.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);

                        count++;


                        while(Int32.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out RH) == false)
                        {
                            count++;
                        }
                        RH = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                        temporaryModel.RH = Int32.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);

                        count++;


                        for(int i = 0; i<40; i++)
                        {
                            while(float.TryParse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture, out restOfData[i]) == false)
                            {
                                count++;
                            }

                            restOfData[i] = float.Parse(nextParts[count], NumberStyles.Any, CultureInfo.InvariantCulture);
                            count++;

                        }

                        temporaryModel.HR = restOfData[0];
                        temporaryModel.WS = restOfData[1];
                        temporaryModel.WD = restOfData[2];
                        temporaryModel.ITH = restOfData[3];
                        temporaryModel.IDH = restOfData[4];
                        temporaryModel.ISH = restOfData[5];
                        temporaryModel.TSKY = restOfData[6];
                        temporaryModel.N_0 = restOfData[7];

                        temporaryModel.N_30 = restOfData[8];
                        temporaryModel.NE_30 = restOfData[9];
                        temporaryModel.E_30 = restOfData[10];
                        temporaryModel.SE_30 = restOfData[11];
                        temporaryModel.S_30 = restOfData[12];
                        temporaryModel.SW_30 = restOfData[13];
                        temporaryModel.W_30 = restOfData[14];
                        temporaryModel.NW_30 = restOfData[15];

                        temporaryModel.N_45 = restOfData[16];
                        temporaryModel.NE_45 = restOfData[17];
                        temporaryModel.E_45 = restOfData[18];
                        temporaryModel.SE_45 = restOfData[19];
                        temporaryModel.S_45 = restOfData[20];
                        temporaryModel.SW_45 = restOfData[21];
                        temporaryModel.W_45 = restOfData[22];
                        temporaryModel.NW_45 = restOfData[23];

                        temporaryModel.N_60 = restOfData[24];
                        temporaryModel.NE_60 = restOfData[25];
                        temporaryModel.E_60 = restOfData[26];
                        temporaryModel.SE_60 = restOfData[27];
                        temporaryModel.S_60 = restOfData[28];
                        temporaryModel.SW_60 = restOfData[29];
                        temporaryModel.W_60 = restOfData[30];
                        temporaryModel.NW_60 = restOfData[31];

                        temporaryModel.N_90 = restOfData[32];
                        temporaryModel.NE_90 = restOfData[33];
                        temporaryModel.E_90 = restOfData[34];
                        temporaryModel.SE_90 = restOfData[35];
                        temporaryModel.S_90 = restOfData[36];
                        temporaryModel.SW_90 = restOfData[37];
                        temporaryModel.W_90 = restOfData[38];
                        temporaryModel.NW_90 = restOfData[39];

                        db.WheatherRecords.Add(temporaryModel);
            
                        Console.WriteLine();
                    }

                    generalCount+=8760;
                }
                
                db.SaveChanges();
            }    
        }
    }
}

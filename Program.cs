using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Project_Okey
{
    class Program
    {
        private static int gosterge;
        private static int okey = -1;  //

        public static string[] first, second, third, fourth;

        static void Main(string[] args)
        {
            ArrayList taslistesi = new ArrayList();

            for (int i = 0; i < 106; i++)
            {

                taslistesi.Add(i);
            }
            taslistesi[0] = "sarı0";
            taslistesi[1] = "sarı1";
            taslistesi[2] = "sarı2";
            taslistesi[3] = "sarı3";
            taslistesi[4] = "sarı4";
            taslistesi[5] = "sarı5";
            taslistesi[6] = "sarı6";
            taslistesi[7] = "sarı7";
            taslistesi[8] = "sarı8";
            taslistesi[9] = "sarı9";
            taslistesi[10] = "sarı10";
            taslistesi[11] = "sarı11";
            taslistesi[12] = "sarı12";
            taslistesi[13] = "sarı0";
            taslistesi[14] = "sarı1";
            taslistesi[15] = "sarı2";
            taslistesi[16] = "sarı3";
            taslistesi[17] = "sarı4";
            taslistesi[18] = "sarı5";
            taslistesi[19] = "sarı6";
            taslistesi[20] = "sarı7";
            taslistesi[21] = "sarı8";
            taslistesi[22] = "sarı9";
            taslistesi[23] = "sarı10";
            taslistesi[24] = "sarı11";
            taslistesi[25] = "sarı12";
            taslistesi[26] = "mavi13";
            taslistesi[27] = "mavi14";
            taslistesi[28] = "mavi15";
            taslistesi[29] = "mavi16";
            taslistesi[30] = "mavi17";
            taslistesi[31] = "mavi18";
            taslistesi[32] = "mavi19";
            taslistesi[33] = "mavi20";
            taslistesi[34] = "mavi21";
            taslistesi[35] = "mavi22";
            taslistesi[36] = "mavi23";
            taslistesi[37] = "mavi24";
            taslistesi[38] = "mavi25";
            taslistesi[39] = "mavi13";
            taslistesi[40] = "mavi14";
            taslistesi[41] = "mavi15";
            taslistesi[42] = "mavi16";
            taslistesi[43] = "mavi17";
            taslistesi[44] = "mavi18";
            taslistesi[45] = "mavi19";
            taslistesi[46] = "mavi20";
            taslistesi[47] = "mavi21";
            taslistesi[48] = "mavi22";
            taslistesi[49] = "mavi23";
            taslistesi[50] = "mavi24";
            taslistesi[51] = "mavi25";
            taslistesi[52] = "siyah26";
            taslistesi[53] = "siyah27";
            taslistesi[54] = "siyah28";
            taslistesi[55] = "siyah29";
            taslistesi[56] = "siyah30";
            taslistesi[57] = "siyah31";
            taslistesi[58] = "siyah32";
            taslistesi[59] = "siyah33";
            taslistesi[60] = "siyah34";
            taslistesi[61] = "siyah35";
            taslistesi[62] = "siyah36";
            taslistesi[63] = "siyah37";
            taslistesi[64] = "siyah38";
            taslistesi[65] = "siyah26";
            taslistesi[66] = "siyah27";
            taslistesi[67] = "siyah28";
            taslistesi[68] = "siyah29";
            taslistesi[69] = "siyah30";
            taslistesi[70] = "siyah31";
            taslistesi[71] = "siyah32";
            taslistesi[72] = "siyah33";
            taslistesi[73] = "siyah34";
            taslistesi[74] = "siyah35";
            taslistesi[75] = "siyah36";
            taslistesi[76] = "siyah37";
            taslistesi[77] = "siyah38";
            taslistesi[78] = "kırmızı39";
            taslistesi[79] = "kırmızı40";
            taslistesi[80] = "kırmızı41";
            taslistesi[81] = "kırmızı42";
            taslistesi[82] = "kırmızı43";
            taslistesi[83] = "kırmızı44";
            taslistesi[84] = "kırmızı45";
            taslistesi[85] = "kırmızı46";
            taslistesi[86] = "kırmızı47";
            taslistesi[87] = "kırmızı48";
            taslistesi[88] = "kırmızı49";
            taslistesi[89] = "kırmızı50";
            taslistesi[90] = "kırmızı51";
            taslistesi[91] = "kırmızı39";
            taslistesi[92] = "kırmızı40";
            taslistesi[93] = "kırmızı41";
            taslistesi[94] = "kırmızı42";
            taslistesi[95] = "kırmızı43";
            taslistesi[96] = "kırmızı44";
            taslistesi[97] = "kırmızı45";
            taslistesi[98] = "kırmızı46";
            taslistesi[99] = "kırmızı47";
            taslistesi[100] = "kırmızı48";
            taslistesi[101] = "kırmızı49";
            taslistesi[102] = "kırmızı50";
            taslistesi[103] = "kırmızı51";
            taslistesi[104] = "sahteokey52";
            taslistesi[105] = "sahteokey52";

            void GöstergeSecim()  //Gösterge Seç  ve okey seç 
            {
                Random rastgele1 = new Random();
                gosterge = rastgele1.Next(1, 104);
                if (gosterge == 52 || gosterge == 104-105) //Sahte okeyler gösterge olamaz.
                {
                    GöstergeSecim();
                }

                okey = gosterge + 1;
             
            }


            GöstergeSecim(); //  Gösterge ve okeyi yazdır

            Console.WriteLine("********* ");
            Console.WriteLine("Gösterge = " + taslistesi[gosterge]);
            Console.WriteLine("******************************* ");
            taslistesi.Remove(gosterge);  // Gösterge taşların arasından çıkar.
            Console.WriteLine("Okey " + taslistesi[okey]);
            taslistesi.Remove(okey);
            Console.WriteLine("******************************** ");

            void shuffle(ArrayList arrayRandom)   // Taşları karıştır.
            {
                for (int i = 1; i < arrayRandom.Count; i++)
                {
                    Random random = new Random();
                    string tmp = (string)arrayRandom[i];
                    int r = random.Next(i, arrayRandom.Count);
                    arrayRandom[i] = arrayRandom[r];
                    arrayRandom[r] = tmp;
                }
            }

            shuffle(taslistesi); // Karıştırılan Taşları Yazdır

            foreach (var item in taslistesi)  
            {
                Console.Write(" " + item);

            }
            Console.WriteLine(" ");
            Console.WriteLine("******************************** ");

            // Karıştırılan Taşlar Oyunculara verilmek üzere dağıtılır.Not: Daha sonra bu taşlar oyuncu sırası belirlenme durumuna göre oyunculara verilir.
            string[] player1 = new string[15];
            taslistesi.CopyTo(0, player1, 0, 15);

            //--------------------------------

            string[] player2 = new string[14];
            taslistesi.CopyTo(15, player2, 0, 14);

            //--------------------------------
            string[] player3 = new string[14];
            taslistesi.CopyTo(29, player3, 0, 14);
            //--------------------------------
           string[] player4 = new string[14];
            taslistesi.CopyTo(43, player4, 0, 14);

            //--------------------------------

            SırayıBelirleDagıt();  //Sırayı belirleyen ve Oyunculara taşlarını veren fonksiyon

            //Oyuncu Taşlarını Yaz
            Console.WriteLine("Player1");
            Console.WriteLine("*************************************************");
            foreach (var item in first)
            {
                Console.Write(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Player2");
            Console.WriteLine("*************************************************");
            foreach (var item in second)
            {
                Console.Write(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Player3");
            Console.WriteLine("*************************************************");
            foreach (var item in third)
            {
                Console.Write(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Player4");
            Console.WriteLine("*************************************************");
            foreach (var item in fourth)
            {
                Console.Write(item);
             }
            //------------

            void SırayıBelirleDagıt()  //  Oyuncuların sırasını random verir ve Önceden dağıtılmış taş dizilerini oyunculara atar.
            {
                int randomPlayer;
                Random random = new Random();
                randomPlayer = random.Next(1, 4);


                if (randomPlayer == 1)
                {
                    first = (string[])player1;
                    second = (string[])player2;
                    third = (string[])player3;
                    fourth = (string[])player4;

                }
                else if (randomPlayer == 2)
                {
                    first = (string[])player4;
                    second = (string[])player1;
                    third = (string[])player2;
                    fourth = (string[])player3;
                }
                else if (randomPlayer == 3)
                {
                    first = (string[])player3;
                    second = (string[])player4;
                    third = (string[])player1;
                    fourth = (string[])player2;
                }
                else
                {
                    first = (string[])player2;
                    second = (string[])player3;
                    third = (string[])player4;
                    fourth = (string[])player1;
                }
            }
        }
    }
}
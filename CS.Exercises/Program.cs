using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CS.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 1    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite sveikajį skaičių");

            ReadIntNumber();
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 2    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Metodas, kuris tikrina paduotus symbolius ir grąžina true/false");
            var grazino = TryParseReloaded("1234", out int number01);
            Console.WriteLine("Grazino {0} || skaicius = {1}", grazino, number01);
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 3    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite betkokį sveikąjį skaičių: ");
            skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary number is {0}", IntegerToBinary(skaicius));
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 4    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Ivesk skaiciu kuri kelsi n-tuoju laipsniu : ");
            skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Ivesk kelimo laipsni :");
            int laipsnis = int.Parse(Console.ReadLine());
            Console.Write("Rezultatas = {0} ", PakeltiLaipsniu(skaicius, laipsnis));
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            int sumResult = 0;
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 5    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Metode paduotas dvejetainis skaicius: 111010");
            Console.WriteLine("Desimtainis skaicius: {0}", BinaryToInteger(sumResult));
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 6    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Metode paduotas sakinys: \"Mary had a little lamp zzzz\"");
            SentenceAnalysis();
            //susideklaruoju kintamuosius

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 7    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite sveikaji skaiciu, toki, kokio dydzio skaiciu trikampi norite gauti: ");
            SkaiciuStatusTrikampis(skaicius);
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 8    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite sveikaji skaiciu, toki, kokio dydzio lygiasoni skaiciu trikampi norite gauti: ");
            LygiasonisTrikampis(skaicius);
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            string tekstas = "";
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 9    |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite kiek kartu norite kad skaicius 1 pasikartotu aritmetine seka: ");
            skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine(AppendingNumbers(skaicius, tekstas));
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();
            //Užduotis 10-------------------------------------------------------------
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 10   |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite sveikaji skaiciu, toki kokio dydzio skaiciu trikampi norite gauti: ");
            SkaiciuTrikampis(skaicius);
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 11   |");
            Console.WriteLine("|-----------------|");
            Console.WriteLine("Iveskite sveikaji skaiciu, toki, kokio dydzio lygiasoni skaiciu trikampi norite gauti: ");
            SkaiciuLygiasonisTrikampis(skaicius);
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            //Užduotis 12-------------------------------------------------------------
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 12   |");
            Console.WriteLine("|-----------------|");
            int x = 3;
            string formule = "1 + x + x / 2 + x / 3 + x / 2 + 1 * 2";
            Console.WriteLine(SkaiciuotiFormule(formule, x));
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

            //Užduotis 12a-------------------------------------------------------------
            Console.WriteLine("|-----------------|");
            Console.WriteLine("|   UŽDUOTIS 12   |");
            Console.WriteLine("|-----------------|");
            string testString = Console.ReadLine();
            Console.WriteLine(Palindronas(testString));
            Console.WriteLine();
            Console.WriteLine("Press any Key for next Method");
            Console.ReadKey();

        }
        //---------------- 1
        static int ReadIntNumber()
        {
            int intNumber;
            while (!int.TryParse(Console.ReadLine(), out intNumber))
            {
                Console.WriteLine("Please input an integer");
            }
            Console.WriteLine("Thank you");
            return intNumber;

        }
        //---------------- 2
        static bool TryParseReloaded(string inputString, out int number01)
        {
            number01 = 0;

            foreach (var letter in inputString)
            {
                if (letter != '0' &&
                    letter != '1' &&
                    letter != '2' &&
                    letter != '3' &&
                    letter != '4' &&
                    letter != '5' &&
                    letter != '6' &&
                    letter != '7' &&
                    letter != '8' &&
                    letter != '9') { return false; }
            }

            number01 = int.Parse(inputString);

            return true;
        }

        static string IntegerToBinary(int skaicius)
        {
            
            if (skaicius == 0) return "0";
            List<int> liekanos = new List<int>();
            string dvejetainis = string.Empty;

            while (skaicius >= 1)
            {
                liekanos.Add(skaicius % 2);
                skaicius = skaicius / 2;
            }
            liekanos.Reverse();

            foreach (var liekana in liekanos)
            {
                dvejetainis = $"{dvejetainis}{liekana}";
                //Console.WriteLine("dvejetainis = {0}",dvejetainis); // pasitikinu su CW.
            }
            return dvejetainis;
        }
        static int PakeltiLaipsniu(int skaicius, int laipsnis)
        {
            if (laipsnis == 0 && skaicius != 0)
            {
                return 1; // pasirašau kėlimo nuliu salygą, kuri yra lygi 1
            }
            else if (skaicius == 0)
            {
                return 0;
            }

            if (laipsnis == 1)
            {
                return skaicius;
            }
            int rezultatas = skaicius;

            for (int i = 1; i < laipsnis; i++)
            {
                rezultatas = rezultatas * skaicius;
                //Console.WriteLine(rezultatas);
            }
            return rezultatas;
        }
        static int BinaryToInteger(int sumResult)
        {
            string dvejetainis = "111010";
            sumResult = 0;
            char[] charMas = dvejetainis.ToCharArray();

            Array.Reverse(charMas);
            Console.WriteLine();

            for (int i = 0; i < charMas.Length; i++)
            {

                if (charMas[i] == '1')
                {
                    int binNum = 2;
                    for (int j = 1; j < i; j++)
                    {
                        binNum = binNum * 2;
                    }
                    sumResult += binNum;
                }
            }
            return sumResult;
        }
        static void SentenceAnalysis()
        {
            string sentence = "Marry had a little lamp zzzz";
            var simboliuZodynas = SukurtiRaidziuZodyna(sentence.ToUpper().ToCharArray());
            foreach (var simbolis in simboliuZodynas)
            {
                Console.WriteLine($"  |   {simbolis.Key}   |   {string.Format("{0,7}", simbolis.Value)}  |");
            }
            string maziausiaiPasikartojo;
            string daugiausiaiPasikartojo;
            MaziausiaiIrDaugiausiaiPasikartojimu(simboliuZodynas, out maziausiaiPasikartojo, out daugiausiaiPasikartojo);
            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"{maziausiaiPasikartojo}");
            Console.WriteLine($"{daugiausiaiPasikartojo}");

        }
        private static void MaziausiaiIrDaugiausiaiPasikartojimu(Dictionary<char, int> simboliuZodynas, out string maziausiaiPasikartojo, out string daugiausiaiPasikartojo)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var simbolis in simboliuZodynas)
            {
                if (simbolis.Value < min) min = simbolis.Value;
                if (simbolis.Value > max) max = simbolis.Value;
            }
            List<char> minSimboliuMasyvas = new List<char>();
            List<char> maxSimboliuMasyvas = new List<char>();

            foreach (var simbolis in simboliuZodynas)
            {
                if (simbolis.Value == min) minSimboliuMasyvas.Add(simbolis.Key);
                if (simbolis.Value == max) maxSimboliuMasyvas.Add(simbolis.Key);
            }

            daugiausiaiPasikartojo = $"Daugiausia {string.Join(", ", maxSimboliuMasyvas)} pasikartojo {max} k. ";
            maziausiaiPasikartojo = $"Maziausia {string.Join(", ", minSimboliuMasyvas)} pasikartojo {min} k. ";
        }
        static Dictionary<char, int> SukurtiRaidziuZodyna(char[] charArray) //dict = ka grazina metodas
        {
            Dictionary<char, int> simboliai = new Dictionary<char, int>();

            foreach (var raide in charArray)
            {
                if (!string.IsNullOrWhiteSpace(raide.ToString())) // tikrinu ar yra whitespace
                {
                    PatikrintiArNeraZodyneIrIdeti(raide, ref simboliai);
                }
            }
            return simboliai;
        }
        static void PatikrintiArNeraZodyneIrIdeti(char raide, ref Dictionary<char, int> simboliai)
        {
            if (!simboliai.ContainsKey(raide))
            {
                simboliai.Add(raide, 1);
            }
            else
            {
                simboliai[raide]++;
            }
        }
        static int SkaiciuStatusTrikampis(int skaicius)
        {
            //Tikrinu ar ivestis yra int tipo kintamasis
            while (!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Blogas skaicius");
                Console.WriteLine("Prasome ivesti sveikaji skiaciu:");
            }
            //Iteruoju eiluciu skaiciu su local var i iki 5
            for (int i = 1; i <= skaicius; i++)
            {
                Console.WriteLine();
                //Iteruoju skaicius kiekvienoje sekancioje eiluteje. Skaiciu kiekis eilutej lygus eilutes skaiciu
                for (int skKiekisEilutej = 1; skKiekisEilutej <= i; skKiekisEilutej++)
                {
                    Console.Write(skaicius);
                }

            }
            return skaicius;
        }
        static int LygiasonisTrikampis(int skaicius)
        {
            //Tikrinu ar ivestis yra int tipo kintamasis
            while (!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Blogas skaicius");
                Console.WriteLine("Prasome ivesti sveikaji skiaciu:");
            }
            //Iteruoju eiluciu skaiciu su local var
            for (int i = 1; i <= skaicius; i++)
            {
                Console.WriteLine();
                //Iteruoju skaicius kiekvienoje sekancioje eiluteje. Skaiciu kiekis eilutej lygus eilutes skaiciu
                for (int skEilutej01 = 1; skEilutej01 <= i; skEilutej01++)
                {
                    Console.Write(skaicius);
                }
            }
            //iteruoju eiluciu skaiciu su local var
            for (int i = 1; i <= skaicius - 1; i++)
            {
                Console.WriteLine();

                for (int skEilutej02 = skaicius - 1; skEilutej02 >= i; skEilutej02--)
                {
                    Console.Write(skaicius);
                }
            }
            return skaicius;
        }        static string AppendingNumbers(int skaicius, string tekstas)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(" -> ");
                for (int j = 1; j <= i; j++)
                {
                    sb.Append(1);
                    tekstas = sb.ToString();
                }
            }
            return tekstas;
        }
        static int SkaiciuTrikampis(int skaicius)
        {
            //Tikrinu ar ivestis yra int tipo kintamasis
            while (!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Blogas skaicius");
                Console.WriteLine("Prasome ivesti sveikaji skiaciu:");
            }
            //Iteruoju eiluciu skaiciu su local var i iki 
            for (int i = 0; i <= skaicius; i++)
            {
                Console.WriteLine();
                //Iteruoju skaicius kiekvienoje sekancioje eiluteje. Kiekviena nauja eilute iteruoja i reiksme (ja kartoja)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
            }
            return skaicius;
        }
        static int SkaiciuLygiasonisTrikampis(int skaicius)
        {
            //Tikrinu ar ivestis yra int tipo kintamasis
            while (!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Blogas skaicius");
                Console.WriteLine("Prasome ivesti sveikaji skiaciu:");
            }
            //Iteruoju eiluciu skaiciu su local var i 
            for (int iDidejantis = 0; iDidejantis <= skaicius; iDidejantis++)
            {
                Console.WriteLine();
                //Iteruoju skaicius kiekvienoje sekancioje eiluteje. Skaiciu kiekis eilutej lygus eilutes skaiciu
                for (int j = 1; j <= iDidejantis; j++)
                {
                    Console.Write(iDidejantis);
                }
            }
            //iteruoju eiluciu skaiciu su local var
            for (int iMazejantis = skaicius - 1; iMazejantis >= 0; iMazejantis--)
            {
                Console.WriteLine();
                for (int j = iMazejantis - 1; j >= 0; j--)
                {
                    Console.Write(iMazejantis);
                }
            }
            return skaicius;
        }

        //-------------------------12-----------------------------------------------------------
        static double SkaiciuotiFormule(string formule, int x)
        {
            char[] formulesElementai = formule.ToCharArray();
            double leftOperator = double.TryParse(formulesElementai[0].ToString(), out double leftSkaicius) ? leftSkaicius : x; // pasiimam pirma elementa

            for (int i = 0; i < formulesElementai.Length - 1; i++) //tikrinu ar turiu matemani veiksma ar skaiciu int
            {

                leftOperator = GautiSkaiciu(formulesElementai, ref i, x, leftOperator);

            }
            return leftOperator; //paskutinis  veikmas i leftop iraso galutini rezultata

        }
        static double GautiSkaiciu(char[] formulesElementai, ref int vidurinisIndex, int x, double leftOperator)
        {
            double matVeiksmuRezultatai = leftOperator; // jei nei i viena if neiejo tai grazintu nuli jei matrez = 0

            var rightOperator = int.TryParse(formulesElementai[vidurinisIndex + 1].ToString(), out int rightSkaicius) ? rightSkaicius : x; //out of bounds exeption!

            if (formulesElementai[vidurinisIndex] == '+')
            {
                matVeiksmuRezultatai = leftOperator + rightOperator;
            }
            else if (formulesElementai[vidurinisIndex] == '^')
            {
                matVeiksmuRezultatai = Math.Pow(leftOperator, rightOperator);
            }
            else if (formulesElementai[vidurinisIndex] == '/')
            {
                matVeiksmuRezultatai = leftOperator / rightOperator;
            }
            else if (formulesElementai[vidurinisIndex] == '-')
            {
                matVeiksmuRezultatai = leftOperator - rightOperator;
            }
            else if (formulesElementai[vidurinisIndex] == '*')
            {
                matVeiksmuRezultatai = leftOperator * rightOperator;
            }
            return matVeiksmuRezultatai;
        }

        static bool Palindronas(string testString)
        {
            int strLength = testString.Length;
            for (int i = 0; i < strLength / 2; i++)
            {
                if (testString[i] != testString[strLength - i - 1])
                    return false;
            }
            return true;
        }

        static void WorkWithMatix()
        {
            int[,] arr4d = new int[4, 4]
                {
                    {9,22,3,19 },
                    {6,16,11,8 },
                    {7,5,18,10 },
                    {8,6,2,11 },
                };
            int lowest = arr4d[0,0];
            int highest = arr4d[0,0];
            int numberOfElementsInArray = arr4d.Length;
            int sum = 0;            
            int closestToAverage = 0;

            for (int i = 0; i < numberOfElementsInArray; i++)
            {
                if (lowest > arr4d[i,i])
                {
                    lowest = arr4d[i,i];
                }
                if (highest < arr4d[i,i])
                {
                    highest = arr4d[i,i];
                }
                sum += arr4d[i,i];
            }

            int average = sum / numberOfElementsInArray;
            Console.WriteLine($"Highest:{highest}");
            Console.WriteLine($"Highest:{average}");
            foreach (var number in arr4d)
            {
                closestToAverage = average 
            }
            Console.WriteLine($"Closest to average: {closestToAverage}");
        }

    }
}

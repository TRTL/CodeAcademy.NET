﻿using System.Text;

namespace L018_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 1.Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1-> 11-> 111-> 1111-> 11111-> .......
            /// programa turi paprašyti nurodyti skaičių ir grupių kiekį
            /// naudokite for ir StringBuilder
            /// </summary>
            //PirmaUzduotis();

            /// <summary>
            /// 2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
            /// 15 X 1 = 15
            /// 15 X 2 = 30
            /// 15 X 3 = 45
            /// 15 X 4 = 60
            /// 15 X 5 = 75
            /// 15 X 6 = 90
            /// 15 X 7 = 105
            /// 15 X 8 = 120
            /// 15 X 9 = 135
            /// 15 X 10 = 150
            /// </summary>
            //AntraUzduotis();


            /// <summary>            
            /// 3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima 
            /// "1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti"
            ///     1.Sudetis
            ///     2.Atimtis
            ///     3.Daugyba
            ///     4.Dalyba
            /// Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
            /// o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu.
            /// 
            ///     Sudeties pvz:
            ///     1
            ///     15
            ///     45
            ///     Rezultatas: 60
            /// 
            ///     1.Nauja operacija
            ///     2.Testi su rezultatu
            ///     3.Iseiti
            /// 
            /// Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
            /// 
            /// BONUS1: Iskelkite operacijas i metodus
            /// BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            /// BONUS3: Parasyti unit testus uztikrinant operaciju veikima
            /// BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas 
            /// </summary>
            TreciaUzduotis();    

            /// <summary>
            /// 4. Sukurkite programa, kuri atspausdintu sia forma:
            /// 
            ///             *
            ///            ***
            ///           *****
            ///          *******
            ///         *********
            ///          *******
            ///           *****
            ///            ***
            ///             * 
            ///             
            /// </summary>

        }


        private static int? SkaiciausTikrinimas(string? txt)
        {

            if (int.TryParse(txt, out int num) == false)
            {
                AntraUzduotis();
                return null;
            }
            else
                return num;
        }

        public static int? IntTryParseNullable(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

        /// <summary>
        /// 1.Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1-> 11-> 111-> 1111-> 11111-> .......
        /// programa turi paprašyti nurodyti skaičių ir grupių kiekį
        /// naudokite for ir StringBuilder
        /// </summary>
        private static void PirmaUzduotis()
        {
            Console.WriteLine("iveskite du skaicius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius2; i++)
            {
                sb.Append(" -> ");
                for (int j = 1; j <= i; j++)
                {
                    sb.Append(skaicius1);
                }
            }
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// 2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
        /// 15 X 1 = 15
        /// 15 X 2 = 30
        /// 15 X 3 = 45
        /// 15 X 4 = 60
        /// 15 X 5 = 75
        /// 15 X 6 = 90
        /// 15 X 7 = 105
        /// 15 X 8 = 120
        /// 15 X 9 = 135
        /// 15 X 10 = 150
        /// </summary>
        private static void AntraUzduotis()
        {
            int? skaicius = null;
            do
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            } while (skaicius != null);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
            }
        }
        
        /// <summary>            
        /// 3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima 
        ///     
        ///     1. Nauja operacija 
        ///     2. Testi su rezultatu 
        ///     3. Iseiti”. 
        ///  
        /// Pasirinkus 1 turetu ismesti
        /// 
        ///     1.Sudetis
        ///     2.Atimtis
        ///     3.Daugyba
        ///     4.Dalyba
        ///     
        /// Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
        /// o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu.
        /// 
        ///     Sudeties pvz:
        ///     1
        ///     15
        ///     45
        ///     Rezultatas: 60
        /// 
        ///     1.Nauja operacija
        ///     2.Testi su rezultatu
        ///     3.Iseiti
        /// 
        /// Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
        /// 
        /// BONUS1: Iskelkite operacijas i metodus
        /// BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
        /// BONUS3: Parasyti unit testus uztikrinant operaciju veikima
        /// BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas 
        /// </summary>        
        private static void TreciaUzduotis()
        {
            SkaiciuotuvoMenu1();
            int? pasirinkimas = null;
            do
            {
                Console.Write("Pasirinkimas: ");
                pasirinkimas = IntTryParseNullable(Console.ReadLine());
            } while (pasirinkimas == null || pasirinkimas > 3 || pasirinkimas < 1);

            switch (pasirinkimas)
            {
                case 1:
                    SkaiciuotuvoMenu2();

                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


            Console.WriteLine("saunu!");

        }

        private static void SkaiciuotuvoMenu1()
        {
            Console.WriteLine("1. Nauja operacija");
            Console.WriteLine("2. Testi su rezultatu");
            Console.WriteLine("3. Iseiti");
        }
        private static void SkaiciuotuvoMenu2()
        {
            Console.WriteLine("1. Sudetis");
            Console.WriteLine("2. Atimtis");
            Console.WriteLine("3. Daugyba");
            Console.WriteLine("3. Dalyba");
        }
    }
}
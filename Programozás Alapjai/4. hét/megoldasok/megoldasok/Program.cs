using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megoldasok
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            //Olvass be két egész számot (a és b) majd írd ki a^b értékét.
            //A hatványozás valójában a szorzás ismételt elvégzése. Azaz:
            //a^b=1*a*a*a*....*a ahol b db szorzás van.
            //ezt úgy is felírhatjuk, hogy c=1 és b darabszor elvégezzük a c=c*a műveletet.

            //Két szám beolvasása:
            Console.WriteLine("Hatványozás");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            int hatvany= 1; //ebben a változóban tároljuk az egyre növekvő hatványokat
                            //kezdetben 1 az értéke mivel minden szám 0. hatványa 1
            for (int i = 0; i < b; i++) //b db szorzást végzünk.
            {
                hatvany = hatvany * a; //Hatvány értéke a-szoros lesz.
            }

            Console.WriteLine($"a^b: {hatvany}");
            #endregion

            #region 2. feladat
            //Faktorizáció: olvass be egy egész számot (n), majd írd ki n!-t
            //A faktorizáció hasonló, mint a hatványozás, csak nem fix az alappal szorzunk, hanem egyre kisebb számokkal
            //n!=n*(n-1)*(n-2)*...*1* összesen a-1 darab szorzást végzünk.
            //Átírva: c=1 és c=c*i ahol i=n,(n-1),...,3,2

            Console.WriteLine("Faktorizáció");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int faktor = 1;
            for (int i = n; i >=2; i--) //i értéke n-ről indul, minden ciklus végén eggyel csökkentjük
                                        //Amíg i>=2, azaz i értéke először n, majd (n-1), (n-2), (n-3)...
            {
                faktor *= i; 
            }
            Console.WriteLine($"n!= {faktor}");
            #endregion

            #region 3. feladat
            //Kassza: beolvassuk néhány termék árait, majd kiírjuk az összköltséget
            //Ehhez használunk egy összeg változót, ahol elmentjük mindig az aktuális összeget.
            Console.WriteLine("Vásárlás");
            Console.Write("termékek száma: ");
            int termekszam = int.Parse(Console.ReadLine());
            int osszeg = 0;
            for (int i = 0; i < termekszam; i++)
            {
                Console.Write($"{i+1}. termék ára: ");
                int ar = int.Parse(Console.ReadLine()); //Emlékeztető: A kapcsoszárójelek közötti változók
                                                        //a bezárókapcsoszárójelig léteznek, itt az ar változó
                                                        //a for ciklust bezáró kapcsoszárójelig él,
                                                        //így minden ciklusban új változó jön létre
                osszeg = osszeg + ar;
            }

            Console.WriteLine($"Fizetendő: {osszeg} Ft");
            #endregion

            #region 4. feladat
            //Fizika: Egy testet egyenletes F erővel húzzuk, ha rá a csúszási súrlódási erő, mennyi a test gyorsulása?
            //Kérd be F, mu, m értékeket. (g=10m/s^2) majd írd ki a értékét.
            Console.WriteLine("Fizika");
            Console.Write("F (N): ");
            double F = double.Parse(Console.ReadLine()); //Erő amivel húzzuk a testet
            Console.Write("mu: ");
            double mu = double.Parse(Console.ReadLine()); //súrlódási együttható
            Console.Write("m (kg): ");
            double m = double.Parse(Console.ReadLine()); //test súlya

            double g = 10; //nehézségi gyorsulás

            double Fny = m * g; //test súlya, nyomó erő
            double Fs = mu * Fny; //súrlódási erő
            double Fe = F - Fs; //eredő erő
            double acc = Fe / m; //a test gyorsulása

            Console.WriteLine($"a: {acc}");
            #endregion

            #region 5. feladat
            //Rajzoljunk ki egy nagyítható négyzetet
            Console.WriteLine("Négyzet");
            Console.Write("négyzet mérete: ");
            int nagyitas = int.Parse(Console.ReadLine());
            //Először rajzoljuk ki a felső sort
            Console.Write("+");
            for (int i = 0; i < nagyitas; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            //Majd rajzoljuk ki a törzset, ehhez nagyitas db sort kell kirajzolni
            for (int i = 0; i < nagyitas; i++) //nagyitas-szor ismételjük egy sor kirajzolását
            {
                //egy sor kirajzolása
                Console.Write("|");
                //itt már nem lehet i a forciklus "futóváltozója" mert azt már használjuk, így legyen mondjuk j
                for (int j = 0; j < nagyitas; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            //És kirajzoljuk az utolsó sort is, ugyanúgy, mint az első sort.
            Console.Write("+");
            for (int i = 0; i < nagyitas; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            #endregion

            Console.ReadLine();
        }
    }
}

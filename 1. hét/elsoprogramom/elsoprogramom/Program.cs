using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsoprogramom
{
    class Program
    {
	//Első heti szakkörön készült program
        static void Main(string[] args)
        {
            // 1.rész: Üdvözlés, bekérjük a felhasználó nevét, és üdvözöljük. 
            // string kereszt = "";
            // string vezetek = "";
            string nev = ""; //Ebben a szöveg típusú változóban fogjuk tárolni a felhasználó nevét
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Üdvözöllek a teszt programban!");
            Console.WriteLine("Mi a neved?"); //Bekérjük a felhasználótól a nevét
            nev=Console.ReadLine(); //A beírt nevet elmentjük a nev változóba
            Console.WriteLine($"Szia {nev}!"); //Üdvözöljük a felhasználót, a dollárjel azért kell, hogy bele tudjuk fűzni a felhasználó nevét a szövegbe

            //2. rész: a felhasználó nehézséget választ.
            string nehezseg = "alma";
            Console.WriteLine("Mi nehézsegű játékot szeretnénk?"); 
            nehezseg = Console.ReadLine(); 
            if (nehezseg == "konnyu") //Ha a játékos könnyű nehézséget választott (a kérdésünkre a konnyu szóval válaszolt), akkor azt írjuk ki neki, hogy NEM
            {
                Console.WriteLine("NEM");

            }else if(nehezseg=="kozepes") //Különben, ha közepes nehézséget választott azt írjuk ki, hogy "Még mindig nem"
            {
                Console.WriteLine("Még mindig nem");
            }
            else if (nehezseg == "impossible") //Különben, ha impossible nehézséget választott akkor azt írjuk ki, hogy "Nyertél!" 
            {
                Console.WriteLine("Nyertél!");
            }
            else //Minden más esetben azt írjuk ki, hogy "Ilyen nincs!"
            {
                Console.WriteLine("Ilyen nincs!");
            }

            //3. rész belérjük a felhasználó korát, majd kiírjuk egy évvel ezelőtt hány éves volt
            int kor = 0; //Ebben az egész szám változóban tároljuk a felhasználó korát
            bool hibasvolt = false; //Ebben tároljuk hibás volt-e a beolvasás
            Console.WriteLine("Hány éves vagy?");
            try //Megpróbáljuk számként értelmezni azt amit a felhasználó beírt.
            {
                kor = int.Parse(Console.ReadLine());
            }
            catch (Exception) //Ha nem sikerül akkor kiírjuk, hogy "Ez nem egy egész szám"
            {
                Console.WriteLine("Ez nem egy egész szám");
                hibasvolt = true;
            }

            //Példák arra milyen műveletet lehet egész számokkal végezni
            //int maradek = kor % 10; //Osztás maradéka
            //int hanyados = kor / 10; //Osztás hányadosa
            //int szorzat = kor * 10; //Szorzás
            //int osszeg = kor + maradek; //Összeadás
            //int kulonbseg = kor - maradek; //Kivonás
            //int bonyolult = ((kor - 10) + 10) * (20 / 20); //Összetett művelet, zárójelekkel, a matekból tanult műveleti sorrend érvényes itt is.


            if (hibasvolt == false) //Csak akkor írjuk ki, hogy hány ées volt egy évvel ezelőtt, ha egész számot írt be a felhasználó.
            {
                Console.WriteLine($"Egy évvel ezelőtt {kor - 1} éves voltál!");
            }
            
            //Beolvasunk mégegy sort, hogy ne záródjon be egyből a konzol.
            Console.ReadLine();
        }
    }
}

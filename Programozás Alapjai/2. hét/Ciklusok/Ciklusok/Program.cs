using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. rész: kérjünk be egy számot és írjuk ki 1-től addig a számokat növekvő sorrendben.
            int meddig = 0; //ebben a változóban fogjuk tárolni meddig írjuk ki a számokat.
            Console.WriteLine("Meddig írjam ki a számokat?");
            meddig = int.Parse(Console.ReadLine());
            Console.WriteLine("A számok növekvő sorrendben:");
            for (int i = 1; i <= meddig; i++) //i++ annak a rövidítése, hogy i=i+1
            {
                Console.WriteLine(i);
            }

            //2. rész: írjuk ki csökkenő sorrendben a számokat 1 és meddig között.
            //ötlet: az i először legyen a meddig, minden ciklus végén eggyel csökkentsük az i-t amíg i>=1
            Console.WriteLine("A számok csökkenő sorrendben:");
            for (int i = meddig; i >=1; i--) //i-- annak a rövidítése, hogy i=i-1
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("A hárommal osztható számok:");
            //3. rész: írjuk ki 0 és meddig között a hárommal osztható számokat:
            //ötlet ne 1-gyel növeljük az i változót minden ciklusban, hanem 3-mal.
            for (int i = 0; i <= meddig; i=i+3)
            {
                Console.WriteLine(i);
            }

            //4. rész: Kérdezzük meg a felhasználót, hány kötőjelet szeretnénk kiírni, majd írjunk ki annyi kötőjelet.
            //Ötlet: kotojelszam-szor kellene ismételni az egy kötőjel kiírását,
            //ezt úgy szokták az informatikusok, hogy i az 0-tól indul, és addig írják ki a kötőjeleket amíg i<kötöjelszám
            //Szintén jó megoldás lenne, hogy: for(int i=1;i<=kotojelszam;i++) ... de ezt ritkábban használják.
            Console.WriteLine("Hány kötőjelet kérsz?");
            int kotojelszam = int.Parse(Console.ReadLine());
            for (int i = 0; i < kotojelszam; i++)
            {
                Console.Write("-"); // Console.Write olyan mint a Console.WriteLine() csak nincs enter a végén
            }

            Console.ReadLine();
        }
    }
}

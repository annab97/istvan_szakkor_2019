using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WalkingDot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Timer timer = new Timer(); //Létrehozzuk az időzítőt, ez fogja rendszeresen meghívni a tick függvényt, mint egy rendszeresen ébresztő ébresztőóra.
            timer.Interval = 50;       //Ennyi ezredmásodpercente kérünk ébresztést
            timer.AutoReset = true;    // Ismétlődően kérünk ébresztést, nem csak egyszer
            timer.Elapsed += Tick;     // Itt mondjuk meg, hogy a tick függvény az, amit rendszeresen meg kell hívni.
            Console.CursorVisible = false; //Eltünteti a kurzort jelző kis alulvonást, amitől szebben néz ki a program

            timer.Start(); //Elindítja a timert.
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); //Beolvas egy karaktert  a konzolról
            while (keyInfo.Key != ConsoleKey.Escape) //Ha az a karakter escape akkor befejezi a program futását
            {
                if (keyInfo.Key == ConsoleKey.LeftArrow) //Ha a karakter balranyíl akkor jelzi, hogy a következő tick-ben -1-gyel kell jobbra mozgatni
                                                         //Azaz eggyel kell csökkenteni a space-ek számát
                {
                    speed = -1;
                }else if (keyInfo.Key == ConsoleKey.RightArrow) //Ha a karakter jobbra akkor jelzi, hogy a következő tick-ben +1-gyel kell jobbra mozgatni
                                                                //Azaz eggyel kell növelni a space-ek számát
                {
                    speed = 1;
                }
                keyInfo = Console.ReadKey(true); //Amint újabb karaktert érzékel beolvassa azt majd a while ciklus következő iterációjában feldolgozza azt.
            }

            timer.Stop();    //Leállítja a timert.
            timer.Dispose(); // A leállított timert még ki is kell törölnünk a programból, különben szellemként itt maradna.
            
            
        }
        private static int position=0;  //Tárolja, hogy hol van éppen az X
        private static int speed = 1;  //Tárolja, hogy merre kell a következő tickben lépnie az X-nek
        
        /* A tick függvényünket a program a main függvénytől függetlenül meghívja időközönként.
           Azaz a main függvény folyamatosan fut, ez a tick függvény meg néha, néha:

           Main: <------------------------------------------------------------------------------------------------->
           Tick: <->     <->     <->     <->     <->     <->     <->     <->     <->     <->     <->     <->     <-> */
        private static void Tick(object sender, ElapsedEventArgs e) //A tick kap bemeneti változókat, amik infót nyújtanak arról,
                                                                    // hogy melyik timer hogy hívta meg stb. de ezek nekünk nem érdekesek.
        {
            position += speed;
            Console.Clear();
            Console.WriteLine("Press esc to quit!");
            for(int i = 0; i < position; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("X");
            speed = 0; //Alapból feltesszük, hogy a következő tickben egy helyben marad az X, ha mégse akkor majd a main függvény módosítja a speed-et.
        }
    }
}

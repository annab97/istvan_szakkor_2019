# Tic Tac Toe
A tic tac toe másnéven amőba egy kétszemélyes játék. 3x3-as táblázatban lehet játszani,
az egyik játékos a 'O'-rel van a másik az 'X'-el.
A játékosok egymás után felváltva írnak 'O'-t vagy 'X'-et a táblázatba,
ha valamelyik oszlopban, sorban vagy átlóban összegyűlik 3 egyforma, akkor a játékos nyer.

Feladat egy tic tac toe játék írása.

## 1. részfeladat: Tábla kirajzolása
Először is írj egy olyan programot, ami kirajzolja az alábbi táblát:
```
+---+---+---+
|   |   |   |
+---+---+---+
|   |   |   |
+---+---+---+
|   |   |   |
+---+---+---+
```
## 2. részfeladat: Változók inicializálása
Hozz létre 9 darab változót, amik az egyes cellák értékét tudják tárolni:
```cs
//char típusú változóban egy karaktert tudunk eltárolni
char a1='X'; //bal felső sarok
char b1='O'; //felső középső
char c1='X'; //Jobb felső sarok
char a2='O'; //Bal középső
char b2='X'; //Középső
...
```
## 3. részfeladat: X-ek és O-ok kirajzolása
Módisítsd úgy a táblakirajzolást, hogy a megfelelő helyekre rajzolja ki az ```a1```, ```b1``` stb. változók értékét.
Példa:
```
+---+---+---+
| X | O | X |
+---+---+---+
| O | X | O |
+---+---+---+
| X | O | X |
+---+---+---+
```
## 4. részfeladat: Táblakirajzoló függvény létrehozása
Már így is elég bonyolult a programunk, pedig még csak egy nem módosítható táblánk van.
Mivel a táblakirajzolást megéri kiszervezni egy külön függvénybe, hogy átláthatóbb legyen a kódunk és többször újra fel tudjuk használni.

<table><tr><td>

<details>
  <summary>Függvények</summary>
  
  A függvényeket arra használjuk, hogy a feladatunkat részfeladatokra bontsuk.
  
  Például vegyük ![n alatt a k](http://chart.googleapis.com/chart?cht=tx&chl={n}\choose{k})-t, azaz hogy n elemből hányféleképp tudunk k darabot kiválasztani.
  Ennek képlete az alábbi:
  
  ![](http://chart.googleapis.com/chart?cht=tx&chl={{n}\choose{k}}=\frac{n!}{(n-k)!\cdot%20k!)
  
  Ha létezne egy faktor függvényünk: ![faktor függvény](http://chart.googleapis.com/chart?cht=tx&chl=f_{faktor}(x)=x!), 
  akkor ennek segítségével, így számolhatnánk ki ![n alatt a k](http://chart.googleapis.com/chart?cht=tx&chl={n}\choose{k})-t:
  
  ![](http://chart.googleapis.com/chart?cht=tx&chl={{n}\choose{k}}=\frac{f_{factor}(n)}{f_{factor}(n-k)\cdot%20f_{factor}(k))
  
  Függvényt C# nyelven függvényt az alábbi módon tudunk írni:
  ```cs
  ...
  class Program{
    static int Faktor(int n){ //a Faktor nevű függvényünk bemeneti paraméterként
                              //egy n egész számot kap,
                              //és a függvény "visszatérési értéke" is egész szám,
                              //ezt a függvény neve előtti int jelzi.
                              //A visszatérési érték a függvényünk értéke adott bemeneti változókra,
                              //azaz számításunk eredménye.
      int eredmeny=1;
      for(int i=n;i>=1;i--){
        eredmeny=eredmeny*i;
      }
      return eredmeny; //Visszatérünk az eredmény változóval. Ez a függvényünk által kiszámolt érték
    }

    static void Main(string[] args){
      int n=int.Parse(Console.ReadLine());
      int k=int.Parse(Console.ReadLine());
      int szamlalo=Faktor(n); //a szamlalo változóba belementjük
                              //a függvényünk által kiszámolt értéket. 
      int nevezo=Faktor(n-k)*Faktor(k); //Újra meghívjuk a faktor függvényünket,
                                        //de más lesz a bemeneti paraméter
      Console.WriteLine($"n alatt a k: {szamlalo/nevezo}");
    }
  }
  ...
  ```
  
  A void típusú függvényeknek nincs visszatérési értékik, csinálnak valamit
  (pl. kiírnak valamit a képernyőre, vagy beolvasnak valamit), de nem térnek vissza kiszámolt eredménnyel.
  ```cs
  void kiir(string szoveg){
    Console.WriteLine(szoveg);
  }
  ```
  
  
</details>

</td></tr></table>


A programod az alábbi módon nézzen ki:
```cs
...
class Program {
  //Az ide írt változókat az összes függvény látja.
  //Itt minden változó elé ki kell írni a static kulcsszót.
  static char a1='X';
  static char b1='O';
  static char c1='X';
  static char a2='O';
  static char b2='X';
  static char c2='O';
  static char a3='X';
  static char b3='O';
  static char c3='X';
  
  static void Tablakirajzol() //Ennek a függvénynek nincs bemeneti értéke, és nem is tér vissza semmivel.
  {
    //Ide írd a tábla kirajzolást a1, b1... változókat felhasználva
  }
  
  static void Main(string[] args) //Ha megfigyeljük a Main is egy függvény,
                                  //ami nem tér vissza semmivel 
                                  //és megkapja hogy hogyan índítottuk el a programot az args változóban
  {
    
    //Meghívjuk a Tablakirajzoló függvényt
    Tablakirajzol();
  }
}
...
```

## 5. részfeladat: Egy felhasználós játék
Módosítsd a programot, hogy az 'X' játékos tudjon vele játszani.
Ehhez kezdetben az a1, b1 stb. változók értéke legyen ' ' (szóköz). Írj egy végtelenségig futó ciklust a ciklus pedig ezt ismételje:
  - Kérjen be a felhasználótól melyik sorba, majd melyik oszlopba szeretne X-et rakni
  - A megfelelő a1, b1 ... változó értékét módosítsa 'X'-re
  - Majd hívja meg a táblakirajzoló függvényt
<table><tr><td>
  
<details>
  <summary>While ciklus</summary>
  
  A while ciklus hasonló a for ciklushoz ez is ismételni tudja a kapcsos zárójelek közötti kódot,
  viszont itt egy feltételt adunk meg, és addig ismétli a programunk a kapcsos zárójelek közötti részt amíg a feltétel igaz.
  Ha azt szeretnénk, hogy végtelenségig fusson a ciklus, akkor feltételnek a true-t adjuk meg, azaz a feltétel mindig igaz lesz.
  ```cs
  while(true)
  {
    //amit ide írunk azt a végtelenségig ismétli
  }
  ```
</details>

</td></tr></table>

Tipp: Console.Clear() paranccsal le tudod törölni a konzolt.

## 6. részfeladat: Kétfelhasználós játék
 Először is emeljük ki függvénybe a felhasználó megkérdezését.
 Azaz hozzunk létre egy ```static void KerdezdMeg(char jatekosszimbolus)```  függvényt,
 ami megkérdezi a felhasználótól melyik sorba és oszlopba szeretne rakni. Majd a megfelelő a1, b1 stb. változó értékét a jatekosszimbolumra állítja.
 Azaz ha a függvényt úgy hívjuk meg, hogy KerdezdMeg('X') akkor az X-t tesz a táblára, ha úgy hívjuk meg, hogy KerdezdMeg('O') akkor kört.
 
 Módosítsd úgy a Main függvényedben lévő ciklust, hogy az alábbit csinálja:
  - Ha páratlan kör van akkor hívja meg a KerdezdMeg('X') függvényt
  - Ha páros kör van hívja meg a KerdezdMeg('Y') függvényt
  - Majd rajzolja ki az új táblát
  
 Már egész játszható játékot kaptunk, de még felül tudja írni az egyik játékos a másik által beírt betűt, ezt próbáld meg kijavítani, ha nem megy nyugodtan kérdezz :)
 
 ## 7. részfeladat: Játék vége
 A program jó lenne, ha észrevenné ha valaki nyert.
 Ehhez írj egy olyan függvényt, ami igazzal tér vissza ha vége van a játéknak és hamissal ha nem: ```static bool VegeVane()```
 Majd módosítsd a Main függvényben lévő ciklust, hogy addig ismételje a kirajzolást, amíg nincs vége a játéknak:
 ```cs
 ...
 while(VegeVan()==false)
 {
    ...
 }
  Console.WriteLine("Vége a játéknak");
  ```
  Tipp: mindig az nyerte meg a játékot, aki legutoljára lépet
 

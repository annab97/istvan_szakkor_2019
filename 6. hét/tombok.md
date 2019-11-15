# Tömbök
A tömbök célja, hogy adatok egy sorozatát tudjuk benne tárolni. Például a névsor is egy tömb, amely sorban tartalmazza
az osztályba járó diákok neveit. Egy tömbre jellemző, hogy sorrendbe vannak benne az elemek, ilyen a névsor is,
ott is egyértelmű ki az első diák a névsorban és ki a 15. diák.

C# nyelven a tömbök minden eleme azonos típusú kell legyen. Pl. minden eleme a felsorolásunknak lehet szöveg vagy mind szám,
de nem lehet vegyes. Például tömböt a 30 főből álló osztályunk neveinek elmentésére így tudunk létrehozni:
```cs
string[] nevsor=new string[30]; //ez egy 30 szöveget tartalmazó tömb
```
Egy tömben tárolt elemeket a tömb "megindexelésével érjük el", pl. ha a névsort tároló tömbünkből el szeretnénk érni,
hogy ki az első diák a névsorban azt az alábbi módon tehetjük meg:
```cs
Console.WriteLine($"Első diák: {nevsor[0]}"); //Szögletes zárójelek között írjuk hanyadik diák érdekel minket,
                                            //de 0-tól számozzuk a tömb elemeit,
                                            //azaz a tömb 1. eleme nevsor[0], a második a nevsor[1] és így tovább 
```
A tömb hosszát a ```nevsor.Length``` utasítással kérdezhetjük le.
Azaz példaképp az alábbi kódrészlet kiírja a nevsor tömbünk összes elemét:
```cs
for(int i=0;i<nevsor.Length;i++){
  Console.WriteLine($"A névsor {i+1}. tagja: {nevsor[i]}");
}
```
A tömb kezdetben csak üres szövegeket tartalmaz, akárcsak egy változó miután létrehoztuk. Nekünk kell megadni milyen értéket vegyen fel.
Pl. ha be akarjuk állítani, hogy a névsor első tagja Alma Ancsa legyen akkor azt az alábbi kóddal tehetjük meg:
```cs
nevsor[0]="Alma Ancsa";
```
## 1. feladat
Egy 30 tagú osztály diákjait olvasd be, majd kérdezd meg a felhasználót hanyadik diák érdekli őt
és válaszolj a kérdésre egészen addig, amíg azt nem írja be hogy -1:
```
Osztaly felvetele:
  1. diak neve: Alma Ancsa
  2. diak neve: Biro Balint
  3. diak neve: Cirmos Cecil
  ...
  30. diak neve: Zsiráf Zsombor
  
Hanyadik diak erdekel? 2
A 2. diak Biro Balint
Hanyadik diak erdekel? 3
A 3. diak Cirmos Cecil
Hanyadik diak erdekel? -1
Szia!
```
## 2. feladat
Olvass be egy sorban valahány számot, majd írd ki őket fordított sorrendben:
```
30 20 10 20 40 20 10 40 50 90
90 50 40 10 20 40 20 10 20 30
```
Tipp: van egy olyan függvény hogy String.Split() ennek egy stringet kell adni és azt szóköz mentén szétdarabolja,
majd visszaadja egy string tömbben: 
```cs
string szoveg=Console.ReadLine();
string[] darabolt=szoveg.Split(' ');```

## 3. feladat
Tölts fel egy tömbböt 20 random számmal. Majd írd ki a tömb tartalmatát, végül írd ki, hogy hány 5-tel osztható szám van a tömbben.
Tipp: úgy tudsz generálni ha leírod ezt a sort a main függvényed legelejére: ```Random rnd=new Random();```
Majd bármikor mikor új random számra lenne szükséged meghívod az rnd.Next() függvényt, pl: ```int randomszam=rnd.Next();```

## 4. feladat
Ez egy kicsit bonyolultabb feladat.
Egy Zrinyi versenyeken gyakori feladat az, hogy meg kell számolni hányféleképpen lehet a ZRINYI feliratot kiolvasni az alábbi táblázatból, ha mindig csak lefele és jobbra folytatjuk az olvasást: 
```
ZRINYI
RINYI
INYI
NYI
YI
I
```
Ha nem ismered a feladatot gondolkozz picit a megoldáson, ha nem megy olvasd el a megoldást.
<table><tr><td>

<details>
  <summary>Megoldás</summary>
  A 'Z' szöveget 1 féleképpen tudjuk kiolvasni. Az 'ZR' szöveget kétféleképpen, egyszer ha az első sorban szereplő 'R'-ben fejezzük be az olvasást, 1-szer ha a második sorban szereplő 'R' betűben fejezzük be. Hasonlóan a ZRINYI szót is annyiszor tudjuk kiolvasni, mint ha összeadnánk, hogy az egyes 'I' betűkben hányféleképpen juthatunk el.
 
 Már csak az a kérdés, hogy az egyes 'I' betűkbe hányféleképpen juthatunk el. A legfölső sorban lévő 'I' betűt könnyen láthatjuk, hogy csak 1 féle képpen lehet elérni, ha végig jobbra lépünk. Hasonlóan a legalsó sorban lévő 'I' betűt. A második sorban lévő 'I' betű már bonyolultabb, de ha azt nézzük, hogy ha a 2. sorban lévő 'I' betűbe honnan érkeztünk, akkor csak az 1. és a 2. sorban lévő 'Y' betű jöhet szóba. Innen jöhet az ötlet, hogy töltsünk ki egy táblázatot, hogy egy betűbe hányféleképpen juthatunk el. Ez mindig a tőle balra lévő és a felette lévő cella összege:
  
|       | Z | R | I  | N  | Y | I |
|-------|---|---|----|----|---|---|
| __Z__ | 1 | 1 | 1  | 1  | 1 | 1 |
| __R__ | 1 | 2 | 3  | 4  | 5 |   |
| __I__ | 1 | 3 | 6  | 10 |   |   |
| __N__ | 1 | 4 | 10 |    |   |   |
| __Y__ | 1 | 5 |    |    |   |   |
| __I__ | 1 |   |    |    |   |   |

 Azaz összesen 1+5+10+10+5+1=32 féleképpen tudjuk kiolvasni a ZRINYI szót.
</details>
</td></tr></table>

A programunkban mostmár nem sima tömböt fogunk használni, hanem 2D tömböt. 2D tömbök hasonlóak, mint az eddig tanult 1D tömbök, csak ezekben nem csak egy sornyi adatot, hanem egy teljes táblázatot lehet tárolni.
```cs
int[,] tablazat=new int[3,4]; //Egy 3 sorból és 4 oszlopból álló táblázatot hoz létre.
tablazat[0,0]=5; //Az első sor, első celláját 5-re állítja
Console.WriteLine($"Tablazat elso cellaja: {tablazat[0,3]}"); //Kiírja az első sor utolsó oszlopának értékét a konzolra
for(int i=0;i<3;i++){ //Kiírja az összes mezőt.
  for(int j=0;j<4;j++){
    Console.Writle($"tablazat[i,j]\t");
  }
  Console.WriteLine();
}
```
Feladatod, hogy írj egy programot, ami fogad egy szögevet, kiírajzolja a táblázatot, majd kiírja hányféleképpen olvasható ki a szó.
```
Írj be egy szót!
Alma

Táblázat:
ALMA
LMA
MA
A

Összesen 8 féleképpen olvasható ki az ALMA szó!
```

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
majd visszaadja egy string tömbben: ```string darabolt=Sring.Split(Console.ReadLine());```

## 3. feladat
Tölts fel egy tömbböt 20 random számmal. Majd írd ki a tömb tartalmatát, végül írd ki, hogy hány 5-tel osztható szám van a tömbben.
Tipp: úgy tudsz generálni ha leírod ezt a sort a main függvényed legelejére: ```Random rnd=new Random();```
Majd bármikor mikor új random számra lenne szükséged meghívod az rnd.Next() függvényt, pl: ```int randomszam=rnd.Next();```

## 4. feladat
Ez egy kicsit bonyolultabb feladat.
Egy Zrinyi versenyeken gyakori feladat az, hogy meg kell számolni hányféleképpen lehet a ZRINYI feliratot kiolvasni az alábbi táblázatból: 
```
ZRINYI
RINYI
INYI
NYI
YI
I
```
Ha nem ismered a feladatot gondolkozz picit a megoldáson, ha nem megy olvasd el a megoldást.


# Rendezések
Viszonylag gyakori probléma, hogy rendezni szeretnénk rendezni az adathalmazunkat.
Sőt az egyes elemeket általában több szempont szerint lehet rendezni, például a diákokat lehet névsorba, vagy tornasorba, vagy mondjuk átlag alapján is rendezni.
Az első 4 feladatban, viszont csak egész számok rendezésével foglalkozunk.

A rendezés egy relative lassú feladat, ezért sok algoritmus találtak rá ki az idők folyamán.
Ezekből kettő egyszerűbbet fogunk megnézni ebben a feladatsorban, viszont ezek kicsit lassabbak, mint a legoptimálisabb rendezések.

__Érdekesség__: Ha n elemet akarunk rendezni akkor a leggyorsabb algoritmusok c * n * log_2(n) lépés alatt rendezik a tömböt, ahol a c konstans függ a pontos algoritmustól,
amely algoritmusokat amelyek ebben az anyagban vannak, azok c * n * n lepés alatt rendezik a tömböt, azaz, mondjuk 1024 elemet a leggyorsabb 
algoritmusok 10240 * c lépés alatt rendeznek, viszont az anyagban lévő algoritmusok 1048576 * c lépés alatt.

## Minimum kiválasztásos rendezés
Adja magát a gondolat, hogy úgy rendezzük az elemeket, hogy először válasszuk ki a legkisebb elemet, ez lesz a rendezett tömb legelső eleme,
majd a maradék elemből válasszuk ki megint a legkisebbet, ez lesz a rendezett tömb második eleme, és így tovább amíg végére nem érünk a tömbnek.
[Wikipédián](https://en.wikipedia.org/wiki/Selection_sort) animációt is találsz a rendezésről.
### 1. feladat: Minimum kiválaszátás
A felhasználó 10 számot adhat meg egy sorban szóközzel elválasztva. Olvasd be a számokat, majd keresd meg és írd ki a minimumukat.
### 2. feladat: Rendezés
Hozz létre egy új tömböt, szintúgy 10 elemű tömböt, és ebbe kezd el feltölteni a minimumokat szépen sorba. Ha egy elemet átraktál az új tömbbe,
akkor annak a helyére írj valamit, hogy azt már figyelmen kívül kell hagyni
(pl. `Int32.MaxValue` tárolja a legnagyobb számot ami az int változóba bele lehet írni, így ha ezt használjuk, akkor ezt tuti nem fogja mint minimum kiválasztani).
Ha feltöltöttük az új tömböt, akkor befejezhetjük a rendezést.

### Extra: Helybenhagyásos (in place) rendezés
Ne hozzunk létre új tömböt, csak a meglévő tömböt használjuk. Csak csere műveletekkel mozgassunk adatokat, azaz csak az megengedett, hogy kicseréljünk két elemet a tömbben.

## Buborék rendezés
A buborék rendezés kevésbé intuitív, de még egyszerű algoritmus, és gyors megírni. Ez cseréken alapul, és nem használ segédtömböt (in place rendez).
Úgy működik, hogy először az első kettő elemet vizsgálja, meg, ha rossz a sorrendjük (a második elem kisebb, mint az első), akkor kicseréli azokat.
Majd ugyanezt elvégzi az új 2. elem és a 3. elem között, majd az új 3. elem és a 4. elem között, így tovább.
Végül újrakezdi megint az első és a második elem összehasonlításával és hasonlóan végigmegy a tömbön.
Ezt a tömbön végigmenést ismétli még n-2-ször, azaz összesen n-szer kell végigmenj a tömbön, jelen esetben 10-szer.
Erről is találsz animációt [wikipédián](https://hu.wikipedia.org/wiki/Bubor%C3%A9krendez%C3%A9s).
### 3. feladat: Csere
Hasonlóan olvasd be a 10 számot, de most a függvényeken kívül (de még a class Program-on belül) hozd létre __globális__ változóként a tömböt (ne felejtsd el ilyenkor kell elé a static).
Majd hozz létre egy csere függvényt, ami vár két indexet, és megcseréli az adott indexű elemeket a tömbben.
### 4. feladat Buborék rendezés
A csere függvényt felhasználva, rendezd buborék rendezéssel a tömböt.

### Extra: Optimalizálás
A buborék rendezést lehetne kicsit optimalizálni, hogy feleennyi idő alatt fusson le. Hogyan? (Segít ha megnézed a wikipédiás animációkat).
## Extra: Struktúrák rendezése.
Tegyük fel, hogy van egy `Tort` nevű struktúránk, ahol tört számokat tárolunk még hozzá úgy hogy két egész szám változóban tároljuk külön a
számlálót és a nevezőt.
Az adatokat a felhasználó az alábbi formában tudja megadni:
```
1/2 23/45 -2/7 3/3 6/1 1/50 1/100 3/30 34/3 1/3
```
### 5. feladat
Olvasd be az adatokat a struktúrába, majd feladatunk ezen struktúra elemeit rendezni. De nem akarjuk módosítani a rendező algoritmusainkat nagyon.
Hozz létre egy `static bool osszehasonlit(Tort egyik, Tort masik)` függvényt a Program.cs-be, ami igazzal tér vissza ha egyik<masik ellenkező esetben hamissal.
Módosítsd úgy a rendező algoritmusokat, hogy ezt az összehasonlít függvényt használják mindenhol, így megoldva, hogy rendezzék a törtekből álló tömböt.
### Szuperextra: 6. feladat
Van egy az összehasonlítnál kényelmesebb megoldás, arra, hogy rendezzük  a törteket. Ehhez azt kell megírjuk, hogy a '<' jel működjön törtekre is.
A C# lehetőséget ad, hogy elmagyarázzuk neki az egyes operátorokat (pl. <, >, <=, >=, +, /, - stb.) hogy kell a mi struktúránkon értelmezni.
Ezt úgy tehetjük meg, ha létrehozunk egy `bool operator< (Tort masik)` függvényt a `Tort` struktúránkba, amely fogja a aktuális törtünk adatait és összehasonlítja a `masik` törttel végül igazzal tér vissza ha aktuális<masik.
(Emlékeztetőképpen bármilyen függvényből lekérhetjük az adott tört adatait, hasonlóan, mint a telefonos feladatnál a van-e még pénzünk kérdés).

Ezután a rendezésben nyugodtan használhatjuk a <-et két tetszőleges tört összehasonlítására. (Sajnos ettől még a '>' nem fog működni, azt is külön meg kell írni, hogy működjön).



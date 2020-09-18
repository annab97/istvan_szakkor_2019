# eUtazás

Egyre több országban fordul elő, hogy a közlekedési eszközökön használatos bérleteket és
jegyeket valamilyen elektronikus eszközön (például: chipes kártya) tárolják. Egy nagyváros
ilyen rendszert szeretne bevezetni a helyi közlekedésben, amelyet néhány buszjáraton
tesztelnek. Ezekre a buszokra csak az első ajtónál lehet felszállni, ahol egy ellenőrző eszközhöz
kell érinteni a kártyát, amelynek chipje tartalmazza a jegy vagy bérlet információkat.

A busz ellenőrző eszköze statisztikai és fejlesztési célból rögzíti a felszállók kártyájának
adatait. Az utasadat.txt szóközökkel tagolt állomány egy, a tesztelésben részt vevő busz
végállomástól-végállomásig tartó útjának adatait tartalmazza. 

## Adatok

Az ```utasadat.txt``` állomány legfeljebb 2000 sort tartalmaz és minden sorában 5 adat
szerepel. Ezek:
- a megálló sorszáma (0-29; 0 az indulás helye és a 30 a végállomás, ahol már nem lehet
felszállni.)
- a felszállás dátuma és időpontja (ééééhhnn-óópp formátumban, kötőjellel elválasztva
a dátum és az idő)
- a kártya egyedi azonosítója (hétjegyű szám), egy utas a járaton legfeljebb egyszer utazik
- a jegy vagy bérlet típusa:

Azonosító | Megnevezés
--- | --- 
FEB | Felnőtt bérlet
TAB | Tanulóbérlet (kedvezményes)
NYB | Nyugdíjas bérlet (kedvezményes)
NYP | 65 év feletti bérlet (ingyenes)
RVS | Rokkant, vak, siket vagy kísérő bérlet (ingyenes)
GYK | Iskolakezdés előtti gyerekbérlet (ingyenes)
JGY | Jegy

- a bérlet érvényességi ideje, vagy a felhasználható jegyek száma. A bérlet esetén a dátum
ééééhhnn formátumban szerepel, jegy esetén egy 0-10 közötti szám szerepel.


Például:
```
0 20190326-0700 6572582 RVS 20210101
0 20190326-0700 8808290 JGY 7
0 20190326-0700 1680423 TAB 20190420
12 20190326-0716 3134404 FEB 20190301
12 20190326-0716 9529716 JGY 0 
```

A fenti példában szereplő adatoknál látható, hogy az induló állomáson (0. állomás)
2019. 03. 26-án 7:00-kor a 1680423 kártyaazonosítójú utas tanulóbérlettel szállt fel, amely
2019. 04. 20-ig érvényes. A 12. állomáson 2019. 03. 26-án 7:16-kor a 9529716
kártyaazonosítójú utas jeggyel szállt volna fel, de már elhasználta az összes jegyét (0). 

## 1. Feladat
Olvasd be és tárolja el az utasadat.txt fájl tartalmát! 

## 2. Feladat
Add meg, hogy hány utas szeretett volna felszállni a buszra!

## 3. Feladat
A közlekedési társaság szeretné, ha a járművőn csak az érvényes jeggyel vagy bérlettel
rendelkezők utaznának. Ezért a jegyeket és bérleteket a buszvezető a felszálláskor ellenőrzi.
(A bérlet még érvényes a lejárat napján.) Add meg, hogy hány esetben kellett
a buszvezetőnek elutasítania az utas felszállását, mert lejárt a bérlete vagy már nem volt
jegye!

## 4. Feladat
Add meg, hogy melyik megállóban próbált meg felszállni a legtöbb utas! (Több azonos
érték esetén a legkisebb sorszámút adja meg!)

## 5. Feladat
A közlekedési társaságnak kimutatást kell készítenie, hogy hányszor utaztak valamilyen
kedvezménnyel a járművön. Határozd meg, hogy hány kedvezményes és hány ingyenes
utazó szállt fel a buszra! (Csak az érvényes bérlettel rendelkező szállhatott fel a buszra!) 

## 6. Feladat
Az alábbi függvényt másold be a programodba. Az algoritmus
a paraméterként megadott két dátumhoz (év, hónap, nap) megadja a közöttük eltelt napok
számát!
```cs
static int napokszama(int e1,int h1, int n1, int e2, int h2, int n2)
{
  h1 = (h1 + 9) % 12;
  e1 = e1 - h1 / 10;
  int d1 = 365*e1 + e1 / 4 - e1 / 100 + e1 / 400 + (h1*306 + 5) / 10 + n1 - 1;
  h2 = (h2 + 9) % 12;
  e2 = e2 - h2 / 10;
  int d2 = 365*e2 + e2 / 4 - e2 / 100 + e2 / 400 + (h2*306 + 5) / 10 + n2 - 1;
  return d2-d1;
} 
```

## 7. Feladat
A közlekedési társaság azoknak az utasoknak, akiknek még érvényes, de 3 napon belül lejár
a bérlete, figyelmeztetést szeretne küldeni e-mailben. (Például, ha a felszállás időpontja
2019. február 5., és a bérlet érvényessége 2019. február 8., akkor már kap az utas levelet,
ha 2019. február 9. az érvényessége, akkor még nem kap levelet.) Válogasd ki és írd a
```figyelmeztetes.txt``` állományba ezen utasok kártyaazonosítóját és a bérlet
érvényességi idejét (éééé-hh-nn formátumban) szóközzel elválasztva! 

__Tipp:__ Felhasználhatod a 6. feladatban szereplő függvényt.

# Robot mozgása

A célunk, hogy a robot ne csak jobbra-balra tudjon mozogni, hanem ugrani is tudjon.

## DoubleBuffering

A kirajzolás jelenleg szakadozik. Ennek oka, hogy mikor újra rajzoljuk a képet, a felhasználó látja a félkész képet is, amin még nincs rajta minden objektum. Hogy ez a hatás megszűnjön
be kell kapcsolunk a DoubleBufferinget. A DoubleBuffering azt csinálja, hogy két képet kezel. Az egyik kép amit a felhasználó éppen lát, az előző képkocka, amit kirendereltünk. A másik képre
meg rajzolhatunk. És mikor befejeztük a rajzot, csak kicseréli a két képkockát. És amire eddig rajzoltunk azt látja mostantól a felhasználó, a másikat meg kitörli és odaadja újra rajzolásra.
Ezzel a megoldással sosem lát a felhasználó félkész rajzot, így csökken a villódzás.

DoubleBuffering bekapcsolása:

```cs
public Form1(){
  InitializeComponents(); //ez eddig is itt volt, hagyjuk is itt
  DoubleBuffered = true; // Bekapcsoljuk a DoubleBuffering-et
}
```

## Ugrás
Ehhez először is az ugrás leírásához a fizika órán tanultakra lesz szükséged. Az ugrást legjobban ferde hajításként modellezhetjük. Mikor a robot elugrik akkor adj neki valamekkora függőleges és vízszintes sebességet is.
Aztán a függőleges sebesség folyamatosan csökkenjen a nehézségi gyorsulás miatt, a vízszintes komponens maradhat változatlan. Ha a robot eléri a földet akkor állítsd mind a vízszintes, mind a függőleges sebességet nullára.

Először írd fel a megfelelő képleteket, amik segítségével ki tudjuk számolni a robot helyzetét az idő múlásával.

Végül programozd is le a képleteket. Figyelj arra, hogy a pontos számítás miatt megéri double-el számolni, és csak a végén visszaváltani egész számra az eredményt.

## Animáció

A robot mostmár tud menni és ugorni is, viszont sokkal szebb lenne, ha futás közben a lábait is mozgatná. Játékprogramozás során ezt hívjuk karakteranimációnak. Karakteranimáció során nagyon gyorsan váltogatjuk a megjelenítendő képet, hogy az úgy tűnjön a karakter folytonosan mozog.

Ehhez a képek között találsz több futással és több ugrással kapcsolatos képet, ha ezeket megfelelő sorrendben cserélgeted, akkor úgy fog tűnni, hogy a karakter mozgatja a lábait.

Másold be a képeket a tanult módon a projektbe. Majd minden tickben cseréld le az aktuálisan kirajzolandó képet (használj hozzá változókat).


 

# Struktúrák II

A struktúrákban, ahogy az a korábbi anyagban szerepelt több összefüggő adatot tudunk tárolni. Például egy ember, kutya, telefon adatait.
A struktúrákban nem csak adatokat tárolhatunk, hanem akár az adott objektumhoz szorosan kötődő függvényeket is írhatunk.
Pl. a telefon struktúránk tárolja a következő adatokat:
  - A telefon számunk (szöveg típusú)
  - Az egyenlegünk (egész szám)
  - Ismerőseink telefonszámai (Partner struktúrából álló tömb)
A partner struktúránk nézzen ki az alábbi módon:
  - A partner neve (szöveg)
  - A partner telefonszáma (szöveg)

## 1. Feladat
Hozd létre a korábbi anyagban leírt módon a telefon struktúrát. És a main függvénybe hozz létre egy telefont, feltöltve azt teszt adatokkal.

__Tipp__: Mikor tömböt töltünk fel adattal, azt így tehetjük:
```cs
...
telefon.partnerek=new Partner[4];
Partner partner1=new Partner();
partner1.nev="Kata";
partner1.telefonszam="+36201234567";
telefon.partnerek[0]=partner1;
```
## Tagfüggények
Egy struktúrában lehetnek úgynevezett tagfüggvények. Ezen tagfüggvények elérik a struktúrában szereplő adatokat.
Például szeretnénk a múltkori kutya struktúránkba egy tagfüggvényt írni,ami meghatározza a kutya korát.
```cs
public struct Kutya{
  public string Nev;
  public DateTime született;
  ...
  public int Kor() //Ez a függvény visszaadja idén hány éves lett/lesz a kutya.
                   //A public kulcsszó mindig kell a függvény elé, a static viszont itt nem kell, sőt hibás is lesz ha használjuk.
  {
    int szuletesi_ev=született.Year;
    int jelenlegi_ev=DateTime.Now.Year; //DateTime.Now a jelenlegi dátumot tartalmazza
    return jelenlegi_ev-szuletesi_ev
  }
}
```
Ezt a Main függvényben az alábbi módon tudjuk használni:
```cs
Kutya bodri=new Kutya();
//beállítjuk bodri nevét, születési idejét
Console.WriteLine($"{bodri.Nev} kora {bodri.Kor()}");
```
Mindig amelyik kutya objektumunkon hívjuk meg a Kor függvényt, annak az adatait fogja használni. Pl. Ha hasonlóan létrehozzuk Buksi nevű kutyánkat,
akkor a buksi.Kor() függvény buksi születési idejével fog számolni. 

## 2. Feladat 
Hozzunk létre egy ```bool VanEMegPenz()``` függvényt, ami visszaadja van-e még pénz az egyenlegünkön. Majd teszteljük a függvényünket.
Hívjuk meg a VanEMegPenz() függvényt egy olyan telefonon amin még van pénz és egy olyanon ahol már nincs.

## 3. Feladat
Hozzunk létre egy ```bool PartnerE(string partner_neve)``` függvényt, ami visszaadja, hogy egy adott nevű partner szerepel-e a partnerek között.
Majd, tesztelésként ezt is hívjuk meg olyan telefonon, ahol szerepel az adott partner és olyanon amiben nem szerepel.

## 4. Feladat
Olyan telefonszolgáltatónál vannak telefonjaink regisztrálva, aki nem percdíjat számláz, hanem minden hívás ugyanannyiba (50 ft) kerül.
Hozz létre egy void Hívás(string partner_neve) függvényt. Ez nézze meg, hogy a partner szerepel-e a partnerek között, van-e pénz az egyenlegünkön
a híváshoz, ha nem szerepel a partner, vagy nincs pénz a kártyánkon akkor hibaüzenetet ír ki, különben pedig kiírja, hogy kit milyen számon hív.
pl. "Kata (+36201234567) hívása"

__Tipp__: A tagfüggvényeket meg tudják egymást hívni.

## Kontruktor
Van egy különleges függvénye minden struktúrának, ez a kontruktor. Ennek neve mindig a struktúra nevével egyezik meg, és nincs visszatérési értéke.
Ez a függvény mindig akkor hívódik meg ha új objektumot hozunk létre.
Pl. partner esetén:
```cs
public struct Partner{
  public string Nev;
  public string Telefonszam;
  public Partner(string nev, string telefonszam) //Ez a kontruktor, mert megegyezik a neve a struktúránk nevével
                                                 //és nincs visszatérési értéke
  {
    Nev=nev; //A paraméterként kapott változókkal inicializálhatjuk a tulajdonságokat.
    Telefonszam=telefonszam; 
  }
}
```
Így változik ekkor a Partner objektum létrehozása, már nem kell külön beállítani a mezők értékeit:
```cs
Partner kata=new Partner("Kata","+36201234567");
```

## 5. Feladat
Másold be a fenti példából a konstruktort a saját partner struktúrádba. És módosítsd a partnerek létrehozását, hogy az új kontruktorral működjön.


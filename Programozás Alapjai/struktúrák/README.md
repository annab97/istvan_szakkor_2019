# Struktúrák
## Struktúra
Programozás során, ha több összetartozó adatok akarunk eltárolni, akkor struktúrát, vagy osztályt hozunk létre.
Először ismerkedjünk meg a struktúrákkal. Tegyük fel, hogy egy élelmiszer boltot üzemeltetünk, ahol sokféle élelmiszer található.
Egy programban akarjuk tárolni az összes élelmiszert, amelyet a vásárlók megvehetnek az üzletből.

Minden élelmiszerről többféle adatot szeretnénk eltárolni:
 - Élelmiszer neve (pl. kenyér, tej, csokoládé)
 - Ár
 - Lejárati dátum
 - Hány fokon kell tárolni
 
Ezek mind fontosak, hogy mindig friss, jó állapotban lévő élelmiszereket tudjunk árulni.

Például a boltunk az alábbi termékeket tartalmazza jelenleg:

| Név | Kenyér | Kenyér | Tej | Fagylalt |
|-----|--------|--------|-----|----------|
| Ár (Ft) | 300 | 300 | 200 | 500 |
| Lejárati dátum | 2020.04.05. | 2020. 04. 01. | 2020. 04. 20. | 2020. 08. 20. |
| Tárolási hőmérséklet (°C) | 20 | 20 | 3 | -5 |

## Strutúra C#-ban
Mikor egy összetett objektumról akarunk többféle adatot eltárolni, a fenti példában az élelmiszer, akkor először is meg kell mondjuk, 
hogy ennek az objektumnak milyen tulajdonságai vannak:
```cs
//class Program-on kívül:
public struct Elelmiszer{ 
  public string nev; //public azt jelenti, hogy kívülről elérhető.
                     //Azaz bárki kiolvashatja a változó értékét és módosíthatja azt.
  public int ar;
  public DateTime lejarati_datum; //A DateTime típus dátumokat tárol (de akár ezredmásodpercre pontosan)
  public double tarolasi_homerseklet; //Lehet, hogy 2.5 fokon kell tárolni.
}
```

Ezek után már létrehozhatunk élelmiszer típusú változókat a programunkban, amelyek egyben tudják egy élelmiszer adatait tárolni:
```cs
//Main függvényen belül:
Elelmiszer kenyer1=new Elelmiszer(); //Létrehozunk egy élelmiszert tároló változót.
                                     //Kezdetben az össszes tulajdonsága alapértéken van (üres szöveg vagy 0) 
                                     //Így kézzel kell beállítsuk a tulajdonságait
kenyer1.nev="kenyér"; //A pont után elérjük azokat a tulajdonságait az élelmiszernek amiket a létrehozáskor megadtunk.
kenyer1.ar=300;
kenyer1.lejarati_datum=new DateTime(2020,04,05); //A dátum is egy struct csak már korábban megírták így azt is new-al hozzuk létre. 
                                                 //Kerek zárójelek között beállíthatjuk, az év, hónap, nap értékeket.
kenyer1.tarolasi_homerseklet=20.0;


Elelmiszer kenyer2=new Elelmiszer(); //Ezzel egy újabb élelmiszert tároló változót hozunk létre
                                     //Ennek is alapértéken vannak a tulajdonságai.
kenyer2.nev="kenyér";
...                                   
```
Akár olyan tömböt is létre tudunk hozni ami élelmiszereket tartalmaz:
```cs
Elelmiszer[] elelmiszerek=new Elelmiszer[4];
```
Természetesen a tulajdonságok ilyenkor is alapértékre vannak állítva, és azokat nekünk kell inicializálnunk a megfelelő értékekre.


## Feladatok

### 1.feladat
Hozz létre egy struktúrák amiben kutyák adatait lehet tárolni.
Egy kutyáról tárold el:
  - A nevét (szöveg)
  - Fajtáját (szöveg)
  - Születési dátumát (dátum)
  - Súlyát (tört szám)
  - Gazdája nevét (szöveg)

Ezek után hozd létre a programban Buksi kutyát aki tacskó, 2017. január 1-én született, 10 kg és Dávid a gazdája. Majd írd ki az adatait a konzolra.

## 2. Feladat

Hozz létre egy Kiír nevű függvényt, ami bekér egy kutyát és kiírja az adatait. Alakítsd át úgy a programod, hogy ezt a függvényt használja buksi adatainak a kiírására.

## 3. Feladat

Hozz létre Beolvas nevű függvényt, ami maximum 10 az ebek.txt-ben található kutya adatát beolvassa egy kutya tömbbe majd visszatér ezzel a tömbbel.

## 4. Feladat
Alakítsd át úgy a programod, hogy hívja meg először a beolvas függvényt, majd az összes kutya adatát írja ki a Kiír függvény segítségével.


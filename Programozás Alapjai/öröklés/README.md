# Öröklés

Előfordul, hogy annyira sok osztályunk van, hogy csoportosítani, hierarchiába szeretnénk őket rendezni, a közös tulajdonságokat kiemelni és csak egyszer megvalósítani.
Egy nagyobb programozási projekt akár több száz osztályt is tartalmazhat, ezek megfelelő csoportosítás nélkül kezelhetetlenek lehetnek.

Az öröklés a fenti problémára ad megoldást, létrehozhatunk a közös tulajdonságok tárolására ősosztályokat, amiből leszármazhatnak a közös tulajdonsággal rendelező osztályaink.

Például szeretnénk e-naplót írni. Az e-naplóba diákok és tanárok illetve szülők léphetnek be. Minden diáknak tanárnak, szülőnek saját felhasználóneve és jelszava van. De míg a tanárok
beírhatnak osztályzatokat a diákoknak, a diákok csak megtekinthetik a saját osztályzataikat, a szülők meg csak a gyerekeik osztályzatait tudják megtekinteni.

Legyen a tanároknak, diákoknak, szülőknek egy közös ős osztálya a felhasználó. A felhasználó rendelkezzen felhasználónévvel és jelszóval, de ne rendelkezzen jegybeírás funkcióval, hiszen a szülők, diákok nem tudnak jegyeb beírni.

Az alábbi ábra összefoglalja, a létrehozandó osztályainkkat, és azok tulajdonságait:

![osztálydiagram](orokles.svg)

Az ábra egy úgynevezett osztálydiagram. Ahol a dobozok az egyes osztályokat jelölik. A dobozt vízszintes vonalak három részre bontják. Az első részben az osztály neve található. A második részben az osztály tagváltozói. A harmadik részben meg a tagfüggvényei. Azaz például a felhasználónak van 3 string típusú változója: teljes név, felhasználónév és jelszó. A diáknak csak egy tagfüggvénye van: osztályzatok_listázása(). Az üres fejű nyíl az öröklést jelöli. A nyíl az ősosztály felé mutat a leszármazottól. Az ábrán mindhárom a diák a szülő és a tanár osztály is a felhasználóból származik le.

Egyenlőre feltételezzük, hogy minden szülőnek pontosan egy gyereke jár az iskolába.

## 1. feladat

Hozd létre a három osztály, hozd létre a tagváltozókat, a tagfüggvényeket, de a tagfüggvények belsejét még ne írd meg, csak hozd létre.

Segítségként a diák osztálynak így kéne kinéznie:

```cs
class Diak: Felhasznalo{ // kettőspont után tudjuk megadni melyik osztályból származik le az osztályunk (ha van ilyen).
  void OsztalyzatokListazasa(){
    //még nem csinál semmit.
  }
}
```

## 2. feladat

Hozz létre a felhasználó osztályban `JelszoModositasa(string regi_jelszo, string uj_jelszo)` függvényt. A függvény módosítsa a felhasználó jelszavát az új jelszóra, ha a régi jelszó megegyezik a `jelszo` tagváltozóban tárolt változóval.

Ez a függvény innentől minden felhasználónál meg fog jelenni, azaz a tanároknál, a diákoknál és a szülőknél is. Teszteléshez hozz létre a Main függvényben egy diákot "Nagy Károly" névvel, legyen a felhasználóneve "nagykarcsi01" jelszava meg "jelszo123" legyen. Majd a hívd meg a JelszoModositasa() függvényt.

## 3. feladat

Hozz létre a Felhasznalo osztályban konstruktort. A konstruktor a teljes nevet, a felhasználó nevet, és a jelszót fogadja bemeneti paraméterként.

A kontruktor létrehozása után hibát jelez a másik három osztályban a visual studio. Mi lehet a hiba oka? Próbáld megindokolni.

Javítsd is ki a hibát. Segítséget [itt](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base#example-1) találsz. A szülő konstrultora fogadjon egy diákot, is, akinek a szülője.

Módosítsd a teszt diák létrehozását, hogy mostmár a konstruktort használd hozzá. Teszteld is le a munkád!

## 4. feladat

Az osztályzatokat, amiket a tanár beír valahogy el is kellene tárolni. Ehhez hozz létre az `Osztályzat` osztályt. Az osztálydiagram segít abban, hogy hogy nézzen ki ez az osztály:

![osztály diagram](orokles2.svg)

Az ábrán látható módon egészítsd ki a tanár és a diák osztályt is. Minden tanárnál eltároljuk, hogy milyen tárgyat tanít. (Feltesszük, hogy minden tanár pontosan egy tantárgyat tanít.) Illetve a diáknál eltároljuk, hogy milyen osztályzatokat szerzet. Módosítsd a konstruktorokat is a változásoknak megfelelően!

## 5. feladat

Vedd fel az `Osztály` nevű osztályt. Az osztálynak legyen neve (mondjuk "9.a"), tartalmazzon egy listát az osztályban található diákokból, a tanárok meg tároljanak egy listát, arról melyik osztályokban tanítanak.

## 6. feladat

Írd meg az `Tanár.Osztályzás(string osztalynev, string diaknev, int osztalyzat)` függvényt. A függvény a bemeneti paraméterek alapján határozza meg, kinek kell az osztályzatot adni, majd, adja hozzá az osztályzatot a diák osztályzataihoz. (Felteheted, hogy egy osztályban nincs két azonos nevű tanuló).

## 7. feladat

Írd meg a `Diák.OsztalyzatokListazasa` függvényt. Az alábbi formátumban írja ki a konzolra a diák osztályzatait:

```
diák: Nagy Károly
-----------------
Matematika: 5 1 1 2 5 4
  átlag: 3.0
Fizika: 2 3
  átlag: 2.5
Magyar: 5 5 5 5 5 5 5 3 5
  átlag: 4.8
Testnevelés: 2 5 5 3 2
  átlag: 3.4
```

## 8. feladat

Írd meg a `Szülő.OsztályzatokListazasa` függvényt, mai kiírja a szülő gyerekének eredményeit. A függvény használja fel a 7. feladatban megírt függvényt!

___Extra feladat___: Módosítsd úgy a szülő osztályt, hogy több gyerekei is lehessen a szülőnek, mindegyik gyerekének írja ki az osztályzatok listázása az eredményét.

## 9. feladat

A Main függvényben hozz létre egy felhasználókból álló listát. Itt fogjuk eltárolni az e-napló felhasználóit. Töltsd is fel tesztfelhasználókkal, akik vagy tanárok, vagy diákok vagy szülők kell legyenek.

Ha létrehozunk egy leszármazott osztályból objektumot, akkor arra nézhetünk úgyis, mintha az ősosztályból hoztunk volna létre egy példányt. Ekkor persze csak az ősosztály tagváltozóit, függvényeit érjük el rajta.

```cs
Felhasznalo felhasznalo1=new Diak("Nagy károly","nagykarcsi01","jelszo123"); //itt egy diákot hozunk létre, de csak úgy tekintünk rá, mintha felhasználó lenne.
Felhasznalo felhasznalo2=new Tanar("Kovács Ede","ede7210","edeakiraly"); //itt egy tanárt hozunk létre, de minket csak az érdekel, hogy ő egy felhasználó

```

Ha olyan listát vagy tömböt készítünk, amiben sok különböző leszármazott elem van, de a lista vagy tömb típusa az ősosztály, akkor azt __heterogén kollekciónak__ hívjuk. 

## 10. feladat

Hozz létre a felhasználó osztályban egy `MenutMutasd()` függvényt az alábbi módon:

```cs
public absctact class Felhasznalo { //Az osztályt is állítsd át, hogy abstract legyen.
   //...
  public abstract void MenutMutasd();

  //...
}
```

Az abstract osztály azt jelenti, hogy ebből az osztályból nem lehet példányokat létrehozni. Azaz felhasználót nem lehet létrehozni, csak a felhasználó osztály leszármazottait, azaz diákokat, tanárokat, szülőket. Az abstract függvény azt jelenti, hogy igérjük, hogy minden felhasználónak lesz majd MenutMutasd függvénye, de azt nem a felhasználó osztályban írjuk meg, hanem az egyes leszármazottakban. Így mikor mondjuk a 9. feladatban létrehozott `felhasznalo1` objektumnak hívjuk meg a `MenuMtutasd()` függvényét, akkor a Diák osztályban megírt függvény fog lefutni. Ha a`felhasznalo2`-ben hívjuk meg ezt, akkor a Tanár osztályban megírt működés fog lefutni.

Figyeld meg, hogy itt pontosvessző szerepel a függvény után, ezzel is jelezzük, hogy ezt a függvényt még nem írjuk meg, csak igérjük, hogy lesz ilyen függvény.

## 11. feladat

Hozz létre a diák, tanár, szülő osztályokban is `MenutMutasd()` függvényeket. Itt fogjuk megmondani, hogy az egyes leszármazottak esetén hogy működjön, a menü megjelenítése. A függvények elé itt az `override` kulcsszót kell írjuk, mert felül akarjuk írni, a Felhasználóban lévő üres működést, a menü kiírásával.

Minden `MenutMutasd` függvény jelenítsen meg egy menüt a konzolon az alábbi módon: 

- Diák:
```
Lehetséges műveletek:
  1. Osztályzatok listázása
  2. Jelszómódosítás
  3. Kilépés
Melyik műveletet szeretnéd elvégezni?
```

- Tanár:

```
Lehetséges műveletek:
  1. Jegybeírás
  2. Jelszómódosítás
  3. Kilépés
Melyik műveletet szeretnéd elvégezni?
```

- Szülő:

```
Lehetséges műveletek:
  1. Osztályzatok listázása
  2. Jelszómódosítás
  3. Kilépés
Melyik műveletet szeretnéd elvégezni?
```

Teszteld is a `MenutMutasd` függvényt.

## 12. feladat

Folytasd a MenutMutasd függvényt. A felhasználó a sorszám megadásával választhassa ki meg melyik műveletet szeretné elvégezni. És kérdezd meg még, ha kell a művelethez plussz adat (pl. jelszómódosítás esetén régi és új jelszó), majd hívd meg a megfelelő függvényt. Végül jelenítsd meg újra a menüt, hogy új műveletet is el tudjon végezni a felhasználó. Addig végezhet műveleteket a felhasználó, amíg a kilépés műveletet nem választja.

## 13. feladat

Az utolsó feladat a bejelentkezés lesz. A `Main` függvényben kérd be a felhasználó felhasználónevét és jelszavát. Keresd ki a tesztfelhasználók közül a megfelelő felhasználót. És hívd meg a felhasználó MenutMutasd függvényét. Ha kilép a felhasználó, újra tudjon belépni más felhasználóként is, a felhasználónév jelszó megadásával. Ha üres felhasználónevet ad meg, akkor lépj ki a programból.

Teszteld a program működését!


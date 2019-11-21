# Tictactoe játék továbbfejlesztése

Most, hogy megismertük a tömböket itt az idő, hogy komplexebb alkalmazást is építsünk a segítségével.

Ha úgy érzed bonyolodna a program nyugodtan szervezd ki függvényekbe az egyes funkciókat.

## 1. feladat

Módosítsd úgy a megírt tictactoe játék kódját, hogy 2D tömbben tárolja a mezőket. Azaz hozz létre egy 3x3-as tömbböt, az ```a1, a2, ...```
változók helyére.

Módosítsd úgy a kódod, hogy ahol lehet ott a sok ismétlődő ```if```-et cseréld le tömb bejárásokra.

Pl. az alábbi bejárással tudjuk kezdetben a tömb összes mezőjét ' '-re állítani:
```cs
for(int i=0;i<3;i++){
  for(int j=0;j<3;j++){
    tabla[i][j]=' ';
  }
}
```

Tipp: ha hanyadik az abc-ben akkor azt így tehetjük meg: 
```cs
char karakter='c';
int hanyadik=karakter-'a'; //2 lesz az értéke (0-tól számozza), ha nagybetűkkel dolgozunk akkor a 'A'-t kell kivonni
```

Magyarázat: A program a karaktereket is számként tárolja el. Minden karakternek megvan a saját úgynevezett ASCII kódja, [ebben a táblázatban](https://en.wikipedia.org/wiki/File:ASCII-Table.svg) láthatod, hogy mely karakternek mennyi a kódja. Pl. a kis a betű kódja 97. Mikor C#-ban kivonunk két karaktert egymásból akkor a program automatikusan a karakter kódjaikat vonja ki egymásból. Így ha megnézzük a 'c' karakterkódja 99 és így 'c'-'a'=99-97=2.

## 2. feladat
Ebben a feladatban megismerjük hogyan lehet fájlba írni, fájlból olvasni. Cél, létrehozni eg toplistát,
ahol elmentjük, hogy ki eddig hány játékot nyert.

Azaz a program a játék elején kérje be a nevünket, majd a futása végén a toplista.txt fájlban módosítsa abban a sorban,
ahol a mi nevünk van a megnyert játszmák számát. Ha még nem szereplünk a fájlban írja be a nevünkkel, és az elért pontszámmal.

A toplista.txt ilyen formátumú legyen (a nevet a pontszámtól egy tabulátor válassza el!):
```
Alma  5
Béla  10
Cecil 1
Dani  0
...
```

### 2.1 részfeladat

Hozz létre a toplista.txt fájlt. Ezt a <projekt_könytár>/<project_neve>/bin/Debug mappában hozzuk létre.
Itt már látnunk kellene többek között egy <projekt_neve>.exe fájlt, ez az elkészült programunk,
ha kétszer kattintunk rá akkor el tudjuk indítani.
Mikor a zöld play gombot megnyomjuk visual studioban akkor az először létrehozza ezt az exe fájlt majd futtatja azt.
Ezért fontos, hogy a txt-t is ide hozzuk létre, hogy az exe megtalálja azt.

### 2.2 részfeladat

Módosítsd úgy a programod, hogy a játék elején kérje be a két játékos nevét és ezt mentse el változókba.

### 2.3 részfeladat

A program végén mentsük ki a fájlba a az elért eredményt:

A program legelején látunk sok 'using' kezdetű sort, ezek azt mondják meg, hogy milyen modulokat használ fel a programunk.
A System modul tartalmazza például a tömböket, szövegeket, random számokat, sok mindent.
Fájl kezeléshez a System.IO modulra lesz szükségünk, így importáljuk ezt a modult a többi importálás alatt.

```cs
using System.IO;
```

A játékunk fő ciklusa után olvassuk be a toplista.txt fájl tartalmát:

```cs
string[] nevek=new string[1000]; //Egy tömbben eltároljuk, a beolvasott neveket
                                 //Feltesszük, hogy 1000 főnél több nem szerepel a fájlban
int[] gyozelmekeddig=new int[1000]; //Hasonlóan az minden játékosra az eddigi győzelmeinek a száma.

int index=0; //Hanyadik sort olvassuk
StreamReader sr=new StreamReader("toplista.txt"); //a streamreader olyan mint a konzol, csak fájlból tudunk vele olvasni.
while(!sr.EndOfStream){ //amíg nincs vége a fájlnak
  string sor=sr.ReadLine();
  string[] darabolt=sor.Split('\t'); //daraboljuk szét a split függvénnyel tabulátorok mentés a sort
  string nev=darabolt[0]; //Az első legyen a név
  int gyozelemeddig=int.Parse(darabolt[1]); //A második meg a fájlban szereplő győzelmek száma
  nevek[index]=nev;
  gyozelmekeddig[index]=gyozelemeddig;
  index++;
}
int jatekosszam=index; //Hány játékos volt a fájlban
sr.Close(); //Bezárjuk a megnyitott fájlt
```
Majd módosítsuk azon játékosaink győzelmeinek számát, a mostani győzelmeikkel. Ha kell vegyünk fel új játékosokat.
És módosítsuk ennek megfelelően a ```jatekosszam``` változó értékét.

Végül írjuk ki a fájlba a módosított adatot:

```cs
StreamWriter sw=new StreamWriter("toplista.txt"); //Most írásra nyitjuk meg a fájlt
for(int i=0;i<jatekosszam;i++){ //Kiírjuk az összes beolvasott játékost és győzelmeinek számát tabulátorral elválasztva
  sw.WriteLine($"{nevek[i]}\t{gyozelmekeddig[i]}");
}
sw.Close(); //Bezárjuk a fájlt
```

## 3. feladat
Jelenítsük meg, hogy az aktuális játékosoknak eddig összesen mennyi győzelme volt.

## 4. feladat
 Írjuk ki ha új rekordot ért el a játékosunk. (Azaz több győzelme van, mint eddig bárkinek)

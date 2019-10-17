# Feladatok a 4. hétre
Itt feladatokat több szinten találsz, ha teljesen kezdő vagy akkor a könnyű feladatokkal foglalkozz, ha már programoztál korábban, és ismerted korábbról a tömböket, függvényeket, akkor a nehéz feladatok közül válassz.

[Könnyű feladatok](#konnyu)

[Nehéz feladatok](#nehez)

<a name="konnyu"/>

## Könnyű feladatok
1. Rajzolj n hosszú szaggatot vonalat!
```
Szaggatott vonal hossza: 5
- - - - -
```

2. Rajzolj ki téglalapot:
```
Téglalap szélessége: 4
Téglalap magassága: 3
+----+
|    |
|    |
|    |
+----+
```
3. Rajzolj ki háromszöget:
```
Háromszög mérete: 3
+
|\
| \
|  \
+---+
```
4. Rajzolj sudoku táblát:
```
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
|   |   |   |   |   |   |   |   |   |
+---+---+---+---+---+---+---+---+---+
```
<a name="nehez"/>

## Nehéz feladatok
1. Számold ki n alatt a k-t az alábbi képlettel:
(n, k)=(n*(n-1)*(n-2)*...*(n-k))/(k*(k-1)*(k-2)*...*1)
2. Számold ki n alatt a k-t használva úgy, hogy először írgy egy faktorizáló függvényt, majd az alábbi képlettel számolsz:
(n, k)=faktor(n)/(faktor(k)*faktor(n-k))

Emlékeztető:
```cs
//Ez egy C# függvény, függvényeket a class Program()-on belülre tudunk létrehozni
//Egyenlőre minden függvény elé odaírjuk, hogy static
//Először a visszatérsi értéket írjuk le, itt int, ha nincs visszatérési érték akkor void-ot kell írni.
//Majd a függvény nevét, itt fnc
//Végül zárójelek között felsoroljuk a paramétereit
static int fnc(int a)
{
 //Ez a függvény mindig az 5 értékkel tér vissza
 return 5;
}
```

3. Számold ki n alatt a k-t felhasználva a pascal háromszöget. Hozz létre egy tömböt amiben tárolod a pascal háromszöget.
[Pascal háromszög](https://hu.wikipedia.org/wiki/Pascal-h%C3%A1romsz%C3%B6g)

Emlékeztető:
```cs
//Ez egy cs tömb, ami 5 hosszú és egész számokat tartalmaz
int[] tomb1=new int[5];
//Ez egy két dimenziós tömb, ami tört számokat tartalmaz
double[,] tomb2=new double[5,5];
//Kezdetben a tömb összes eleme 0 lesz.
tomb1[2]=6; //Értékadás 1D tömbnél
tomb2[1,2]=4; //Értékadás 2D tömbnél
```

4. Számold ki n alatt a k-t rekurzió segítségével, használd ki, hogy:
(n,k)=(n-1,k-1)+(n-1,k)




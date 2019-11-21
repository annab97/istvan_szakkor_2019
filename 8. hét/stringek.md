# Szövegkezelés C#-ban

C#-ban a string hasonlóan viselkedik mint a tömbök. Length-vel érhető el a string hossza, és szögleteszárójellel az egyes karakterek.
Hasonlóan végig mehetünk egy forciklussal egy string-en, mint egy tömbön.

```cs
string a="Alma";
Console.WriteLine(a.Length); //4-et ír ki.
Console.WriteLine(a[0]); //'A'-t ír ki.
```
A string-en is működik néhány a számokon már ismert művelet (operátor):
```cs
string a="Alma";
string b="Körte";

bool egyenloe=(a==b); //Dupla egyenlőségjel itt is azt nézi két szöveg megegyezik-e. != is működik szövegekre.
bool avanelobb=(a<b); //A <, >, <=, >= relációsjelek azt vizsgálják melyik szöveg van előrébb az abc-ben
string osszeg=a+" "+b; //Az összeadás összefűzi a szövegeket, ennek a kifejezésnek az értéke "Alma Körte" lesz.
string osszeg2=a+'a'; //Sőt szövegekhez karaktereket is hozzá tudunk adni.
string osszeg3=a+1; //Sőt még számokat is, ennek a kifejezésnek az értéke "Alma1" lesz.
//Viszont nem működik szövegekre a -, * ,/ és % művelet.
```
Ezen kívül több függvényt előre megírtak, amik segítenek nekünk string-ek kezelésében:
```cs
string a="Alma";

string[] darabolt=a.Split('l'); //A split függvénnyel már találkoztunk
string a2=String.Join('l',darabolt); //Pont az ellenkezőjét teszi, a feldarabolásnak,
                                     //összefűzi a szövegeket úgy hogy a szövegdarabok közé jelenleg az 'l' betűt rakjastr
string a3=a.Replace("l","m"); //Az eredmény "Amma" lesz.                                  
string a4=a.ToLower(); //Kisbetűssé alakítja a szöveget, eredmény "alma" lesz.
string a5=a.ToUpper(); //Csupa nagybetűssé alakítja a szöveget.
char a='A'.ToLower();  //A ToLower, ToUpper függvények karaktereken is működnek.
```
További függvényeket találsz a a [hivatalos dokumentációban](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8#methods)
ahol, ha a függvények nevére kattintasz, akkor példakódokat is látsz a függvény használatára.

# 1. Feladat
Olvass be egy szöveget és írd ki megfordítva:
```
alma
amla
```

## 2. Feladat
Állapítsd meg hogy egy szöveg palindrom-e. Azaz előre és visszafele olvasva megegyezik-e.
```
Szöveg: görög
Palindrom
Szöveg: a kutya sétál
Nem palindrom
```
A program fejezze be a futását, ha a felhasználó szöveg beírása helyet entert üt.

## 3. feladat

Számold meg az egyes karakterekből hány darab van a szövegben (egy karaktert csak akkor írj ki ha van a szövegben, csak angol betűkkel dolgoz
és kis- és nagybetűket ne különböztesd meg):
```
Ez egy hosszu szoveg.
e: 3
g: 2
h: 1
o: 2
s: 3
u: 1
v: 1
y: 1
z: 3
```

# 4. feladat

Keres meg egy mintát a szövegben és írd, ki hanyadik indextől találtad meg először a mintát, ha nem találod meg akkor írd ki, hogy
a szövegben nem szerepel a minta.
```
Szöveg: Ez egy hosszu szoveg
Minta: ez
A minta először a szöveg 1. betűjétől található meg.
```

# C# programozás szakkör év eleji felmérő

A félév során mindenki, egy általa választott témával fog haladni, amíg ezt kiválasztjuk, addig is itt egy rövid feladat, amivel átismételheted, a tavaly tanultakat. A feladat egy történelem dolgozatra felkészítő program írása lesz. Amely képes kikérdezni tőled, hogy jól emlékszel-e a fontosabb események évszámaira.

## 1. Feladat

Hozz létre egy C# Console Application (.Net Framework) projektet. Futtasd le a projektet. A konzolon meg kell jelenjen a "Hello World" felirat.

## 2. Feladat

A program írja ki, hogy "Tortenelem kikerdezo v0.1". Majd várjon egy enter leütést és záródjon be.

___Emlékeztető___:
```cs
Console.WriteLine("szöveg");
string valasz=Console.ReadLine();
```

## 3. Feladat

A program kérdezze meg, hogy "Melyik évben történt a mohácsi csata?", olvassa be a felhasználó válaszát, majd ellenőrizze, hogy helyesen válaszolt-e (1526). Írja ki, hogy helyes/helytelen volt a válasz.

## 4. Feladat
A program addig kérdezze meg, hogy "Melyik évben történt a mohácsi csata?" Amíg a felhasználó helyes választ nem ad.

## 5. Feladat

Definiálj egy kétdimenziós stringekből álló tömböt, aminek az alábbi legyen a tartalma (a fejlécek nélkül):

Esemény | Év 
---|---
mohácsi csata | 1526
aranybulla | 1222
március 15-i szabadságharc | 1848
Római birodalom bukása | 476
Mátyás király uralkodásának kezdete | 1458

## 6. Feladat
Írj ciklust, amely minden a tömbben szereplő eseményről megkérdezi, hogy "Melyik évben történt a(z) *?". A csillag helyére az esemény nevét illesztve. Mindegyik eseményt addig kérdezd, amíg helyes választ nem ad rá a felhasználó

## 7. Feladat

Írd ki az összes esemény kikérdezése után, hogy hányat talált el a felhasználó, ezzel hány százalékos eredményt ért el.

## 8. Feladat

Ahelyett, hogy "a(z)" szerepelne a kérdésben ellenőrizd az esemény első betűjét, ha az magánhangzó akkor az-t ha az mássalhangzó akkor a-t írj. Figyelj a kis és nagybetűkre (használhatod a toUpper, toLower függvényeket).

## 9. Feladat

Az egy eseményt kikérdezéséért felelős kódot emeld ki külön függvénybe. Azaz hozz létre egy `bool Kikerdez(string esemeny, string evszam)` függvényt. Amely addig kérdezi ki, hogy az esemény évszámát, amíg a felhasználó nem találja azt el, végül visszatér azzal, hogy elsőre eltalálta-e.

## 10. Feladat

Az esemény évszám párosokat a program elején az `adatok.txt`-ből olvasd be.


# Adatbázisok alapjai

Az adatbázisok hasonlítanak az excelhez, annyiban, hogy abban is adatok tárolunk, viszont míg az excelben néhány ezer sor tárolására van lehetőségünk, adatbázisokban több millió sort is tárolhatunk.
Az adatbázisban tároljuk az adatot, amit az adatbáziskezelő segítségével tudunk kiolvasni. Több féle adatbáziskezelő létezik, az Access például egy közölük. Én most az mssql adatbázisokkal, adatbáziskezelővel fogok foglalkozni.

Az mssql a Microsoft által írt adatbáziskezelő. Ehhez is van grafikus felület Microsoft SQL Server Management Studio, amivel kezelni tudjuk az adatbázisunkat.

## Adatbázis felépítése

A relációs adatbázisok (amilyen a mssql is) táblákból épülnek fel. A táblákban azonos típusú adatokat tudunk eltárolni.

Vegyük az alábbi _felhasznalok_ táblát:
id | email_cim   | teljes_nev     | jelszo | telefonszam |
---|-------------|----------------|--------|-------------|
1  | aladar@a.hu | Kovács Aladár  | jelszo | 06901234567  |
2  | kata01@a.hu | Kovács Katalin | kata   | 06908765432  |
3  | bencec@a.hu | Cirok Bence    | cb     | 06901928374  |

A tábla felhasználók adatait tartalmazza. A tábla minden rekordja (sora) egy-egy felhasználó. A mezők (oszlopok) adják meg milyen tulajdonságokat tárolunk el egy-egy emberről.

Az mssql adatbázisokban minden mezőnek van típusa.  A fenti példában az id például szám típusú, míg a többi négy mező szöveg típusú. Az adatbáziskezelésből többnyire programozásból
megismert típusokat használhatjuk. Egyetlen eltérés, hogy ha szöveget adunk meg akkor két dolgot kell még a szövegről megadjunk. Hogy tartalmaz-e nem-angol karaktereket (ékezeteket),
illetve hogy milyen hosszú lehet maximum. Mondjuk a telefonszám 11 karakter hosszú maximum, a többi mezőnél ki kell találjunk egy limitet, például mondhatjuk, hogy mindhárom maximum 100 karakter hosszú.

Minden rekord egyedi kell legyen, ezért az adatbáziskezelés során általában létrehozunk egy id mezőt. Ami a rekord egyedi azonosítója. Röviden azt tárolja, hanyadik felhasználóról beszélünk.
Ezt az id-t, amúgy az adatbázis magától le tudja generálni ha megkérjük rá. Azt a mezőt, ami egyedivé teszi a rekordot, kulcsnak nevezzük.

## Az SQL nyelv

Az adatbáziskezelőhöz kérdéseket, és kéréseket végezhetünk, amiket ő végrehajt. Ha kérdéseket intézünk, amire valami adatot várunk azt SELECT típusú lekérdezéssel tudjuk megtenni.
Adatok lekérdezésén kívül van lehetőségünk azok módosítására is.

### Teljes tábla lekérdezése

A legegyszerűbb lekérdezés, ha egy tábla teljes tartalmát akarjuk lekérdezni:

```sql
SELECT * FROM felhasznalok;
```

A lekérdezéseket pontosvesszővel zárjuk. Nagybetűvel szoktuk írni a parancsszavakat, de ez nem kötelező.

A fenti lekérdezést így tudjuk kiolvasni: "A felhasznalok táblából válaszd ki az összes rekordot, és jelenítsd meg azoknak minden mezőjét", ezedménye meg az alábbi lesz:
id | email_cim   | teljes_nev     | jelszo | telefonszam |
---|-------------|----------------|--------|-------------|
1  | aladar@a.hu | Kovács Aladár  | jelszo | 06901234567  |
2  | kata01@a.hu | Kovács Katalin | kata   | 06908765432  |
3  | bencec@a.hu | Cirok Bence    | cb     | 06901928374  |

### Szűrés

Van, hogy minket nem az összes felhasználó, hanem csak pár felhasználó érdekel. Ilyenkor lehetőségünk van szűrőfeltételeket megadni.

```sql
SELECT * FROM felhasznalok WHERE email_cim='aladar@a.hu';
```
A fenti lekérdezést így tudjuk kiolvasni: "A felhasznalok táblából válaszd ki azokat a rekordokat, ahol az e-mail cím aladar@a.hu és jelenítsd meg azok minden mezőjét", eredménye meg az alábbi lesz:
id | email_cim   | teljes_nev     | jelszo | telefonszam |
---|-------------|----------------|--------|-------------|
1  | aladar@a.hu | Kovács Aladár  | jelszo | 06901234567  |

### Projekció

Lehet hogy minket nem az összes, csak bizonyos tulajdonságai érdekelnek a felhasználónak. Például csak a email-címük és a jelszavuk:
```sql
SELECT email_cim, jelszo FROM felhasznalok;
```

A fenti lekérdezést így tudjuk kiolvasni: "A felhasznalok táblából válaszd ki az összes rekordot, és jelenítsd meg azoknak az e-mail címét és a jelszavát", ezedménye meg az alábbi lesz:
| email_cim   | jelszo |
|-------------|----------------|
| aladar@a.hu   | jelszo |
| kata01@a.hu  | kata   |
| bencec@a.hu   | cb     |

Természetesen szűrést és projekciót tudunk egyszerre is csinálni, pl.:

```sql
SELECT id FROM felhasznalok WHERE email_cim='aladar@a.hu';
```

Melyen eredménye az alábbi lesz:

| id |
|----|
| 1  |

### Adatok módosítása

Az adatokat módosítani INSERT, UPDATE, DELETE műveletekkel tudjuk, míg egész táblákat a CREATE TABLE, ALTER TABLE, DROP TABLE utasításokkal tudunk módosítani.

Részletesebben a https://www.w3schools.com/sql/sql_syntax.asp linken találsz erről információt.

## Relációk, táblák közötti kapcsolatok

Sokszor előfordul, hogy az egyes táblákban tárolt adatok között kapcsolatok vannak. Például, ha egy Facebookhoz hasonló alkalmazást írunk, akkor el kell tároljuk a felhasználók posztjait.

A posztokat megéri egy külön `posztok` táblában eltérolni, viszont valahogy jeleznünk kell ki írta az adott posztot. Hivatkoznunk kell a felhasználóra:

| id | irta | tartalom                               | lajkok_szama |
|----|------|----------------------------------------|--------------|
| 1  | 1    | Boldog névnapot a Győzőknek!           | 30           |
| 2  | 2    | Csodálatos nyaralás volt, köszi Nagyi! | 1            |
| 3  | 2    | Bombabiztos csokisfánk recept!         | 100          |

Azt, hogy melyik posztot ki írta az `irta` mező tárolja, pontosabban a posztot író személy id-ját tárolja, azaz az első posztot Aladár, a következő kettőt Katalin írta.

Ilyenkor az irta mezőt idegen kulcsnak hívjuk. Mivel a másik tábla kulcs mezőjére hivatkozik.

A következő kérdés, hogy SQL nyelvben hogyan tudunk a két táblát eggyüttesen használva, bonyolultabb lekérdezéseket is csinálni? Erre megoldás a JOIN, amivel két táblát tudunk összekapcsolni.

```sql
SELECT f.teljes_nev p.tartalom
FROM felhasznalok AS f INNER JOIN posztok AS p ON f.id=p.irta;
```

A fenti lekérdezésben azt mondjuk, hogy a felhasználók táblához (amire innenről röviden f-ként hivatkozunk), illeszd hozzá úgy a posztok tábla, tartalmát.
Azt is meg kell adjunk, hogy végezze az illesztést. Itt megadtuk, hogy akkor illesszen össze egy posztot egy felhasználóval, ha a poszt `irta` mezőjének értéke megegyezik a felhasználó `id`-jával.

A fenti lekérdezés eredménye az alábbi lesz:

| f.teljes_nev   | p.tartalom                               | 
|----------------|------------------------------------------|
| Kovács Aladár  | Boldog névnapot a Győzőknek!             |
| Kovács Katalin | Csodálatos nyaralás volt, köszi Nagyi!   | 
| Kovács Katalin | Bombabiztos csokisfánk recept!           |

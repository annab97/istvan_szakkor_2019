# Napló

A feladat egy olyan naplóalkalmazás írása lesz, amely titkosítva tárolja a naplóbejegyzéseket, azokat csak a megfelelő jelszó beírásával nézhetjük meg.

## Belépés

Az alkalmazásunkba először is be kell tudjunk lépni. Ehhez készíts a korábbi bejelentkeztető formhoz hasonló formot. A Form1.cs-be (a függvényeken kívül) hozz létre egy `public bool SikeresBelepes=false`
változót. Ez akkor lesz igaz, ha sikeres volt a belépés.

Ha a felhasználó a belépés gombra kattint ellenőrizd, hogy helyes-e a felhasználónév és a jelszó. Ha helyesek, akkor állítsd a SikeresBelepes változót true-ra és hívd meg a `Close()` függvényt, ami bezárja majd a bejelentkező ablakot.

Ezután adj hozzá egy új formot az alkalmazáshoz. Itt tudja majd a felhasználó megtekinteni, hogy milyen naplóbejegyzéseket írt eddig. Ehhez a __Solution Explorer__-ben kattints a projekt nevére jobb gombbal.
Itt válaszd ki az Add > Forms opciót. És a megjelenő ablakban nevezd el a formot ListaNezet.cs-nek.

Miután létrejött nyisd meg a Program.cs-t. A Program.cs felel azért, hogy elindítsa a formokat. Így ide fogjuk megírni, hogy ha sikeres volt a bejelentkezés, akkor indítsa el a ListaNézet formot is.

Egészítsd ki a Main függvént:

```cs

static void Main()
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Form1 belepes = new Form1(); 
    Application.Run(belepes); //Először a programunk a belepes ablakot nyitja meg
    if (belepes.SikeresBelepes=true) //Majd ha sikeres volt a belepes
    {
        Application.Run(new ListaNezet()); //Akkor elindítja a ListaNezet ablakot is.
    }
}

```

Teszteld, hogy helyesen működik-e a program.



## ListaNézet

Cél egy ilyen listanézet létrehozása:

![lista_nezet1.png](lista_nezet.png)

Elindítca így fog kinézni:

![lista_nezet2.png](lista_nezet_2.png)

### Menü

Ehhez először is adj egy MenuStrip-et a programhoz. Ezzel lehet felső menüt létrehozni. Ha a menü bal oldalára kattintasz akkor hozzá tudsz adni új menüelemeket. Az ábrán látható módon add hozzá a fájl menüt.
Majd ennek a megfelelő almenüpontokat. Vízszintes vonalat úgy tudsz hozzáadni, ha egy almenüpontra jobbgombbal kattintasz, itt kiválasztod, hogy Insert > Separator majd a megfelelő helyre húzod a szeparáló vonalat.

Kattints duplán a Bezárás menüpontra. A létrejövő függvény akkor hívódik meg, ha a felhasználó a Bezárásra kattint. Itt egyszerűen hívd meg a `Close()` függvényt, hogy bezáruljon a program. Teszteld is le, hogy működik-e!

A Kijelentkezés menüpontra kattintáskor be kell zárni a programot, majd újra megnyitni a bejelentkező ablakot. Ehhez itt is megéri egy `public bool Kijelentkezett=false` változót létrehozni, majd úgy módosítani a Program.cs-t,
hogy addig ismételje a bejelentkező, majd listanézett megjelenítést, amíg a felhasználó kijelentkezéssel zárta be a ListaNézetet.

A többi menüpontot majd később írjuk meg.

### Lista Nézet

Az alkalmazásunk úgy fog működni, hogy minden naplóbejegyzés egy .txt fájl lesz, ami az exe-vel egy mappában lesz. A txt fájl neve meg az a nap lesz, amikor a bejegyzést írtuk (pl. 2020_10_4.txt). Hozz létre a teszteléshez pár ilyen teszt naplóbejegyzést.

A képen fehér területen egy listview van. Hozd létre ezt. Ha miután ráhúztad a listview-t a formra a jobb oldalt megjelenő nyílra kattintasz, és ott a _Dock in Parent Container_-re kattintasz akkor automatikusan kitölti a rendelkezésre álló teret.
Szintúgy a nyílra kattinva tudjuk beállítani a listview legfontosabb tulajdonságait.
 - View: a megjelenés módja LargeIcon legyen.
 - ImageList: a toolboxból hozz létre egy imageList-et. Töltsd le a document.png-t, majd állítsd be az imageList Images tulajdonságánál, hogy egyedül ezt a png-t tartalmazza.  Állítsd be, hogy a képméret 100x100 legyen. És végül állítsd be, hogy a listView Large ImageList-je ez az imageList legyen.
 
A listánkba a listaelemeket majd kódból fogjuk feltölteni. Ehhez váltsd át a kódra. A konstruktort egészítsd ki, hogy hívja meg a ListaBetolt függvényt.

A ListBetolt-be az alábbi kódot írd bele (én listView-nak neveztem el a listát):

```cs
listView.Clear();  //Kitöröljük, ami eddig a listában volt, ez majd a törlésnél lesz fontos
DirectoryInfo directoryInfo = new DirectoryInfo("."); //directoryInfo-val egy mappa tartalmát tudjuk kiolvasni, a "." azt jelenti, hogy azt a mappát, ahol az exe van szeretnénk olvasni.
FileInfo[] fajlok=directoryInfo.GetFiles("*.txt"); //Kigyűjtjük a txt kiterjesztésű fájlokat a mappából. 
for (int i = 0; i < fajlok.Length; i++) //Végigmegyünk a fájlokon
{
    string fajlnev = fajlok[i].Name; //Kiolvassuk a fájl nevét, pl. 2020_10_04.txt
    string fajl_kiterjesztes_nelkul = fajlnev.Split('.')[0]; //Eltüntetjük a végéről a .txt kiterjesztést. ('.' szerint splitelünk és csak az első elemet tartjuk meg). Pl. 2020_10_04
    string[] darabolt = fajl_kiterjesztes_nelkul.Split('_'); //Aláhúzás alapján is splitelünk, hogy szépen tudjuk majd kiírni a dátumokat.
    string datum = $"{darabolt[0]}. {darabolt[1]}. {darabolt[2]}."; //Szépen megformázzuk a dátumot. Pl. 2020. 10. 04.
    ListViewItem listViewItem = new ListViewItem(datum,0); //Létrehozunk egy ListView-ba rakható elemet, ahol a datum szöveg jelenjen meg, és a képlistában szereplő 1. kép (0. indexű).
                                                           //Mivel a képlista 1 elemű így ez a document.png lesz.
    listViewItem.Tag=fajlok[i]; //A Tag-ba bármit eltárolhatunk ami később hasznos lesz, itt eltároljuk a fájlt, mert később ez kelleni fog, hogy megnyitni vagy törölni tudjuk azt.
    listView.Items.Add(listViewItem); //Hozzáadjuk a listview-hoz az új elemet.

}

```

Teszteld az alkalmazást!

### Kontext menü

A jobbgombbal kattintáskor lenyíló menü hivatalon neve ContextMenu. Célunk egy ilyet létrehozni, amivel naplóbejegyzésekekre kattintva lehet velük műveletet végezni.
Ehhez először is a toolboxból hozz létre egy ContextMenuStrip-et. A menü elemei a __Megnyitás__ és a __Törlés__ legyenek. Azt, hogy a kontext menü mikor jelenjen meg azt programból tudjuk megmondani.
Ehhez segítséget [itt](https://stackoverflow.com/questions/13437889/showing-a-context-menu-for-an-item-in-a-listview) találsz. Teszteld az alkalmazást!

Ha a törlésre nyom a felhasználó akkor ki akarjuk törölni az adott fájlt. Ha contextMenuStrip1-re kattintasz, ott a Törlésre duplán kattintasz akkor létrehozhatod az eseménykezelőt.
Töröld ki az aktív fájlt, majd töltsd újra a listanézetet!

__Segítségek__:
  - A `listView.FocusedItem` az éppen aktív listaelem.
  - A Tag-ba benne van a fájlinfó (a ListaBetöltben beletettük)
  - A fájlinfónak van Delete() függvénye. Ha ezt meghívod akkor kitörli a fájlt.

### Új bejegyzés létrehozása

Ez a feladatrész még nincs kész!


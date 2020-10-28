# Tulajdonságok

Az osztályokban nem csak tagváltozókat, hanem propertyket is létrehozhatunk. A propertyk viselkedése nagyon hasonló, a tagváltozókéhoz, de létrehozásuk különbözik.
Továbbá a propertyket nagy kezdőbetűvel szokás kezdeni a függvényekhez hasonlóan.

```cs
public class Peldaosztaly{
  public int szamTagvaltozo; //Egy szám típusú tagváltozó, ami mivel public más osztályokból is el lehet érni.
  
  public int SzamProperty {get; set;} //Szám típusú tulajdonság.
                                      //A public itt is azt jelenti, hogy másik osztályból is el lehet érni.
                                      //A get azt jelenti, hogy olvastható, a set meg hogy szerkeszthető 
}
```

A property-knél megadhatjuk, hogy kinek milyen joga van a változóhoz. Ha csak olvasási jogot adunk `public int Szam{get;}` (nincs set), akkor csak a konstruktorban módosítható a változó értéke, többet nem.
Azt is mondhatjuk, hogy csak az osztályon belülről módosíthatjuk a property értékét  (`public int Szam{get; private set;}`).

A property, abban igazán más viszont, mint a hagyományos változó, hogyan lehet kiolvasni, módosítani az értékét. Például szeretnénk személyeknek eltárolni, hogy mikor születtek, illetve, hogy hány évesek.
És azt szeretnénk, hogy egyrészt a koruk mindig friss legyen, évente nőjön, másrészt, ha módosítjuk a korukat, akkor módosuljon a születési dátumuk is.
Ezt úgy tudjuk, megtenni, hogy csak a születési dátumot tároljuk, a korukat nem. A kornál, csak azt mondjuk meg, hogy kell kiszámolni az értékét.

```cs
public DateTime SzulIdo {get; set;} //Itt mindegy propertyt vagy tagváltozót hozunk létre, de tipikusan propertyt szoktunk inkább

public int Kor{
  get{  // Akkor hívódik meg, mikor valaki ki akarja olvasni a kort
    endDate=DateTime.Now;
    startDate=SzulIdo;
    int years = endDate.Year - startDate.Year;

    if (startDate.Month == endDate.Month &&// if the start month and the end month are the same
        endDate.Day < startDate.Day// AND the end day is less than the start day
        || endDate.Month < startDate.Month)// OR if the end month is less than the start month
    {
        years--;
    }

    return years;
  }
  set{ //Akkor hívódik meg, mikor valaki módosítani akarja a kort.
    SzulIdo=DateTime.Now.AddYears(-value); //value az az érték, amire a kort akarták módosítani.
  }
}
```

Listákból propertyt is csak úgy tudunk csinálni, ha megmondjuk mi történjen get és set esetén
```cs
private List<int> lista; //a privát tagváltozónk amibe valójában tároljuk a dolgokat.
public List<int> Lista{
  get{ return lista;}
  set{ lista=value;}
}
```

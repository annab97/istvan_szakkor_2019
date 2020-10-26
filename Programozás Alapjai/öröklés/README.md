# Öröklés

Előfordul, hogy annyira sok osztályunk van, hogy csoportosítani, hierarchiába szeretnénk őket rendezni, a közös tulajdonságokat kiemelni és csak egyszer megvalósítani.
Egy nagyobb programozási projekt akár több száz osztályt is tartalmazhat, ezek megfelelő csoportosítás nélkül kezelhetetlenek lehetnek.

Az öröklés a fenti problémára ad megoldást, létrehozhatunk a közös tulajdonságok tárolására ősosztályokat, amiből leszármazhatnak a közös tulajdonsággal rendelező osztályaink.

Például szeretnénk e-naplót írni. Az e-naplóba diákok és tanárok illetve szülők léphetnek be. Minden diáknak tanárnak, szülőnek saját felhasználóneve és jelszava van. De míg a tanárok
beírhatnak osztályzatokat a diákoknak, a diákok csak megtekinthetik a saját osztályzataikat, a szülők meg csak a gyerekeik osztályzatait tudják megtekinteni.

Legyen a tanároknak, diákoknak, szülőknek egy közös ős osztálya a felhasználó. A felhasználó rendelkezzen felhasználónévvel és jelszóval, de ne rendelkezzen jegybeírás funkcióval, hiszen a szülők, diákok nem tudnak jegyeb beírni.

Az alábbi ábra összefoglalja, a létrehozandó osztályainkkat, és azok tulajdonságait:


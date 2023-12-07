<h1>TvShop Felhasználói Dokumentáció</h1>

Dluhi Dániel     Rajna Torda Imre Luczi Alex

*https://github.com/alexluczi/TvShop*

<h1>Felhasználói dokumentáció</h1>

<h2>Rendszerkövetelmény</h2>

Operációs rendszer:

- Windows
- macOS
- Linux

Perifériák:

- Billentyűzet
- Monitor

<h2>Program használata</h2>

**Rendszer indítása**

A program letöltése után az alábbi könyvtárban található a fájl, ami elindítása utána egyből a rendszer beállítási folyamatának kezdetén találjuk magunkat. 

/TvShop/TvShop/bin/Debug/net7.0

*A program indítása ![](Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.001.png)*

**Ügynökök létszámának kezelése**

Miután a rendszer elindult el is kezdhetjük megadni az ott dolozó ügynökök számát.

*Ügynökök létszámának megadása![](Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.002.png)*

A rendszerünk maximum 999 ügynök adatait tudja eltárolni, ezért már az ügynökön bekérdezésénél is limitáltuk a megadható mennyiséget.

Ennél a bekérdezésnél felmerülő hibaüzeneteket és azok jelentését az alábbi táblázatban találja meg.



|**Hibaüzenet**|**Jelentés**|
| - | - |
|Nullánál nagyobb értéket adjon meg!|A ügynökök száma nem lehet sem nulla, sem negatív.|
|Hiba lépett fel az ügynökök számának megadásában!|Valószínűleg nem szá- mot, vagy nem egész számot adott meg.|

Ha sikeres volt a létszám megadása, akkor következő lépésben az átláthatóság érdekében kötelezően meg kell adni ezen ügynökök neveit. Így a rendszerben név szerint tekintheti majd meg az eladók  minősítését.

**Ügynökök nevének kezelése**

Az alábbi képernyőkepen tekinthető meg az ügynökök nevének kezelése.

*Ügynökök nevének megadása![](Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.003.png)*

Ennél a bekérdezésnél felmerülő hibaüzeneteket és azok jelentését az alábbi táblázatban találja meg.



|**Hibaüzenet**|**Jelentés**|
| - | - |
|A név megadása kötelező!|Valószínűleg név megadása nélkül szerette volna folytat- ni, ami viszont nem lehetséges.|
|Hiba lépett fel a név megadásában!|Egyéb hiba lépett fel a név megadása folyamán.|

Ezzel a lépéssel az ügynökök bevitele a rendszerbe megtörtént. A következő lépésben a minősétő rendszer működését fogjuk ismer- tetni. Kérjük ne lépjen ki a programból, mert újra kell kezdenie a folyamatot.

**Ügynökök minősítése**

Az alábbi képernyőkepen az ügynökök minősítésének kiiratási menüje látható.

*Kiiratási menü![](Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.004.png)*

Ennél a bekérdezésnél felmerülő hibaüzeneteket és azok jelentését az alábbi táblázatban találja meg.



|**Hibaüzenet**||**Jelentés**|
| - | :- | - |
|Kérem a menüpon tok sorszámai közül válasszon!|-|A számnak, amit beír 0 és 6 közé kell esni (azaz 1, 2, 3, 4, 5).|
|Hiba lépett fel a menüpont kiválasz tása során!|-|Valószínűleg üresen hagyta a mezőt, vagy egyéb hibák léptek fel.|

Itt egyszeűen egyetlen szám és az Enter billentyű megadásával már láthatjuk is az adott minősétés szerint rendezett ügynököket.

*Alap minősétésű ügynökök (PÉLDA)![](Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.005.png)*

A rendszer ezen részén felül láthatjuk azt, hogy melyik minősétési kategóriában vagyunk, alatta pedig egyből a nevek és a hozzátartozó betelefonálószámot tekinthetjük meg.

Erről a felületről a menübe való visszalépéshez csak egy Enter-t kell nyomnia (ahogy azt a képernyő alján is jelzi a program).

Van lehetőségünk megtekinteni az összes ügynököt és azok minősítését. Az alábbi képernyőkepen az ‘összes‘ menüpont alatt található felület látható.

*Összes ügynök (PÉLDA)![](Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.006.png)*

Erről a felületről a menübe való visszalépéshez csak egy Enter-t kell nyomnia (ahogy azt a képernyő alján is jelzi a program).

*A kód megtekinthető a https://github.com/alexluczi/TvShop oldalon.*

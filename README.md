<h1>TvShop Felhasználói Dokumentáció</h1>

Dluhi Dániel, Rajna Torda Imre, Luczi Alex

*https://github.com/alexluczi/TvShop*

<h1>Tartalomjegyzék</h1>

<a href="https://github.com/alexluczi/TvShop#tartalomjegyzék">**Tartalomjegyzék**</a>

<a href="https://github.com/alexluczi/TvShop#felhasználói-dokumentáció">**Felhasználói dokumentáció**</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://github.com/alexluczi/TvShop#rendszerkövetelmény">**Rendszerkövetelmény**</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://github.com/alexluczi/TvShop#program-használata">**Program használata**</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://github.com/alexluczi/TvShop#rendszer-indítása">Rendszer indítása</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://github.com/alexluczi/TvShop#ügynökök-létszámának-kezelése">Ügynökök létszámának kezelése</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://github.com/alexluczi/TvShop#ügynökök-nevének-kezelése">Ügynökök nevének kezelése</a>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="https://github.com/alexluczi/TvShop#ügynökök-minősítése">Ügynökök minősítése</a>

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

<h3>Rendszer indítása</h3>

A program letöltése után az alábbi könyvtárban található a fájl, ami elindítása utána egyből a rendszer beállítási folyamatának kezdetén találjuk magunkat. 

/TvShop/TvShop/bin/Debug/net7.0

<p align="center">
  <img src="Documentation/Images/Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.001.png" />
  <br>
  <i>A program indítása</i>
</p>

<h3>Ügynökök létszámának kezelése</h3>

Miután a rendszer elindult el is kezdhetjük megadni az ott dolozó ügynökök számát.

<p align="center">
  <img src="Documentation/Images/Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.002.png" />
  <br>
  <i>Ügynökök létszámának megadása</i>
</p>

A rendszerünk maximum 999 ügynök adatait tudja eltárolni, ezért már az ügynökön bekérdezésénél is limitáltuk a megadható mennyiséget.

Ennél a bekérdezésnél felmerülő hibaüzeneteket és azok jelentését az alábbi táblázatban találja meg.



|**Hibaüzenet**|**Jelentés**|
| - | - |
|Nullánál nagyobb értéket adjon meg!|A ügynökök száma nem lehet sem nulla, sem negatív.|
|Hiba lépett fel az ügynökök számának megadásában!|Valószínűleg nem szá- mot, vagy nem egész számot adott meg.|

Ha sikeres volt a létszám megadása, akkor következő lépésben az átláthatóság érdekében kötelezően meg kell adni ezen ügynökök neveit. Így a rendszerben név szerint tekintheti majd meg az eladók  minősítését.

<h3>Ügynökök nevének kezelése</h3>

Az alábbi képernyőkepen tekinthető meg az ügynökök nevének kezelése.

<p align="center">
  <img src="Documentation/Images/Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.003.png" />
  <br>
  <i>Ügynökök nevének megadása</i>
</p>

Ennél a bekérdezésnél felmerülő hibaüzeneteket és azok jelentését az alábbi táblázatban találja meg.



|**Hibaüzenet**|**Jelentés**|
| - | - |
|A név megadása kötelező!|Valószínűleg név megadása nélkül szerette volna folytat- ni, ami viszont nem lehetséges.|
|Hiba lépett fel a név megadásában!|Egyéb hiba lépett fel a név megadása folyamán.|

Ezzel a lépéssel az ügynökök bevitele a rendszerbe megtörtént. A következő lépésben a minősétő rendszer működését fogjuk ismer- tetni. Kérjük ne lépjen ki a programból, mert újra kell kezdenie a folyamatot.

<h3>Ügynökök minősítése</h3>

Az alábbi képernyőkepen az ügynökök minősítésének kiiratási menüje látható.

<p align="center">
  <img src="Documentation/Images/Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.004.png" />
  <br>
  <i>Kiiratási menü</i>
</p>

Ennél a bekérdezésnél felmerülő hibaüzeneteket és azok jelentését az alábbi táblázatban találja meg.



|**Hibaüzenet**||**Jelentés**|
| - | :- | - |
|Kérem a menüpon tok sorszámai közül válasszon!|-|A számnak, amit beír 0 és 6 közé kell esni (azaz 1, 2, 3, 4, 5).|
|Hiba lépett fel a menüpont kiválasz tása során!|-|Valószínűleg üresen hagyta a mezőt, vagy egyéb hibák léptek fel.|

Itt egyszeűen egyetlen szám és az Enter billentyű megadásával már láthatjuk is az adott minősétés szerint rendezett ügynököket.

<p align="center">
  <img src="Documentation/Images/Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.005.png" />
  <br>
  <i>Alap minősétésű ügynökök (PÉLDA)</i>
</p>

A rendszer ezen részén felül láthatjuk azt, hogy melyik minősétési kategóriában vagyunk, alatta pedig egyből a nevek és a hozzátartozó betelefonálószámot tekinthetjük meg.

Erről a felületről a menübe való visszalépéshez csak egy Enter-t kell nyomnia (ahogy azt a képernyő alján is jelzi a program).

Van lehetőségünk megtekinteni az összes ügynököt és azok minősítését. Az alábbi képernyőkepen az ‘összes‘ menüpont alatt található felület látható.

<p align="center">
  <img src="Documentation/Images/Aspose.Words.0095dc24-6592-4159-9410-2e36272c0c5f.006.png" />
  <br>
  <i>Összes ügynök (PÉLDA)</i>
</p>

Erről a felületről a menübe való visszalépéshez csak egy Enter-t kell nyomnia (ahogy azt a képernyő alján is jelzi a program).

<p align="center"><i>A kód megtekinthető a <a href="https://github.com/alexluczi/TvShop">https://github.com/alexluczi/TvShop</a> oldalon.</i></p>

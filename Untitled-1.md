# Ügynökök Minősítési Rendszer

## Bevezetés

Ez a program egy egyszerű ügynökök minősítési rendszert valósít meg. A felhasználó beállíthatja a minősítendő eladók számát, majd megadhatja az eladók nevét. Minden ügynöknek generál egy véletlenszerű betelefonálószámot, majd minősíti az ügynököket a betelefonálószám alapján. Végül a felhasználó választhatja ki, hogy csak az alap, közép, emelt minősítésű ügynököket szeretné látni, vagy az összeset egyszerre.

## Rendszerkövetelmények

- .NET Core vagy .NET Framework telepítve a futtatáshoz.
- Fejlesztőkörnyezet: Visual Studio ajánlott.

## Telepítés és Futtatás

1. Klónozza le a projektet a GitHub repository-ról vagy másolja le a forrásfájlokat a gépére.
2. Nyissa meg a projektet a választott fejlesztőkörnyezetben.
3. Futtassa a programot.

## Használat

1. **Indulás:**
   - A program elindul.

2. **Ügynökök számának bekérése:**
   - A program bekéri a felhasználótól, hogy adja meg a minősítendő ügynökök számát.

3. **Adatok bekérése és ügynökök létrehozása:**
   - A program létrehoz egy üres ügynöklistát.
   - Egy ciklus segítségével bekéri a felhasználótól az egyes ügynökök nevét és generál egy véletlenszerű betelefonálószámot minden egyes ügynöknek.
   - Az ügynökök adatait hozzáadja a listához.

4. **Ügynökök minősítése:**
   - Az ügynökök minősítése a betelefonálószámok alapján történik.
   - Az "Alap" minősítéshez: 30 000 betelefonálóig.
   - A "Közép" minősítéshez: 30 001-től 40 000 betelefonálóig.
   - Az "Emelt" minősítéshez: 40 001 betelefonálótól.

5. **Felhasználói menü:**
   - A program egy menüt jelenít meg a felhasználónak, ahol választhatja ki, hogy mely minősítésű ügynököket szeretné látni, vagy az összeset egyszerre.

6. **Ügynökök kiíratása:**
   - A program kiírja a felhasználó által kért minősítési kategóriába tartozó ügynökök adatait vagy az összeset egyszerre.

7. **Visszalépés és Kilépés:**
   - A felhasználó választhat a menüpontok között, és a program végrehajtja a kiválasztott műveletet.
   - A kilépés opció kiválasztásával a program véget ér.

8. **Vége:**
   - A program befejezi futását.

## Kód Struktúra

- A `Agent` osztály felelős az ügynökök létrehozásáért és minősítéséért.
- A `Main` metódusban található fő logika, ahol a felhasználói inputokat kezeli és az ügynökök listáját kezeli.

## Példa Használatra

```csharp
// Példa használat a kódban
class Program
{
    static void Main(string[] args)
    {
        // ...

        // A program inicializálása és futtatása
        MinositesiRendszer rendszer = new MinositesiRendszer();
        rendszer.Futtatas();
    }
}
```

## Fejlesztői Megjegyzések

- Az ügynökök minősítése a betelefonálószámok alapján történik, ahol az Alap, Közép és Emelt minősítési kategóriák a számsávok alapján lettek meghatározva.
- A program jelenlegi formájában egyszerű, további funkciók hozzáadhatók vagy a felhasználói felület fejleszthető.
- A kód tartalmaz néhány ellenőrzést a felhasználói inputok validációjára.

---

Remélem, ez a folyamatábrával kiegészített dokumentáció segít a program megértésében és használatában. Ha további kérdéseid vagy javaslataid vannak, szívesen segítek!
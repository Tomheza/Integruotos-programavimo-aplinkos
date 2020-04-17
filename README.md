# Integruotos-programavimo-aplinkos v1.0 versija - ``1 strategija``
## Užduoties formuluotė
> Parašykite programą, kuri nuskaito šiuos studentų duomenis:
**`vardą`** ir **`pavardę`**
 **n** atliktų namų darbų (nd) rezultatus (10-balėje sistemoje), o taip pat egzamino (egz) rezultatą.
Tuomet iš šių duomenų, suskaičiuoja galutinį balą **`(galutinis)`**:

#### Dokumentaciją galima rasti releases puslapyje parsisiuntus **`documentation.rar (naudota Doxygen)`**

# Užduotis v1.0 versijai
- **Optimizuokite studentų  rūšiavimo (dalijimo) į  dvi  kategorijas ("vargšiukų" ir  "kietiakų") realizaciją:** t.y. visiems trims konteinerių tipams (List, LinkedList ir Deque) išmatuokite programos veikimo spartą priklausomai nuo studentų dalijimo į dvi kategorijas strategijos:
  - **1 strategija:** Bendro **studentai** konteinerio (vector, list ir deque tipų) skaidymas (rūšiavimas) **į  du  naujus to  paties tipo  konteinerius:  "vargšiukų"  ir  "kietiakų".** Tokiu būdu tas pats studentas yra dvejuose konteineriuose: bendrame **studentai** ir viename iš suskaidytų **(vargšiukai arba kietiakai).** Nesunku pastebėti, kad  tokia strategija yra neefektyvi užimamos atminties atžvilgiu (įsitikinkite tuo!), tačiau šiame žingsnyje svarbiausia yra patyrinėti, kaip programos veikimo sparta priklauso nuo konteinerio tipo?
  - **2  strategija:** Bendro studentų konteinerio (vector, list  ir deque) skaidymas (rūšiavimas) **panaudojant tik  vieną naują konteinerį: "vargšiukai".** Tokiu būdu, jei studentas yra vargšiukas, jį turime įkelti į naująjį **"vargšiukai".** Tokiu  būdu, jei  studentas yra vargšiukas, jį turime įkelti į naująjį **"vargšiukų"** konteinerį ir ištrinti iš bendro **studentai** konteinerio. Po šio žingsnio **studentai** konteineryje liks vien tik **kietiakai.** Atminties atveju tai efektyviau, tačiau dažni trynimai gali būti "skausmingi", ypač tam tikro tipo konteineriams.

P.s. Jeigu Jūsų šiuo metu realizuota strategija nesutampa nė su viena iš šių dviejų aukščiau aprašytų strategijų, turėsite palyginti tris strategijas: Jūsų ir abi aukščiau aprašytas strategijas.

Programos efektyvumas stipriai gali priklausyti ne tik nuo naudojamo konteinerio tipo, tačiau ir nuonaudojamų algoritmų. Susipažinkite su žemiau pateiktais algoritmais:

- ``List<T>.Find()``
- ``List<T>.FindIndex()``
- ``List<T>.BinarySearch()``
- ``List<T>.Contains()``
- ``List<T>.CopyTo()``
- ``List<T>.Remove()``
- ``List<T>.RemoveAt(int index)``
- ``List<T>.RemoveRange (int index, int count);``
- ``List<T>.Insert(int index, T item)``
- ``List<T>.Reverse()``
- ``List<T>.TrimExcess()``
# Greičio tyrimai
Visi tyrimai atlikti su 1000 rezultatų iš sugeneruoto failo 1.txt (praitų užduočių).
Laikas užrašomas ``milisekundėmis``, ``sekundėmis``, ``minutėmis``
# Paleistis
Paleidus programą reikia pasirinkti iš 3 opcijų kokio tipo konteinerį naudoti
- 1 ``List<T>``
- 2 ``LinkedList<T>``
- 3 ``Queue<t>``

## ``List<T>``
#### addstudentsio - adds students from file of your choice

| Command        | Execution time|
| ------------- |----------------|
|  Read: 1.txt  | Elapsed miliseconds: 11  |
| Txt file parse| Elapsed miliseconds: 9   |
| Sort all lists... | Elapsed miliseconds: 22 |

#### print - selected goodguys and print to file

| Command        | Execution time|
| ------------- |----------------|
|  print - 2 save to file  |Elapsed miliseconds: 48 |


#### print - selected badguys and print to file

| Command        | Execution time|
| ------------- |----------------|
|  print - 3 save to file  |Elapsed miliseconds: 42 |


## ``LinkedList<T>``
#### addstudentsio - adds students from file of your choice

| Command        | Execution time|
| ------------- |----------------|
|  Read: 1.txt  | Elapsed miliseconds: 3  |
| Txt file parse| Elapsed miliseconds: 22   |
| Sort all lists... | Elapsed miliseconds: 30 |

#### print - selected goodguys and print to file

| Command        | Execution time|
| ------------- |----------------|
|  print - 2 save to file  |Elapsed miliseconds: 46 |


#### print - selected badguys and print to file

| Command        | Execution time|
| ------------- |----------------|
|  print - 3 save to file  |Elapsed miliseconds: 44 |

## ``Queue<T>``
#### addstudentsio - adds students from file of your choice

| Command        | Execution time|
| ------------- |----------------|
|  Read: 1.txt  | Elapsed miliseconds: 3  |
| Txt file parse| Elapsed miliseconds: 18   |
| Sort all lists... | Elapsed miliseconds: 25 |

#### print - selected goodguys and print to file

| Command        | Execution time|
| ------------- |----------------|
|  print - 2 save to file  |Elapsed miliseconds: 4 |


#### print - selected badguys and print to file

| Command        | Execution time|
| ------------- |----------------|
|  print - 3 save to file  |Elapsed miliseconds: 4 |


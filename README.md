# Integruotos-programavimo-aplinkos v0.5 versija
## Užduoties formuluotė
> Parašykite programą, kuri nuskaito šiuos studentų duomenis:
**`vardą`** ir **`pavardę`**
 **n** atliktų namų darbų (nd) rezultatus (10-balėje sistemoje), o taip pat egzamino (egz) rezultatą.
Tuomet iš šių duomenų, suskaičiuoja galutinį balą **`(galutinis)`**:

#### Dokumentaciją galima rasti releases puslapyje parsisiuntus **`documentation.rar (naudota Doxygen)`**

# Užduotis v0.5 versijai
- **Konteinerių testavimas:** išmatuokite programos veikimo spartą (be failų generavimo (turite naudotituos  pačius failus visais atvejais) ir  surūšiuotų studentų išvedimą į  naujus failus) priklausomai  nuonaudojamo vieno iš trijų konteinerių:
- ``List<T>``
- ``LinkedList<T>``
- ``Queue<T>``

T.y.,  jeigu Jūs  turite susikurę struktūrą Studentai  (ar  kaip  jūs  ją  pavadinote) ir  iki  šiol  naudojoteList<Students>, tai turite ištirti: ar pasikeistų ir kaip pasikeistų sparta, jei vietoje List<Students>naudotumėte LinkedList<Students>  ir Queue<Students>.  Visus  tyrimus  ir  jų  analizę aprašykite ``README.md`` faile.

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

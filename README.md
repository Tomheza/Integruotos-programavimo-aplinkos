# Integruotos-programavimo-aplinkos v0.4 versija
## Užduoties formuluotė
> Parašykite programą, kuri nuskaito šiuos studentų duomenis:
**`vardą`** ir **`pavardę`**
 **n** atliktų namų darbų (nd) rezultatus (10-balėje sistemoje), o taip pat egzamino (egz) rezultatą.
Tuomet iš šių duomenų, suskaičiuoja galutinį balą **`(galutinis)`**:

#### Dokumentaciją galima rasti releases puslapyje parsisiuntus **`documentation.rar (naudota Doxygen)`**

# Užduotis v0.3 versijai
### Atlikite versijos (v0.2) kodo reorganizavimą (refactoring'ą):
#### Kur tikslinga, programoje naudokite (jeigu dar nenaudojote) struct'ūras;
#### Funkcijas, naujus duomenų tipus (struct’ūras) perkelkite į  atskiru (.cs)  failus, t.y.  tokiu būduturėtumete sukurtame projekte turėti kelis *.cs failus.
### Kur tikslinga, bent minimaliai panaudokite išimčių valdymą (angl. Exception, Exception Handling)
```
try{
// Code to try goes here.
}
catch (SomeSpecificExceptionex)
{
// Code to handle the exception goes here.
// Only catch exceptions that you know how to handle.
// Never catch base class System.Exception without
// rethrowing it at the end of the catch block.
}
```

##### `Kam viso to reikia?` O pvz. kas atsitiks, jeigu failas, kurį bandote atidaryti neegzistuoja; arba bandotegauti masyvo elementą, kuris neegzistuoja?

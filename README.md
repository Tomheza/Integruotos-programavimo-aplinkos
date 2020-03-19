# Integruotos-programavimo-aplinkos
## Užduoties formuluotė
> Parašykite programą, kuri nuskaito šiuos studentų duomenis:
**`vardą`** ir **`pavardę`**
 **n** atliktų namų darbų (nd) rezultatus (10-balėje sistemoje), o taip pat egzamino (egz) rezultatą.
Tuomet iš šių duomenų, suskaičiuoja galutinį balą **`(galutinis)`**:

#### *Galutinis = 0.3 * Vidurkis + 0.7 * Egzaminas*
## Functions
| ------ | ------ | ------ |
| ------ | ------ | ------ |
| addStudent() | Prideda studentą prie gobalaus List kreipiantis į `AddStudent()` funkciją| Integruotos_programavimo_aplinkos.helper.ScreenManager |
| AddStudent() | Prideda studentą į globalų List | Integruotos_programavimo_aplinkos.Students |
| addStudentArr() | Prideda studentą į globalų List naudojant masyvą | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| addStudentRnd() | Prideda studentą RND duomenim | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| Galutinis() | Apskaičiuoja galutinį balą palei formulę `*Galutinis = 0.3 * Vidurkis + 0.7 * Egzaminas*` | Integruotos_programavimo_aplinkos.helper.Formulas |
| Galutinis_mediana() | Apskaičiuoja galutinį balą mediana | Integruotos_programavimo_aplinkos.helper.Formulas |
| Galutinis_mediana_arr() | Apskaičiuoja galutinį balą mediana, naudojant masyvą| Integruotos_programavimo_aplinkos.helper.Formulas |
| menu() | Pagrindinė meniu funkcija | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| pause() | Padaro console lange pauzę | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| pauseClear() | Padaro console lange pauzę su ekrano išvalymu | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| printHelp() | Atspausdina pagalbinę informaciją (komandos) | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| printMenu() | Atspausdina meniu | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| printResults() | Atspausdina rezultatus (studentu duomenis) | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| printResultsMediana() | Atspausdina studentų duomenis mediana | Integruotos_programavimo_aplinkos.helper.ScreenManager |
|  printResultsMedianaArr() | Atspausdina studentų duomenis mediana, naudojant masyvą| Integruotos_programavimo_aplinkos.helper.ScreenManager |
| RemoveStudent() | Pašalina studentą | Integruotos_programavimo_aplinkos.Students |
| ScreenManager() | Konstruktorius | Integruotos_programavimo_aplinkos.helper.ScreenManager |
| Student() | Konstruktorius |Integruotos_programavimo_aplinkos.Student |

## Variables
| ------ | ------ |
| ------ | ------ | 
| students |Integruotos_programavimo_aplinkos.Program |
| studentsController | Integruotos_programavimo_aplinkos.helper.ScreenManager|
## Properties
| ------ | ------ |
| ------ | ------ | 
| exam | Integruotos_programavimo_aplinkos.Grades |
| grade | Integruotos_programavimo_aplinkos.Grades |
| grades | Integruotos_programavimo_aplinkos.Grades |
| gradesArr | Integruotos_programavimo_aplinkos.Grades |
| name | Integruotos_programavimo_aplinkos.Student |
| surname | Integruotos_programavimo_aplinkos.Student |



## Integruotos_programavimo_aplinkos.helper.Formulas Class Reference

#### Galutinis()
```csharp
static double Integruotos_programavimo_aplinkos.helper.Formulas.Galutinis (	double vidurkis,double egzaminas )	
```
**Returns the final grade**
Parameters:
| Parameter | description |
| ------ | ------ |
| vidurkis | avg of the grades |
| egzaminas | exam grade |

#### Galutinis_mediana()
```csharp
static double Integruotos_programavimo_aplinkos.helper.Formulas.Galutinis_mediana ( List<double> vidurkis, double egzaminas ) 	
```
**Returns the final grade**
Parameters:
| Parameter | description |
| ------ | ------ |
| vidurkis | avg of the grades |
| egzaminas | exam grade |

#### Galutinis_mediana_arr()
```csharp
static double Integruotos_programavimo_aplinkos.helper.Formulas.Galutinis_mediana_arr (double[] vidurkis, double egzaminas ) 	
```
**Returns the final grade**
Parameters:
| Parameter | description |
| ------ | ------ |
| vidurkis | avg of the grades |
| egzaminas | exam grade |

## Integruotos_programavimo_aplinkos.helper.ScreenManager Class Reference
### Public Member Functions
>	ScreenManager ()
 void printResults ()
 void printResultsMediana ()
 void printResultsMedianaArr ()
 void printMenu ()
 void pause ()
 void pauseClear ()
 void printHelp ()
 void addStudent ()
 void addStudentArr ()
 void addStudentRnd ()
 void menu ()
 
### Public Attributes
#### Students
```csharp
Students 	studentsController = new Students()
```
### Constructor & Destructor Documentation
#### ScreenManager()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.ScreenManager() 
```
#### addStudent()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.addStudent()
```
#### addStudentArr()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.addStudentArr()
```
#### addStudentRnd()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.addStudentRnd()
```
#### menu()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.menu()
```
#### pause()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.pause()
```
#### pauseClear()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.pauseClear()
```
#### printHelp()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.printHelp()
```
#### printMenu()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.printMenu()
```
#### printResults()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.printResults()
```
#### printResultsMediana()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.printResultsMediana()
```
#### printResultsMedianaArr()
```csharp
Integruotos_programavimo_aplinkos.helper.ScreenManager.printResultsMedianaArr()
```
## Integruotos_programavimo_aplinkos.Grades Class Reference
### Properties
```csharp
double grade[get, set]
double exam[get, set]
List<double> grades[get, set]
double[] gradesArr[get, set]
```
## Integruotos_programavimo_aplinkos.Program Class Reference
```csharp
static List<Student> students = new List<Student>()
```
## Integruotos_programavimo_aplinkos.Student Class Reference
### Properties
```csharp
string name[get, set]
string surname[get, set]
```
#### Properties inherited from Integroutos_programavimo_aplinkos.Grades
```csharp
double grade[get, set]
double exam[get, set]
List<double> grades[get, set]
double[] gradesArr[get, set]
```
### Constructor & Destructor Documentation
#### Student() [1/2]
```csharp
Integruotos_programavimo_aplinkos.Student.Student( string name, string  surname, double grade, double exam, List<double> grades) 	
```
Parameters:
| Parameter | description |
| ------ | ------ |
| name | Student name|
| surname | Student surname|
| grade | Student laboratory grade|
| exam | Student exam grade|
| grades | Grades list|
#### Student() [2/2]
```csharp
Integruotos_programavimo_aplinkos.Student.Student( string name, string  surname, double grade, double exam, double[] gradesArr) 	
```
Parameters:
| Parameter | description |
| ------ | ------ |
| name | Student name|
| surname | Student surname|
| grade | Student laboratory grade|
| exam | Student exam grade|
| gradesArr | Grades array|
## Integruotos_programavimo_aplinkos.Students Class Reference
#### AddStudent() [1/3]
```csharp
void Integruotos_programavimo_aplinkos.Students.AddStudent(string name, string surname, double grade, double exam, double[] gradesArr) 		
```
#### AddStudent() [2/3]
```csharp
void Integruotos_programavimo_aplinkos.Students.AddStudent(string name, string surname, double grade, double exam, List<double> grades ) 		
```
#### AddStudent() [3/3]
```csharp
void Integruotos_programavimo_aplinkos.Students.AddStudent(Student stud) 	
```
#### RemoveStudent()
```csharp
void Integruotos_programavimo_aplinkos.Students.RemoveStudent(string name, string surname) 	 	
```

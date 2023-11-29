// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// var myAge = 59;
int myAge2 = 120;
int newAge = myAge2 + 5;
// Console.WriteLine(newAge);

// liczby całkowite
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong muVar3 = ulong.MaxValue;
// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;
// zmiwnne tekstowe
string name = "Adam";
string surname = "Kamizelich";
string result = name + surname + myAge2;
// Console.WriteLine(result);

char myVar5 = 'c';
var result2 = name.ToArray();

// zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
// Console.WriteLine(isValid);

// ==
// !=
// >
// <
// >=
// <=

var number1 = 50;
var number2 = 10;

if (number1 < number2)
{
    Console.WriteLine("JESTEM TUTAJ W LINI 34");
}
else
{
    Console.WriteLine("JESTEM TUTAJ W LINI 38");
}

var name1 = "Adam";
var age = 33;
if (name1 == "Adam" && age < 50)
{
    Console.WriteLine("JESTEM ADAMEM PRZED 50.");
}
else
{
    Console.WriteLine("JESTEM KIMŚ INNYM");
}

// &&
// ||
// !

// Napisz w Program.cs kod, w którym który:
// - zadeklarujesz zmienną z imięniem
// - zadeklarujesz zmienną z płcią (dobierz zmien
// - zadeklarujesz zmienną z wiekiem
// - zweryfikujesz dane i wyświetlisz
// jeden z komunikatów:
// (1): "Kobieta poniżej 30 lat"
// (2): "Ewa, lat 33"
// (3): "Niepełnoletni Mężczyzna"

// (możesz dodać swoje)
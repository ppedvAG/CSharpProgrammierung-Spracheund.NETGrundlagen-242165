#region Arrays

int[] arrayOfNumbers = new int[5];
arrayOfNumbers[0] = 1;
arrayOfNumbers[1] = 2;
arrayOfNumbers[2] = 3;
arrayOfNumbers[3] = 4;
arrayOfNumbers[4] = 5;

// Seit C# 12 lassen sich Arrays so initialisieren
int[] numbers2 = [1, 2, 333, 4, -5];

var sum = arrayOfNumbers.Sum();
Console.WriteLine("Sum of numbers: " + sum);

var avg = arrayOfNumbers.Average();
Console.WriteLine("Average of numbers: " + avg);

char[] helloArray = { 'H', 'e', 'l', 'l', 'o' };

// intern ist ein string auch "nur" ein Array von chars
string helloString = new string(helloArray);
Console.WriteLine("4th letter of \"Hello\": " + helloArray[3]);
Console.WriteLine("4th letter of \"Hello\": " + helloString[3]);

// 2D Array muss immer gleichfoermig ("rechteckig") sein
var array2d = new int[,]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 /* , 7 */ }
};

var array3d = new int[3,2,2];

// Aneinander gehaengtes Array, also ein Array von Arrays
// und muss dann nicht gleichfoermig sein
var arrayOfArrays = new int[3][]
{
    [1, 2],
    [3, 4],
    [5, 6, 7, 8]
};

#endregion

#region Listen

// Array ist ein Datentyp
// Liste ist eine Klasse mit Methoden und Feldern
// Eine Liste ist im Gegensatz zu Arrays dynamisch erweiterbar und kann beliebig groß sein

var listOfNumbers = new List<int> { 1, 2, 3 };
listOfNumbers.Add(43);

List<int> listFromNumbers = arrayOfNumbers.ToList();
List<int> anotherListFromNumbers = new List<int>(arrayOfNumbers);

#endregion

#region Bedingen
// Boolsche Operatoren
// ==, !=, >, >=, <, <=
// Logische Operatoren
// &&, ||, !, ^

int n1 = 4, n2 = 5;

if (n1 > n2)
{
    Console.WriteLine("n1 > n2");
}
else if (n1 < n2)
{
    Console.WriteLine("n1 < n2");
}
else
{
    Console.WriteLine("n1 == n2");
}

Console.WriteLine("\nGlueckszahl generieren");
var randomInt = Random.Shared.Next(1, 10);
if (randomInt % 2 == 1)
{
    Console.WriteLine("Heutige Glueckszahl ist " + randomInt);
}
else
{
    Console.WriteLine("Heute keine Glueckszahl dabei!");
}

// Kurznotation (trinaerer Operator)
// Ergebnis, Zuweisung, Bedingung, true-Case, false-Case
var result = (n1 == n2) ? "n1 gleich n2" : "n1 ungleich n2";
Console.WriteLine("Trinaerer Vergleich: " + result);

// Beispiel String Vergleich
string person1 = "Hugo";
string person2 = "Julia";

if (person1.Equals(person2)) // person1 == person2
{
    Console.WriteLine("person1 == person2");
}
else
{
    Console.WriteLine("person1 != person2");
}

#endregion
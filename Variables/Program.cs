using System; // Frueher immer erforderlich; heute gibt es das Feature "Global using"

// Regions werden verwendet um Codebereiche zu gruppieren und ändern den Programmablauf nicht!
#region Variablen

int nummer = 20;
string wort = "Hallo";
char buchstabe = 'A';

int alter; // Deklaration
alter = 20; // Zuweisung

int doppeltesAlter = alter * 2;

//var gehtNicht; // Fehler weil keine direkte Zuweisung
var nochNeNummer = 42; //var erfordert Zuweisung um Typ zu bestimmen
var textMitUmbruch = "Hallo, \r\nWelt";

var konkatinierterText = "Text mit Variable " + nochNeNummer
    + " und einem Umbruch " + Environment.NewLine + " und blah...";

// Hier werden die Platzhalter {0} und {1} mit den Variablen alter und nummer ersetzt
var formattedText = string.Format("Text mit Variablen {0} und {1}", alter, nummer);

// Einfachere Alternative zu string.Format
var formattedTextSimpler = $"Text mit Variablen {alter} und {konkatinierterText}";


#endregion

#region Ein- und Ausgabe

Console.WriteLine("Enter your name:");

string? input; // Wenn wir ein ? hinter den Datentyp schreiben, kann der Wert null sein
input = Console.ReadLine(); // Hier lesen wir die Eingabe ein
Console.WriteLine($"Hello, {input}");

var info = Console.ReadKey(); // Hier lesen wir einen einzelnen Tastendruck ein
Console.WriteLine($"You pressed {info.Key}");

#endregion

#region Konvertierung

Console.WriteLine("Enter a integer number:");
string strEingabe = Console.ReadLine();
int intEingabe = int.Parse(strEingabe); // Parse wandelt einen string in einen int um

Console.WriteLine("Enter any number:");
string strNummer = Console.ReadLine();
int intNummer = int.Parse(strNummer);

string backToString = intNummer.ToString();

double precisionNumber = 3.64159;
float singlePrecisionNumber = 3.14159f; // Wir muessen f schreiben um den float zu deklarieren

// Cast, Typecast, Casting: Umwandlung von einer Variable in einen anderen Typen erzwingen
int intWert = (int)precisionNumber; // 3 weil nachkommastellen verloren gehen
double doubleWithoutDecimal = (double)singlePrecisionNumber;

Console.WriteLine($"Casted {precisionNumber} to int: {intWert}");

#endregion

#region Arithmetische Operationen

// Grundrechenarten +, -, *, /, %, ++, --
// % Modulo: Rest der Division

// = ist Zuweisungsoperator
// == ist Vergleichsoperator

var even = 42 % 2 == 0; // event = true
var odd = 43 % 2 == 0; // odd = false

nummer++; // erhoeht die Variable um 1
++nummer;
nummer--; // verringert die Variable um 1
--nummer;

#endregion
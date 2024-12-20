namespace ExceptionHandling.Test
{
    /// <summary>
    /// Grundsaetzliches Vorgehen beim Schreiben von Tests:
    /// 
    /// 1. Name der Klasse sollte der Name der zu testenden Klasse sein + Test als Suffix.
    /// 
    /// 2. Wir benennen die Methode nach folgendem Schema:
    ///    ZuTestendeMethode_Szenario_ErwartetesErgebnis
    ///    
    /// 3. Es ist empfehlenswert nach dem AAA Muster vorzugehen. D. h.
    ///    a) Arrange: Testdaten vorbereiten
    ///    b) Act: Die zu testende Methode aufrufen
    ///    c) Assert: Erwartetes Ergebnis pruefen
    ///    
    /// </summary>
    [TestClass]
    public sealed class ProgramTest
    {
        [TestMethod]
        public void ReadNumber_ValidNumber_ReturnsNumber()
        {
            // Arrange
            // Wir muessen hier nichts großartig vorbereiten
            var expected = 42;

            // Act
            var actual = Program.ReadNumber("42");

            // Assert
            Assert.AreEqual(expected, actual, "Die Zahl stimmt nicht überein!");
        }

        // Alternativ zu "DataRow" gibt es noch das Attribut "DynamicData"
        // Damit koennte man auch Objekte statt nur Primitives uebergeben
        // Typischerweise wuerden wir als Testwerte Edge-Cases verwenden
        // wie z. B. MinValue, MaxValue, 0, spezielle Zahlen usw.
        [TestMethod]
        [DataRow(42, "42")]
        [DataRow(-1, "-1"), DataRow(0, "0")]
        public void ReadNumber_ValidNumber_ReturnsNumber(int expected, string input)
        {
            // Wir sollten unnoetige Logik in den Tests vermeiden weswegen wir
            // ebenfalls den input als Parameter uebergeben
            // d. h. wir vermeiden den expected value in einen string umzuwandeln
            // (auch wenn das in diesem Szenario voellig trivial ist)
            // Weil streng genommen kann bei int.ToString() ein Fehler passieren

            // Act
            var actual = Program.ReadNumber(input);

            // Assert
            Assert.AreEqual(expected, actual, "Die Zahl stimmt nicht überein!");
        }

        [TestMethod]
        public void ReadNumber_InvalidNumber_ReturnsNull()
        {
            // Act
            var result = Program.ReadNumber("foo");

            // Assert
            Assert.IsNull(result, "Das Ergebnis sollte null sein!");
        }

        [TestMethod]
        public void ReadNumber_NullValue_ReturnsNull()
        {
            // Act
            var result = Program.ReadNumber(null);

            // Assert
            Assert.IsNull(result, "Das Ergebnis sollte null sein!");
        }

        [TestMethod]
        public void ReadNumber_UnluckyNumber_ThrowsUnluckyNumberException()
        {
            // Als Argument uebergeben wir eine sog. Lambda Expression
            // Wir uebergeben sozusagen die Adresse der Methode an sich statt 
            // sie selber vorher aufzurufen
            Assert.ThrowsException<UnluckyNumberException>(() => Program.ReadNumber("99"));
        }
    }
}

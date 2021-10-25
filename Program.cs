using Linq;

// Maak en vul een paar aandelen

var aandelen = new Aandeel[3];

aandelen[0] = new Aandeel() { Land = "VS", Naam = "Microsoft", Symbool = "MSTF" };
aandelen[1] = new Aandeel() { Land = "Nederland", Naam = "TomTom", Symbool = "TMOAF" };
aandelen[2] = new Aandeel() { Land = "VS", Naam = "Oracle", Symbool = "JAVA" };

aandelen[0].NieuweTransactie(new DateTime(2021, 10, 25), 235, 33.11, Transactie.TransactieTypen.Aankoop);
aandelen[0].NieuweTransactie(new DateTime(2021, 10, 26), 130, 35.12, Transactie.TransactieTypen.Verkoop);
aandelen[1].NieuweTransactie(new DateTime(2021, 10, 24), 125, 102.11, Transactie.TransactieTypen.Aankoop);
aandelen[1].NieuweTransactie(new DateTime(2021, 10, 26), 125, 102.98, Transactie.TransactieTypen.Verkoop);
aandelen[2].NieuweTransactie(new DateTime(2021, 10, 22), 650, 15.68, Transactie.TransactieTypen.Aankoop);
aandelen[2].NieuweTransactie(new DateTime(2021, 10, 26), 500, 15.72, Transactie.TransactieTypen.Verkoop);


// Gebruik een lambda-expressie om te selecteren
var lijstVS = aandelen.Where(x => x.Land == "VS" && x.Naam.StartsWith("M"));

// Doe hetzelfde met een linq-statement
var mijnLijst = from aandeel in aandelen
                where aandeel.Land == "VS" && aandeel.Naam.StartsWith("M")
                select aandeel;

// Toon de selectie in de console
foreach (Aandeel aandeel in mijnLijst)
{
    Console.WriteLine(aandeel.ToString());

    foreach (Transactie transactie in aandeel.Transacties)
        Console.WriteLine(transactie.ToString());
}

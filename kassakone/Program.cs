// See https://aka.ms/new-console-template for more information
Console.WriteLine("Anna nimi: !");
// Luo merkkijonomuuttuja
string tuotteen_nimi;
// Lue käyttäjän vastaus
tuotteen_nimi = Console.ReadLine();

// Kysy määrä
Console.WriteLine("Anna määrä: ");
// luo kokonaislukumuuttuja
int tuotteen_maara;
string maara_vastaus;
maara_vastaus = Console.ReadLine();
// Muuta vastaus lukuksi
tuotteen_maara = Convert.ToInt32
(maara_vastaus);

Console.WriteLine("Anna hinta: ");
int tuotteen_hinta;
string hinta_vastaus;
hinta_vastaus = Console.ReadLine();
tuotteen_hinta = Convert.ToInt32
(hinta_vastaus);


Console.WriteLine(tuotteen_nimi + "x" + tuotteen_maara + "=" + "kokonashinta : " + (tuotteen_maara * tuotteen_hinta));

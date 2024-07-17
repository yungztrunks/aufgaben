// ARRAYS

double[] mathe_noten_schriftlich = new double[4];
mathe_noten_schriftlich[0] = 4.25;
mathe_noten_schriftlich[1] = 2.0;
mathe_noten_schriftlich[2] = 5.0;
mathe_noten_schriftlich[3] = 3.5;
// Einzeln deklarieren

double[] englisch_noten_schriftlich = { 1.0, 2.0, 3.0, 4.0 };
// Auf einmal deklarieren

Console.WriteLine(englisch_noten_schriftlich[2]); // 3.0, weil 3. Element (ab 0 zählen)


// LISTEN

List<string> schülerliste = new List<string>();

schülerliste.Add("Antonios");
schülerliste.Add("Benni");
schülerliste.Add("Desi");
schülerliste.Add("Der Drache");
schülerliste.Add("Marc");
schülerliste.Add("Silvan");

// schülerliste.Remove("Der Drache");
// oder eben
// schülerliste.RemoveAt(3);

schülerliste.Sort(); // Alphabetisch sortieren

schülerliste.Insert(4, "Philipp"); // An 4. Stelle einfügen (Nach Marc)

// Wieviele Schüler?
Console.WriteLine(schülerliste.Count);

// 2025 - Ende Ausbildung
schülerliste.Clear();

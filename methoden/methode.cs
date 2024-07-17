static void vorstellen(string name, int alter)
{
    Console.WriteLine($"Hallo ich bin {name} und bin {alter} Jahre alt");
}

vorstellen("Philipp", 20);
vorstellen("Silvan", 21);


string[] viele_namen = new string[] { "Philipp", "Silvan", "Hans", "Peter", "Benjamin", "Florian", "Tobias"};
int[] alter = new int[] { 20, 21, 22, 23, 24, 25, 26};

for (int i = 0; i < viele_namen.Length; i++)
{
    vorstellen(viele_namen[i], alter[i]);
    // Stell dir vor man müsste das alles einzeln machen
    // Mit Methoden ist das viel einfacher und zentraler
}

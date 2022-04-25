using GestoreEventi;

Console.Write("Inserisci il nome dell'evento: ");
string titoloEventoSceltoDallUtente = Console.ReadLine();

Console.Write("Inserisci la data dell'evento: ");
DateTime dataDellEventoSceltaDallUtente = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci la capienza massima dell'evento: ");
int capienzaMassimaEventoSceltaDallUtente = int.Parse(Console.ReadLine());

Console.Write("Quanti posti desideri prenotare? ");
int numeroPostiPrenotatiDallUtente = int.Parse(Console.ReadLine());

Evento nuovoEvento = new Evento(titoloEventoSceltoDallUtente, dataDellEventoSceltaDallUtente, capienzaMassimaEventoSceltaDallUtente);

nuovoEvento.PrenotaPosti(numeroPostiPrenotatiDallUtente);

    Console.Write("Vuoi disdire dei posti [si/no] ? ");
    string sceltaDisdettaUtente = Console.ReadLine();

    if (sceltaDisdettaUtente == "si")
    {
        Console.Write("Inserisci il numero di posti da disdire: ");
        int sceltaNumeroPostiDisdettiDallUtente = int.Parse(Console.ReadLine());
        nuovoEvento.DisdiciPosti(sceltaNumeroPostiDisdettiDallUtente);
    } else if (sceltaDisdettaUtente == "no")
{
    nuovoEvento.ToString();
}

nuovoEvento.ToString();










/*
Console.WriteLine();
Console.WriteLine($"Numero di posti prenotati: {numeroPostiPrenotatiDallUtente}");
Console.WriteLine($"Numero di posti disponibili: {capienzaMassimaEventoSceltaDallUtente - numeroPostiPrenotatiDallUtente}");
Console.WriteLine();


nuovoEvento.DisdiciPosti(numeroPostiPrenotatiDallUtente);

Console.WriteLine();
Console.WriteLine($"Numero di posti prenotati: {numeroPostiPrenotatiDallUtente}");
Console.WriteLine($"Numero di posti disponibili: {capienzaMassimaEventoSceltaDallUtente - numeroPostiPrenotatiDallUtente}");
Console.WriteLine();
*/
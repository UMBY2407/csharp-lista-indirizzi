using csharp_lista_indirizzi;
List<Indirizzo> listaIndirizzi = new List<Indirizzo>();
try
{
	StreamReader file = File.OpenText("C:\\Users\\Umberto\\Desktop\\Informatica\\Corso Generation .NET\\esercizi C#\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\Lista\\addresses.csv");
	int contatoreRigheLette = 0;

	while (!file.EndOfStream)
	{
		string rigaIndirizzoLetta = file.ReadLine();
		contatoreRigheLette++;
		if(contatoreRigheLette > 1)
		{
			string[] informazioniSeparate = rigaIndirizzoLetta.Split(',');
			if(informazioniSeparate.Length != 6)
			{
				Console.WriteLine("La riga " + contatoreRigheLette + " non rispetta il numero delle informazioni richieste per l'indirizzo per riga");
			}
			else
			{
				int cap = int.Parse(informazioniSeparate[5]);
				try
				{
					Indirizzo IndirizzoLetto = new Indirizzo(informazioniSeparate[0], informazioniSeparate[1], informazioniSeparate[2], informazioniSeparate[3], informazioniSeparate[4], cap);
					listaIndirizzi.Add(IndirizzoLetto);
				}catch (ArgumentException e)
				{
					Console.WriteLine("C'è stato un errore durante la lettura dell'indirizzo, alla riga n°" + contatoreRigheLette);
					Console.WriteLine(e.Message);
				}
			}
		}
	}
}
catch (Exception e)
{
	Console.WriteLine("Qualcosa è andato storto...");
	Console.WriteLine(e.Message);
}

foreach(Indirizzo indirizzo in listaIndirizzi)
{
	Console.WriteLine(indirizzo);
}
﻿using Aliante_Astratto.Aliante.Ruota;
using Aliante_Astratto.Aliante;
using static System.Console;

namespace Aliante_Astratto
{
	internal class Program
	{
		static void Main()
		{
			WriteLine("Inserimento automatico? (y)es/(Any)No");
			if(ReadKey(true).KeyChar == 'y')
			{
				Aliante.Aliante auto = new Aliante.Aliante(new Ala(10f,10f), new Fusoliera("aria",10f), new Coda(10f), new Ruota(new Cerchione(10f,"aria"),new Gomma(10f,10f,10f)));

				WriteLine("Inserire errore? (y)es/(Any)No");
				if(ReadKey(true).KeyChar == 'y')
					auto.Add(new Gomma(10f, 10f, 10f));

				WriteLine("descrizione\n" + auto.Details());
				WriteLine("\nPrezzo\n" + auto.Price().ToString("C") + "(euro)");
				return;
			}

			float ChechInput(string displayText)
			{
				WriteLine(displayText);
				float fvar;
				while(!float.TryParse(ReadLine(), out fvar) || fvar <= 0)
				{//bad input
					WriteLine("numero decimale positivo");
				}
				return fvar;
			}
			string DisplayInput(string displayText)
			{
				WriteLine(displayText);
				return ReadLine();
			}

			Clear();

			Ala ala = new Ala(
				ChechInput("COSTRUIAMO UN ALIANTE INSIEME!\n\nCominciamo dalle ali, che saranno ovviamente due uguali.\n" +
				"Quale sarà la lunghezza di un ala?"),
				ChechInput("Dopodiché la loro apertura:")
			);


			Fusoliera fusoliera = new Fusoliera(
				DisplayInput("Ora invece pensiamo già alla fusoliera, di che materiale sarà?"),
				ChechInput("Adesso la sua lunghezza:")
				);

			Coda coda = new Coda(
				ChechInput("Bene, bene.. Ora tocca alla coda, quanto lunga?")
				);

			Cerchione cerchione = new Cerchione(
				ChechInput("Finalmente le ruote, di cui la singola si divide innanzitutto in Cerchione e Gomma.\n" +
				"Partiamo dai pollici del cerchione:"),
				DisplayInput("E ovviamente il materiale:")
				);
			
			Gomma gomma = new Gomma(
				ChechInput("La gomma invece è un pò complicata.. ma ce la possiamo fare!\nCi servono solo 3 misure, l'altezza:"),
				ChechInput("la larghezza:"),
				ChechInput("e il raggio:")
				);

			WriteLine("\nPossiamo finalmente creare tutte le ruote!");
			Ruota ruota = new Ruota(cerchione, gomma);

			WriteLine("E, dopo questo lungo lavoro, finalmente l'aliante!!!");
			Aliante.Aliante aliante = new Aliante.Aliante(ala, fusoliera, coda, ruota);

			WriteLine("Ecco la descrizione dell'aliante che abbiamo creato:\n" + aliante.Details());
			WriteLine("\nEd, ovviamente, ecco il conto, nel caso accetto anche pagamenti in dollari, rateizzati e in natura!\n"
				+ aliante.Price().ToString("C")
				+ "(euro)");
		}
	}
}

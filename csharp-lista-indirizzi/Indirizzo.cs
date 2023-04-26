using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
	public class Indirizzo
	{
		private string name;
		private string surname;
		private string street;
		private string city;
		private string province;
		private string zip;
		
		//COSTRUTTORE
		public Indirizzo(string nome, string cognome, string strada, string citta, string provincia, string cap)
		{
			this.name = nome;
			this.surname = cognome;
			this.street = strada;
			this.city = citta;
			this.province = provincia;
			this.zip = cap;
			if(this.zip.Length > 5)
			{
				throw new ArgumentException("Il codice postale supera il numero di cifre!", "cap");
			}
		}

		//GETTERS

		public string GetName()
		{
			return this.name;
		}

		public string GetSurname()
		{
			return this.surname;
		}

		public string GetStreet()
		{
			return this.street;
		}

		public string GetCity()
		{
			return this.city;
		}

		public string GetProvince()
		{
			return this.province;
		}

		public string GetZip()
		{
			return this.zip;
		}

		//METODI
		public override string ToString()
		{
			string stringa = $"--------- Indirizzo di {this.name} {this.surname} ---------\n";
			stringa += $"\tVia: {this.street}\n";
			stringa += $"\tCittà: {this.city}\n";
			stringa += $"\tProvincia: {this.province}\n";
			stringa += $"\tZIP: {this.zip}\n";
			stringa += "-----------------------------------";
			return stringa;
		}
	}
}

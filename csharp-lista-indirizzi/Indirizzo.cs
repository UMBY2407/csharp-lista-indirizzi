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
		private int zip;
		
		//COSTRUTTORE
		public Indirizzo(string nome, string cognome, string strada, string citta, string provincia, int cap)
		{
			this.name = nome;
				if(this.name == "")
				{
					throw new ArgumentException("Il nome non esiste!","name");
				}
			this.surname = cognome;
				if (this.surname == "")
				{
					throw new ArgumentException("Il cognome non esiste!", "surname");
				}
			this.street = strada;
				if (this.street == "")
				{
					throw new ArgumentException("La strada non esiste!", "street");
				}
			this.city = citta;
			if (this.city == "")
			{
				throw new ArgumentException("La città non esiste!", "city");
			}
			this.province = provincia;
			if (this.street == "")
			{
				throw new ArgumentException("La provincia non esiste!", "province");
			}
			this.zip = cap;
			if(this.zip.ToString().Length > 5)
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

		public int GetZip()
		{
			return this.zip;
		}

		//METODI
		public override string ToString()
		{
			string stringa = $"--------- Indirizzo di {this.surname}, {this.name} ---------\n";
			stringa += $"\tVia: {this.street}\n";
			stringa += $"\tCittà: {this.city}\n";
			stringa += $"\tProvincia: {this.province}\n";
			stringa += $"\tZIP: {this.zip}\n";
			stringa += "----------------------------------------------------";
			return stringa;
		}
	}
}

using System.Collections.Generic;

namespace Aliante_Astratto.Aliante
{
	internal class Aliante : Componente
	{
		private List<Componente> _componenti;

		public List<Componente> Componenti
		{ get { return _componenti; } set { _componenti = value; } }

		public Aliante() => Componenti = new List<Componente>();

		public Aliante(Ala ala, Fusoliera fusoliera, Coda coda, Ruota.Ruota ruota) =>
			Componenti = new List<Componente> { ala, ala, fusoliera, coda, ruota, ruota };

		public Aliante(Aliante aliante) => Componenti = aliante.Componenti;

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Aliante aliante
			&& !(aliante is null)
			&& Componenti == aliante.Componenti;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString()
		{
			string ret = null;
			for(int i = 0; i < Componenti.Count; ++i)
				ret += $"{Componenti[i]};";
			return ret.Remove(ret.Length-1);
		}

		public override string Details()
		{
			string ret = "";
			Dictionary<Pezzi, bool> check = new Dictionary<Pezzi, bool>
			{
				{Pezzi.Ala, false},
				{Pezzi.Fusoliera, false},
				{Pezzi.Coda, false},
				{Pezzi.Ruota, false},
			};
			try
			{
				for(int i = 0; i < Componenti.Count; ++i)
				{
					Pezzi pezzo = Componenti[i].MyEnum();
					if(check[pezzo]) continue;
					ret += Componenti[i].Details() + "\r\n";
					check[pezzo] = true;
				}
			}
			catch(KeyNotFoundException ex)
			{
				System.Console.WriteLine("\nInserito componente non valido nell'aliante\nStampare l'eccezione generata? (y)es/(Any)No");
				if(System.Console.ReadKey(true).KeyChar == 'y')
					throw ex;
				System.Environment.Exit(-1);
			}

			return ret;
		}

		public override float Price()
		{
			float ret = 0;
			for(int i = 0; i < Componenti.Count; ++i) ret += Componenti[i].Price();
			return ret;
		}

		public override void Add(Componente componente) => Componenti.Add(componente);

		public override void Remove(int ind) => Componenti.RemoveAt(ind);

		public override string GetChild(int ind) => Componenti[ind].ToString();

		public override Pezzi MyEnum() => Pezzi.Aliante;
	}
}

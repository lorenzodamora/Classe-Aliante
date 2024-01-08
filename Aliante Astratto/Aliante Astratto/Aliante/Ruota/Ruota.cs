namespace Aliante_Astratto.Aliante.Ruota
{
	internal class Ruota : Componente
	{
		private Gomma _gomma;
		private Cerchione _cerchione;

		public Cerchione Cerchione
		{ get { return _cerchione; } set { _cerchione = value; } }
		
		public Gomma Gomma
		{ get { return _gomma; } set { _gomma = value; } }

		public Ruota()
		{
			Cerchione = new Cerchione();
			Gomma = new Gomma();
		}

		public Ruota(Cerchione cerchione, Gomma gomma)
		{
			Cerchione = cerchione;
			Gomma = gomma;
		}

		public Ruota(Ruota rt)
		{
			Cerchione = rt.Cerchione;
			Gomma = rt.Gomma;
		}

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Ruota ruota
			&& !(ruota is null)
			&& ruota.Gomma.Equals(Gomma)
			&& ruota.Cerchione.Equals(Cerchione);


		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() => $"{Gomma};{Cerchione}";

		public override string Details() =>  $"{Cerchione.Details()}\r\n{Gomma.Details()}" ;

		public override float Price() => Cerchione.Price() + Gomma.Price();

		public override void Add(Componente cpm) => throw new System.NotImplementedException();

		public override void Remove(int ind) => throw new System.NotImplementedException();

		public override string GetChild(int ind) => throw new System.NotImplementedException();

		public override Pezzi MyEnum() => Pezzi.Ruota;

	}
}

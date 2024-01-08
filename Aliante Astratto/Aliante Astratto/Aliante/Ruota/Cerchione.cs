namespace Aliante_Astratto.Aliante.Ruota
{
	internal class Cerchione : Componente
	{
		private float _pollici;
		private string _materiale;

		public float Pollici
		{ get { return _pollici; } set { _pollici = value; } }

		public string Materiale
		{ get { return _materiale; } set { _materiale = value; } }

		public Cerchione() => throw new System.NotImplementedException();

		public Cerchione(float pollici, string materiale)
		{
			Pollici = pollici;
			Materiale = materiale;
		}

		public Cerchione(Cerchione cerchione)
		{
			Pollici = cerchione.Pollici;
			Materiale = cerchione.Materiale;
		}

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Cerchione cerchione
			&& !(cerchione is null)
			&& Pollici == cerchione.Pollici
			&& Materiale == cerchione.Materiale;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() => $"{Materiale};{Pollici}";

		public override string Details() => $"Il materiale del cerchione è {Materiale} e i suoi pollici sono {Pollici}";

		public override float Price() => Pollici * 2;

		public override void Add(Componente cpm) => throw new System.NotImplementedException();

		public override void Remove(int ind) => throw new System.NotImplementedException();

		public override string GetChild(int ind) => throw new System.NotImplementedException();

		public override bool IsComposite() => false;

		public override Pezzi MyEnum() => Pezzi.Cerchione;
	}
}

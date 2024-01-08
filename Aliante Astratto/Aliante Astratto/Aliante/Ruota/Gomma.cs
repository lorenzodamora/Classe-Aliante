namespace Aliante_Astratto.Aliante.Ruota
{
	internal class Gomma : Componente
	{
		private float _altezza;
		private float _larghezza;
		private float _raggio;

		public float Altezza
		{ get { return _altezza; } set { _altezza = value; } }
		
		public float Larghezza
		{ get { return _larghezza; } set { _larghezza = value; } }
		
		public float Raggio
		{ get { return _raggio; } set { _raggio = value; } }

		public Gomma() => throw new System.NotImplementedException();

		public Gomma(float altezza, float larghezza, float raggio)
		{
			Altezza = altezza;
			Larghezza = larghezza;
			Raggio = raggio;
		}

		public Gomma(Gomma gomma)
		{
			Altezza = gomma.Altezza;
			Larghezza = gomma.Larghezza;
			Raggio = gomma.Raggio;
		}

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Gomma gomma
			&& !(gomma is null)
			&& Altezza == gomma.Altezza
			&& Larghezza == gomma.Larghezza
			&& Raggio == gomma.Raggio;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() => $"{Altezza};{Larghezza};{Raggio}";

		public override string Details() => $"L'altezza della gomma è {Altezza}, la sua larghezza è {Larghezza} e il suo raggio è {Raggio}";

		public override float Price() => Altezza * Larghezza * Raggio;

		public override void Add(Componente cpm) => throw new System.NotImplementedException();

		public override void Remove(int ind) => throw new System.NotImplementedException();

		public override string GetChild(int ind) => throw new System.NotImplementedException();

		public override bool IsComposite() => false;

		public override Pezzi MyEnum() => Pezzi.Gomma;
	}
}

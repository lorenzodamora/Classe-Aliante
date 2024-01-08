namespace Aliante_Astratto.Aliante
{
	internal class Ala : Componente
	{
		private float _lunghezza;
		private float _apertura;

		public float Lunghezza
		{ get { return _lunghezza; } set { _lunghezza = value; } }

		public float Apertura
		{ get { return _apertura; } set { _apertura = value; } }

		public Ala() => throw new System.NotImplementedException();

		public Ala(float lunghezza, float apertura)
		{
			Lunghezza = lunghezza;
			Apertura = apertura;
		}

		public Ala(Ala ala)
		{
			Lunghezza = ala.Lunghezza;
			Apertura = ala.Apertura;
		}

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Ala ala
			&& !(ala is null)
			&& Lunghezza == ala.Lunghezza
			&& Apertura == ala.Apertura;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() => $"{Lunghezza};{Apertura}";

		public override string Details() => $"La lunghezza dell'ala è {Lunghezza} e la sua apertura è {Apertura}";

		public override float Price() => Lunghezza * Apertura;

		public override void Add(Componente cpm) => throw new System.NotImplementedException();

		public override void Remove(int ind) => throw new System.NotImplementedException();

		public override string GetChild(int ind) => throw new System.NotImplementedException();

		public override bool IsComposite() => false;

		public override Pezzi MyEnum() => Pezzi.Ala;
	}
}

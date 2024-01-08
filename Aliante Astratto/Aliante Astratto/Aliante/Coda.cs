namespace Aliante_Astratto.Aliante
{
	internal class Coda : Componente
	{
		private float _lunghezza;

		public float Lunghezza
		{ get { return _lunghezza; } set { _lunghezza = value; } }

		public Coda() => throw new System.NotImplementedException();

		public Coda(float lun) => Lunghezza = lun;

		public Coda(Coda coda) => Lunghezza = coda.Lunghezza;

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Fusoliera fus
			&& !(fus is null)
			&& Lunghezza == fus.Lunghezza;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() => Lunghezza.ToString();

		public override string Details() => $"La lunghezza della coda è {Lunghezza}";

		public override float Price() => Lunghezza * 5;

		public override void Add(Componente cpm) => throw new System.NotImplementedException();

		public override void Remove(int ind) => throw new System.NotImplementedException();

		public override string GetChild(int ind) => throw new System.NotImplementedException();

		public override bool IsComposite() => false;
		public override Pezzi MyEnum() => Pezzi.Coda;
	}
}

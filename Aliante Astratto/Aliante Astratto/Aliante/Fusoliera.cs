namespace Aliante_Astratto.Aliante
{
	internal class Fusoliera : Componente
	{
		private string _materiale;
		private float _lunghezza;

		public string Materiale
		{ get { return _materiale; } set { _materiale = value; } }
		
		public float Lunghezza
		{ get { return _lunghezza; } set { _lunghezza = value; } }

		public Fusoliera() => throw new System.NotImplementedException();

		public Fusoliera(string mat, float lun)
		{
			Materiale = mat;
			Lunghezza = lun;
		}

		public Fusoliera(Fusoliera fus)
		{
			Materiale = fus.Materiale;
			Lunghezza = fus.Lunghezza;
		}

		public override bool Equals(object obj) =>
			!(obj is null)
			&& obj is Fusoliera fus
			&& !(fus is null)
			&& Lunghezza == fus.Lunghezza
			&& Materiale == fus.Materiale;

		public override int GetHashCode() => base.GetHashCode();

		public override string ToString() => $"{Materiale};{Lunghezza}";

		public override string Details() => $"Il materiale della fusoliera è {Materiale} e la sua lunghezza è {Lunghezza}";

		public override float Price() => Lunghezza * 3f;

		public override void Add(Componente cpm) => throw new System.NotImplementedException();

		public override void Remove(int ind) => throw new System.NotImplementedException();

		public override string GetChild(int ind) => throw new System.NotImplementedException();

		public override bool IsComposite() => false;

		public override Pezzi MyEnum() => Pezzi.Fusoliera;
	}
}

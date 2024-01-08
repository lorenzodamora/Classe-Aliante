namespace Aliante_Astratto.Aliante
{
	internal abstract class Componente
	{
		public abstract string Details();
		public abstract float Price();
		public abstract void Add(Componente cmp);
		public abstract void Remove(int ind);
		public abstract string GetChild(int ind);
		public virtual bool IsComposite() => true;
		public virtual Pezzi MyEnum() => Pezzi.Composite;

		internal enum Pezzi
		{
			Composite = -1,
			Aliante = 0,
			Ala = 1,
			Fusoliera = 2,
			Coda = 3,
			Ruota = 4,
			Cerchione = 5,
			Gomma = 6
		}
	}
}

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
	}
}

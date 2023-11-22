namespace Entidades
{
    public class ListaGenerica<T>
    {
        List<T> lista;

        public ListaGenerica()
        {
            this.lista = new List<T>();
        }
        public void Push(T elemento)
        {
            lista.Add(elemento);
        }
        public void Delete()
        {
            lista.Clear();
        }
        public int Largo
        {
            get { return lista.Count; }
        }
        public bool Contains(T elemento)
        {
            return lista.Contains(elemento);
        }


    }
}

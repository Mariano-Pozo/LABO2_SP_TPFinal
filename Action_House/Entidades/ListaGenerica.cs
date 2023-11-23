namespace Entidades
{
    public class ListaGenerica<T>
    {
        private List<T> lista;

        /// <summary>
        /// Constructor de la clase ListaGenerica.
        /// </summary>
        public ListaGenerica()
        {
            this.lista = new List<T>();
        }

        /// <summary>
        /// Agrega un elemento a la lista.
        /// </summary>
        /// <param name="elemento">Elemento a agregar.</param>
        public void Push(T elemento)
        {
            lista.Add(elemento);
        }

        /// <summary>
        /// Elimina todos los elementos de la lista.
        /// </summary>
        public void Delete()
        {
            lista.Clear();
        }

        /// <summary>
        /// Obtiene el número de elementos en la lista.
        /// </summary>
        public int Largo
        {
            get { return lista.Count; }
        }

        /// <summary>
        /// Comprueba si un elemento está presente en la lista.
        /// </summary>
        /// <param name="elemento">Elemento a comprobar.</param>
        /// <returns>True si el elemento está en la lista; de lo contrario, False.</returns>
        public bool Contains(T elemento)
        {
            return lista.Contains(elemento);
        }
    }
}

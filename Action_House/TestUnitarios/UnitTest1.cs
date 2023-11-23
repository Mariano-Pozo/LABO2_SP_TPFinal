using Entidades;
namespace TestUnitarios
{
    /// <summary>
    /// Clase que contiene pruebas unitarias para la clase ListaGenerica.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Verifica si un nombre se agrega correctamente a la lista.
        /// </summary>
        [TestMethod]
        public void Nombre_deberia_agregarloALaLista()
        {
            ListaGenerica<string> listaGenerica = new ListaGenerica<string>();
            string nombreAgregado = "Daniela";
            listaGenerica.Push(nombreAgregado);
            Assert.IsTrue(listaGenerica.Contains(nombreAgregado));
        }

        /// <summary>
        /// Verifica si un nombre se borra correctamente de la lista.
        /// </summary>
        [TestMethod]
        public void Nombre_deberia_borrarloDeLaLista()
        {
            ListaGenerica<string> listaGenerica = new ListaGenerica<string>();
            string nombreAgregado = "Daniela";
            listaGenerica.Push(nombreAgregado);
            listaGenerica.Delete();
            Assert.AreEqual(0, listaGenerica.Largo);
        }
    }

}


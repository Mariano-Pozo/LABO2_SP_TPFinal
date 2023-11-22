using Entidades;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Nombre_deberia_agregarloALaLista()
        {
            ListaGenerica<string> listaGenerica = new ListaGenerica<string>();
            string nombreAgregado = "Daniela";
            listaGenerica.Push(nombreAgregado);
            Assert.IsTrue(listaGenerica.Contains(nombreAgregado));
        }
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
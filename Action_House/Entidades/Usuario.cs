using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    /// <summary>
    /// Clase que contiene nombre y contraseña.
    /// </summary>
    public class Usuario
    {
        private string nombre;
        private string contrasenia;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
    }
}

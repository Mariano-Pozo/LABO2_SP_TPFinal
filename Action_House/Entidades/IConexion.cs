using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public interface IConexion
    {
        
        public SqlConnection GetConexion();
        public void AbrirConexion();
        public void CerrarConexion();

    }
}

using Entidades;
namespace Form1
{
    public class LoginHelper
    {
        public static bool Login(string usuario, string pass)
        {
           
            return LoginRepository.Login(usuario, pass);
        }
    }
}
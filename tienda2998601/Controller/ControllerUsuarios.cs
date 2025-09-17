using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda2998601.Model;

namespace tienda2998601.Controller
{
    public class ControllerUsuarios
    {
        private readonly Tienda2998601Context _context;

        public ControllerUsuarios()
        {
            _context = new Tienda2998601Context();
        }

        public bool ValidarIngreso(string usuario, string pass) 
        {
            Usuario usu = _context.Usuarios.FirstOrDefault(u => u.usuario == usuario && u.pass == pass);
            if (usu == null)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Persona
    {
        private int dni;
        private string nombre;
        private DateTime fechaNac;

        public Persona(int unDni,string unNom,DateTime unaFN)
        {
            this.dni = unDni;
            nombre = unNom;
            fechaNac = unaFN;
        }
        public Persona()
        {

        }

        public int Dni
        {
            set { dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value;  }
        }

        public DateTime FechaNac
        {
            set { fechaNac = value; }
        }
        public int edad()
        {
            DateTime hoy = DateTime.Today;
            int e = hoy.Year - fechaNac.Year;
            if (hoy.Month < fechaNac.Month)
                e--;
            else
            {
                if (hoy.Month==fechaNac.Month && hoy.Day < fechaNac.Day)
                    e--;
            }
            return e;
        }
    }
}

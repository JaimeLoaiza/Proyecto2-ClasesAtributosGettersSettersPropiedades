using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónClasesAtributosGettersSettersPropiedades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        //private string numeroDeDocumento;
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string numeroDeDocumento { get; set; }
    }
}

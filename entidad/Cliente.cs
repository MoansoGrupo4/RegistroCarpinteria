using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCarpinteria.entidad
{
    class Cliente
    {
        private string IdCliente;
        private string NomCliente;
        private string ApellidoCliente;
        private string dirCliente;

        public Cliente()
        {
            this.IdCliente = "";
            this.NomCliente = "";
            this.ApellidoCliente = "";
            this.dirCliente = "";
        }

        public string IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public string NomCliente1 { get => NomCliente; set => NomCliente = value; }
        public string ApellidoCliente1 { get => ApellidoCliente; set => ApellidoCliente = value; }
        public string DirCliente { get => dirCliente; set => dirCliente = value; }
    }
}

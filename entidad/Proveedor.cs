using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCarpinteria.entidad
{
    class Proveedor
    {
        private string CodProveedor;
        private string NomProveedor;
        private string DirProveedor;
        private string TelfProveedor;

        public Proveedor()
        {
            this.CodProveedor = "";
            this.NomProveedor = "";
            this.DirProveedor = "";
            this.TelfProveedor = "";
        }

        public string CodProveedor1 { get => CodProveedor; set => CodProveedor = value; }
        public string NomProveedor1 { get => NomProveedor; set => NomProveedor = value; }
        public string DirProveedor1 { get => DirProveedor; set => DirProveedor = value; }
        public string TelfProveedor1 { get => TelfProveedor; set => TelfProveedor = value; }
    }
}

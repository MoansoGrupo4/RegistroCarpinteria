using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCarpinteria.entidad
{
    class Empleado
    {
        private string IdEmpleado;
        private string NomEmpleado;
        private string ApellidoEmpleado;
        private string FuncionEmpleado;
        private string DirEmpleado;
        private int DNIEmpleado;
        private int EdadEmpleado;
        private string FechaEmpleado;

        public Empleado()
        {
            this.IdEmpleado = "";
            this.NomEmpleado = "";
            this.ApellidoEmpleado = "";
            this.FuncionEmpleado = "";
            this.DirEmpleado = "";
            this.DNIEmpleado = 0;
            this.EdadEmpleado = 0;
            this.FechaEmpleado = "";
        }

        public string IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public string NomEmpleado1 { get => NomEmpleado; set => NomEmpleado = value; }
        public string ApellidoEmpleado1 { get => ApellidoEmpleado; set => ApellidoEmpleado = value; }
        public string FuncionEmpleado1 { get => FuncionEmpleado; set => FuncionEmpleado = value; }
        public string DirEmpleado1 { get => DirEmpleado; set => DirEmpleado = value; }
        public int DNIEmpleado1 { get => DNIEmpleado; set => DNIEmpleado = value; }
        public int EdadEmpleado1 { get => EdadEmpleado; set => EdadEmpleado = value; }
        public string FechaEmpleado1 { get => FechaEmpleado; set => FechaEmpleado = value; }
    }
}

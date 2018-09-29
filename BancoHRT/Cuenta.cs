using System;
using System.Collections.Generic;
using System.Text;

namespace BancoHRT
{
    public class Cuenta
    {
        private int NIP;

        public int PropiedadNIP
        {
            get { return NIP; }
            set { NIP = value; }
        }
        private string numCuenta;

        public string PropiedadNumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }
        private string usuario;

        public string PropiedadUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}

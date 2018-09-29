using System;
using System.Collections.Generic;
using System.Text;

namespace BancoHRT
{
    public class Banco
    {
        private Cliente []listaClientes;

        public Banco()
        {
            //throw new System.NotImplementedException();
        }

        public Cliente []PropiedadListaClientes
        {
            get { return listaClientes; }
            set { listaClientes = value; }
        }
    }
}

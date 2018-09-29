using System;
using System.Collections.Generic;
using System.Text;

namespace BancoHRT
{
    public class Cliente
    {
        private string nombre;
        private string direccion;

        public string PropiedadDireccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string email;

        public string PropiedadEmail
        {
            get { return email; }
            set { email = value; }
        }

        public Cliente(string nombre, string dir, string email)
        {
            this.nombre = nombre;
            this.direccion = dir;
            this.email = email;
            //throw new System.NotImplementedException();
        }

        public string PropiedadNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Crear_Cuenta()
        {
            //throw new System.NotImplementedException();
        }
    }
}

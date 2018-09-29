using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BancoHRT
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        int cont = 0;
        Cliente[] c;
        public Form1()
        {
            InitializeComponent();
            banco.PropiedadListaClientes = new Cliente[10];
        }

        private void btnGuardat_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string email = txtEmail.Text.Trim();
            c = banco.PropiedadListaClientes;
            rtbMostrar.Text = "";

            if (nombre.CompareTo("") != 0 && direccion.CompareTo("")!=0 && email.CompareTo("")!=0)
            {
                if (cont < 9)
                {
                    c[cont] = new Cliente(nombre, direccion, email);
                    cont++;
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtEmail.Text = "";
                }
                else MessageBox.Show("Pendejo ya metiste 10 no le caben mas registros!!");
            }
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            c = banco.PropiedadListaClientes; //Compartiendo referencias
            for (int i = 0; i < banco.PropiedadListaClientes.Length; i++)
            {
                Cliente cliente = (Cliente)c[i];
                if (cliente != null)
                {
                    rtbMostrar.AppendText("Nombre: " + cliente.PropiedadNombre + "\n" +
                        "Direccion: " + cliente.PropiedadDireccion + "\n" +
                        "Email: " + cliente.PropiedadEmail + "\n");
                }
            }

            /*foreach (Cliente c in banco.PropiedadListaClientes)
            {
                Cliente cliente = (Cliente)c[i];
                if(c != null)
                    rtbMostrar.AppendText("Nombre: " + cliente.PropiedadNombre + "\n" +
                              "Direccion: " + cliente.PropiedadDireccion + "\n" +
                              "Email: " + cliente.PropiedadEmail + "\n");
            }*/
        }
    }
}
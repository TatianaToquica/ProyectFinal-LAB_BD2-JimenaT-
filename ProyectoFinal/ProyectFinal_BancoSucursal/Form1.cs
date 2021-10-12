using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectFinal_BancoSucursal.Logica;

namespace ProyectFinal_BancoSucursal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creo objetos de la Logica
        Sucursal sucur = new Sucursal();
        Banco bank = new Banco();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            //valido que se haya ingresado informacion            
            if (estalleno(txtCodSucursalElim.Text))
            {
                //capturo en una variable lo escrito en la caja de texto
                int cod = int.Parse(txtCodSucursalElim.Text);

                //envio la variable a la capa logica
                string respuesta = sucur.EliminarSucursalBanco(cod);
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("No ha ingresado el código de la sucursal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio la caja de texto
            txtCodSucursalElim.Text = "";
        }

        private void btnRegistrarBanco_Click(object sender, EventArgs e)
        {
            //valido que se haya ingresado informacion            
            if (estalleno(txtNitBanco.Text) && estalleno(txtNomBanco.Text))
            {
                //capturo las valores ingresados en variables
                int nit = int.Parse(txtNitBanco.Text);
                string nombre = txtNomBanco.Text;
                string fecha = calFechaBanco.SelectionStart.Date.Day + "/" + calFechaBanco.SelectionStart.Date.Month + "/" + calFechaBanco.SelectionStart.Date.Year;
                
                //envio las variables a la capa logica
                string respuesta = bank.RegistrarBanco(nit, nombre, fecha);
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("Ningún campo puede quedar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio las cajas de texto
            txtNitBanco.Text = "";
            txtNomBanco.Text = "";
            
        }

        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            //valido que se haya ingresado informacion            
            if (estalleno(txtCodSucursal.Text) && estalleno(txtNomSucursal.Text) && estalleno(cbxUbicSucursal.SelectedItem.ToString())
                && estalleno(txtNempSucursal.Text) && estalleno(txtAniosSucursal.Text) && estalleno(txtNitBancoSucursal.Text))
            {
                //capturo las valores ingresados en variables
                int cod = int.Parse(txtCodSucursal.Text);
                string nombre = txtNomSucursal.Text;
                string ubicacion = cbxUbicSucursal.SelectedItem.ToString();
                int numEmp = int.Parse(txtNempSucursal.Text);
                int anios = int.Parse(txtAniosSucursal.Text);
                int nitBanco = int.Parse(txtNitBancoSucursal.Text);

                //envio las variables a la capa logica
                string respuesta = sucur.RegistrarSucursalBanco(cod, nombre, ubicacion, numEmp, anios, nitBanco);
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("Ningún campo puede quedar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio las cajas de texto
            txtCodSucursal.Text = "";
            txtNomSucursal.Text = "";
            cbxUbicSucursal.Text = "";
            txtNempSucursal.Text = "";
            txtAniosSucursal.Text = "";
            txtNitBancoSucursal.Text = "";
        }

        private void btnConsultarSucursales_Click(object sender, EventArgs e)
        {
            //valido que se haya ingresado informacion            
            if (estalleno(txtNitBancoConsultS.Text)){
                //capturo el valor ingresado en una variable
                int nit = int.Parse(txtNitBancoConsultS.Text);
                DataSet dt = new DataSet();
                //envio la variable a la capa logica
                dt = sucur.ConsultarSucursalesBanco(nit);
                //valido si el DataSet dt se lleno
                if (dt.Tables.Count > 0)
                {
                    dgvDatos.DataSource = dt;
                    dgvDatos.DataMember = "Sucursales";
                }
                
            }
            else
            {
                MessageBox.Show("No ha ingresado el nit del banco", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNitBancoConsultS.Text = "";
            //dgvDatos.ClearSelection();
            
        }
        public static Boolean estalleno(string dato)
        {
            if (dato.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}

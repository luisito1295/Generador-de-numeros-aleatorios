using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void generar_Click(object sender, EventArgs e)
        {
         
            int i, linf, lsup, cn;

            linf = int.Parse(linferior.Text);
            lsup = int.Parse(lsuperior.Text);
            cn = int.Parse(cantidad.Text);
            Random rdn = new Random();
            for (i = 1; i <= int.Parse(cantidad.Text); i++)
                {
                    int numaleatorio = rdn.Next(linf, lsup);
                    numeros.Text = numeros.Text + i + ": " + numaleatorio.ToString() + ", ";
                    
                }
            generar.Enabled = false;
            
                                    
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            if (linferior.Text != ""  && lsuperior.Text != "" && cantidad.Text != "")
            {
                generar.Enabled = true;
                return;
            }
        }

        private void linferior_TextChanged(object sender, EventArgs e)
        {

            if (linferior.Text != "" && lsuperior.Text != "" && cantidad.Text != "")
            {
                generar.Enabled = true;
                return;
            }
        }

        private void lsuperior_TextChanged(object sender, EventArgs e)
        {
            if (lsuperior.Text == "")
            {
                return;
            }
            if (int.Parse(linferior.Text) > int.Parse(lsuperior.Text)) 
            {
                MessageBox.Show("El limite inferior NO debe ser igual o mayor al superior", "ERROR EN EL INGRESO DE DATOS");
                return;
            
            }
            if (linferior.Text != "" && lsuperior.Text != "" && cantidad.Text != "")
            {
                generar.Enabled = true;
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void numeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            linferior.Text = null ;
            lsuperior.Text = null;
            cantidad.Text = null ;
            numeros.Text = null;

            
        }

        private void Others_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void linferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (Convert.ToInt16(e.KeyChar) <48 || Convert.ToInt16(e.KeyChar) >57)
            {
                
                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;    
                
            }
            
        }

        private void lsuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }
    }
}
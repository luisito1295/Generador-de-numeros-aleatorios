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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Semilla_TextChanged(object sender, EventArgs e)
        {
            
            if (Semilla.Text != "" && Multi.Text != "" && Cons.Text != "" && modulo.Text != "" && Cantidad.Text != "" && Semilla.TextLength == 4 && int.Parse(modulo.Text) > int.Parse(Semilla.Text))
            {
                lineal.Enabled = true;
                multiplicador.Enabled = true;
                return;
            }
            else
            {
                lineal.Enabled = false;
                multiplicador.Enabled = false;
                return;
            }
        }

        private void msg_Click(object sender, EventArgs e)
        {

        }

        private void Multi_TextChanged(object sender, EventArgs e)
        {
            
            if (Semilla.Text != "" && Multi.Text != "" && Cons.Text != "" && modulo.Text != "" && Cantidad.Text != "" && Semilla.TextLength == 4 && int.Parse(modulo.Text) > int.Parse(Semilla.Text))
            {
                lineal.Enabled = true;
                multiplicador.Enabled = true;
                return;
            }
            else
            {
                lineal.Enabled = false;
                multiplicador.Enabled = false;
                return;
            }
        }
        
        private void Cons_TextChanged(object sender, EventArgs e)
        {
         
            if (Semilla.Text != "" && Multi.Text != "" && Cons.Text != "" && modulo.Text != "" && Cantidad.Text != "" && Semilla.TextLength == 4 && int.Parse(modulo.Text) > int.Parse(Semilla.Text))
            {
                lineal.Enabled = true;
                multiplicador.Enabled = true;
                return;
            }
            else
            {
                lineal.Enabled = false;
                multiplicador.Enabled = false;
                return;
            }
        }

        private void modulo_TextChanged(object sender, EventArgs e)
        {
            
            if (Semilla.Text != "" && Multi.Text != "" && Cons.Text != "" && modulo.Text != "" && Cantidad.Text != "" && Semilla.TextLength == 4 && int.Parse(modulo.Text) > int.Parse(Semilla.Text))
            {
                lineal.Enabled = true;
                multiplicador.Enabled = true;
                return;
            }
            else
            {
                lineal.Enabled = false;
                multiplicador.Enabled = false;
                return;
            }
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            
            if (Semilla.Text != "" && Multi.Text != "" && Cons.Text != "" && modulo.Text != "" && Cantidad.Text != "" && Semilla.TextLength == 4 && int.Parse(modulo.Text) > int.Parse(Semilla.Text))
            {
                lineal.Enabled = true;
                multiplicador.Enabled = true;
                return;
            }
            else
            {
                lineal.Enabled = false;
                multiplicador.Enabled = false;
                return;
            }
        }

        private void lineal_CheckedChanged(object sender, EventArgs e)
        {
            numeros.Text = null;
            int periodo = 0;           
            int x,a,c,mod,num;
            a=int.Parse(Multi.Text);//Multiplicador
            c=int.Parse(Cons.Text);//Contante
            x= int.Parse(Semilla.Text);//Semilla
            mod = int.Parse(modulo.Text);//Modulo
            num = int.Parse(Cantidad.Text);//Cantidad de numero generados
            while (periodo!= num )
            {                  
                 x = (a * x + c) % mod;
                 numeros.Text = numeros.Text + x + "- ";
                 periodo = periodo + 1;
                    
             }
        }

        private void multiplicador_CheckedChanged(object sender, EventArgs e)
        {
            numeros.Text = null;
            int periodo = 0;
            int x, a, c, mod, num;
            a = int.Parse(Multi.Text);
            c = int.Parse(Cons.Text);
            x = int.Parse(Semilla.Text);
            mod = int.Parse(modulo.Text);
            num = int.Parse(Cantidad.Text);
            while (periodo != num)
            {
                x = (a * x) % mod;
                numeros.Text = numeros.Text + x + "- ";
                periodo = periodo + 1;

            }
        }

        private void modulo_Enter(object sender, EventArgs e)
        {
            msg2.Visible = true;
        }

        private void modulo_Leave(object sender, EventArgs e)
        {
            msg2.Visible = false;
        }

        private void Semilla_Leave(object sender, EventArgs e)
        {
            msg.Visible = false;
        }

        private void Semilla_Enter(object sender, EventArgs e)
        {
            msg.Visible = true;
        }

        private void numeros_Enter(object sender, EventArgs e)
        {
            
        }

        private void Semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }

        private void Multi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }

        private void Cons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }

        private void modulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57)
            {

                MessageBox.Show("Ingrese datos numericos", "ERROR EN EL INGRESO DE DATOS");
                e.KeyChar = Convert.ToChar(Keys.None);
                return;

            }
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Semilla.Text = "";
            Multi.Text = "";
            Cons.Text = "";
            modulo.Text = "";
            Cantidad.Text = "";
            numeros.Text = "";
            
        }

        private void generar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

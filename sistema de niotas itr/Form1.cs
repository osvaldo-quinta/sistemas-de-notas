using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_niotas_itr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, promedio;
            if (string.IsNullOrEmpty(txtNota1.Text) || string.IsNullOrEmpty(txtNota2.Text) || string.IsNullOrEmpty(txtNota3.Text))

            {
                lblError.Text = "Existe un campo vacio \n por favor ingresa el dato que falta";
            } 
            else
            {
                nota_1=double.Parse(txtNota1.Text);
                nota_2= double.Parse(txtNota2.Text);
                nota_3= double.Parse(txtNota3.Text);
                if ((nota_1 > 10 || nota_1 > 0) || (nota_2 > 10 || nota_2 < 0) || (nota_3 > 10 || nota_3 < 0))
                {
                    lblError.Text = "porfavor ingresa un valor entre 0 y 10";

                }
                else {
                    promedio = (nota_1 + nota_2 + nota_3) / 3;
                    txtPromedio.Text = promedio.ToString("N2");
                    lblError.Text = string.Empty;
                
                }
            }

            
          
      
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

  

       
    }


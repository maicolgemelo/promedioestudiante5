using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prom_notascinco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nota1 = txtcalif1.Text;
            string nota2 = txtcalif2.Text;
            string nota3 = txtcalif3.Text;
            string nota4 = txtcalif4.Text;
            string nota5 = txtcalif5.Text;
            string promedio = lblrespuesta.Text; 

            float calif1 = float.Parse(nota1);
            float calif2 = float.Parse(nota2);
            float calif3 = float.Parse(nota3);
            float calif4 = float.Parse(nota4);
            float calif5 = float.Parse(nota5);
            float prom = (calif1 + calif2 + calif3 + calif4 + calif5) / 5;

            if (prom >= 3.5)
            {

                lblrespuesta.Text = prom.ToString();
                lblpaso.Text = " has superado la materia ";
                lblrespuesta.Visible = true;
                lblpaso.Visible = true;
                lblpaso.ForeColor = Color.Blue;

            }
            else
            {

                lblrespuesta.Text = prom.ToString();
                lblpaso.Text = " No superaste la competencia de la materia";
                lblrespuesta.Visible = true;
                lblpaso.Visible = true;
                lblpaso.ForeColor = Color.Red;
            }
        }
    }
}

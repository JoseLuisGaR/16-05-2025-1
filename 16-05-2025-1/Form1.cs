using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace _16_05_2025_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            string ruta = txtRuta.Text;
            int Valor1 = 1;
            int Valor2 = 1;
            bool primeraVez = false;
            SLDocument sl = new SLDocument(ruta);
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(Valor1, Valor2)))
            {
                if (!primeraVez)
                {
                    lstMostrar.Clear(); 
                }

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(Valor1, Valor2)))
                {
                    if (Valor1 == 1)
                    {
                        lstMostrar.Columns.Add(sl.GetCellValueAsString(Valor1, Valor2), -2, HorizontalAlignment.Left);

                    }
                    lstMostrar.Items.Add(sl.GetCellValueAsString(Valor1, Valor2));
                    Valor2++;

                }
                Valor1++;
                Valor2 = 1;
                primeraVez = true;
            }
            int Largo = lstMostrar.Items.Count;
            int Ancho = lstMostrar.Columns.Count;
            lstMostrar.Width = Ancho * 85;
            lstMostrar.Height = (Largo / Ancho) * 20;
            
            
        }
    }
}

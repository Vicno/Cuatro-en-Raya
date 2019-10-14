using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4enRaya
{
    public partial class Form1 : Form
    {
        PictureBox seleccionado = null;
        int[] fichas = new int[7];
        public Form1()
        {
            InitializeComponent();
            iniciar();
        }

        private void iniciar()
        {
            for(int i = 0; i<7; i++)
            {
                fichas[i] = 0;
            }
        }
        private void insertar(object sender, EventArgs e)
        {
            seleccionado = (PictureBox)sender;
            if (seleccionado != null)
            {
                int numero = (Convert.ToInt32(seleccionado.Name.ToString().Substring(7)))%7;
                if (validacion(numero))//validar
                {
                    int altura = fichas[numero];

                }
            }
}

        private bool validacion(int numero)
        {
            if (fichas[numero]<6)
            {
                return true;
            }
            return false;
        }
    }

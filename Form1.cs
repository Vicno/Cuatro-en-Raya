using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
            BotonMutear.Visible = false;
            BotonSonido.Visible = true;
        }

        private void iniciar()
        {

            for (int i = 0; i < 7; i++)
            {
                fichas[i] = 0;
            }
        }
        private void insertar(object sender, EventArgs e)
        {

            seleccionado = (PictureBox)sender;
            if (seleccionado != null)
            {

                int numero = (Convert.ToInt32(seleccionado.Name.ToString().Substring(7)));
                int posicion = numero % 7;
                int profundidad = fichas[posicion];
                if (validacion(posicion))//validar
                {

                    int numeroInsertar = 42 - ((profundidad + 1) * 7) - (7 - posicion);
                    String nombre = "picture" + numeroInsertar;
                }
            }
        }

        private bool validacion(int numero)
        {

            if (fichas[numero] < 6)
            {
                return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonSonido_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\2CELLOS - Seven Nation Army.wav";
            player.PlayLooping();
            BotonMutear.Visible = true;
            BotonSonido.Visible = false;
        }

        private void BotonMutear_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\2CELLOS - Seven Nation Army.wav";
            player.Stop();
            BotonMutear.Visible = false;
            BotonSonido.Visible = true;
        }
    }
    }

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
        int turno = 0;
        int tamaño = 60;
        int cont = 0;
        int[] fichas = new int[7];
        PictureBox seleccionado = null;
        PictureBox auxiliar = null;
        List<PictureBox> pictures = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            iniciar();
            iniciarPictureBoxs();
            BotonMutear.Visible = false;
            BotonSonido.Visible = true;
        }


        private void iniciar()
        {
            for (int i = 0; i < 6; i++)
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
                    int numeroInsertar = 42 - ((profundidad) * 7) - (7 - posicion);
                    String nombre = "picture" + numeroInsertar;
                    label1.Text = nombre;
                    auxiliar = buscar(nombre);
                    asignarColor(auxiliar);
                    fichas[posicion]++;
                    comprobarGanador(numeroInsertar);
                    turno++;
                    
                    //MessageBox.Show(""+auxiliar.BackColor);
                }
            }
        }

        private void comprobarGanador(int numeroInsertar)
        {
            if ((numeroInsertar % 7) < 4)
            {
                comprobarDer(numeroInsertar);
            }
            if ((numeroInsertar % 7) > 2)
            {
                comprobarIzq(numeroInsertar);
            }
            if (numeroInsertar < 21)
            {
                comprobarabajo(numeroInsertar);
            }
            if ((numeroInsertar < 19)&& ((numeroInsertar % 7) < 4))
            {
                comprobardiagder(numeroInsertar);
            }
            if ((numeroInsertar < 19) && ((numeroInsertar % 7) > 2))
            {
                comprobardiagizq(numeroInsertar);
            }
            if (cont == 3)
            {
                String color = turno%2==0 ? "azul" : "rojo";
                MessageBox.Show("Gano "+color);
            }
        }

        private void comprobarDer(int numeroInsertar)
        {
            int der = numeroInsertar + 1;
            while (cont < 3)
            {
                String nombreder = "picture" + der;
                PictureBox auxder = buscar(nombreder);
                if (auxder.Tag == auxiliar.Tag)
                {
                    der++;
                    cont++;
                }
                else
                {
                    //if (cont > 0)
                    //{
                    //    comprobarIzq(numeroInsertar);
                    //}
                    //else
                    //{
                        cont = 0;
                        break;
                    //}
                }
            }
        }

        private void comprobarIzq(int numeroInsertar)
        {
            int izq = numeroInsertar - 1;
            while (cont < 3)
            {
                String nombreizq = "picture" + izq;
                PictureBox auxizq = buscar(nombreizq);
                if (auxizq.Tag == auxiliar.Tag)
                {
                    izq--;
                    cont++;
                }
                else
                {
                    //if (cont > 0)
                    //{
                    //    comprobarDer(numeroInsertar);
                    //}
                    //else
                    //{
                        cont = 0;
                        break;
                    //}
                }
            }
        }

        private void comprobarabajo(int numeroInsertar)
        {
            int abajo = numeroInsertar + 7;
            while (cont < 3)
            {
                String nombreabajo = "picture" + abajo;
                PictureBox auxabajo = buscar(nombreabajo);
                if (auxabajo.Tag == auxiliar.Tag)
                {
                    abajo += 7;
                    cont++;
                }
                else
                {
                    cont = 0;
                    break;
                }
            }
        }
        private void comprobardiagder(int numeroInsertar)
        {
            int diagder = numeroInsertar + 8;
            while (cont < 3)
            {
                String nombrediagder = "picture" + diagder;
                PictureBox auxdiagder = buscar(nombrediagder);
                if (auxdiagder.Tag == auxiliar.Tag)
                {
                    diagder += 8;
                    cont++;
                }
                else
                {
                    cont = 0;
                    break;
                }
            }
        }
        private void comprobardiagizq(int numeroInsertar)
        {
            int diagizq = numeroInsertar + 6;
            while (cont < 3)
            {
                String nombrediagizq = "picture" + diagizq;
                PictureBox auxdiagizq = buscar(nombrediagizq);
                if (auxdiagizq.Tag == auxiliar.Tag)
                {
                    diagizq += 6;
                    cont++;
                }
                else
                {
                    cont = 0;
                    break;
                }
            }
        }

        private void asignarColor(PictureBox aux)
        {
            if (turno % 2 == 0)
            {
                aux.BackgroundImage = Properties.Resources.azul;
                aux.Tag = "azul";
            }
            else
            {
                aux.BackgroundImage = Properties.Resources.rojo;
                aux.Tag = "rojo";
            }
        }

        private PictureBox buscar(string nombre)
        {
            PictureBox aux = null;
            for (int i = 0; i < 42; i++)
            {
                if (pictures[i].Name == nombre)
                {
                    aux = pictures[i];
                    break;
                }
            }
            return aux;
        }

        private bool validacion(int numero)
        {
            if (fichas[numero] < 6)
            {
                return true;
            }
            return false;
        }
        private void iniciarPictureBoxs()
        {
            pictures.Add(picture0);
            pictures.Add(picture1);
            pictures.Add(picture2);
            pictures.Add(picture3);
            pictures.Add(picture4);
            pictures.Add(picture5);
            pictures.Add(picture6);
            pictures.Add(picture7);
            pictures.Add(picture8);
            pictures.Add(picture9);
            pictures.Add(picture10);
            pictures.Add(picture11);
            pictures.Add(picture12);
            pictures.Add(picture13);
            pictures.Add(picture14);
            pictures.Add(picture15);
            pictures.Add(picture16);
            pictures.Add(picture17);
            pictures.Add(picture18);
            pictures.Add(picture19);
            pictures.Add(picture20);
            pictures.Add(picture21);
            pictures.Add(picture22);
            pictures.Add(picture23);
            pictures.Add(picture24);
            pictures.Add(picture25);
            pictures.Add(picture26);
            pictures.Add(picture27);
            pictures.Add(picture28);
            pictures.Add(picture29);
            pictures.Add(picture30);
            pictures.Add(picture31);
            pictures.Add(picture32);
            pictures.Add(picture33);
            pictures.Add(picture34);
            pictures.Add(picture35);
            pictures.Add(picture36);
            pictures.Add(picture37);
            pictures.Add(picture38);
            pictures.Add(picture39);
            pictures.Add(picture40);
            pictures.Add(picture41);
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

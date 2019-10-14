using EO.Internal;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonSonido_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\Queen - Bohemian Rhapsody WAV.wav";
            player.PlayLooping();

        }
    }
}

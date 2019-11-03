using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;

namespace Snake
{
    public partial class frmIndex : Form
    {
        SoundPlayer player = new SoundPlayer(); //objeto para sonido
        public frmIndex()
        {
            InitializeComponent();
            player.SoundLocation = "C:/Users/JHON/Desktop/Snake/Snake/imagenes/ini.wav";// direccion del sonido
            player.Play();// para hacer sonar el sonido
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}

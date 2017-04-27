using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace Handwriting
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

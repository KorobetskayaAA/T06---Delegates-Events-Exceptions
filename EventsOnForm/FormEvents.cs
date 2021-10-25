using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsOnForm
{
    public partial class FormEvents : Form
    {
        public FormEvents()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelCoord.Text = $"X: {e.X} Y: {e.Y}";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            labelSize.Text = $"Ширина: {Width} Высота: {Height}";
        }
    }
}

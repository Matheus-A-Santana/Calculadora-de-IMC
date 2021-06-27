using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_IMC._1___Forms
{
    public partial class FrmResult : Form
    {
        public FrmResult()
        {
            InitializeComponent();
        }

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void PanelBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void PanelBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)//se drag igual a true mover o form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}

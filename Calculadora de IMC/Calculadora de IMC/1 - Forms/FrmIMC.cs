using Calculadora_de_IMC._2___Calculo;
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
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

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
            if(drag == true)//se drag igual a true mover o form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch.Checked)
            {
                LblWoman.ForeColor = Color.MediumSlateBlue;
                LblMen.ForeColor = Color.LightGray;
            }
            else
            {
                LblMen.ForeColor = Color.FromArgb(0, 192, 192);
                LblWoman.ForeColor = Color.LightGray;
            }
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {
            if (ToggleSwitch.Checked)
            {
                LblWoman.ForeColor = Color.MediumSlateBlue;
                LblMen.ForeColor = Color.LightGray;
            }
            else
            {
                LblMen.ForeColor = Color.FromArgb(0, 192, 192);
                LblWoman.ForeColor = Color.LightGray;
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            CalculoIMC calculo = new CalculoIMC();

            if(TxtAge.Text == "" && TxtStature.Text == "" && TxtWeight.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                calculo.Calculo(int.Parse(TxtAge.Text), float.Parse(TxtStature.Text), float.Parse(TxtWeight.Text));

                TxtAge.Clear();
                TxtStature.Clear();
                TxtWeight.Clear();
            }
        }
    }
}

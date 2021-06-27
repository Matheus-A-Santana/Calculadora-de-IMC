using Calculadora_de_IMC._1___Forms;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_IMC._2___Calculo
{
    class CalculoIMC
    {
        public void Calculo(int age, float stature, float weight)
        {
            FrmResult frmResult = new FrmResult();

            float imc;

            imc = weight / (stature * stature);

            if(imc < 16)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado de 'Magreza Grave'" + imc;
                frmResult.LblMGrave.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if(imc >= 16 && imc < 17)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado de 'Magreza moderada'" + imc;
                frmResult.LblMmoderada.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if(imc >= 17 && imc < 18.5)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado de 'Magreza leve'" + imc;
                frmResult.LblMagreza.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if (imc >= 18.5 && imc  < 25)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado 'Saudável' " + imc;
                frmResult.LblSaudavel.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if (imc >= 25 && imc < 30)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado 'Sobrepeso' " + imc;
                frmResult.LblSobrepeso.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if (imc >= 30 && imc < 35)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado de 'Obesidade' " + imc;
                frmResult.LblObesidade1.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if (imc >= 35 && imc < 40)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado de 'Obesidade severa' " + imc;
                frmResult.LblObesidade2.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
            else if(imc >= 40)
            {
                frmResult.LblResult.Text = "O seu Indice de massa corpôrea está em estado de 'Obesidade mórbita' " + imc;
                frmResult.LblObesidade3.ForeColor = Color.IndianRed;
                frmResult.Show();
            }
        }
    }
}

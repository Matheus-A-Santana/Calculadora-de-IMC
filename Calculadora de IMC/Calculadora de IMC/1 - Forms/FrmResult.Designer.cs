
namespace Calculadora_de_IMC._1___Forms
{
    partial class FrmResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMGrave = new System.Windows.Forms.Label();
            this.LblMmoderada = new System.Windows.Forms.Label();
            this.LblMagreza = new System.Windows.Forms.Label();
            this.LblSaudavel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblSobrepeso = new System.Windows.Forms.Label();
            this.LblObesidade1 = new System.Windows.Forms.Label();
            this.LblObesidade2 = new System.Windows.Forms.Label();
            this.LblObesidade3 = new System.Windows.Forms.Label();
            this.PanelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelBar.Controls.Add(this.label2);
            this.PanelBar.Controls.Add(this.BtnExit);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(750, 30);
            this.PanelBar.TabIndex = 0;
            this.PanelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBar_MouseDown);
            this.PanelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBar_MouseMove);
            this.PanelBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelBar_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMC";
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::Calculadora_de_IMC.Properties.Resources.delete;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(706, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(44, 30);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado:";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.ForeColor = System.Drawing.Color.LightGray;
            this.LblResult.Location = new System.Drawing.Point(14, 90);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(420, 21);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "O seu Indice de massa corpoêa está em um estado Normal ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 1);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indice:";
            // 
            // LblMGrave
            // 
            this.LblMGrave.AutoSize = true;
            this.LblMGrave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMGrave.ForeColor = System.Drawing.Color.LightGray;
            this.LblMGrave.Location = new System.Drawing.Point(12, 213);
            this.LblMGrave.Name = "LblMGrave";
            this.LblMGrave.Size = new System.Drawing.Size(227, 21);
            this.LblMGrave.TabIndex = 5;
            this.LblMGrave.Text = "Menor que 16 – Magreza grave";
            // 
            // LblMmoderada
            // 
            this.LblMmoderada.AutoSize = true;
            this.LblMmoderada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMmoderada.ForeColor = System.Drawing.Color.LightGray;
            this.LblMmoderada.Location = new System.Drawing.Point(14, 256);
            this.LblMmoderada.Name = "LblMmoderada";
            this.LblMmoderada.Size = new System.Drawing.Size(293, 21);
            this.LblMmoderada.TabIndex = 6;
            this.LblMmoderada.Text = "16 a menor que 17 – Magreza moderada";
            // 
            // LblMagreza
            // 
            this.LblMagreza.AutoSize = true;
            this.LblMagreza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMagreza.ForeColor = System.Drawing.Color.LightGray;
            this.LblMagreza.Location = new System.Drawing.Point(14, 300);
            this.LblMagreza.Name = "LblMagreza";
            this.LblMagreza.Size = new System.Drawing.Size(262, 21);
            this.LblMagreza.TabIndex = 7;
            this.LblMagreza.Text = "17 a menor que 18,5 – Magreza leve";
            // 
            // LblSaudavel
            // 
            this.LblSaudavel.AutoSize = true;
            this.LblSaudavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaudavel.ForeColor = System.Drawing.Color.LightGray;
            this.LblSaudavel.Location = new System.Drawing.Point(14, 341);
            this.LblSaudavel.Name = "LblSaudavel";
            this.LblSaudavel.Size = new System.Drawing.Size(233, 21);
            this.LblSaudavel.TabIndex = 8;
            this.LblSaudavel.Text = "18,5 a menor que 25 – Saudável";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(313, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 149);
            this.panel2.TabIndex = 9;
            // 
            // LblSobrepeso
            // 
            this.LblSobrepeso.AutoSize = true;
            this.LblSobrepeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSobrepeso.ForeColor = System.Drawing.Color.LightGray;
            this.LblSobrepeso.Location = new System.Drawing.Point(320, 213);
            this.LblSobrepeso.Name = "LblSobrepeso";
            this.LblSobrepeso.Size = new System.Drawing.Size(232, 21);
            this.LblSobrepeso.TabIndex = 10;
            this.LblSobrepeso.Text = "25 a menor que 30 – Sobrepeso";
            // 
            // LblObesidade1
            // 
            this.LblObesidade1.AutoSize = true;
            this.LblObesidade1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObesidade1.ForeColor = System.Drawing.Color.LightGray;
            this.LblObesidade1.Location = new System.Drawing.Point(320, 256);
            this.LblObesidade1.Name = "LblObesidade1";
            this.LblObesidade1.Size = new System.Drawing.Size(278, 21);
            this.LblObesidade1.TabIndex = 11;
            this.LblObesidade1.Text = "30 a menor que 35 – Obesidade Grau I";
            // 
            // LblObesidade2
            // 
            this.LblObesidade2.AutoSize = true;
            this.LblObesidade2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObesidade2.ForeColor = System.Drawing.Color.LightGray;
            this.LblObesidade2.Location = new System.Drawing.Point(320, 300);
            this.LblObesidade2.Name = "LblObesidade2";
            this.LblObesidade2.Size = new System.Drawing.Size(429, 21);
            this.LblObesidade2.TabIndex = 12;
            this.LblObesidade2.Text = "35 a menor que 40 – Obesidade Grau II (considerada severa)";
            // 
            // LblObesidade3
            // 
            this.LblObesidade3.AutoSize = true;
            this.LblObesidade3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObesidade3.ForeColor = System.Drawing.Color.LightGray;
            this.LblObesidade3.Location = new System.Drawing.Point(320, 341);
            this.LblObesidade3.Name = "LblObesidade3";
            this.LblObesidade3.Size = new System.Drawing.Size(408, 21);
            this.LblObesidade3.TabIndex = 13;
            this.LblObesidade3.Text = "Maior que 40 – Obesidade Grau III (considerada mórbida)";
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.LblObesidade3);
            this.Controls.Add(this.LblObesidade2);
            this.Controls.Add(this.LblObesidade1);
            this.Controls.Add(this.LblSobrepeso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblSaudavel);
            this.Controls.Add(this.LblMagreza);
            this.Controls.Add(this.LblMmoderada);
            this.Controls.Add(this.LblMGrave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRessult";
            this.PanelBar.ResumeLayout(false);
            this.PanelBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LblMGrave;
        public System.Windows.Forms.Label LblMmoderada;
        public System.Windows.Forms.Label LblMagreza;
        public System.Windows.Forms.Label LblSaudavel;
        public System.Windows.Forms.Label LblSobrepeso;
        public System.Windows.Forms.Label LblObesidade1;
        public System.Windows.Forms.Label LblObesidade2;
        public System.Windows.Forms.Label LblObesidade3;
        public System.Windows.Forms.Label LblResult;
    }
}
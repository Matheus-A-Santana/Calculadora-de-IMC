
namespace Calculadora_de_IMC._1___Forms
{
    partial class FrmIMC
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
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMen = new System.Windows.Forms.Label();
            this.LblWoman = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtStature = new System.Windows.Forms.TextBox();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ToggleSwitch = new Calculadora_de_IMC.ToggleButton();
            this.roundedButton1 = new Calculadora_de_IMC.RoundedButton();
            this.PanelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelBar.Controls.Add(this.label2);
            this.PanelBar.Controls.Add(this.BtnMinimize);
            this.PanelBar.Controls.Add(this.BtnExit);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(400, 30);
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
            this.label2.TabIndex = 3;
            this.label2.Text = "IMC";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackgroundImage = global::Calculadora_de_IMC.Properties.Resources.minus;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(306, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnMinimize.Size = new System.Drawing.Size(44, 30);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::Calculadora_de_IMC.Properties.Resources.delete;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(356, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(44, 30);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(105, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculadora de IMC";
            // 
            // LblMen
            // 
            this.LblMen.AutoSize = true;
            this.LblMen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMen.ForeColor = System.Drawing.Color.LightGray;
            this.LblMen.Location = new System.Drawing.Point(71, 113);
            this.LblMen.Name = "LblMen";
            this.LblMen.Size = new System.Drawing.Size(71, 21);
            this.LblMen.TabIndex = 3;
            this.LblMen.Text = "Homem";
            // 
            // LblWoman
            // 
            this.LblWoman.AutoSize = true;
            this.LblWoman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWoman.ForeColor = System.Drawing.Color.LightGray;
            this.LblWoman.Location = new System.Drawing.Point(263, 113);
            this.LblWoman.Name = "LblWoman";
            this.LblWoman.Size = new System.Drawing.Size(65, 21);
            this.LblWoman.TabIndex = 4;
            this.LblWoman.Text = "Mulher";
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(86, 207);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(199, 29);
            this.TxtAge.TabIndex = 5;
            // 
            // TxtStature
            // 
            this.TxtStature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStature.Location = new System.Drawing.Point(86, 295);
            this.TxtStature.Name = "TxtStature";
            this.TxtStature.Size = new System.Drawing.Size(199, 29);
            this.TxtStature.TabIndex = 6;
            // 
            // TxtWeight
            // 
            this.TxtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWeight.Location = new System.Drawing.Point(86, 389);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(199, 29);
            this.TxtWeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(82, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(82, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(82, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(291, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "anos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(291, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(291, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "kg";
            // 
            // ToggleSwitch
            // 
            this.ToggleSwitch.AutoSize = true;
            this.ToggleSwitch.Location = new System.Drawing.Point(159, 106);
            this.ToggleSwitch.MinimumSize = new System.Drawing.Size(80, 40);
            this.ToggleSwitch.Name = "ToggleSwitch";
            this.ToggleSwitch.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ToggleSwitch.OffToggleButton = System.Drawing.Color.Gainsboro;
            this.ToggleSwitch.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.ToggleSwitch.OnToggleButton = System.Drawing.Color.WhiteSmoke;
            this.ToggleSwitch.Size = new System.Drawing.Size(80, 40);
            this.ToggleSwitch.TabIndex = 1;
            this.ToggleSwitch.UseVisualStyleBackColor = true;
            this.ToggleSwitch.CheckedChanged += new System.EventHandler(this.ToggleSwitch_CheckedChanged);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.IndianRed;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(86, 471);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(199, 45);
            this.roundedButton1.TabIndex = 14;
            this.roundedButton1.Text = "Calcular IMC";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.TxtStature);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblWoman);
            this.Controls.Add(this.LblMen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToggleSwitch);
            this.Controls.Add(this.PanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIMC";
            this.Load += new System.EventHandler(this.FrmIMC_Load);
            this.PanelBar.ResumeLayout(false);
            this.PanelBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
        private ToggleButton ToggleSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMen;
        private System.Windows.Forms.Label LblWoman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtStature;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RoundedButton roundedButton1;
    }
}
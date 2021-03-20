
namespace Menu
{
    partial class IMC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbMuitoAbaixo = new System.Windows.Forms.Label();
            this.lbAbaixa = new System.Windows.Forms.Label();
            this.lbNormal = new System.Windows.Forms.Label();
            this.lbAcimadoPeso = new System.Windows.Forms.Label();
            this.lbOb1 = new System.Windows.Forms.Label();
            this.lbOb2 = new System.Windows.Forms.Label();
            this.lbOb3 = new System.Windows.Forms.Label();
            this.lbIMC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cáculo do IMC do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IMC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resultado";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(100, 66);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(100, 95);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(224, 158);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 9;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "   Resultado\t         Situação",
            "Abaixo de 17,00\t     Muito abaixo do peso",
            "Entre 17,00 e 18,49     Abaixo do peso",
            "Entre 18,50 e 24,99     Peso normal",
            "Entre 25,00 e 29,99     Acima do peso",
            "Entre 30,00 e 34,99     Obesidade I",
            "Entre 35,00 e 39,99     Obesidade II  (Severa)",
            "Acima de 40,00            Obesidade III (Mórbida)"});
            this.listBox1.Location = new System.Drawing.Point(27, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 225);
            this.listBox1.TabIndex = 10;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(130, 163);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(16, 13);
            this.lbResultado.TabIndex = 11;
            this.lbResultado.Text = "...";
            // 
            // lbMuitoAbaixo
            // 
            this.lbMuitoAbaixo.AutoSize = true;
            this.lbMuitoAbaixo.BackColor = System.Drawing.Color.Yellow;
            this.lbMuitoAbaixo.Location = new System.Drawing.Point(281, 211);
            this.lbMuitoAbaixo.Name = "lbMuitoAbaixo";
            this.lbMuitoAbaixo.Size = new System.Drawing.Size(16, 13);
            this.lbMuitoAbaixo.TabIndex = 12;
            this.lbMuitoAbaixo.Text = "<-";
            this.lbMuitoAbaixo.Visible = false;
            // 
            // lbAbaixa
            // 
            this.lbAbaixa.AutoSize = true;
            this.lbAbaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbAbaixa.Location = new System.Drawing.Point(281, 224);
            this.lbAbaixa.Name = "lbAbaixa";
            this.lbAbaixa.Size = new System.Drawing.Size(16, 13);
            this.lbAbaixa.TabIndex = 13;
            this.lbAbaixa.Text = "<-";
            this.lbAbaixa.Visible = false;
            // 
            // lbNormal
            // 
            this.lbNormal.AutoSize = true;
            this.lbNormal.BackColor = System.Drawing.Color.Lime;
            this.lbNormal.Location = new System.Drawing.Point(281, 237);
            this.lbNormal.Name = "lbNormal";
            this.lbNormal.Size = new System.Drawing.Size(16, 13);
            this.lbNormal.TabIndex = 14;
            this.lbNormal.Text = "<-";
            this.lbNormal.Visible = false;
            // 
            // lbAcimadoPeso
            // 
            this.lbAcimadoPeso.AutoSize = true;
            this.lbAcimadoPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbAcimadoPeso.Location = new System.Drawing.Point(281, 250);
            this.lbAcimadoPeso.Name = "lbAcimadoPeso";
            this.lbAcimadoPeso.Size = new System.Drawing.Size(16, 13);
            this.lbAcimadoPeso.TabIndex = 15;
            this.lbAcimadoPeso.Text = "<-";
            this.lbAcimadoPeso.Visible = false;
            // 
            // lbOb1
            // 
            this.lbOb1.AutoSize = true;
            this.lbOb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbOb1.Location = new System.Drawing.Point(281, 263);
            this.lbOb1.Name = "lbOb1";
            this.lbOb1.Size = new System.Drawing.Size(16, 13);
            this.lbOb1.TabIndex = 16;
            this.lbOb1.Text = "<-";
            this.lbOb1.Visible = false;
            // 
            // lbOb2
            // 
            this.lbOb2.AutoSize = true;
            this.lbOb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbOb2.Location = new System.Drawing.Point(281, 276);
            this.lbOb2.Name = "lbOb2";
            this.lbOb2.Size = new System.Drawing.Size(16, 13);
            this.lbOb2.TabIndex = 17;
            this.lbOb2.Text = "<-";
            this.lbOb2.Visible = false;
            // 
            // lbOb3
            // 
            this.lbOb3.AutoSize = true;
            this.lbOb3.BackColor = System.Drawing.Color.Red;
            this.lbOb3.Location = new System.Drawing.Point(281, 289);
            this.lbOb3.Name = "lbOb3";
            this.lbOb3.Size = new System.Drawing.Size(16, 13);
            this.lbOb3.TabIndex = 18;
            this.lbOb3.Text = "<-";
            this.lbOb3.Visible = false;
            // 
            // lbIMC
            // 
            this.lbIMC.AutoSize = true;
            this.lbIMC.Location = new System.Drawing.Point(130, 130);
            this.lbIMC.Name = "lbIMC";
            this.lbIMC.Size = new System.Drawing.Size(16, 13);
            this.lbIMC.TabIndex = 19;
            this.lbIMC.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(224, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Parar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbIMC);
            this.Controls.Add(this.lbOb3);
            this.Controls.Add(this.lbOb2);
            this.Controls.Add(this.lbOb1);
            this.Controls.Add(this.lbAcimadoPeso);
            this.Controls.Add(this.lbNormal);
            this.Controls.Add(this.lbAbaixa);
            this.Controls.Add(this.lbMuitoAbaixo);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IMC";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbMuitoAbaixo;
        private System.Windows.Forms.Label lbAbaixa;
        private System.Windows.Forms.Label lbNormal;
        private System.Windows.Forms.Label lbAcimadoPeso;
        private System.Windows.Forms.Label lbOb1;
        private System.Windows.Forms.Label lbOb2;
        private System.Windows.Forms.Label lbOb3;
        private System.Windows.Forms.Label lbIMC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}
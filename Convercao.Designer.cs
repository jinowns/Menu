
namespace Menu
{
    partial class Convercao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convercao));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbFarenheit = new System.Windows.Forms.Label();
            this.btnCalcularF = new System.Windows.Forms.Button();
            this.txtCentigradosF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbKelvin = new System.Windows.Forms.Label();
            this.bntCalcularK = new System.Windows.Forms.Button();
            this.txtCentigradosK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbFarenheit);
            this.tabPage1.Controls.Add(this.btnCalcularF);
            this.tabPage1.Controls.Add(this.txtCentigradosF);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "C para F";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbFarenheit
            // 
            this.lbFarenheit.AutoSize = true;
            this.lbFarenheit.Location = new System.Drawing.Point(113, 133);
            this.lbFarenheit.Name = "lbFarenheit";
            this.lbFarenheit.Size = new System.Drawing.Size(16, 13);
            this.lbFarenheit.TabIndex = 14;
            this.lbFarenheit.Text = "...";
            this.lbFarenheit.Visible = false;
            // 
            // btnCalcularF
            // 
            this.btnCalcularF.Location = new System.Drawing.Point(219, 128);
            this.btnCalcularF.Name = "btnCalcularF";
            this.btnCalcularF.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularF.TabIndex = 13;
            this.btnCalcularF.Text = "Calcular";
            this.btnCalcularF.UseVisualStyleBackColor = true;
            this.btnCalcularF.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCentigradosF
            // 
            this.txtCentigradosF.Location = new System.Drawing.Point(113, 89);
            this.txtCentigradosF.Name = "txtCentigradosF";
            this.txtCentigradosF.Size = new System.Drawing.Size(100, 20);
            this.txtCentigradosF.TabIndex = 11;
            this.txtCentigradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apenasNumerosVirgulas);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Farenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Centígrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Conversão de graus Centígrados em Farenheit";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbKelvin);
            this.tabPage2.Controls.Add(this.bntCalcularK);
            this.tabPage2.Controls.Add(this.txtCentigradosK);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "C em K";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbKelvin
            // 
            this.lbKelvin.AutoSize = true;
            this.lbKelvin.Location = new System.Drawing.Point(115, 135);
            this.lbKelvin.Name = "lbKelvin";
            this.lbKelvin.Size = new System.Drawing.Size(16, 13);
            this.lbKelvin.TabIndex = 20;
            this.lbKelvin.Text = "...";
            this.lbKelvin.Visible = false;
            // 
            // bntCalcularK
            // 
            this.bntCalcularK.Location = new System.Drawing.Point(221, 130);
            this.bntCalcularK.Name = "bntCalcularK";
            this.bntCalcularK.Size = new System.Drawing.Size(75, 23);
            this.bntCalcularK.TabIndex = 19;
            this.bntCalcularK.Text = "Calcular";
            this.bntCalcularK.UseVisualStyleBackColor = true;
            this.bntCalcularK.Click += new System.EventHandler(this.bntCalcularK_Click);
            // 
            // txtCentigradosK
            // 
            this.txtCentigradosK.Location = new System.Drawing.Point(115, 91);
            this.txtCentigradosK.Name = "txtCentigradosK";
            this.txtCentigradosK.Size = new System.Drawing.Size(100, 20);
            this.txtCentigradosK.TabIndex = 18;
            this.txtCentigradosK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apenasNumerosVirgulas);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kelvin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Centígrados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Conversão de graus Centígrados em Kelvin";
            // 
            // Convercao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 330);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Convercao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converção";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalcularF;
        private System.Windows.Forms.TextBox txtCentigradosF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFarenheit;
        private System.Windows.Forms.Label lbKelvin;
        private System.Windows.Forms.Button bntCalcularK;
        private System.Windows.Forms.TextBox txtCentigradosK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
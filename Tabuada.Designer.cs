
namespace Menu
{
    partial class Tabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuada));
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.ListBox();
            this.lbTabuada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(77, 67);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(58, 20);
            this.txtN1.TabIndex = 0;
            this.txtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apenasNumerosVirgulas);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(77, 126);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(58, 20);
            this.txtN2.TabIndex = 1;
            this.txtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apenasNumerosVirgulas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabuada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(156, 167);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(56, 23);
            this.bntCalcular.TabIndex = 5;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // box
            // 
            this.box.AllowDrop = true;
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(24, 210);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(177, 160);
            this.box.TabIndex = 6;
            // 
            // lbTabuada
            // 
            this.lbTabuada.AutoSize = true;
            this.lbTabuada.Location = new System.Drawing.Point(74, 172);
            this.lbTabuada.Name = "lbTabuada";
            this.lbTabuada.Size = new System.Drawing.Size(16, 13);
            this.lbTabuada.TabIndex = 7;
            this.lbTabuada.Text = "...";
            // 
            // Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(224, 381);
            this.Controls.Add(this.lbTabuada);
            this.Controls.Add(this.box);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.ListBox box;
        private System.Windows.Forms.Label lbTabuada;
    }
}
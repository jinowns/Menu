﻿
namespace Menu
{
    partial class Programas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaDasNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cáculoDeIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoCEmFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeFreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médiaDasNotasToolStripMenuItem,
            this.cáculoDeIMCToolStripMenuItem,
            this.tabuadaToolStripMenuItem,
            this.conversãoCEmFToolStripMenuItem,
            this.calculoDeFreteToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.programasToolStripMenuItem_Click);
            // 
            // médiaDasNotasToolStripMenuItem
            // 
            this.médiaDasNotasToolStripMenuItem.Name = "médiaDasNotasToolStripMenuItem";
            this.médiaDasNotasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.médiaDasNotasToolStripMenuItem.Text = "Média das Notas";
            this.médiaDasNotasToolStripMenuItem.Click += new System.EventHandler(this.médiaDasNotasToolStripMenuItem_Click);
            // 
            // cáculoDeIMCToolStripMenuItem
            // 
            this.cáculoDeIMCToolStripMenuItem.Name = "cáculoDeIMCToolStripMenuItem";
            this.cáculoDeIMCToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cáculoDeIMCToolStripMenuItem.Text = "Cáculo de IMC";
            this.cáculoDeIMCToolStripMenuItem.Click += new System.EventHandler(this.cáculoDeIMCToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            // 
            // conversãoCEmFToolStripMenuItem
            // 
            this.conversãoCEmFToolStripMenuItem.Name = "conversãoCEmFToolStripMenuItem";
            this.conversãoCEmFToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.conversãoCEmFToolStripMenuItem.Text = "Conversão";
            this.conversãoCEmFToolStripMenuItem.Click += new System.EventHandler(this.conversãoCEmFToolStripMenuItem_Click);
            // 
            // calculoDeFreteToolStripMenuItem
            // 
            this.calculoDeFreteToolStripMenuItem.Name = "calculoDeFreteToolStripMenuItem";
            this.calculoDeFreteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.calculoDeFreteToolStripMenuItem.Text = "Calculo de Frete";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Programas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Programas";
            this.Text = "Main_Programas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaDasNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cáculoDeIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoCEmFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeFreteToolStripMenuItem;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Programas : Form
    {
        public Programas()
        {
            InitializeComponent();
        }

        private void médiaDasNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media fmMedia = new Media();
            fmMedia.Show();
        }

        private void conversãoCEmFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convercao fmConvercao = new Convercao();
            fmConvercao.Show();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cáculoDeIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMC fmIMC = new IMC();
            fmIMC.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabuada fmTabuada = new Tabuada();
            fmTabuada.Show();
        }

        private void calculoDeFreteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frete fmFrete = new Frete();
            fmFrete.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda fmAjuda = new Ajuda();
            fmAjuda.Show();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            academica.Form1 objForm = new academica.Form1();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materia objForm = new materia();
            objForm.MdiParent = this;
            objForm.Show();
        }
    }
}

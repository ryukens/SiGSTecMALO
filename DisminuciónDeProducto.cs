﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPantalla
{
    public partial class DisminuciónDeProducto : UserControl
    {
        public DisminuciónDeProducto()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Productos Disminuidos Correctamente", "Productos Dismunuidos");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new AsignaciónDeProductos().Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

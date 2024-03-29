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
        TabControl tabControl;
        TabPage tabInicio;
        public DisminuciónDeProducto(TabControl tabControl, TabPage tabInicio)
        {
            InitializeComponent();

            cbBuscar.SelectedIndex = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Código");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Cantidad Asignada");
            dgvDisminuir.DataSource = dt;
            dgvDisminuir.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDisminuir.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDisminuir.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            

            this.tabControl = tabControl;
            this.tabInicio = tabInicio;


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


            new AsignaciónDeProductos().ShowDialog();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabInicio);
        }
    }
}

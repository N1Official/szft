using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyulakesrokak
{
    public partial class Form1 : Form
    {
        public static bool[,] nyulak = new bool[10, 10];
        public static bool[,] rokak = new bool[10, 10];
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos be akarja zárni?", "Bezárás", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rowCount = 10;
            int columnCount = 10;

            for (int row = 0; row < rowCount; row++)
            {
                tabla.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                for (int column = 0; column < columnCount; column++)
                {
                    tabla.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                    CheckBox checkBox = new CheckBox();

                    tabla.Controls.Add(checkBox);
                }
            }

        }

        private void roka_CheckedChanged(object sender, EventArgs e)
        {
            start.Visible = true;
            stop.Visible = true;
            figyelmezteto.Visible = false;
            tabla.Visible = true;
        }

        private void nyul_CheckedChanged(object sender, EventArgs e)
        {
            start.Visible = true;
            stop.Visible = true;
            figyelmezteto.Visible = false;
            tabla.Visible = true;
        }

        private void tabla_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

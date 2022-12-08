using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CargaisonForm
{
    public partial class distance : Form
    {
        public distance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void list_marchandise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cargaison_Click(object sender, EventArgs e)
        {
            int distanceT = Int32.Parse(text_distance.Text);
            string typeT = (string)list_cargaison.SelectedItem;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sap)
            {
                try
                {
                    Double aa = 0.0;
                    if (a.Text != "" & b.Text != "" & c.Text != "" & d.Text != "")
                    {
                        aa = (Double.Parse(b.Text) + Double.Parse(c.Text) + Double.Parse(d.Text)) / 3;
                        this.e.Rows.Add(a.Text, b.Text, c.Text, d.Text, aa);
                        ca++;
                        f.Text = ca + "";
                        sap = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int ca = 0;
        private void e_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.e.Rows.RemoveAt(this.e.SelectedCells[0].RowIndex);
                ca--;
                f.Text = ca + "";
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.e.Rows.Clear();
            button4.PerformClick();
            cont = 0.0;
            ca = 0;
            f.Text = ca + "";
        }
        bool sap = true;
        private void button4_Click(object sender, EventArgs e)
        {
            sap = true;
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
        }
        Double cont = 0.0;
        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.e.Rows[0].Cells[4].Value.ToString());
            for(int i = 0; i < this.e.Rows.Count; i++)
            {
                if(i!=(this.e.Rows.Count-1))cont = cont+Double.Parse(this.e.Rows[i].Cells[4].Value.ToString());
            }
            ee.Text = (cont / ca)+"";
        }
    }
}

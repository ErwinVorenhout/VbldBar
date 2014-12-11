using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbldBar
{
    public partial class form2 : Form
    {
        public int id;

        public form2(string id)
        {
            
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            MessageBox.Show(id.ToString());
        }
        

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label3.Hide();
            bool bestaat = false;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {

                if (Convert.ToString(row.Cells[1].Value) == "2312") {
                    bestaat = true;
                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + 1;

                    row.Cells[4].Value = Convert.ToDecimal(row.Cells[4].Value) + Convert.ToDecimal(0.75);
                  
                }
                
           }
            if (bestaat == false)
            {
                this.dataGridView1.Rows.Add("Hertog Jan", "2312", "33", "1", 0.75);
            }


        
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            this.label3.Hide();
            bool bestaat = false;

            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {

                if (Convert.ToString(row.Cells[1].Value) == "2333")
                {

                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + 1;

                    row.Cells[4].Value = Convert.ToDecimal(row.Cells[4].Value) + Convert.ToDecimal(0.75);
                    bestaat = true;



                }
            }
            if (bestaat == false)
            {
                this.dataGridView1.Rows.Add("Wiekse Witte", "2333", "33", "1", 0.75);
            }
           
        }
    }
}

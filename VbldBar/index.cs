using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VbldBar
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();

        }
        string MyConnectionString = "Server=localhost;Database=bar;Uid=root;Pwd=";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 4)
            {
                CheckUser(textBox1.Text);
            }
        }
        private void CheckUser(string number)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(MyConnectionString);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM USERS WHERE barcode = " + number, myConn);

                myConn.Open();
                MySqlDataReader myReader;
                myReader = SelectCommand.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {

                    form2 f2 = new form2(number);
                    f2.id = Convert.ToInt32(number);
                    this.Hide();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Gebruiker niet gevonden");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void afsluitenaltf4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

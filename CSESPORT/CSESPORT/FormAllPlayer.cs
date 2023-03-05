using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        public FormAllPlayer()
        {
            InitializeComponent();

            
            dataGridView1.DataSource = listPlayer;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            


            //Save data from list to CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Player item in listPlayer)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2}",
                            item.Name,
                            item.Lastname,
                            item.Major));
                    }
                }
            }
        }

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e, DataGridView dataGridView1)
        {
            
        }

        private void newPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 formInfo = new Form1();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer = formInfo.GetPlayer();
                //Add new Player to List
                this.listPlayer.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                //Add list to Datagrid view
                formInfo.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Player selectPlayer = (Player)row.DataBoundItem;
            }
        }
    }
}

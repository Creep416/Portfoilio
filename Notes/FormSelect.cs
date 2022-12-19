using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notes
{
	public partial class FormSelect : Form
	{
		public FormSelect()
		{
			InitializeComponent();
		}
        int number = 0;
		private void FormSelect_Load(object sender, EventArgs e)
		{
            StreamReader rd = new StreamReader("C:\\Users\\Creep\\source\\repos\\Notes\\Base\\Base.txt");
            DataSet ds = new DataSet();
            ds.Tables.Add("Score");
            ds.Tables[0].Columns.Add("Название заметки");
            string row = rd.ReadLine();
            while (row != null)
            {
                string[] rvalue = System.Text.RegularExpressions.Regex.Split(row, ";");
                ds.Tables[0].Rows.Add(rvalue[0]);
                row = rd.ReadLine();
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void cancelButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = Convert.ToString(dataGridView1.SelectedCells[0].RowIndex);
            number = dataGridView1.SelectedCells[0].RowIndex;
        }
        private void openButton_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text = Convert.ToString(number);
        }
    }
}

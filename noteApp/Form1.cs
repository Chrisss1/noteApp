using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title");
            table.Columns.Add("Messages");

            dgvNote.DataSource = table;
            dgvNote.Columns["Messages"].Visible= false;
            dgvNote.Columns["Title"].Width = 423;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            TxtMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, TxtMessage.Text);
            btnNew.PerformClick();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dgvNote.CurrentCell.RowIndex;
            if( index >= -1 )
             {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                TxtMessage.Text= table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvNote.CurrentCell.RowIndex;
            table.Rows.Clear();
        }
    }
}

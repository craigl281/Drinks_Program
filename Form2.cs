using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks_Program
{
    public partial class Form2 : Form
    {
        public Form2(List<Drinks> data)
        {
            InitializeComponent();
            ///Only want description shown
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Desciption";
            dataGridView1.Columns[0].DataPropertyName = "Description";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.DataSource = data;
        }
    }
}

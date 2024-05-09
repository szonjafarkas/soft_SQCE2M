using Studies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies
{
    public class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 128);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(129, 394);
            listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(352, 389);
            dataGridView1.TabIndex = 2;
            // 
            // UserControl1
            // 
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "UserControl1";
            Size = new Size(563, 584);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public UserControl1()
        {
            BackColor = Color.Fuchsia;

        }

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

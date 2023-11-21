using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private CustomerViewModel vm;
        public Form1()
        {
            InitializeComponent();
            vm = new CustomerViewModel();

            // The databinding will bind the datasouce to the control, so when the value of the control is chanaged the value of Viewmodel is changed correspondingly 
            vm.CustomerBindingSource = customerBindingSource;
            this.Load += delegate { vm.load(); };
            btnNew.Click += delegate { vm.New(); };
            btnDelete.Click += delegate { vm.Delete(); };
            btnSave.Click += delegate { vm.Save(); };

            this.FormClosing += delegate { vm.Dispose(); };
             

        }

         
        private void customer_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void first_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void customer_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

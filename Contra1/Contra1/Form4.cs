using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contra1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Form3 openForm = new Form3();
            openForm.Show();
            Visible = false;
        }
        
        private void finalScore_Click(object sender, EventArgs e)
        {
        }
    }
}

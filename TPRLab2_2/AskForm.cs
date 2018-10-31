using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPRLab2_2
{
    public partial class AskForm : Form
    {
       public select sel;
        public AskForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sel = select.AND;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sel = select.OR;
            this.Close();
        }
    }
}

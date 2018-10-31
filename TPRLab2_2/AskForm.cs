using System;
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

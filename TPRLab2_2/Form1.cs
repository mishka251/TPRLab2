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

    public enum select { OR, AND };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sits = new Dictionary<Label, Situation>();
            sits2 = new Dictionary<TextBox, Situation>();
            sits3 = new Dictionary<TextBox, Situation>();
            root = new Situation(0, "main", 2);
            sits3.Add(tbName, root);
            sits2.Add(tbProp, root);
            sitCount = 1;
        }
        const int dy = 40;
        const int dx = 600;

        int[] dx_a = new int[]
        {
            900,
            300,
            250,
            70,
            55,
            5
        };

        Dictionary<Label, Situation> sits;
        Dictionary<TextBox, Situation> sits2;
        Dictionary<TextBox, Situation> sits3;
        Situation root;
        int sitCount;
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            AskForm af = new AskForm();
            af.ShowDialog();
            select sel = af.sel;

            TextBox tb = sender as TextBox;
            Label lbl = new Label();
            lbl.Top = tb.Top + dy;
            lbl.Left = tb.Left;

            sits2[tb].sel = sel;

            lbl.Text = sel == select.AND ? "AND" : "OR";

            sits.Add(lbl, sits2[tb]);
            lbl.Click += label1_Click;
            this.Controls.Add(lbl);
        }


        private void label1_Click(object sender, EventArgs e)
        {

            Label lbl = sender as Label;

            Situation newsit = new Situation(0, "", sits[lbl].depth + 1, sits[lbl].down.Count + 1);
            TextBox tb1 = new TextBox();
            tb1.Top = lbl.Top + dy;// + sits[lbl].index * 50;
            tb1.Left = lbl.Left + (sits[lbl].down.Count - 1) * dx_a[sits[lbl].depth]; //+ (sits[lbl].down.Count - 1) * (dx/ (3*sits[lbl].depth));
            tb1.Width = tbName.Width;
            tb1.Height = tbName.Height;

            TextBox tb2 = new TextBox();
            tb2.Top = tb1.Top + tb1.Height;
            tb2.Left = tb1.Left;
            tb2.Width = tbProp.Width;
            tb2.Height = tbProp.Height;


            //  tb1.MouseDoubleClick += textBox1_MouseClick;
            tb2.MouseDoubleClick += textBox1_MouseClick;

            tb1.TextChanged += tbName_TextChanged;
            tb2.TextChanged += tbProp_TextChanged;

            sits[lbl].down.Add(newsit);

            sits3.Add(tb1, newsit);
            sits2.Add(tb2, newsit);

            this.Controls.Add(tb1);
            this.Controls.Add(tb2);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            sits3[sender as TextBox].Name = (sender as TextBox).Text;
        }

        private void tbProp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sits2[sender as TextBox].property = double.Parse((sender as TextBox).Text.Replace(".", ","));
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = root.Formula().Replace("!!", "");
            label_FAL.Text = root.Formula1();
            double prop = root.CalculateProp();
            label2.Text = prop.ToString();
            foreach (var pair in sits2)
                pair.Key.Text = pair.Value.property.ToString();

            if (double.TryParse(tbUsherb.Text, out double price))
            {
                lblUsherb.Text = (prop * price).ToString();
            }
            else
                lblUsherb.Text = "Ошибка ввода цены ущерба";

        }
    }
}

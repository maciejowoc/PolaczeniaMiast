using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolaczeniaMiast
{
    public partial class OknoWyboru : Form
    {
        public OknoWyboru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Europa.txt");
            form1.Show();
            form1.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            this.Hide();
        }

        private void USA_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("USA.txt");
            form1.Show();
            form1.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Skandynawia.txt");
            form1.Show();
            form1.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            this.Hide();
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        
    }
}

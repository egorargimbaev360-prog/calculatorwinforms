using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.Design;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double Firstnum;
        double Secondnum;
        string operation = "";
        bool newOperation;
        double mathResult = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnnumbersactions(object sender, EventArgs e)
        {
            if (newOperation)
            {
                textBox2.Clear();
                newOperation = false;
            }
            var btn = (Button)sender;
            textBox2.Text += btn.Text;

        }



        private void mathoperation(object sender, EventArgs e)
        {
            var ope = (Button)sender;
            if (textBox2.Text == "")
                return;
            Firstnum = double.Parse(textBox2.Text);

            operation = ope.Text;

            newOperation = true;

        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            Secondnum = double.Parse(textBox2.Text);

            if (operation == "+")
            {
                mathResult = Firstnum + Secondnum;
            }
            else if (operation == "-")
            {
                mathResult = Firstnum - Secondnum;
            }
            else if (operation == "*")
            {
                mathResult = Firstnum * Secondnum;
            }
            else if (operation == "/")
            {
                if (Secondnum != 0)
                {
                    mathResult = Firstnum / Secondnum;
                }
                else
                {
                    MessageBox.Show("На ноль делить нельзя!");
                    return;
                }
            }
            textBox2.Text = mathResult.ToString();
        }

        private void dotoperation(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains(","))
            {
                MessageBox.Show("Нельзя!");
            }
            else
            {
                textBox2.Text += ",";
            }
        }
    }
}

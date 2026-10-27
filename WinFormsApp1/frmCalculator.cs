using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.Design;

namespace WinFormsApp1
{
    public partial class frmCalculator : Form
    {
        double Firstnum;
        double Secondnum;
        string operation = "";
        bool newOperation;
        double mathResult = 0;
        public frmCalculator()
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

            if (operation != "" && !newOperation)
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
                    mathResult = Secondnum * Firstnum;
                }

                else if (operation == "/")
                {
                    mathResult = Firstnum / Secondnum;
                }

                textBox2.Text = mathResult.ToString();
            }
            
            Firstnum = double.Parse(textBox2.Text);
            operation = ope.Text;
            newOperation = true;

        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }

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
        private void clearoperation(object sender, EventArgs e)
        {
            textBox2.Clear();
            Firstnum = 0;
            Secondnum = 0;
            operation = "";
            newOperation = true;
        }

    }
}

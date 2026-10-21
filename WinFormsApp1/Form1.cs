namespace WinFormsApp1
{
    public partial class Form1 : Form 
    {
        double Firstnum;
        string operation = "";
        bool newOperation;
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
            var btn = (Button)sender;
            textBox2.Text += btn.Text;
            if (newOperation)
            {
                textBox2.Clear();
                newOperation = false;
            }
        }
            
                

            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mathoperation(object sender, EventArgs e)
        {
            var ope = (Button)sender;
            
        }
    }
}

using Microsoft.VisualBasic.Devices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string option;
        public string num1;
        public bool num2;

        public Form1()
        {
            num2 = true;
            InitializeComponent();
        }
        private void btnNumbers_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                txtDisplay.Text = "0";
            }
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

       
        private void allOperations_Click(object sender, EventArgs e)
        {
            if (option == "+" || option == "-" || option == "X" || option == "/")
            {
                btn_equal_Click(sender, e);
            }
            Button button = (Button)sender;
            option = button.Text;
            num1 = txtDisplay.Text;
            num2 = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double dnum1, dnum2, result;
            result = 0;
            dnum1 = Convert.ToDouble(num1);
            dnum2 = Convert.ToDouble(txtDisplay.Text);
            if (option == "+")
            {
                result = dnum1 + dnum2;
            }
            if (option == "-")
            {
                result = dnum1 - dnum2;
            }
            if (option == "X")
            {
                result = dnum1 * dnum2;
            }
            if (option == "/")
            {
                result = dnum1 / dnum2;
            }
            if (option == "%")
            {
                result = (dnum1 / 100)*dnum2;
            }
            option = "=";
            num2 = true;
            txtDisplay.Text = result.ToString();
        }

        private void btn_plus_minus_Click(object sender, EventArgs e)
        {
            double dnum, result;
            dnum = Convert.ToDouble(txtDisplay.Text);
            result = -dnum;
            txtDisplay.Text = result.ToString();
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
                txtDisplay.Text += ",";
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length == 0) MessageBox.Show("Var olan eded yoxdur", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            else
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
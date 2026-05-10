namespace WinFormsCalculator
{
    public partial class CalculatorForm : Form
    {
        private double firstNumber; // variable for the first entered number
        private string selectedOperator; // the selector pressed, e.g. +, -, x, /
        
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = btn.Text;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + btn.Text;
            }
            
        }

        private void operatorButton_Click (object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            selectedOperator = btn.Text;
            firstNumber = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
        }
    }
}

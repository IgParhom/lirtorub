using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ConvertLyraToRub(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Сумма не может быть отрицательной");

            double rate;

            if (amount < 50.0)
                rate = 7.0;
            else if (amount < 100.0)
                rate = 6.5;
            else if (amount < 200.0)
                rate = 6.0;
            else if (amount < 500.0)
                rate = 5.5;
            else if (amount < 600.0)
                rate = 5.4;
            else if (amount < 700.0)
                rate = 5.3;
            else if (amount < 800.0)
                rate = 5.2;
            else if (amount < 900.0)
                rate = 5.1;
            else if (amount < 1000.0)
                rate = 5.0;
            else if (amount < 1100.0)
                rate = 4.9;
            else if (amount < 1200.0)
                rate = 4.8;
            else if (amount < 1300.0)
                rate = 4.7;
            else if (amount < 1400.0)
                rate = 4.6;
            else if (amount < 1500.0)
                rate = 4.5;
            else if (amount < 1600.0)
                rate = 4.4;
            else if (amount < 1700.0)
                rate = 4.3;
            else if (amount < 1800.0)
                rate = 4.2;
            else if (amount < 1900.0)
                rate = 4.1;
            else if (amount < 2000.0)
                rate = 4;
            else if (amount < 2200.0)
                rate = 3.9;
            else if (amount < 2400.0)
                rate = 3.8;
            else if (amount < 2600.0)
                rate = 3.7;
            else if (amount < 2800)
                rate = 3.6;
            else
                rate = 3.5;

            double convertedAmount = amount * rate;
            return Math.Floor(convertedAmount / 5) * 5;
        }

        private string replace_reg(string text) 
        {
            string pattern = ".";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(text, replacement);
            return result;
        }
            
            

        private void amountStr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tmp_amount = amountStr.Text;
                tmp_amount = tmp_amount.Replace(".", "");
                amountStr.Text = tmp_amount;
                double amount = Convert.ToDouble(amountStr.Text);
                double itog = ConvertLyraToRub(amount);
                string itog_text = itog.ToString() + " рублей";
                label1.Text = itog_text.ToString();
                Clipboard.SetData(DataFormats.Text, (Object)itog_text);
            }
            catch (Exception ex)
            {
                label1.Text = label1.Text;
            }
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

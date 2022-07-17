namespace StockCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //往上一個tick
        private string plusprice(string textbox)
        {
            decimal price = decimal.Parse(textbox);
            if (price > 0 && price < 10)
            {
                textbox = (price + 0.01m).ToString();
            }
            else if (price >= 10 && price < 50)
            {
                textbox = (price + 0.05m).ToString();
            }
            else if (price >= 50 && price < 100)
            {
                textbox = (price + 0.1m).ToString();
            }
            else if (price >= 100 && price < 500)
            {
                textbox = (price + 0.5m).ToString();
            }
            else if (price >= 500 && price < 1000)
            {
                textbox = (price + 1m).ToString();
            }
            else if (price >= 1000)
            {
                textbox = (price + 5m).ToString();
            }
            return textbox;
        }

        //往下一個tick
        private string subtractprice(string textbox)
        {
            decimal price = decimal.Parse(textbox);
            if (price > 0 && price <= 10)
            {
                textbox = (price - 0.01m).ToString();
            }
            else if (price > 10 && price <= 50)
            {
                textbox = (price - 0.05m).ToString();
            }
            else if (price > 50 && price <= 100)
            {
                textbox = (price - 0.1m).ToString();
            }
            else if (price > 100 && price <= 500)
            {
                textbox = (price - 0.5m).ToString();
            }
            else if (price > 500 && price <= 1000)
            {
                textbox = (price - 1m).ToString();
            }
            else if (price >= 1000)
            {
                textbox = (price - 5m).ToString();
            }
            return textbox;
        }

        //股價*股數*手續費
        private string calculate(string pricetextBox, string unittextBox, decimal price)
        {
            decimal charge = decimal.Parse(pricetextBox) * decimal.Parse(unittextBox) * price;
            charge = decimal.Round(charge, 2);
            return "" + charge;
        }
        //買價*股數+買手續費-買手續折扣
        private string buyprice(string unittextBox, string buypricetextBox, string buychargelabel, string buydiscountlabel)
        {
            decimal price = decimal.Parse(unittextBox) * decimal.Parse(buypricetextBox) + decimal.Parse(buychargelabel) - decimal.Parse(buydiscountlabel);
            return "" + price;
        }

        //賣價*股數-賣手續-交易稅+手續折扣
        private string sellprice(string unittextBox, string sellpricetextBox, string sellchargelabel, string selldiscountlabel, string tradetaxlabel)
        {
            decimal price = decimal.Parse(unittextBox) * decimal.Parse(sellpricetextBox) - decimal.Parse(sellchargelabel) + decimal.Parse(selldiscountlabel) - decimal.Parse(tradetaxlabel);
            return "" + price;
        }

        //買手續費折讓金額
        private string discount(string chargelabel, string chargetextBox)
        {
            decimal Charge;
            Charge = (decimal.Parse(chargelabel) * (1 - decimal.Parse(chargetextBox) * 0.1m));
            Charge = decimal.Round(Charge, 2);
            return "" + Charge;
        }

        //結算百分比
        private string percent(string IncomeStatementlabel, string buypricelabel)
        {
            decimal value = decimal.Parse(IncomeStatementlabel) / Math.Abs(decimal.Parse(buypricelabel)) * 100;
            return "" + decimal.Round(value, 2) + "%";
        }




        private void buysubtractbutton_Click(object sender, EventArgs e)
        {
            if (buypricetextBox.Text != "" && unittextBox.Text != "")
                buypricetextBox.Text = subtractprice(buypricetextBox.Text);
            else
                MessageBox.Show("請輸入價錢與股數");
        }

        private void buyplusbutton_Click(object sender, EventArgs e)
        {
            if (buypricetextBox.Text != "" && unittextBox.Text != "")
                buypricetextBox.Text = plusprice(buypricetextBox.Text);
            else
                MessageBox.Show("請輸入價錢與股數");
        }


        private void sellplusbutton_Click(object sender, EventArgs e)
        {
            if (sellpricetextBox.Text != "" && unittextBox.Text != "")
                sellpricetextBox.Text = plusprice(sellpricetextBox.Text);
            else
                MessageBox.Show("請輸入價錢與股數");
        }

        private void sellsubtractbutton_Click(object sender, EventArgs e)
        {
            if (sellpricetextBox.Text != "" && unittextBox.Text != "")
                sellpricetextBox.Text = subtractprice(sellpricetextBox.Text);
            else
                MessageBox.Show("請輸入價錢與股數");
        }

        private void buyChargelabel_Click(object sender, EventArgs e)
        {

        }

        private void sellChargelabel_Click(object sender, EventArgs e)
        {

        }

        private void buypricetextBox_TextChanged(object sender, EventArgs e)
        {

            if (unittextBox.Text != "" && buypricetextBox.Text != "")
            {
                if (buypricetextBox.Text == "-")
                { }
                else
                    buychargelabel.Text = calculate(buypricetextBox.Text, unittextBox.Text, 0.001425m);
            }
            else
            {
                buychargelabel.Text = "";
                buypricelabel.Text = "";
                IncomeStatementlabel.Text = "";
                percentlabel.Text = "";
                tradetaxlabel.Text = "";
            }

            if (buychargelabel.Text != "" && buychargetextBox.Text != "" && buychargetextBox.Text != "0")
            {
                buydiscountlabel.Text = discount(buychargelabel.Text, buychargetextBox.Text);
                selldiscountlabel.Text = discount(sellchargelabel.Text, sellchargetextBox.Text);

            }
            else
                buydiscountlabel.Text = "0";

            if (unittextBox.Text != "" && buypricetextBox.Text != "" && sellpricetextBox.Text != "")
            {
                tradetaxlabel.Text = calculate(sellpricetextBox.Text, unittextBox.Text, 0.003m);
                while (checkBox1.Checked)
                {
                    decimal tax = decimal.Parse(tradetaxlabel.Text) / 2;
                    tradetaxlabel.Text = "" + tax;
                    break;
                }
            }

            if (unittextBox.Text != "" && buypricetextBox.Text != "" && buychargelabel.Text != "")
            {
                buypricelabel.Text = buyprice(unittextBox.Text, buypricetextBox.Text, buychargelabel.Text, buydiscountlabel.Text);
            }

            if (sellpricelabel.Text != "" && buypricelabel.Text != "")
            {
                IncomeStatementlabel.Text = (decimal.Parse(sellpricelabel.Text) - decimal.Parse(buypricelabel.Text)).ToString();
                percentlabel.Text = percent(IncomeStatementlabel.Text, buypricelabel.Text);
            }
        }

        private void sellpricetextBox_TextChanged(object sender, EventArgs e)
        {
            if (unittextBox.Text != "" && sellpricetextBox.Text != "")
            {
                if (sellpricetextBox.Text == "-")
                { }
                else
                {
                    sellchargelabel.Text = calculate(sellpricetextBox.Text, unittextBox.Text, 0.001425m);
                    tradetaxlabel.Text = calculate(sellpricetextBox.Text, unittextBox.Text, 0.003m);
                }

                while (checkBox1.Checked)
                {
                    decimal tax = decimal.Parse(tradetaxlabel.Text) / 2;
                    tradetaxlabel.Text = "" + tax;
                    break;
                }
            }
            else
            {
                sellchargelabel.Text = "";
                sellpricelabel.Text = "";
                IncomeStatementlabel.Text = "";
                percentlabel.Text = "";
                tradetaxlabel.Text = "";
            }


            if (sellchargelabel.Text != "" && sellchargetextBox.Text != "" && sellchargetextBox.Text != "0")
                selldiscountlabel.Text = discount(sellchargelabel.Text, sellchargetextBox.Text);
            else
                selldiscountlabel.Text = "0";

            if (unittextBox.Text != "" && sellpricetextBox.Text != "" && sellchargelabel.Text != "")
            {
                sellpricelabel.Text = sellprice(unittextBox.Text, sellpricetextBox.Text, sellchargelabel.Text, selldiscountlabel.Text, tradetaxlabel.Text);
            }
            if (sellpricelabel.Text != "" && buypricelabel.Text != "")
            {
                IncomeStatementlabel.Text = (decimal.Parse(sellpricelabel.Text) - decimal.Parse(buypricelabel.Text)).ToString();
                percentlabel.Text = percent(IncomeStatementlabel.Text, buypricelabel.Text);
            }
        }

        private void unittextBox_TextChanged(object sender, EventArgs e)
        {
            if (unittextBox.Text == "")
            {

                buychargelabel.Text = "0";
                sellchargelabel.Text = "0";
                buypricelabel.Text = "";
                sellpricelabel.Text = "";
                IncomeStatementlabel.Text = "";
                percentlabel.Text = "";
                tradetaxlabel.Text = "";
                return;
            }
            else if (unittextBox.Text != "")
            {
                while (sellpricetextBox.Text != "")
                {
                    sellchargelabel.Text = calculate(sellpricetextBox.Text, unittextBox.Text, 0.001425m);
                    sellpricelabel.Text = sellprice(unittextBox.Text, sellpricetextBox.Text, sellchargelabel.Text, selldiscountlabel.Text, tradetaxlabel.Text);
                    break;
                }
                while (buypricetextBox.Text != "")
                {
                    buychargelabel.Text = calculate(buypricetextBox.Text, unittextBox.Text, 0.001425m); ;
                    buypricelabel.Text = buyprice(unittextBox.Text, buypricetextBox.Text, buychargelabel.Text, buydiscountlabel.Text);
                    break;
                }
            }

            if (sellpricelabel.Text != "" && buypricelabel.Text != "")
            {
                IncomeStatementlabel.Text = (decimal.Parse(sellpricelabel.Text) - decimal.Parse(buypricelabel.Text)).ToString();
                percentlabel.Text = percent(IncomeStatementlabel.Text, buypricelabel.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (buychargetextBox.Text != "" && decimal.Parse(buychargetextBox.Text) < 10 && decimal.Parse(buychargetextBox.Text) > 0 && buypricetextBox.Text != "")
            {
                buydiscountlabel.Text = discount(buychargelabel.Text, buychargetextBox.Text);
            }
            else if (buychargetextBox.Text == "" || buychargetextBox.Text == "0")
            {
                buydiscountlabel.Text = "0";
            }
            else if (decimal.Parse(buychargetextBox.Text) > 10 || decimal.Parse(buychargetextBox.Text) < 0)
            {
                MessageBox.Show("格式錯誤");
                buychargetextBox.Text = "";
            }


            if (unittextBox.Text != "" && buypricetextBox.Text != "" && sellpricetextBox.Text != "")
                buypricelabel.Text = buyprice(unittextBox.Text, buypricetextBox.Text, buychargelabel.Text, buydiscountlabel.Text);

            if (sellpricelabel.Text != "" && buypricelabel.Text != "")
            {
                IncomeStatementlabel.Text = (decimal.Parse(sellpricelabel.Text) - decimal.Parse(buypricelabel.Text)).ToString();
                percentlabel.Text = percent(IncomeStatementlabel.Text, buypricelabel.Text);
            }
        }

        private void sellchargetextBox_TextChanged(object sender, EventArgs e)
        {
            if (sellchargetextBox.Text != "" && decimal.Parse(sellchargetextBox.Text) < 10 && decimal.Parse(sellchargetextBox.Text) > 0 && sellpricetextBox.Text != "")
            {
                selldiscountlabel.Text = discount(sellchargelabel.Text, sellchargetextBox.Text);
            }
            else if (sellchargetextBox.Text == "" || sellchargetextBox.Text == "0")
            {
                selldiscountlabel.Text = "0";
            }
            else if (decimal.Parse(sellchargetextBox.Text) > 10 || decimal.Parse(sellchargetextBox.Text) < 0)
            {
                MessageBox.Show("格式錯誤");
                sellchargetextBox.Text = "";
            }

            if (unittextBox.Text != "" && buypricetextBox.Text != "" && sellpricetextBox.Text != "")
                sellpricelabel.Text = sellprice(unittextBox.Text, sellpricetextBox.Text, sellchargelabel.Text, selldiscountlabel.Text, tradetaxlabel.Text);

            if (sellpricelabel.Text != "" && buypricelabel.Text != "")
            {
                IncomeStatementlabel.Text = (decimal.Parse(sellpricelabel.Text) - decimal.Parse(buypricelabel.Text)).ToString();
                percentlabel.Text = percent(IncomeStatementlabel.Text, buypricelabel.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sellpricetextBox.Text != "" && buypricetextBox.Text != "")
            {
                if (checkBox1.Checked)
                {
                    decimal tax = decimal.Parse(tradetaxlabel.Text) / 2;
                    tradetaxlabel.Text = "" + tax;
                }
                else
                {
                    tradetaxlabel.Text = calculate(sellpricetextBox.Text, unittextBox.Text, 0.003m);
                }
                sellpricelabel.Text = sellprice(unittextBox.Text, sellpricetextBox.Text, sellchargelabel.Text, selldiscountlabel.Text, tradetaxlabel.Text);
                if (sellpricelabel.Text != "" && buypricelabel.Text != "")
                {
                    IncomeStatementlabel.Text = (decimal.Parse(sellpricelabel.Text) - decimal.Parse(buypricelabel.Text)).ToString();
                    percentlabel.Text = percent(IncomeStatementlabel.Text, buypricelabel.Text);
                }
            }
            else if (sellpricetextBox.Text == "" && buypricetextBox.Text == "" && checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                MessageBox.Show("請先輸入價格");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
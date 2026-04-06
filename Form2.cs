using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        string mainDish = "Main Dish:\n";
        private void pnl_Burger_Click(object sender, EventArgs e)
        {
            double price = 55;
            int quantity = 2;
            double total = price * quantity;

            MessageBox.Show($"Burger Total: {total:C}");
        }
        private void btn_CPata_Click_1(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Crispy Pata");

            double price = 15;
            int quantity = 1;
            double total = price * quantity;
        }

        private void pnl_FChicken_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add(lst_YourOrder);
            double price = 105;
            int quantity = 1;
            double total = price * quantity;

            MessageBox.Show($"Chicken Total: {total:C}");
        }

        private void pnl_Ramen_Click(object sender, EventArgs e)
        {
            double price = 105;
            int quantity = 3;
            double total = price * quantity;

            MessageBox.Show($"Ramen Total: {total:C}");
        }
        private void btn_Burger_Click_1(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Burger");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_CPata_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Crispy Pata");

            double price = 15;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_FChicken_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Fried Chicken");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_Omlette_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Omlette");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void Ramen_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Ramen");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_CInasal_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Chicken Inasal");

            double price = 25;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_Sphag_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Sphagetti");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_LKawali_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Lechon Kawali");

            double price = 25;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_POverload_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Pares Overload");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_BBQ_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("BBQ");

            double price = 15;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_Steak_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Steak");

            double price = 20;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_HPizza_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Hawaian Pizza");

            double price = 15;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_VSalad_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Vege Salad");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_BamE_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Bam-E");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_Sushi_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Sushi");

            double price = 15;
            int quantity = 1;
            double total = price * quantity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Coca Cola");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Lemmonade");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Ice Coffee");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_IceCream_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Ice Cream");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_HHalo_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Halo-Halo");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Mountain Dew");

            double price = 5;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_MilkTea_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Milk Tea");

            double price = 9.99;
            int quantity = 1;
            double total = price * quantity;
        }

        private void btn_DragonBall_Click(object sender, EventArgs e)
        {
            lst_YourOrder.Items.Add("Dragon Ball");

            double price = 10;
            int quantity = 1;
            double total = price * quantity;
        }
    

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var selectedItems = lst_YourOrder.SelectedItems.Cast<object>().ToList();

            foreach (var item in selectedItems)
            {
                lst_YourOrder.Items.Remove(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nameSentence = "Customer Name: " + txt_CustomerName.Text;

            if (lst_YourOrder.Items.Count == 0)
            {
                lst_YourOrder.Items.Add(nameSentence);
            }
            else
            {
                // Update index 0 if it starts with the name prefix
                if (lst_YourOrder.Items[0].ToString().StartsWith("Customer Name:"))
                {
                    lst_YourOrder.Items[0] = nameSentence;
                }
                else
                {
                    lst_YourOrder.Items.Insert(0, nameSentence);
                }
            }
        }

        private void btn_Calcu_Click(object sender, EventArgs e)
        {

            Dictionary<string, double> menuPrices = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
    {
        { "Burger", 5 }, { "Crispy Pata", 15 }, { "Fried Chicken", 10 }, { "Omlette", 5 },
        { "Ramen", 10 }, { "Chicken Inasal", 20 }, { "Sphagetti", 5 }, { "Lechon Kawali", 25 },
        { "Pares Overload", 10 }, { "BBQ", 15 }, { "Steak", 20 }, { "Hawaian Pizza", 15 },
        { "Vege Salad", 10 }, { "Bam-E", 10 }, { "Sushi", 15 },
        { "Coca Cola", 5 }, { "Ice Tea", 5 }, { "Ice Cream", 5 }, { "Ice Coffee", 5 },
        { "Halo-Halo", 10 }, { "Mountain Dew", 5 }, { "Milk Tea", 9.99 }, { "Dragon Ball", 10 }, { "Lemmonade", 5 }
    };

            if (string.IsNullOrWhiteSpace(txt_CustomerName.Text))
            {
                MessageBox.Show("Please enter Customer Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPayment = rb_Gcash.Checked ? "G-Cash" : rb_EWallet.Checked ? "E-Wallet" :
                                     rb_CC.Checked ? "Credit Card" : rb_Cash.Checked ? "Cash" : "";

            string dineOption = rb_DineIn.Checked ? "Dine-In" : rb_TakeOut.Checked ? "Take-Out" : "";

            if (selectedPayment == "" || dineOption == "")
            {
                MessageBox.Show("Please select Payment and Dine Option.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            double total = 0;
            StringBuilder mainList = new StringBuilder();
            StringBuilder addOnList = new StringBuilder();

            foreach (var item in lst_YourOrder.Items)
            {
                string text = item.ToString();

                
                if (text.StartsWith("Customer Name:") || text.StartsWith("Dine Option:") ||
                    text == "G-Cash" || text == "Cash" || text == "E-Wallet" || text == "Credit Card")
                    continue;

                foreach (var food in menuPrices.Keys)
                {
                    if (text.StartsWith(food, StringComparison.OrdinalIgnoreCase))
                    {
                        if (text.Contains("x")) 
                        {
                            try
                            {
                                string pricePart = text.Split('=')[1].Replace("₱", "").Trim();
                                total += double.Parse(pricePart, System.Globalization.NumberStyles.Any);
                                mainList.AppendLine(text);
                            }
                            catch { }
                        }
                        else 
                        {
                            total += menuPrices[food];
                            addOnList.AppendLine($"{food} - {menuPrices[food]:C}");
                        }
                        break;
                    }
                }
            }

            // Receipt DatA
            string currentDate = DateTime.Now.ToString("MMMM dd, yyyy (hh:mm tt)");
            int orderNum = new Random().Next(1000, 9999);

            // receipy
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("========= OFFICIAL RECEIPT =========");
            receipt.AppendLine($"Order #: {orderNum} ");
            receipt.AppendLine($"Date: {currentDate}");
            receipt.AppendLine($"Customer: {txt_CustomerName.Text}");
            receipt.AppendLine($"Option: {dineOption}");
            receipt.AppendLine("------------------------------------");
            receipt.AppendLine("ITEMS:");
            receipt.AppendLine(mainList.Length > 0 ? mainList.ToString() : "No Main Dishes");
            receipt.AppendLine(addOnList.Length > 0 ? addOnList.ToString() : "No Add-ons");
            receipt.AppendLine("------------------------------------");
            receipt.AppendLine($"TOTAL PAYMENT: {total:C}");
            receipt.AppendLine($"PAYMENT VIA: {selectedPayment}");
            receipt.AppendLine("====================================");
            receipt.AppendLine("\nCoder: Romnick Carao");
            receipt.AppendLine("Section: IT201A");
            receipt.AppendLine("Subject: Copro2");
            MessageBox.Show(receipt.ToString(), "Order Summary");
        }

        private void rb_Gcash_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Gcash.Checked)
            {
                lst_YourOrder.Items.Add("G-Cash");
            }
        }

        private void rb_EWallet_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EWallet.Checked)
            {
                lst_YourOrder.Items.Add("E-Wallet");
            }
        }

        private void rb_CC_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_CC.Checked)
            {
                lst_YourOrder.Items.Add("Credit Card");
            }
        }

        private void rb_Cash_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Cash.Checked)
            {
                lst_YourOrder.Items.Add("Cash");
            }
        }

        private void rb_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_TakeOut.Checked)
            {
                lst_YourOrder.Items.Add("Take-Out");
            }
        }

        private void rb_DineIn_CheckedChanged(object sender, EventArgs e)
        {
            if( rb_DineIn.Checked)
            {
                lst_YourOrder.Items.Add("Dine-In");
            }
        }
    }
}


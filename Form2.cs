using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
namespace Pizza_Project
{

    public partial class frmPizzaMenue : Form
    {
        float GetSelectedSizePrice()
        {
            if (rd_small.Checked)
                return Convert.ToSingle(rd_small.Tag);
            else if (rd_medium.Checked)
                return Convert.ToSingle(rd_medium.Tag);
            else
                return Convert.ToSingle(rd_large.Tag);

         }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;
            if (chk_cheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_cheese.Tag);
            }
            if (chk_mushroom.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_mushroom.Tag);
            }
            if (chk_olives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_olives.Tag);

            }
            if (chk_Onion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Onion.Tag);
            }
            if (chk_peper.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_peper.Tag);
            }
            if (chk_Tomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Tomatoes.Tag);
            }
            return ToppingsTotalPrice;
        }
        float GetSelectedCrustPrice()
        {
            if (rdThin.Checked)
                return Convert.ToSingle(rdThin.Tag);
            else
                return Convert.ToSingle(rdThink.Tag);
        }
        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + GetSelectedSizePrice() + CalculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            try
            {
                lb_TotalPrice.Text = "$" + CalculateTotalPrice().ToString();

            }

            catch (Exception ex) { MessageBox.Show("Error Calculating Total price: " + ex.Message); }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if (rdEat_in.Checked)
            {
                lb_WhereToEat.Text = "Eat In";
                return;
            }
            if (rdTake_Out.Checked)
            {
                lb_WhereToEat.Text = "Take Out";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rdThin.Checked)
            {
                lb_CurstType.Text = "Think Crust";
                return;
            }
            if (rdThink.Checked)
            {
                lb_CurstType.Text = "Thick Curst";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            if (chk_cheese.Checked)
            {
                sToppings = "Extra Cheese";
            }
            if (chk_mushroom.Checked)
            {
                sToppings += " , Mushrooms";
            }
            if (chk_olives.Checked)
            {
                sToppings += " , Olives";
            }
            if (chk_Onion.Checked)
            {
                sToppings += " , Onion";
            }
            if (chk_peper.Checked)
            {
                sToppings += " , Green Peper";
            }
            if (chk_Tomatoes.Checked)
            {
                sToppings += " , Tomatos";
            }
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.TrimStart(',').Trim();
            }
            if (sToppings=="")
            {
                sToppings = "NO Toppings";
            }
            lb_Topping.Text = sToppings;
        }
        void UpdateSize()
        {
            UpdateTotalPrice() ;
            if (rd_small.Checked)
            {
                lb_size.Text = "Small";
                return;
            }
            if (rd_medium.Checked)
            {
                lb_size.Text = "Medium";
                return;
            }
            if (rd_large.Checked)
            {
                lb_size.Text = "Large";
                return;
            }
        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {
            gp_size.Enabled = true;
            gp_Toppings.Enabled = true;
            gp_where.Enabled = true;
            gpCrustType.Enabled = true;

            rd_medium.Checked = true;

            chk_cheese.Checked = false;
            chk_mushroom.Checked = false;
            chk_olives.Checked = false;
            chk_Onion.Checked = false;
            chk_peper.Checked = false;
            chk_Tomatoes.Checked = false;

            rdThin.Checked= true;
            rdEat_in.Checked= true;
            btnOrderPizaa.Enabled = true;

        }
        public frmPizzaMenue()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lb1menue.Parent = pictureBox1;
            lb1menue.BackColor = Color.Transparent;

            gpCrustType.Parent = pictureBox1;
            gpCrustType.BackColor = Color.Transparent;

            gp_size.Parent = pictureBox1;
            gp_size.BackColor = Color.Transparent;

            gp_Toppings.Parent = pictureBox1;
            gp_Toppings.BackColor = Color.Transparent;

            gp_where.Parent = pictureBox1;
            gp_where.BackColor = Color.Transparent;
            gp_OrderSammary.Parent = pictureBox1;
            gp_OrderSammary.BackColor = Color.Transparent;
            rdEat_in.Checked = true;
            rdThin.Checked = true;
            UpdateOrderSummary();

        }

       
        private void btnOrderPizaa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizaa.Enabled = false;
                gpCrustType.Enabled = false;
                gp_size.Enabled = false;
                gp_Toppings.Enabled = false;
                gp_where.Enabled = false;


            }
            else
            {
                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rd_small_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rd_medium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rd_large_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chk_cheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chk_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chk_olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chk_mushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chk_peper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void rdThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void rdEat_in_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdTake_Out_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        
    }
}

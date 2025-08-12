using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl_2
{
    public partial class CfrmStockControl : Form
    {
        List<CItem> lstItems;
        public CfrmStockControl()
        {
            InitializeComponent();

            lstItems = new List<CItem>();
        }

        private void lblCloseStock_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {

        }

        public void ClearFields()
        {
            txtCostPrice.Clear();
            txtItemCode.Clear();
            txtItemName.Clear();
            txtQuantity.Clear();
            txtRetailPrice.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CItem item = new CItem
                {
                    ItemCode = txtItemCode.Text,
                    ItemName = txtItemName.Text
                };
                item.CostPrice = decimal.Parse(txtCostPrice.Text);
                item.RetailPrice = decimal.Parse(txtRetailPrice.Text);
                //item.Quantity = int.Parse(txtQuantity.Text);
                item.Quantity = int.Parse(txtQuantity.Text).ToString();

                lstItems.Add(item);
                ClearFields();
            }
            catch
            {
                MessageBox.Show(CItem.Instructions(), "STOCK CONTROL",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListItems_Click(object sender, EventArgs e)
        {
            CfrmlstItems itemList = new CfrmlstItems(lstItems);
            //itemList.Show();
            itemList.ShowDialog();

            //version 2
            //lstItems.Sort(CompareByCode);

            //version 3
            //if (radItemCode.Checked)
            //    lstItems.Sort(CompareByCode);
            //if(radItemName.Checked)
            //    lstItems.Sort(CompareByName);
            //if(radItemPrice.Checked)
            //    lstItems.Sort(CompareByPrice);
            //ListItems();
        }

        //to find a specific item in the list
        private CItem GetItem(string _itemCode)
        {
            bool isFound = false;
            int i = 0;
            CItem item = null;
            while (i <= lstItems.Count - 1 && !isFound)
            {
                item = lstItems[i];
                if (item.ItemCode == _itemCode)
                {
                    isFound = true;
                }
                else
                    i++;
            }
            return (isFound) ? item : null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Read item code of the item to remove
            string itemCode = Interaction.InputBox("Item code of the item to remove:",
                                                    "STOCK CONTROL", "", 200, 200);

            //obtain item in the list
            CItem item = GetItem(itemCode);
            if (item != null)
            {
                if (MessageBox.Show("Are you sure you want to remove item with code "
                                    + itemCode + "?", "STOCK CONTROL", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //remove this item from the list
                    lstItems.Remove(item);
                    MessageBox.Show("Item successfully removed.", "STOCK CONTROL",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Item not found.", "STOCK CONTROL",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnMarkUp_Click(object sender, EventArgs e)
        {
            string markUp = Interaction.InputBox("Mark-up (%):", "STOCK CONTROL",
                                                CItem.MarkUp.ToString("0.0"), 200, 200);
            try
            {
                CItem.MarkUp = double.Parse(markUp);
            }
            catch
            {
                MessageBox.Show("Invalid numeric value.", "STOCK CONTROL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetRetailPrice_Click(object sender, EventArgs e)
        {
            foreach (CItem item in lstItems)
            {
                item.SetRetailPrice(CItem.MarkUp);
            }
            MessageBox.Show("Retail prices set to " + CItem.MarkUp.ToString("0.0")
                            + "% above cost price.", "STOCK CONTROL",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            //read item code of item to sell
            string itemCode = Interaction.InputBox("Item code of item to sell:",
                                                    "STOCK CONTROL", "", 200, 200);

            //obtain item in the list
            CItem item = GetItem(itemCode);
            if (item != null)
            {
                if (item.Sale())
                {
                    MessageBox.Show("Item sold.", "STOCK CONTROL",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No stock available.", "STOCK CONTROL",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Item not found.", "STOCK CONTROL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


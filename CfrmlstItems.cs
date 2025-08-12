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
    public partial class CfrmlstItems : Form
    {
        public CfrmlstItems(List<CItem> items)
        {
            InitializeComponent();
            LoadItems(items);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadItems(List<CItem> items)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = items;

            //adjust headers
            //dataGridView1.Columns["ItemCode"].HeaderText = "Code";
            //dataGridView1.Columns["ItemName"].HeaderText = "Name";
            //dataGridView1.Columns["CostPrice"].HeaderText = "Cost Price";
            //dataGridView1.Columns["RetailPrice"].HeaderText = "Retail Price";
            //dataGridView1.Columns["Quantity"].HeaderText = "Quantity";

            // Add rows from the list
            foreach (CItem item in items)
            {
                dataGridView1.Rows.Add(item.ItemCode, item.ItemName, item.RetailPrice, item.CostPrice, item.Quantity);
            }
        }
    }
}

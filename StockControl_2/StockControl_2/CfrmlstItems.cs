using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl_2
{
    public partial class CfrmlstItems : Form
    {
        private List<CItem> lstItems = new List<CItem>();
        public CfrmlstItems(List<CItem> items)
        {
            InitializeComponent();
            lstItems = items;
            LoadItems(items);


            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadItems(List<CItem> items)
        {
            //edit
            dataGridView1.Rows.Clear();

            //add rows from the list
            foreach (CItem item in items)
            {
                dataGridView1.Rows.Add(item.ItemCode, item.ItemName, item.CostPrice, item.RetailPrice, item.Quantity);
            }
        }

        

        private void CfrmlstItems_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchItem = txtSearch.Text.ToLower();

                var filteredItems = lstItems
                    .Where(item => item.ItemCode.ToLower().Contains(searchItem)
                    || item.ItemName.ToLower().Contains(searchItem)).ToList();

                LoadItems(filteredItems);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Search error: " +  ex.Message);
            }

        }
    }
}

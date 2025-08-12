namespace StockControl_2
{
    partial class CfrmStockControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnListItems = new System.Windows.Forms.Button();
            this.btnSetRetailPrice = new System.Windows.Forms.Button();
            this.btnMarkUp = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCloseStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(215, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 31);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(215, 243);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(136, 22);
            this.txtQuantity.TabIndex = 37;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(215, 204);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(136, 22);
            this.txtRetailPrice.TabIndex = 36;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(215, 165);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(136, 22);
            this.txtCostPrice.TabIndex = 35;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(215, 128);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(136, 22);
            this.txtItemName.TabIndex = 34;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(215, 95);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(136, 22);
            this.txtItemCode.TabIndex = 33;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 31);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnListItems
            // 
            this.btnListItems.Location = new System.Drawing.Point(56, 473);
            this.btnListItems.Name = "btnListItems";
            this.btnListItems.Size = new System.Drawing.Size(136, 31);
            this.btnListItems.TabIndex = 31;
            this.btnListItems.Text = "&List  Items";
            this.btnListItems.UseVisualStyleBackColor = true;
            this.btnListItems.Click += new System.EventHandler(this.btnListItems_Click);
            // 
            // btnSetRetailPrice
            // 
            this.btnSetRetailPrice.Location = new System.Drawing.Point(56, 436);
            this.btnSetRetailPrice.Name = "btnSetRetailPrice";
            this.btnSetRetailPrice.Size = new System.Drawing.Size(136, 31);
            this.btnSetRetailPrice.TabIndex = 30;
            this.btnSetRetailPrice.Text = "Set Retail Prices";
            this.btnSetRetailPrice.UseVisualStyleBackColor = true;
            this.btnSetRetailPrice.Click += new System.EventHandler(this.btnSetRetailPrice_Click);
            // 
            // btnMarkUp
            // 
            this.btnMarkUp.Location = new System.Drawing.Point(215, 436);
            this.btnMarkUp.Name = "btnMarkUp";
            this.btnMarkUp.Size = new System.Drawing.Size(136, 31);
            this.btnMarkUp.TabIndex = 29;
            this.btnMarkUp.Text = "Mark-up";
            this.btnMarkUp.UseVisualStyleBackColor = true;
            this.btnMarkUp.Click += new System.EventHandler(this.btnMarkUp_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(56, 399);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(136, 31);
            this.btnReceive.TabIndex = 28;
            this.btnReceive.Text = "Receive Stock";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(215, 399);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(136, 31);
            this.btnSale.TabIndex = 27;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(215, 362);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 31);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 31);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quality On Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Retail Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cost Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(52, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "STOCK MANAGEMENT";
            // 
            // lblCloseStock
            // 
            this.lblCloseStock.AutoSize = true;
            this.lblCloseStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCloseStock.Location = new System.Drawing.Point(382, 9);
            this.lblCloseStock.Name = "lblCloseStock";
            this.lblCloseStock.Size = new System.Drawing.Size(25, 24);
            this.lblCloseStock.TabIndex = 40;
            this.lblCloseStock.Text = "X";
            this.lblCloseStock.Click += new System.EventHandler(this.lblCloseStock_Click);
            // 
            // CfrmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 570);
            this.ControlBox = false;
            this.Controls.Add(this.lblCloseStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnListItems);
            this.Controls.Add(this.btnSetRetailPrice);
            this.Controls.Add(this.btnMarkUp);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CfrmStockControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK CONTROL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnListItems;
        private System.Windows.Forms.Button btnSetRetailPrice;
        private System.Windows.Forms.Button btnMarkUp;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCloseStock;
    }
}
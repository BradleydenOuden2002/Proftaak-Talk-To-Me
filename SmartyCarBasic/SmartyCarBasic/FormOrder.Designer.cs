
namespace SmartyCarBasic
{
    partial class FormOrder
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
            this.button5 = new System.Windows.Forms.Button();
            this.BtOrder = new System.Windows.Forms.Button();
            this.BtMainMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtExit = new System.Windows.Forms.Button();
            this.LvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LbItemSelected = new System.Windows.Forms.Label();
            this.LbSelecteditemPrice = new System.Windows.Forms.Label();
            this.LbAmountOrder = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtSup = new System.Windows.Forms.Button();
            this.LbTotal = new System.Windows.Forms.Label();
            this.BtAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(287, 689);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtOrder
            // 
            this.BtOrder.Location = new System.Drawing.Point(216, 689);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(65, 65);
            this.BtOrder.TabIndex = 9;
            this.BtOrder.Text = "Order";
            this.BtOrder.UseVisualStyleBackColor = true;
            // 
            // BtMainMenu
            // 
            this.BtMainMenu.Location = new System.Drawing.Point(145, 688);
            this.BtMainMenu.Name = "BtMainMenu";
            this.BtMainMenu.Size = new System.Drawing.Size(65, 65);
            this.BtMainMenu.TabIndex = 8;
            this.BtMainMenu.Text = "Home";
            this.BtMainMenu.UseVisualStyleBackColor = true;
            this.BtMainMenu.Click += new System.EventHandler(this.BtMainMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(270, 12);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(75, 23);
            this.BtExit.TabIndex = 12;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // LvProducts
            // 
            this.LvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvProducts.HideSelection = false;
            this.LvProducts.Location = new System.Drawing.Point(12, 94);
            this.LvProducts.MultiSelect = false;
            this.LvProducts.Name = "LvProducts";
            this.LvProducts.Size = new System.Drawing.Size(333, 367);
            this.LvProducts.TabIndex = 13;
            this.LvProducts.UseCompatibleStateImageBehavior = false;
            this.LvProducts.View = System.Windows.Forms.View.Details;
            this.LvProducts.SelectedIndexChanged += new System.EventHandler(this.LvProducts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductName";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // LbItemSelected
            // 
            this.LbItemSelected.AutoSize = true;
            this.LbItemSelected.Location = new System.Drawing.Point(22, 483);
            this.LbItemSelected.Name = "LbItemSelected";
            this.LbItemSelected.Size = new System.Drawing.Size(0, 17);
            this.LbItemSelected.TabIndex = 14;
            // 
            // LbSelecteditemPrice
            // 
            this.LbSelecteditemPrice.AutoSize = true;
            this.LbSelecteditemPrice.Location = new System.Drawing.Point(181, 483);
            this.LbSelecteditemPrice.Name = "LbSelecteditemPrice";
            this.LbSelecteditemPrice.Size = new System.Drawing.Size(0, 17);
            this.LbSelecteditemPrice.TabIndex = 15;
            // 
            // LbAmountOrder
            // 
            this.LbAmountOrder.AutoSize = true;
            this.LbAmountOrder.Location = new System.Drawing.Point(112, 557);
            this.LbAmountOrder.Name = "LbAmountOrder";
            this.LbAmountOrder.Size = new System.Drawing.Size(16, 17);
            this.LbAmountOrder.TabIndex = 16;
            this.LbAmountOrder.Text = "0";
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(153, 536);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(61, 58);
            this.BtAdd.TabIndex = 17;
            this.BtAdd.Text = "+";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtSup
            // 
            this.BtSup.Location = new System.Drawing.Point(25, 536);
            this.BtSup.Name = "BtSup";
            this.BtSup.Size = new System.Drawing.Size(61, 58);
            this.BtSup.TabIndex = 18;
            this.BtSup.Text = "-";
            this.BtSup.UseVisualStyleBackColor = true;
            this.BtSup.Click += new System.EventHandler(this.BtSup_Click);
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Location = new System.Drawing.Point(230, 536);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(40, 17);
            this.LbTotal.TabIndex = 19;
            this.LbTotal.Text = "Total";
            // 
            // BtAddToCart
            // 
            this.BtAddToCart.Location = new System.Drawing.Point(25, 616);
            this.BtAddToCart.Name = "BtAddToCart";
            this.BtAddToCart.Size = new System.Drawing.Size(189, 40);
            this.BtAddToCart.TabIndex = 20;
            this.BtAddToCart.Text = "Add to Cart";
            this.BtAddToCart.UseVisualStyleBackColor = true;
            this.BtAddToCart.Click += new System.EventHandler(this.BtAddToCart_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 765);
            this.Controls.Add(this.BtAddToCart);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.BtSup);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.LbAmountOrder);
            this.Controls.Add(this.LbSelecteditemPrice);
            this.Controls.Add(this.LbItemSelected);
            this.Controls.Add(this.LvProducts);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtOrder);
            this.Controls.Add(this.BtMainMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormOrder";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtOrder;
        private System.Windows.Forms.Button BtMainMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.ListView LvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label LbItemSelected;
        private System.Windows.Forms.Label LbSelecteditemPrice;
        private System.Windows.Forms.Label LbAmountOrder;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtSup;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Button BtAddToCart;
    }
}
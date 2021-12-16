
namespace SmartyCarBasic
{
    partial class FormShoppingCart
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
            this.BtShoppingCard = new System.Windows.Forms.Button();
            this.BtOrder = new System.Windows.Forms.Button();
            this.BtHome = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LvShoppingCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtShoppingCard
            // 
            this.BtShoppingCard.Location = new System.Drawing.Point(288, 689);
            this.BtShoppingCard.Name = "BtShoppingCard";
            this.BtShoppingCard.Size = new System.Drawing.Size(65, 65);
            this.BtShoppingCard.TabIndex = 10;
            this.BtShoppingCard.Text = "Shopping Card";
            this.BtShoppingCard.UseVisualStyleBackColor = true;
            this.BtShoppingCard.Click += new System.EventHandler(this.BtShoppingCard_Click);
            // 
            // BtOrder
            // 
            this.BtOrder.Location = new System.Drawing.Point(217, 689);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(65, 65);
            this.BtOrder.TabIndex = 9;
            this.BtOrder.Text = "Order";
            this.BtOrder.UseVisualStyleBackColor = true;
            this.BtOrder.Click += new System.EventHandler(this.BtOrder_Click);
            // 
            // BtHome
            // 
            this.BtHome.Location = new System.Drawing.Point(146, 688);
            this.BtHome.Name = "BtHome";
            this.BtHome.Size = new System.Drawing.Size(65, 65);
            this.BtHome.TabIndex = 8;
            this.BtHome.Text = "Home";
            this.BtHome.UseVisualStyleBackColor = true;
            this.BtHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LvShoppingCart
            // 
            this.LvShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvShoppingCart.HideSelection = false;
            this.LvShoppingCart.Location = new System.Drawing.Point(12, 94);
            this.LvShoppingCart.MultiSelect = false;
            this.LvShoppingCart.Name = "LvShoppingCart";
            this.LvShoppingCart.Size = new System.Drawing.Size(333, 367);
            this.LvShoppingCart.TabIndex = 14;
            this.LvShoppingCart.UseCompatibleStateImageBehavior = false;
            this.LvShoppingCart.View = System.Windows.Forms.View.Details;
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
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(270, 12);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(75, 23);
            this.BtExit.TabIndex = 15;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 765);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.LvShoppingCart);
            this.Controls.Add(this.BtShoppingCard);
            this.Controls.Add(this.BtOrder);
            this.Controls.Add(this.BtHome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormShoppingCart";
            this.Text = "FormShoppingCard";
            this.Load += new System.EventHandler(this.FormShoppingCart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtShoppingCard;
        private System.Windows.Forms.Button BtOrder;
        private System.Windows.Forms.Button BtHome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LvShoppingCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtExit;
    }
}
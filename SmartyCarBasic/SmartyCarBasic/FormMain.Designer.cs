
namespace SmartyCarBasic
{
    partial class FormMain
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
            this.BtExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtMainMenu = new System.Windows.Forms.Button();
            this.BtOrder = new System.Windows.Forms.Button();
            this.BtShoppingCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(270, 12);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(75, 23);
            this.BtExit.TabIndex = 0;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtMainMenu
            // 
            this.BtMainMenu.Location = new System.Drawing.Point(145, 688);
            this.BtMainMenu.Name = "BtMainMenu";
            this.BtMainMenu.Size = new System.Drawing.Size(65, 65);
            this.BtMainMenu.TabIndex = 3;
            this.BtMainMenu.Text = "Home";
            this.BtMainMenu.UseVisualStyleBackColor = true;
            this.BtMainMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtOrder
            // 
            this.BtOrder.Location = new System.Drawing.Point(216, 689);
            this.BtOrder.Name = "BtOrder";
            this.BtOrder.Size = new System.Drawing.Size(65, 65);
            this.BtOrder.TabIndex = 4;
            this.BtOrder.Text = "Order";
            this.BtOrder.UseVisualStyleBackColor = true;
            this.BtOrder.Click += new System.EventHandler(this.BtOrder_Click);
            // 
            // BtShoppingCart
            // 
            this.BtShoppingCart.Location = new System.Drawing.Point(287, 689);
            this.BtShoppingCart.Name = "BtShoppingCart";
            this.BtShoppingCart.Size = new System.Drawing.Size(65, 65);
            this.BtShoppingCart.TabIndex = 5;
            this.BtShoppingCart.Text = "Shopping Cart";
            this.BtShoppingCart.UseVisualStyleBackColor = true;
            this.BtShoppingCart.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 765);
            this.Controls.Add(this.BtShoppingCart);
            this.Controls.Add(this.BtOrder);
            this.Controls.Add(this.BtMainMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtExit);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtMainMenu;
        private System.Windows.Forms.Button BtOrder;
        private System.Windows.Forms.Button BtShoppingCart;
    }
}


namespace Simulation_Lab16
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAmountToBuy = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalRubles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.inputAmountToSell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonBuy);
            this.tabPage1.Controls.Add(this.inputAmountToBuy);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonSell);
            this.tabPage2.Controls.Add(this.inputAmountToSell);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sell";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(13, 13);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(34, 13);
            this.labelDays.TabIndex = 1;
            this.labelDays.Text = "Days:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(16, 38);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(125, 13);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 13);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total: $0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "$:";
            // 
            // inputAmountToBuy
            // 
            this.inputAmountToBuy.Location = new System.Drawing.Point(28, 49);
            this.inputAmountToBuy.Name = "inputAmountToBuy";
            this.inputAmountToBuy.Size = new System.Drawing.Size(145, 20);
            this.inputAmountToBuy.TabIndex = 1;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(179, 47);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 2;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "You have a Total amount of dollars($) and with this money is possible to buy rubl" +
                "es at the price indicated";
            // 
            // labelTotalRubles
            // 
            this.labelTotalRubles.AutoSize = true;
            this.labelTotalRubles.Location = new System.Drawing.Point(125, 38);
            this.labelTotalRubles.Name = "labelTotalRubles";
            this.labelTotalRubles.Size = new System.Drawing.Size(34, 13);
            this.labelTotalRubles.TabIndex = 4;
            this.labelTotalRubles.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the amount of dollars to exchange to rubles";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter the amount of rubles to exchange to dollars";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 59);
            this.label5.TabIndex = 8;
            this.label5.Text = "You have a Total amount of rubles which you can sell";
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(179, 47);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(75, 23);
            this.buttonSell.TabIndex = 7;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // inputAmountToSell
            // 
            this.inputAmountToSell.Location = new System.Drawing.Point(58, 49);
            this.inputAmountToSell.Name = "inputAmountToSell";
            this.inputAmountToSell.Size = new System.Drawing.Size(115, 20);
            this.inputAmountToSell.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rubles: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.labelTotalRubles);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Buy/Sell";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox inputAmountToBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalRubles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox inputAmountToSell;
        private System.Windows.Forms.Label label6;
    }
}
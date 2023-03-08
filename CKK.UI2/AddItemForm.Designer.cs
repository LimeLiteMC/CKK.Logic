
namespace CKK.UI2
{
    partial class AddItemForm
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
            this.AddPriceLabel = new System.Windows.Forms.Label();
            this.AddQuantityLabel = new System.Windows.Forms.Label();
            this.AddProductNameLabel = new System.Windows.Forms.Label();
            this.AddPriceBox = new System.Windows.Forms.TextBox();
            this.AddQuantityBox = new System.Windows.Forms.TextBox();
            this.AddProductNameBox = new System.Windows.Forms.TextBox();
            this.AddSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPriceLabel
            // 
            this.AddPriceLabel.AutoSize = true;
            this.AddPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddPriceLabel.Location = new System.Drawing.Point(326, 234);
            this.AddPriceLabel.Name = "AddPriceLabel";
            this.AddPriceLabel.Size = new System.Drawing.Size(48, 20);
            this.AddPriceLabel.TabIndex = 11;
            this.AddPriceLabel.Text = "Price:";
            // 
            // AddQuantityLabel
            // 
            this.AddQuantityLabel.AutoSize = true;
            this.AddQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddQuantityLabel.Location = new System.Drawing.Point(302, 192);
            this.AddQuantityLabel.Name = "AddQuantityLabel";
            this.AddQuantityLabel.Size = new System.Drawing.Size(72, 20);
            this.AddQuantityLabel.TabIndex = 10;
            this.AddQuantityLabel.Text = "Quantity:";
            // 
            // AddProductNameLabel
            // 
            this.AddProductNameLabel.AutoSize = true;
            this.AddProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddProductNameLabel.Location = new System.Drawing.Point(260, 149);
            this.AddProductNameLabel.Name = "AddProductNameLabel";
            this.AddProductNameLabel.Size = new System.Drawing.Size(114, 20);
            this.AddProductNameLabel.TabIndex = 9;
            this.AddProductNameLabel.Text = "Product Name:";
            // 
            // AddPriceBox
            // 
            this.AddPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddPriceBox.Location = new System.Drawing.Point(380, 234);
            this.AddPriceBox.Name = "AddPriceBox";
            this.AddPriceBox.Size = new System.Drawing.Size(160, 26);
            this.AddPriceBox.TabIndex = 8;
            // 
            // AddQuantityBox
            // 
            this.AddQuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddQuantityBox.Location = new System.Drawing.Point(380, 189);
            this.AddQuantityBox.Name = "AddQuantityBox";
            this.AddQuantityBox.Size = new System.Drawing.Size(160, 26);
            this.AddQuantityBox.TabIndex = 7;
            // 
            // AddProductNameBox
            // 
            this.AddProductNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddProductNameBox.Location = new System.Drawing.Point(380, 146);
            this.AddProductNameBox.Name = "AddProductNameBox";
            this.AddProductNameBox.Size = new System.Drawing.Size(160, 26);
            this.AddProductNameBox.TabIndex = 6;
            // 
            // AddSubmitButton
            // 
            this.AddSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddSubmitButton.Location = new System.Drawing.Point(361, 315);
            this.AddSubmitButton.Name = "AddSubmitButton";
            this.AddSubmitButton.Size = new System.Drawing.Size(87, 44);
            this.AddSubmitButton.TabIndex = 12;
            this.AddSubmitButton.Text = "Submit";
            this.AddSubmitButton.UseVisualStyleBackColor = true;
            this.AddSubmitButton.Click += new System.EventHandler(this.AddSubmitButton_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSubmitButton);
            this.Controls.Add(this.AddPriceLabel);
            this.Controls.Add(this.AddQuantityLabel);
            this.Controls.Add(this.AddProductNameLabel);
            this.Controls.Add(this.AddPriceBox);
            this.Controls.Add(this.AddQuantityBox);
            this.Controls.Add(this.AddProductNameBox);
            this.Name = "AddItemForm";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPriceLabel;
        private System.Windows.Forms.Label AddQuantityLabel;
        private System.Windows.Forms.Label AddProductNameLabel;
        private System.Windows.Forms.TextBox AddPriceBox;
        private System.Windows.Forms.TextBox AddQuantityBox;
        private System.Windows.Forms.TextBox AddProductNameBox;
        private System.Windows.Forms.Button AddSubmitButton;
    }
}
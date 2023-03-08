
namespace CKK.UI2
{
    partial class RemoveItemForm
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
            this.RemProductNameBox = new System.Windows.Forms.TextBox();
            this.RemQuantityBox = new System.Windows.Forms.TextBox();
            this.RemProductNameLabel = new System.Windows.Forms.Label();
            this.RemQuantityLabel = new System.Windows.Forms.Label();
            this.RemIDLabel = new System.Windows.Forms.Label();
            this.RemPriceBox = new System.Windows.Forms.TextBox();
            this.RemSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemProductNameBox
            // 
            this.RemProductNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemProductNameBox.Location = new System.Drawing.Point(335, 147);
            this.RemProductNameBox.Name = "RemProductNameBox";
            this.RemProductNameBox.Size = new System.Drawing.Size(160, 26);
            this.RemProductNameBox.TabIndex = 0;
            // 
            // RemQuantityBox
            // 
            this.RemQuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemQuantityBox.Location = new System.Drawing.Point(335, 238);
            this.RemQuantityBox.Name = "RemQuantityBox";
            this.RemQuantityBox.Size = new System.Drawing.Size(160, 26);
            this.RemQuantityBox.TabIndex = 1;
            // 
            // RemProductNameLabel
            // 
            this.RemProductNameLabel.AutoSize = true;
            this.RemProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemProductNameLabel.Location = new System.Drawing.Point(215, 150);
            this.RemProductNameLabel.Name = "RemProductNameLabel";
            this.RemProductNameLabel.Size = new System.Drawing.Size(114, 20);
            this.RemProductNameLabel.TabIndex = 3;
            this.RemProductNameLabel.Text = "Product Name:";
            // 
            // RemQuantityLabel
            // 
            this.RemQuantityLabel.AutoSize = true;
            this.RemQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemQuantityLabel.Location = new System.Drawing.Point(257, 238);
            this.RemQuantityLabel.Name = "RemQuantityLabel";
            this.RemQuantityLabel.Size = new System.Drawing.Size(72, 20);
            this.RemQuantityLabel.TabIndex = 4;
            this.RemQuantityLabel.Text = "Quantity:";
            // 
            // RemIDLabel
            // 
            this.RemIDLabel.AutoSize = true;
            this.RemIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemIDLabel.Location = new System.Drawing.Point(242, 197);
            this.RemIDLabel.Name = "RemIDLabel";
            this.RemIDLabel.Size = new System.Drawing.Size(87, 20);
            this.RemIDLabel.TabIndex = 5;
            this.RemIDLabel.Text = "Find By ID:";
            // 
            // RemPriceBox
            // 
            this.RemPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemPriceBox.Location = new System.Drawing.Point(335, 191);
            this.RemPriceBox.Name = "RemPriceBox";
            this.RemPriceBox.Size = new System.Drawing.Size(160, 26);
            this.RemPriceBox.TabIndex = 2;
            // 
            // RemSubmitButton
            // 
            this.RemSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RemSubmitButton.Location = new System.Drawing.Point(335, 308);
            this.RemSubmitButton.Name = "RemSubmitButton";
            this.RemSubmitButton.Size = new System.Drawing.Size(97, 51);
            this.RemSubmitButton.TabIndex = 6;
            this.RemSubmitButton.Text = "Submit";
            this.RemSubmitButton.UseVisualStyleBackColor = true;
            this.RemSubmitButton.Click += new System.EventHandler(this.RemSubmitButton_Click);
            // 
            // RemoveItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemSubmitButton);
            this.Controls.Add(this.RemIDLabel);
            this.Controls.Add(this.RemQuantityLabel);
            this.Controls.Add(this.RemProductNameLabel);
            this.Controls.Add(this.RemPriceBox);
            this.Controls.Add(this.RemQuantityBox);
            this.Controls.Add(this.RemProductNameBox);
            this.Name = "RemoveItemForm";
            this.Text = "Remove Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RemProductNameBox;
        private System.Windows.Forms.TextBox RemQuantityBox;
        private System.Windows.Forms.Label RemProductNameLabel;
        private System.Windows.Forms.Label RemQuantityLabel;
        private System.Windows.Forms.Label RemIDLabel;
        private System.Windows.Forms.TextBox RemPriceBox;
        private System.Windows.Forms.Button RemSubmitButton;
    }
}
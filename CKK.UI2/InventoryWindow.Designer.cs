
namespace CKK.UI2
{
    partial class InventoryWindow
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.InventoryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(535, 36);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // InventoryList
            // 
            this.InventoryList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.Location = new System.Drawing.Point(0, 82);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.Size = new System.Drawing.Size(800, 368);
            this.InventoryList.TabIndex = 1;
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InventoryList);
            this.Controls.Add(this.AddItemButton);
            this.Name = "InventoryWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ListBox InventoryList;
    }
}
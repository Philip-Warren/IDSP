namespace IDSP7_pw
{
    partial class Form1
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
            this.buttonFormRecieveStoreOrder = new System.Windows.Forms.Button();
            this.buttonFormSuppOrder = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonFormBackOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormRecieveStoreOrder
            // 
            this.buttonFormRecieveStoreOrder.Location = new System.Drawing.Point(12, 12);
            this.buttonFormRecieveStoreOrder.Name = "buttonFormRecieveStoreOrder";
            this.buttonFormRecieveStoreOrder.Size = new System.Drawing.Size(165, 23);
            this.buttonFormRecieveStoreOrder.TabIndex = 0;
            this.buttonFormRecieveStoreOrder.Text = "Recieve Str Order";
            this.buttonFormRecieveStoreOrder.UseVisualStyleBackColor = true;
            this.buttonFormRecieveStoreOrder.Click += new System.EventHandler(this.buttonFormRecieveStoreOrder_Click);
            // 
            // buttonFormSuppOrder
            // 
            this.buttonFormSuppOrder.Location = new System.Drawing.Point(12, 41);
            this.buttonFormSuppOrder.Name = "buttonFormSuppOrder";
            this.buttonFormSuppOrder.Size = new System.Drawing.Size(165, 23);
            this.buttonFormSuppOrder.TabIndex = 1;
            this.buttonFormSuppOrder.Text = "Create Supplier Order";
            this.buttonFormSuppOrder.UseVisualStyleBackColor = true;
            this.buttonFormSuppOrder.Click += new System.EventHandler(this.buttonFormSuppOrder_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Recieve Supp Order into WH";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonFormBackOrder
            // 
            this.buttonFormBackOrder.Location = new System.Drawing.Point(12, 96);
            this.buttonFormBackOrder.Name = "buttonFormBackOrder";
            this.buttonFormBackOrder.Size = new System.Drawing.Size(165, 23);
            this.buttonFormBackOrder.TabIndex = 3;
            this.buttonFormBackOrder.Text = "View Back Orders";
            this.buttonFormBackOrder.UseVisualStyleBackColor = true;
            this.buttonFormBackOrder.Click += new System.EventHandler(this.buttonFormBackOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 163);
            this.Controls.Add(this.buttonFormBackOrder);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonFormSuppOrder);
            this.Controls.Add(this.buttonFormRecieveStoreOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFormRecieveStoreOrder;
        private System.Windows.Forms.Button buttonFormSuppOrder;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonFormBackOrder;
    }
}


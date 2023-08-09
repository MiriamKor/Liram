namespace Liram
{
    partial class ProductForm
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
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lbChooseProduct = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(183, 22);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 24);
            this.cmbProducts.TabIndex = 0;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // lbChooseProduct
            // 
            this.lbChooseProduct.AutoSize = true;
            this.lbChooseProduct.Location = new System.Drawing.Point(35, 22);
            this.lbChooseProduct.Name = "lbChooseProduct";
            this.lbChooseProduct.Size = new System.Drawing.Size(106, 17);
            this.lbChooseProduct.TabIndex = 1;
            this.lbChooseProduct.Text = "choose product";
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Location = new System.Drawing.Point(13, 67);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(46, 17);
            this.lbList.TabIndex = 2;
            this.lbList.Text = "label1";
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(678, 415);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(48, 415);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(75, 23);
            this.btPrevious.TabIndex = 4;
            this.btPrevious.Text = "previous";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.lbChooseProduct);
            this.Controls.Add(this.cmbProducts);
            this.Name = "ProductForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lbChooseProduct;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevious;
    }
}


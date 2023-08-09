using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liram
{
    public partial class ProductForm : Form
    {
        int num = 0;
        List<string> final = new List<string>();
        public ProductForm()
        {
            InitializeComponent();
        } 
         
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedIndex != 0)
            { 
                final = ProductsBL.EditPrice((int)cmbProducts.SelectedValue);
                this.btNext.Enabled = true;
                num = 0;
                this.lbList.Text = final[num].ToString();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            List<ProductsDTO> listProduct = new List<ProductsDTO>();
            ProductsDTO product = new ProductsDTO();
            product.ProductId = -1;
            product.Name = "";
            product.ParentId = null;
            listProduct.Add(product);
            listProduct.AddRange(ProductsBL.GetProducts());
            
            //this.cmbProducts.SelectedIndex = -1;
            this.cmbProducts.DataSource = listProduct;
            this.cmbProducts.DisplayMember = "Name";
            this.cmbProducts.ValueMember = "ProductId";

            this.lbList.Text = "";
            this.btNext.Enabled = false;
            this.btPrevious.Enabled = false;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            num++;
            if (num > 0)
                this.btPrevious.Enabled = true;
            else
                this.btPrevious.Enabled = false;
            if (num > final.Count)
                this.btNext.Enabled = false;
            else
                this.btNext.Enabled = true;
            this.lbList.Text = final[num].ToString();
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            num--;
            if (num > final.Count)
                this.btNext.Enabled = false;
            else
                this.btNext.Enabled = true;
            if (num > 0)
                this.btPrevious.Enabled = true;
            else
                this.btPrevious.Enabled = false;
            this.lbList.Text = final[num].ToString();
        }
    }
}

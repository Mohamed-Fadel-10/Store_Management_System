using Store_System.Data;
using Store_System.Models;
using Store_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.UI
{
    public partial class AddSupplierPage : UserControl
    {
        SupplierService supplierService;
        Supplier supplier;

        public AddSupplierPage()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            supplier = new Supplier();
        }



        private async void AddSupplierPage_Load(object sender, EventArgs e)
        {
            List<Supplier> suppliers = await supplierService.GetAllSuppliers();
            existSuppliersGridView.AutoGenerateColumns = false;
            existSuppliersGridView.DataSource = suppliers;

            existSuppliersGridView.Columns[0].DataPropertyName = "Name";
            existSuppliersGridView.Columns[1].DataPropertyName = "Phone";
            existSuppliersGridView.Columns[2].DataPropertyName = "Email";
            existSuppliersGridView.Columns[3].DataPropertyName = "Address";
            existSuppliersGridView.Columns[4].DataPropertyName = "ContractDate";
            existSuppliersGridView.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            existSuppliersGridView.Columns[5].DataPropertyName = "ID";
            existSuppliersGridView.ClearSelection();

        }


        private async void saveSupplierBtn_Click(object sender, EventArgs e)
        {
            if (supplierNameBox.Text != "" && SupPhoneBox.Text != "")
            {

                if (await supplierService.IsUniqe(supplierNameBox.Text) == true)
                {
                    supplier.Name = supplierNameBox.Text;
                    supplier.Email = SupMailBox.Text;
                    supplier.Phone = SupPhoneBox.Text;
                    supplier.Address = SupAddressBox.Text;
                    supplier.ContractDate = contractDateBox.Value;
                    await supplierService.AddSupplier(supplier);
                    MessageBox.Show("تمت إضافة المورد بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                    Clear();
                }
                else
                {
                    MessageBox.Show("لا يمكن إضافة نفس المورد مرتان", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            else
            {
                MessageBox.Show("يرجى إدخال الاسم ورقم الهاتف", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear()
        {
            supplierNameBox.Clear();
            SupAddressBox.Clear();
            SupMailBox.Clear();
            SupPhoneBox.Clear();
            contractDateBox.Value = DateTime.Now;
            SupplierID.Clear();
        }

        


        private async Task RefreshGridView()
        {
            List<Supplier> Suppliers = await supplierService.GetAllSuppliers();

            existSuppliersGridView.DataSource = Suppliers;
        }

        private void existSuppliersGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplierNameBox.Text = existSuppliersGridView.CurrentRow.Cells[0].Value.ToString();
            SupPhoneBox.Text = existSuppliersGridView.CurrentRow.Cells[1].Value.ToString();
            SupMailBox.Text = existSuppliersGridView.CurrentRow.Cells[2].Value.ToString();
            SupAddressBox.Text = existSuppliersGridView.CurrentRow.Cells[3].Value.ToString();
            if (existSuppliersGridView.CurrentRow.Cells[4].Value != null)
            {
                contractDateBox.Text = existSuppliersGridView.CurrentRow.Cells[4].Value.ToString();
            }
            SupplierID.Text = existSuppliersGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier Sup = await supplierService.GetSupplier(int.Parse(SupplierID.Text));
                if (Sup != null)
                {
                    if (supplierNameBox.Text == "" && SupPhoneBox.Text == "" & SupplierID.Text == "")
                    {
                        MessageBox.Show("يرجى تحديد مورد لتعديل بياناته", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Sup.Name = supplierNameBox.Text;
                        Sup.Email = SupMailBox.Text;
                        Sup.Address = SupAddressBox.Text;
                        Sup.Phone = SupPhoneBox.Text;
                        Sup.ContractDate = contractDateBox.Value;
                        await supplierService.UpdateSupplier(Sup);
                        MessageBox.Show("تم التعديل بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshGridView();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("يرجى تحديد خلية مورد للتعديل", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى تحديد خلية مورد للتعديل", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private async void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                RefreshGridView();
            }
            else
            {
                var Suppliers = await supplierService.Search(textBox2.Text);
                existSuppliersGridView.DataSource = Suppliers;
            }
        }
    }
}

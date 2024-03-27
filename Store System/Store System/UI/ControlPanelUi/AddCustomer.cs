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

namespace Store_System.UI.ControlPanelUi
{
    public partial class AddCustomer : Form
    {
        private readonly ClientService _clientService;
        private readonly Customer _customer;
        public int CustomerID { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
            _clientService = new ClientService();
            _customer = new Customer();
        }
        public string CustomerName { get; set; }

        private async void AddClientBtn_Click(object sender, EventArgs e)
        {
            if (_customer.Name != "")
            {
                _customer.Name = _NameBox.Text;
                _customer.Phone = _PhoneBox.Text;
                await _clientService.AddCustomer(_customer);
                CustomerID = _customer.ID;
                MessageBox.Show("تمت إضافة العميل بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("يرجى إدخال إسم العميل", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerName = _NameBox.Text;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

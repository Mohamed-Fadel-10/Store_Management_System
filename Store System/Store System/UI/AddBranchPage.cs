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
    public partial class AddBranchPage : Form
    {
        Branch branch;
        BranchService branchService;
        public int BranchID { get; set; }
        public string BranchName { get; set; }

        public AddBranchPage()
        {
            InitializeComponent();
            branch = new Branch();
            branchService = new BranchService();
        }

        private async void addBranchBtn_Click(object sender, EventArgs e)
        {
            if (branch.Name != "")
            {
                branch.Name = branchNameBox.Text;
                branch.Phone = branchPhoneBox.Text;
                branch.Address =addressBox.Text;
                await branchService.AddBranch(branch);
                BranchID = branch.ID;
                MessageBox.Show("تمت إضافة الفرع بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("يرجى إدخال إسم الفرع", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void AddBranchPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            BranchName = branchNameBox.Text;
        }
    }
}

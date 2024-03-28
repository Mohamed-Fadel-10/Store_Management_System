using Store_System.Models;
using Store_System.Services;
using Store_System.UI.DevExpReports;
using Store_System.UI.UiReportsUserControls;
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
    public partial class Dashboard : Form
    {
        /// <summary>
        /// AddBranchPage AddBranchPage1;
        /// </summary>
        public string? UserName { get; set; }
        public string? CashierName { get; set; }
        public string? StockMoneyName { get; set; }
        public int UserID { get; set; }

        UserServices _userServices;
        SaleingReports saleingReports;
        BuyReports buyReports;
        public Dashboard()
        {
            InitializeComponent();
            _userServices = new UserServices();

            {
                addUserPage1 = new AddUserPage();
                addProductPage1 = new AddProductPage();
                addSupplierPage1 = new AddSupplierPage();
                mainStockPage1 = new MainStockPage();
                shortFallsPage1 = new ShortFallsPage();
                buyBill1 = new ControlPanelUi.BuyBill();
                saleBill1 = new ControlPanelUi.SaleBill();
                returnedItems1 = new ControlPanelUi.ReturnedItems();
                shiftLock1 = new ControlPanelUi.ShiftLock();
                addCategoryPage1 = new AddCategoryPage();
                welcomePage1 = new WelcomePage();
                saleingReports = new SaleingReports();
                buyReports = new BuyReports();
                //AddBranchPage1 = new AddBranchPage();

                Controls.Add(welcomePage1);
                Controls.Add(addUserPage1);
                Controls.Add(addProductPage1);
                Controls.Add(addSupplierPage1);
                Controls.Add(mainStockPage1);
                Controls.Add(shortFallsPage1);
                Controls.Add(buyBill1);
                Controls.Add(saleBill1);
                Controls.Add(returnedItems1);
                Controls.Add(shiftLock1);
                Controls.Add(addCategoryPage1);
                Controls.Add(saleingReports);
                Controls.Add(buyReports);

                saleBill1.Location = new Point(-5, 50);
                buyBill1.Location = new System.Drawing.Point(-5, 50);
                addUserPage1.Location = new System.Drawing.Point(-5, 50);
                addProductPage1.Location = new System.Drawing.Point(-5, 50);
                addSupplierPage1.Location = new System.Drawing.Point(-5, 50);
                addCategoryPage1.Location = new System.Drawing.Point(-5, 50);
                shiftLock1.Location = new System.Drawing.Point(-5, 50);
                mainStockPage1.Location = new System.Drawing.Point(-5, 50);
                shortFallsPage1.Location = new System.Drawing.Point(-5, 50);
                returnedItems1.Location = new System.Drawing.Point(-5, 50);
                saleingReports.Location = new System.Drawing.Point(-5, 50);
                buyReports.Location = new System.Drawing.Point(-5, 50);


            }


        }

        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = UserName;   //  ||  < assign to username label to check if username has admin role or no > || \\
            var user = await _userServices.GetUserByUserName(label1.Text);
            if (user != null)
            {
                if (user.Role == Role.Cashier)
                {
                    ControlAdminGr.Visible = false;
                }
                else
                {
                    ControlAdminGr.Visible = true;

                }
            }
            addUserPage1.Visible = false;
            addProductPage1.Visible = false;
            addCategoryPage1.Visible = false;
            addSupplierPage1.Visible = false;
            mainStockPage1.Visible = false;
            shortFallsPage1.Visible = false;
            buyBill1.Visible = false;
            saleBill1.Visible = false;
            returnedItems1.Visible = false;
            shiftLock1.Visible = false;

            buyBill1.cashierNameBox.Text = CashierName;

            buyBill1.cashierNameBox.Text = CashierName;
            buyBill1.UserIDBox.Text = UserID.ToString();
            saleBill1.cashierNameBox.Text = CashierName;
            saleBill1.StockBox.Text = StockMoneyName;
            saleBill1.UserIDBox.Text = UserID.ToString();
            shiftLock1.userIDBox.Text = UserID.ToString();
            shiftLock1.branchIdBox.Text=1.ToString();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            addUserPage1.Visible = true;
            addUserPage1.BringToFront();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            addProductPage1.Visible = true;
            addProductPage1.BringToFront();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            addCategoryPage1.Visible = true;
            addCategoryPage1.BringToFront();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            addSupplierPage1.Visible = true;
            addSupplierPage1.BringToFront();
        }

        private void mainStockBtn_Click(object sender, EventArgs e)
        {
            mainStockPage1.Visible = true;
            mainStockPage1.BringToFront();
        }

        private void shortFallsBtn_Click(object sender, EventArgs e)
        {
            shortFallsPage1.Visible = true;
            shortFallsPage1.BringToFront();
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            welcomePage1.Visible = true;
            welcomePage1.BringToFront();
            welcomePage1.Location = new Point(-5, 50);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void buyBillBtn_Click(object sender, EventArgs e)
        {
            buyBill1.Visible = true;
            buyBill1.BringToFront();
        }

        private void saleBillBtn_Click(object sender, EventArgs e)
        {
            saleBill1.Username = label1.Text;
            saleBill1.Visible = true;
            saleBill1.BringToFront();
        }


        private void returnedBillBtn_Click(object sender, EventArgs e)
        {
            returnedItems1.Visible = true;
            returnedItems1.BringToFront();
        }

        private void shiftLockBtn_Click(object sender, EventArgs e)
        {
            shiftLock1.Visible = true;
            shiftLock1.BringToFront();
            shiftLock1.Refresh();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addBranchBtn_Click(object sender, EventArgs e)
        {
            AddBranchPage addBranch = new AddBranchPage();
            addBranch.Show();
        }


        private void saleReportBtn_Click_1(object sender, EventArgs e)
        {
            saleingReports.BringToFront();

        }

        private void buyReportBtn_Click_1(object sender, EventArgs e)
        {
            buyReports.BringToFront();

        }
    }
}

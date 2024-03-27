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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Store_System.UI
{
    public partial class AddUserPage : UserControl
    {
        UserServices _userServices;
        User _user;
        public AddUserPage()
        {
            InitializeComponent();
            _userServices = new UserServices();
            _user = new User();

        }
        private async void AddUserPage_Load(object sender, EventArgs e)
        {

            List<User> Users = await _userServices.GetALlUsers();
            existUsrsGridView.AutoGenerateColumns = false;
            existUsrsGridView.DataSource = Users;
            existUsrsGridView.Columns["_Name"].DataPropertyName = "Name";
            existUsrsGridView.Columns["phone"].DataPropertyName = "Phone";
            existUsrsGridView.Columns["Email"].DataPropertyName = "Email";
            existUsrsGridView.Columns["_UserName"].DataPropertyName = "UserName";
            existUsrsGridView.Columns["Password"].DataPropertyName = "Password";
            existUsrsGridView.Columns["Role"].DataPropertyName = "Role";
            existUsrsGridView.Columns["StockName"].DataPropertyName = "MoneyStockName";
            existUsrsGridView.ClearSelection();


        }
        private async void saveUserBtn_Click(object sender, EventArgs e)
        {
            _user = new User();
            if (nameUserBox.Text != "" && userNameBox.Text != "" && passwordBox.Text != "" && UserRoleBox.SelectedIndex != -1 && stockNameBox.Text != "")
            {
                if (await _userServices.isUnique(userNameBox.Text))
                {
                    _user.Name = nameUserBox.Text;
                    _user.Phone = userPhoneBox.Text;
                    _user.Email = userMailBox.Text;
                    _user.UserName = userNameBox.Text;
                    _user.Password = passwordBox.Text;
                    _user.Role = (Role)Convert.ToInt32(UserRoleBox.SelectedIndex);
                    _user.MoneyStockName = stockNameBox.Text;
                    await _userServices.AddUser(_user);
                    MessageBox.Show("تمت إضافة المستخدم بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    RefreshGridView();

                }
                else
                {
                    MessageBox.Show("إسم المستخدم موجود من قبل", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (nameUserBox.Text == "")

                    nameerrore.Visible = true;

                else
                    nameerrore.Visible = false;
                if (userNameBox.Text == "")
                    usernameerror.Visible = true;
                else
                    usernameerror.Visible = false;
                if (passwordBox.Text == "")
                    passerror.Visible = true;
                else
                    passerror.Visible = false;
                if (UserRoleBox.SelectedIndex == -1)
                    roleerror.Visible = true;
                else
                    roleerror.Visible = false;
                if (stockNameBox.Text == "")
                    stockerror.Visible = true;
                else
                    stockerror.Visible = false;

            }
        }

        private async void deleteUserBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هل انت متأكد من حذف هذا العنصر؟", "!system", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string UserName = userNameBox.Text;
            if (userNameBox.Text != "")
            {

                await _userServices.DeleteUser(userNameBox.Text);
                MessageBox.Show("تم حذف المستخدم بنجاح", "!system", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("يرجى تحديي المستخدم لحذفه", "!system", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Clear();
            RefreshGridView();

        }

        private void LoadData()
        {
            if (existUsrsGridView.Rows.Count > 0)
            {
                existUsrsGridView.CurrentRow.Cells[6].Value = nameUserBox.Text;
                existUsrsGridView.CurrentRow.Cells[5].Value = userPhoneBox.Text;
                existUsrsGridView.CurrentRow.Cells[4].Value = userMailBox.Text;
                existUsrsGridView.CurrentRow.Cells[3].Value = userNameBox.Text;
                existUsrsGridView.CurrentRow.Cells[2].Value = passwordBox.Text;
                existUsrsGridView.CurrentRow.Cells[1].Value = UserRoleBox.Text;
                existUsrsGridView.CurrentRow.Cells[0].Value = stockNameBox.Text;
            }
        }
        private void Clear()
        {

            nameUserBox.Clear();
            userPhoneBox.Clear();
            userMailBox.Clear();
            userNameBox.Clear();
            passwordBox.Clear();
            stockNameBox.Clear();
            UserRoleBox.SelectedIndex = -1;
        }

        private void existUsrsGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameUserBox.Text = existUsrsGridView.CurrentRow.Cells[0].Value.ToString();
            userPhoneBox.Text = existUsrsGridView.CurrentRow.Cells[1].Value.ToString();
            userMailBox.Text = existUsrsGridView.CurrentRow.Cells[2].Value.ToString();
            userNameBox.Text = existUsrsGridView.CurrentRow.Cells[3].Value.ToString();
            passwordBox.Text = existUsrsGridView.CurrentRow.Cells[4].Value.ToString();
            UserRoleBox.Text = existUsrsGridView.CurrentRow.Cells[5].Value.ToString();
            stockNameBox.Text = existUsrsGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void RefreshGridView()
        {
            StoreContext storeContext = new StoreContext();
            var Users = storeContext.User.ToList();
            existUsrsGridView.DataSource = Users;
        }
        private async void updatebtn_Click(object sender, EventArgs e)
        {
            _user = new User();

            _user = await _userServices.GetUserByUserName(userNameBox.Text);
            if (_user != null)
            {
                try
                {
                    _user.Name = nameUserBox.Text;
                    _user.Phone = userPhoneBox.Text;
                    _user.Email = userMailBox.Text;
                    _user.UserName = userNameBox.Text;
                    _user.Password = passwordBox.Text;
                    _user.Role = (Role)Convert.ToInt32(UserRoleBox.SelectedIndex);
                    _user.MoneyStockName = stockNameBox.Text;
                    await _userServices.UpdateUser(_user);
                    MessageBox.Show("تم التعديل بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    RefreshGridView();
                }

                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد باركود المنتج المراد تعديله من أسفل الجدول ", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}

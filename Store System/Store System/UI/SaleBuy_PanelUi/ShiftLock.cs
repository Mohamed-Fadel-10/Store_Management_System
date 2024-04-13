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

namespace Store_System.UI.ControlPanelUi
{
    public partial class ShiftLock : UserControl
    {
        SaleBill saleBill;
        ShiftLockService shiftLockService;
        UserServices userServices;
        //OrderItems orderItem;
        //Order order;
        double shiftMoney;
        User user;

        public ShiftLock()
        {
            InitializeComponent();

            saleBill = new SaleBill();
            shiftLockService = new ShiftLockService();
            user = new User();
            userServices = new UserServices();

            ShiftLockService.ShiftMoneyChanged += GetShiftMoney;


        }



        private void ShiftLock_Load(object sender, EventArgs e)
        {
            shiftMoney = 0;
        }

        private void GetShiftMoney(object? sender, double money)
        {
            shiftMoney += money;
            shiftMoneyBox.Text = shiftMoney.ToString();
        }

        private void shiftMoneyBox_TextChanged(object sender, EventArgs e)
        {
            finalShiftMoneyBox.Text = shiftMoneyBox.Text;
        }

        private void ExpensesBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpensesBox.Text != string.Empty)
                    finalShiftMoneyBox.Text = ((double.Parse(shiftMoneyBox.Text))
                                        - (double.Parse(ExpensesBox.Text))).ToString();
                else finalShiftMoneyBox.Text = shiftMoneyBox.Text;
            }catch(Exception ex)
            {
                MessageBox.Show("لا يوجد مبيعات حتى الان", "!System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void Addbtn_Click(object sender, EventArgs e)
        {
            int effectedRow = await shiftLockService.UpdateMoney(int.Parse(userIDBox.Text), int.Parse(branchIdBox.Text), double.Parse(finalShiftMoneyBox.Text));
            if (effectedRow == 2)
            {
                MessageBox.Show(".تم تقفيل الشيفت بنجاح", "!System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                shiftMoney = 0;
            }
            else
            {
                MessageBox.Show("حدثت مشكلة يرجى اعادة المحاولة", "!System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Clear()
        {
            shiftMoneyBox.Clear();
            finalShiftMoneyBox.Clear();
            ExpensesBox.Clear();
        }
    }
}

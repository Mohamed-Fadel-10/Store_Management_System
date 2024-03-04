﻿using Store_System.Models;
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
    public partial class LogIn : Form
    {
        Login Login;
        Home home;
        UserDashboard userDashboard;
        public LogIn()
        {
            InitializeComponent();
            Login = new Login();
            home = new Home();
            userDashboard = new UserDashboard();
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {

            if (UserNameBox.Text == "Admin".ToLower() && PasswordBox.Text == "Admin".ToLower() && Adminradio.Checked)
            {

                this.Hide();
                home.Show();
            }
            else if (UserNameBox.Text == "" && PasswordBox.Text == "")
            {
                MessageBox.Show("قم بإدخال اسم مستخدم وكلمة السر", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (Adminradio.Checked == false && Cashierradio.Checked == false)
                {
                    MessageBox.Show("يرجى  إدخال نوع المستخدم اولا", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User user = await Login.AdminLogIn(UserNameBox.Text);
                    if (user != null)
                    {
                        if (Adminradio.Checked)
                        {
                            if (user.Role == Role.Admin && user.Password == PasswordBox.Text)
                            {
                                this.Hide();
                                home.Show();
                            }
                            else if (user.Role == Role.Admin)
                            {
                                MessageBox.Show("هذا المستخدم ليس لديه هذه الصلاحية ", "System");

                            }
                            else
                            {
                                MessageBox.Show("خطأ فى كلمة المرور", "System");
                            }
                        }
                        else if (Cashierradio.Checked)
                        {
                            if (user.Role == Role.Cashier && user.Password == PasswordBox.Text)
                            {
                                this.Hide();
                                userDashboard.Show();
                            }
                            else if (user.Role == Role.Admin)
                            {
                                MessageBox.Show("هذا المستخدم ليس لديه هذه الصلاحية ", "System");

                            }
                            else
                            {
                                MessageBox.Show("خطأ فى كلمة المرور لهذا ", "System");

                            }
                        }
                    } else
                    {
                        MessageBox.Show("هذا المستخدم غير موجود ", "System");
                    }
                }
            }
        }
      }
    }


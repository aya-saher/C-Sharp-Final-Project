using SchoolLibraryStockManagement.Libraries;
using SchoolLibraryStockManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryStockManagement
{
    public partial class Settings : Form
    {
        public string query;
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_password_update_Click(object sender, EventArgs e)
        {
            query = (new Setting()).authenticate(
                  txt_username.Text,
                   txt_password.Text
                     );
            Console.WriteLine(query);
            var result = DatabaseOperation.authenticate(query);
            if (result == false)
            {
                MessageBox.Show("Incorrect username or password");
            }

            if (result && checkBox_name.Checked || checkBox_password.Checked || checkBox_username.Checked)
            {
                if (checkBox_name.Checked && checkBox_password.Checked && checkBox_username.Checked)
                {
                    if (txtbox_name.Text == txtbox_repeatname.Text && txtbox_username.Text == txtbox_repeatusername.Text && txtbox_newpass.Text == txtbox_repeatpass.Text)
                    {
                        query = new Setting().updateAll(
                         txt_username.Text,
                         txtbox_username.Text,
                         txtbox_name.Text,
                         txtbox_newpass.Text
                          );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);

                        MessageBox.Show("The change has been successful");
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                       
                    }

                }
                else if (checkBox_name.Checked && checkBox_username.Checked && checkBox_password.Checked != true)
                {
                    if (txtbox_name.Text == txtbox_repeatname.Text && txtbox_username.Text == txtbox_repeatusername.Text)
                    { 
                        query = (new Setting()).update_nameandusername(
                           txt_username.Text,
                           txtbox_username.Text,
                            txtbox_name.Text
                           );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);
                        MessageBox.Show("The change has been successful");
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                       
                    }

                }
                else if (checkBox_name.Checked && checkBox_password.Checked && checkBox_username.Checked != true)
                {
                    if (txtbox_name.Text == txtbox_repeatname.Text && txtbox_newpass.Text == txtbox_repeatpass.Text)
                    {
                        query = (new Setting()).update_NameAndPassword(
                       txt_username.Text,
                        txtbox_name.Text,
                        txtbox_newpass.Text
                          );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);
                        MessageBox.Show("The change has been successful");
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                        
                    }
                }

                else if (checkBox_username.Checked && checkBox_password.Checked && checkBox_name.Checked != true)
                {
                    if (txtbox_username.Text == txtbox_repeatusername.Text && txtbox_newpass.Text == txtbox_repeatpass.Text)
                    {
                        query = (new Setting()).update_UsernameAndPassword(
                         txt_username.Text,
                          txtbox_username.Text,
                          txtbox_newpass.Text
                            );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);
                        MessageBox.Show("The change has been successful");
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                        
                    }
                }
                else if (checkBox_name.Checked && checkBox_username.Checked == false && checkBox_password.Checked == false)
                {
                    if (txtbox_name.Text == txtbox_repeatname.Text)
                    {
                        query = (new Setting()).update_Name(
                        txt_username.Text,
                         txtbox_name.Text
                           );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);
                        MessageBox.Show("The change has been successful");
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                        
                    }
                }
                else if (checkBox_username.Checked && checkBox_name.Checked != true && checkBox_password.Checked != true)
                {
                    if (txtbox_username.Text == txtbox_repeatusername.Text)
                    {
                        query = (new Setting()).update_Username(
                        txt_username.Text,
                         txtbox_username.Text
                           );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);
                        MessageBox.Show("The change has been successful");
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                      
                    }
                }
                else if (checkBox_password.Checked && checkBox_username.Checked != true && checkBox_name.Checked != true)
                {
                    if (txtbox_newpass.Text == txtbox_repeatpass.Text)
                    {
                        query = (new Setting()).update_Password(
                       txt_username.Text,
                        txtbox_newpass.Text
                          );
                        Console.WriteLine(query);
                        DatabaseOperation.create(query);
                        MessageBox.Show("The change has been successful");
                        clearFields();

                    }
                    else
                    {
                        MessageBox.Show("The fields do not match");
                       
                    }

                }
            }


            else if (checkBox_name.Checked == false || checkBox_password.Checked == false || checkBox_username.Checked == false)
                MessageBox.Show("check what do you want to change");
           
        }
        private void clearFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked =false;
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }
    }
}

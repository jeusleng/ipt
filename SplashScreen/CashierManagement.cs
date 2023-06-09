﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SplashScreenLadera;
using Guna.UI2.WinForms;

namespace SplashScreen
{
    public partial class CashierManagement : Form
    {
        public CashierManagement()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        private void populate()
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from cashierTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                dataTable.Columns.Add("No", typeof(int));

                //add counter 
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }

                dataGridview.DataSource = dataTable;

                dataGridview.Columns["No"].DisplayIndex = 0;
                dataGridview.Columns["user_id"].Visible = false;
                dataGridview.Columns["cashier_id"].Visible = false;

                //rename header
                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[1].HeaderText = "First Name";
                dataGridview.Columns[2].HeaderText = "Last Name";
                dataGridview.Columns[3].HeaderText = "Contact No.";
                dataGridview.Columns[4].HeaderText = "Birthday";
                dataGridview.Columns[5].HeaderText = "Date Hired";
                dataGridview.Columns[6].HeaderText = "Salary";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void CashierManagement_Load(object sender, EventArgs e)
        {
            populate();
            dataGridview.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
            dataGridview.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //random password generator
        private static Random random = new Random();

        private static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+=<>?";

            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }


        private void insertButton_Click(object sender, EventArgs e)
        {
            AddCashierScreen addCashierScreen = new AddCashierScreen();

            // Subscribe to the CashierAdded event
            addCashierScreen.CashierAdded += AddCashierScreen_CashierAdded;

            // Make the background below the new form darker
            this.Enabled = false;

            // Display the CashierDetailsScreen form as a modal dialog
            addCashierScreen.ShowDialog();

            // Re-enable the background form after the CashierDetailsScreen form is closed
            this.Enabled = true;
        }

        private void AddCashierScreen_CashierAdded(object sender, EventArgs e)
        {
            populate(); // Refresh the DataGridView when a cashier is added
        }


        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
                cashierId.Text = rows.Cells["cashier_id"].Value.ToString();
                firstName.Text = rows.Cells["first_name"].Value.ToString();
                lastName.Text = rows.Cells["last_name"].Value.ToString();
                contactNum.Text = rows.Cells["contact_no"].Value.ToString();
                birthday.Text = rows.Cells["birthday"].Value.ToString();
                dateHired.Text = rows.Cells["date_hired"].Value.ToString();
                salary.Text = rows.Cells["salary"].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (contactNum.Text == string.Empty)
            {
                MessageBox.Show("Please fill out Cashier field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select cashier_id from cashierTable where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    SqlCommand cmd = new SqlCommand("update cashierTable set first_name='" + firstName.Text + "', last_name='" + lastName.Text + "', contact_no='" + contactNum.Text + "', birthday='" + birthday.Text + "', date_hired='" + dateHired.Text + "', salary='" + salary.Text + "' where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cashier name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbCon.closeConnection();
                firstName.Text = " ";
                lastName.Text = " ";
                contactNum.Text = "";
                birthday.Text = " ";
                dateHired.Text = " ";
                salary.Text = " ";
                populate();
            }
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (contactNum.Text == string.Empty)
            {
                MessageBox.Show("Please fill Cashier field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select cashier_id from cashierTable where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {

                    if (MessageBox.Show("Do you want to delete this Cashier?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete from cashierTable where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cashier deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                dbCon.closeConnection();
                firstName.Text = " ";
                lastName.Text = " ";
                contactNum.Text = "";
                birthday.Text = " ";
                dateHired.Text = " ";
                salary.Text = " ";
                populate();
            }
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            if (dataGridview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridview.SelectedRows[0];
                string firstName = row.Cells["first_name"].Value.ToString();
                string lastName = row.Cells["last_name"].Value.ToString();
                string contactNumber = row.Cells["contact_no"].Value.ToString();
                string birthday = row.Cells["birthday"].Value.ToString();
                string dateHired = row.Cells["date_hired"].Value.ToString();
                string cashierId = row.Cells["cashier_id"].Value.ToString();
                decimal salary = decimal.Parse(row.Cells["salary"].Value.ToString());

                CashierDetailsScreen cashierDetailsScreen = new CashierDetailsScreen();

                // Pass the values to the CashierDetailsScreen form
                cashierDetailsScreen.FirstName = firstName;
                cashierDetailsScreen.LastName = lastName;
                cashierDetailsScreen.ContactNumber = contactNumber;
                cashierDetailsScreen.Birthday = birthday;
                cashierDetailsScreen.DateHired = dateHired;
                cashierDetailsScreen.Salary = salary;
                cashierDetailsScreen.CashierId = cashierId;

                // Make the background below the new form darker
                this.Enabled = false;

                // Display the CashierDetailsScreen form as a modal dialog
                cashierDetailsScreen.ShowDialog();

                // Re-enable the background form after the CashierDetailsScreen form is closed
                this.Enabled = true;

                // Refresh the data grid view after closing the CashierDetailsScreen form
                populate();
            }
        }



        public void searchCashier(String searchValue)
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from cashierTable where concat(first_name, last_name, contact_no, birthday, date_hired, salary) like '%" + searchBox.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                dataTable.Columns.Add("No", typeof(int));

                //add counter 
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }

                dataGridview.DataSource = dataTable;

                dataGridview.Columns["No"].DisplayIndex = 0;
                dataGridview.Columns["user_id"].Visible = false;
                dataGridview.Columns["cashier_id"].Visible = false;

                //rename header
                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[1].HeaderText = "First Name";
                dataGridview.Columns[2].HeaderText = "Last Name";
                dataGridview.Columns[3].HeaderText = "Contact No.";
                dataGridview.Columns[4].HeaderText = "Birthday";
                dataGridview.Columns[5].HeaderText = "Date Hired";
                dataGridview.Columns[6].HeaderText = "Salary";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchCashier(searchBox.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, decimal point, or control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the keypress
                return;
            }

            // Check if a decimal point already exists
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Ignore the keypress
                return;
            }

            // Check if the input would result in more than two decimal places
            if (e.KeyChar != '.' && ((TextBox)sender).Text.Contains("."))
            {
                int decimalPosition = ((TextBox)sender).Text.IndexOf(".");
                if (((TextBox)sender).Text.Substring(decimalPosition).Length >= 3)
                {
                    e.Handled = true; // Ignore the keypress
                    return;
                }
            }
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }

        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
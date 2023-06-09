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
using System.Web.UI.WebControls;

namespace SplashScreen
{
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        private void populate()
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from categoryTable";
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
                dataGridview.Columns["category_id"].Visible = false;

                //rename header
                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[1].HeaderText = "Category Name";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void CategoryManagement_Load(object sender, EventArgs e)
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

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryName.Text != string.Empty)
                {
                    dbCon.openConnection();
                    string query = "insert into categoryTable values('" + categoryName.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbCon.closeConnection();
                    populate();

                    categoryName.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill out category field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
                categoryId.Text = rows.Cells["category_id"].Value.ToString();
                categoryName.Text = rows.Cells["category_name"].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (categoryName.Text == string.Empty)
            {
                MessageBox.Show("Please fill out category field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select category_id from categoryTable where category_id='" + categoryId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    SqlCommand cmd = new SqlCommand("update categoryTable set category_name='" + categoryName.Text + "' where category_id='" + this.categoryId.Text + "'", dbCon.getConnection());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbCon.closeConnection();
                categoryName.Text = "";
                populate();
            }
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (categoryName.Text == string.Empty)
            {
                MessageBox.Show("Please fill category field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select category_id from categoryTable where category_id='" + categoryId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    // Check if there are any products under the selected category
                    sda = new SqlDataAdapter("select * from productsTable where category_id='" + categoryId.Text + "'", dbCon.getConnection());
                    dataSet = new DataSet();
                    sda.Fill(dataSet);

                    if (dataSet.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Cannot delete category because there are products under this category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Do you want to delete this category?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("delete from categoryTable where category_id='" + categoryId.Text + "'", dbCon.getConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                dbCon.closeConnection();
                categoryName.Text = "";
                populate();
            }
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(this.categoryId.Text);
            CategoryDetails detailsForm = new CategoryDetails(categoryId);
            detailsForm.ShowDialog();

        }
        public void searchCategory(String searchValue)
        {
            try
            {
                dbCon.openConnection();
                string query = "SELECT * FROM categoryTable WHERE category_name LIKE '%" + searchBox.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                dataTable.Columns.Add("No", typeof(int));

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }

                dataGridview.DataSource = dataTable;

                dataGridview.Columns["No"].DisplayIndex = 0;
                dataGridview.Columns["category_id"].Visible = false;

                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[1].HeaderText = "Category Name";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchCategory(searchBox.Text);
        }

        private void categoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }
        }
    }
}

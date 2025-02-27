using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkladSportInventory100.kursDataSet;

namespace SkladSportInventory100
{
    public partial class Inventory : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public Inventory()
        {
            InitializeComponent();
        }
        DataTable produktDataTable = new DataTable("Produkt");
        private int GetSelectedProductID()
        {

            if (produktDataGridView.SelectedRows.Count > 0)
            {

                return Convert.ToInt32(produktDataGridView.SelectedRows[0].Cells["ProduktID"].Value);
            }
            else
            {
                return -1;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Produkt". При необходимости она может быть перемещена или удалена.
            this.produktTableAdapter.Fill(this.kursDataSet.Produkt);

        }
        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            produktBindingSource.Filter = string.Format("NazvanieProdukta LIKE '%{0}%'", txtProductSearch.Text);
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductQuantity.Text = "";
            comboCategories.Text = "";
            txtProductSearch.Text = "";
        }
        private Boolean validateProduct()
        {
            if (txtProductName.Text != "" && comboCategories.Text != "" && double.TryParse(txtProductPrice.Text, out double price) && int.TryParse(txtProductQuantity.Text, out int qty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private void btnCreateNewProduct_Click(object sender, EventArgs e)
        //{

        //}

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Produkt SET NazvanieProdukta = @ProductName, Tsena = @ProductPrice, KolichestvoNaSklade = @ProductQuantity, Kategoriya = @CategoryName WHERE NazvanieProdukta = @ProductName";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                            sqlCommand.Parameters.AddWithValue("@ProductPrice", double.Parse(txtProductPrice.Text));
                            sqlCommand.Parameters.AddWithValue("@ProductQuantity", int.Parse(txtProductQuantity.Text));
                            sqlCommand.Parameters.AddWithValue("@CategoryName", comboCategories.Text);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Успешно обновлен продукт");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при обновлении продукта: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Незаполненные поля");
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            {
                string selectedProductName = "";
                if (produktDataGridView.SelectedRows.Count > 0)
                {
                    selectedProductName = produktDataGridView.SelectedRows[0].Cells["ProduktID"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(selectedProductName))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Produkt WHERE ProduktID = @ProductName";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@ProductName", selectedProductName);
                                int rowsAffected = sqlCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Продукт успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Не удалось найти продукт для удаления");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении продукта: " + ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите продукт для удаления");
                }
            }

        }

        private void btnCreateNewProdukt_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Produkt(NazvanieProdukta, Tsena, KolichestvoNaSklade, Kategoriya) VALUES(@ProductName, @ProductPrice, @ProductQuantity, @CategoryName)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                            sqlCommand.Parameters.AddWithValue("@ProductPrice", double.Parse(txtProductPrice.Text));
                            sqlCommand.Parameters.AddWithValue("@ProductQuantity", int.Parse(txtProductQuantity.Text));
                            sqlCommand.Parameters.AddWithValue("@CategoryName", comboCategories.Text);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Успешно добавлен новый продукт");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка с добавкой продукта: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Незаполненные поля");
            }
        }
    }
}

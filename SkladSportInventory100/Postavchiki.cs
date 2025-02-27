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

namespace SkladSportInventory100
{
    public partial class Postavchiki : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public Postavchiki()
        {
            InitializeComponent();
        }

        private void Postavchiki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.kursDataSet.Postavshiki);

        }
        private bool validateProduct()
        {
            // Проверяем, что все текстовые поля не пустые
            if (!string.IsNullOrWhiteSpace(txtProductName.Text) &&
                !string.IsNullOrWhiteSpace(txtKontakt.Text) &&
                !string.IsNullOrWhiteSpace(txtELpochta.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Postavshiki(NazvaniePostavshika, KontaktnoeLitso, ElektronnayaPochta, Telefon) VALUES(@ProductName, @ProductKontakt, @ProductPochta, @Telefone)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                            sqlCommand.Parameters.AddWithValue("@ProductKontakt", txtKontakt.Text);
                            sqlCommand.Parameters.AddWithValue("@ProductPochta", txtELpochta.Text);
                            sqlCommand.Parameters.AddWithValue("@Telefone", txtTelephone.Text);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Успешно добавлен новый поставащик");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка с добавкой поставщика: " + ex.Message);
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
                MessageBox.Show("Незаполненные поля или неверный формат данных");
            }
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Postavshiki SET KontaktnoeLitso = @KontaktnoeLitso, ElektronnayaPochta = @ElektronnayaPochta, Telefon = @Telefon WHERE NazvaniePostavshika = @NazvaniePostavshika";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@NazvaniePostavshika", txtProductName.Text);
                            sqlCommand.Parameters.AddWithValue("@KontaktnoeLitso", txtKontakt.Text);
                            sqlCommand.Parameters.AddWithValue("@ElektronnayaPochta", txtELpochta.Text);
                            sqlCommand.Parameters.AddWithValue("@Telefon", txtTelephone.Text);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные поставщика успешно обновлены");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось найти поставщика для обновления");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при обновлении данных поставщика: " + ex.Message);
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
                MessageBox.Show("Незаполненные поля или неверный формат данных");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            {
                {
                    string selectedSupplierName = "";
                    if (postavshikiDataGridView.SelectedRows.Count > 0)
                    {
                        selectedSupplierName = postavshikiDataGridView.SelectedRows[0].Cells["nazvaniePostavshikaDataGridViewTextBoxColumn"].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(selectedSupplierName))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Postavshiki WHERE NazvaniePostavshika = @SupplierName";
                            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                            {
                                try
                                {
                                    connection.Open();
                                    sqlCommand.CommandType = CommandType.Text;
                                    sqlCommand.Parameters.AddWithValue("@SupplierName", selectedSupplierName);
                                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Поставщик успешно удален");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Не удалось найти поставщика для удаления");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ошибка при удалении поставщика(Нельзя удалить, тк не удален товар, привязанный к нему): " + ex.Message);
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
                        MessageBox.Show("Пожалуйста, выберите поставщика для удаления");
                    }
                }
            }

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtTelephone.Text = "";
            txtELpochta.Text = "";
            txtKontakt.Text = "";
            txtProductSearch.Text = "";
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            postavshikiBindingSource.Filter = string.Format("NazvaniePostavshika LIKE '%{0}%'", txtProductSearch.Text);
        }
    }
}

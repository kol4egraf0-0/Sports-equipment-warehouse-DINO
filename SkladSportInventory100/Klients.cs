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
    public partial class Klients : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public Klients()
        {
            InitializeComponent();
        }

        private void Klients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Klienty". При необходимости она может быть перемещена или удалена.
            this.klientyTableAdapter.Fill(this.kursDataSet.Klienty);

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            klientyBindingSource.Filter = string.Format("Familia LIKE '%{0}%'", txtProductSearch.Text);
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductFamilia.Text = "";
            txtProductElPochta.Text = "";
            txtTelephone.Text = "";
            txtProductSearch.Text = "";
        }
        private bool validateProduct()
        {
            // Проверяем, что все текстовые поля не пустые
            if (!string.IsNullOrWhiteSpace(txtProductName.Text) &&
                !string.IsNullOrWhiteSpace(txtProductFamilia.Text) &&
                !string.IsNullOrWhiteSpace(txtProductElPochta.Text))
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
                    string query = "INSERT INTO Klienty(Imya, Familia, ElektronnayaPochta, Telefon) VALUES(@ProductName, @Familia, @ProductPochta, @Telefone)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                            sqlCommand.Parameters.AddWithValue("@Familia", txtProductFamilia.Text);
                            sqlCommand.Parameters.AddWithValue("@ProductPochta", txtProductElPochta.Text);
                            sqlCommand.Parameters.AddWithValue("@Telefone", txtTelephone.Text);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Успешно добавлен новый клиент");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка с добавкой клиента: " + ex.Message);
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
                    string query = "UPDATE Klienty SET Imya = @Imya, Familia = @Familia, ElektronnayaPochta = @ElektronnayaPochta, Telefon = @Telefon WHERE ElektronnayaPochta = @ElektronnayaPochta";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@Imya", txtProductName.Text);
                            sqlCommand.Parameters.AddWithValue("@Familia", txtProductFamilia.Text);
                            sqlCommand.Parameters.AddWithValue("@ElektronnayaPochta", txtProductElPochta.Text);
                            sqlCommand.Parameters.AddWithValue("@Telefon", txtTelephone.Text);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные клиента успешно обновлены");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось обновить данные клиента");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при обновлении данных клиента: " + ex.Message);
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
                string selectedClientEmail = "";
                if (klientyDataGridView.SelectedRows.Count > 0)
                {
                    selectedClientEmail = klientyDataGridView.SelectedRows[0].Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(selectedClientEmail))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Klienty WHERE ElektronnayaPochta = @ClientEmail";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@ClientEmail", selectedClientEmail);
                                int rowsAffected = sqlCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Клиент успешно удален");
                                }
                                else
                                {
                                    MessageBox.Show("Не удалось найти клиента для удаления");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении клиента: " + ex.Message);
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
                    MessageBox.Show("Пожалуйста, выберите клиента для удаления");
                }
            }

        }
    }
}

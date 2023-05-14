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

namespace inventory
{
    public partial class Form2 : Form
    {

        string connectionString = "Data Source=DESKTOP-6HOINII;Initial Catalog=inventory_cabinets;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventory_cabinetsDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventory_cabinetsDataSet.room_info_view". При необходимости она может быть перемещена или удалена.
            this.room_info_viewTableAdapter.Fill(this.inventory_cabinetsDataSet.room_info_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventory_cabinetsDataSet.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.inventory_cabinetsDataSet.teachers);

        }

        private void teacher_insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // открываем подключение
                connection.Open();

                // создаем SQL-запрос на добавление записи в таблицу teachers
                string sql = "INSERT INTO teachers (teacher_name, teacher_phone) VALUES (@name, @phone)";

                // создаем команду SQL-запроса
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // добавляем параметры команды
                    command.Parameters.AddWithValue("@name", teacher_name.Text);
                    command.Parameters.AddWithValue("@phone", teacher_phone.Text);

                    // выполняем команду
                    int rowsAffected = command.ExecuteNonQuery();

                    // выводим сообщение об успешном добавлении записи
                    MessageBox.Show("Запись успешно добавлена в таблицу teachers.");
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM teachers";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        teachersDataGridView.DataSource = dt;
                    }
                    conn.Close();
                }
                // Обновление teachersBindingSource
                teachersBindingSource.ResetBindings(false);

                // Обновление teachersDataGridView
                teachersDataGridView.Refresh();


                // Очистка текстовых полей
                teacher_name.Text = "";
                teacher_phone.Text = "";

            }
        }

        private void teacher_delete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в таблице
            if (teachersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            // Получаем значение первичного ключа выбранной записи
            int teacher_id = Convert.ToInt32(teachersDataGridView.SelectedRows[0].Cells[0].Value);

            // Создаем подключение к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем соединение с базой данных
                    connection.Open();

                    // Создаем SQL-запрос на удаление записи
                    string query = $"DELETE FROM teachers WHERE teacher_id = {teacher_id};";

                    // Создаем объект SqlCommand для выполнения SQL-запроса
                    SqlCommand command = new SqlCommand(query, connection);

                    // Выполняем SQL-запрос на удаление записи
                    int rowsAffected = command.ExecuteNonQuery();

                    // Проверяем, удалена ли запись
                    if (rowsAffected > 0)
                    {
                        // Выводим сообщение об успешном удалении записи
                        MessageBox.Show("Запись успешно удалена из таблицы teachers.");

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM teachers";
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                teachersDataGridView.DataSource = dt;
                            }
                            conn.Close();
                        }
                    }
                    else
                    {
                        // Выводим сообщение об ошибке при удалении записи
                        MessageBox.Show("Не удалось удалить запись из таблицы teachers.");
                    }
                }
                catch (Exception ex)
                {
                    // Выводим сообщение об ошибке при удалении записи
                    MessageBox.Show($"Ошибка при удалении записи из таблицы teachers: {ex.Message}");
                }
            }
        }

        private void room_insert_Click(object sender, EventArgs e)
        {
            string roomName = room_name.Text;
            int floor = int.Parse(floors.Text);
            string teacherName = teachers_name.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("insert_room_info_view", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@room_name", roomName);
                    command.Parameters.AddWithValue("@floor", floor);
                    command.Parameters.AddWithValue("@teacher_name", teacherName);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Error adding room");
                    }
                    else
                    {
                        MessageBox.Show("Room added successfully");
                    }

                    using (SqlCommand selectCommand = new SqlCommand("SELECT * FROM room_info_view", connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        room_info_viewDataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
            }
            finally
            {
                room_name.Clear();
                floors.Clear();
                teachers_name.Clear();
            }
        }

        private void room_delete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в таблице
            if (room_info_viewDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            // Получаем значение первичного ключа выбранной записи
            int id = Convert.ToInt32(room_info_viewDataGridView.SelectedRows[0].Cells[0].Value);

            // Создаем подключение к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем соединение с базой данных
                    connection.Open();

                    // Создаем SQL-запрос на удаление записи
                    string query = $"DELETE FROM rooms WHERE room_id = {id};";

                    // Создаем объект SqlCommand для выполнения SQL-запроса
                    SqlCommand command = new SqlCommand(query, connection);

                    // Выполняем SQL-запрос на удаление записи
                    int rowsAffected = command.ExecuteNonQuery();

                    // Проверяем, удалена ли запись
                    if (rowsAffected > 0)
                    {
                        // Выводим сообщение об успешном удалении записи
                        MessageBox.Show("Запись успешно удалена из таблицы rooms.");

                        // Перезагружаем данные в таблице
                        string selectQuery = "SELECT * FROM room_info_view";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        room_info_viewDataGridView.DataSource = table;
                    }
                    else
                    {
                        // Выводим сообщение об ошибке при удалении записи
                        MessageBox.Show("Не удалось удалить запись из таблицы rooms.");
                    }
                }
                catch (Exception ex)
                {
                    // Выводим сообщение об ошибке при удалении записи
                    MessageBox.Show($"Ошибка при удалении записи из таблицы rooms: {ex.Message}");
                }
            }
        }

    }
}

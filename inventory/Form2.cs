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

                // Очистка текстовых полей
                teacher_name.Text = "";
                teacher_phone.Text = "";

            }
        }

        private void teacher_delete_Click(object sender, EventArgs e)
        {
            // Получение teacher_id из текстового поля
            int teacher_id = int.Parse(teacher_idTextBox.Text);

            // Создание соединения с базой данных
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Открытие соединения
                connection.Open();

                // Создание команды SQL для удаления записи
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM teachers WHERE teacher_id = @teacher_id";
                command.Parameters.AddWithValue("@teacher_id", teacher_id);

                // Выполнение команды SQL
                command.ExecuteNonQuery();

                // Очистка текстового поля
                teacher_idTextBox.Text = "";

                // Оповещение пользователя об успешном удалении записи
                MessageBox.Show("Teacher record deleted successfully.");

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
            catch (Exception ex)
            {
                // Вывод ошибки при возникновении исключения
                MessageBox.Show("Error deleting teacher record: " + ex.Message);
            }
            finally
            {
                // Закрытие соединения
                connection.Close();
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


        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(room_idTextBox.Text, out int room_id))
            {
                MessageBox.Show("Invalid room ID");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM rooms WHERE room_id = @room_id", connection))
                {
                    command.Parameters.AddWithValue("@room_id", room_id);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Room not found");
                    }
                    else
                    {
                        MessageBox.Show("Room deleted successfully");
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
                MessageBox.Show("Error deleting room: " + ex.Message);
            }
            finally
            {
                room_idTextBox.Text = "";
            }
        }

    }
}

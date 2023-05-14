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
    public partial class Form3 : Form
    {
        string connectionString = "Data Source=DESKTOP-6HOINII;Initial Catalog=inventory_cabinets;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventory_cabinetsDataSet.equipment_info_view". При необходимости она может быть перемещена или удалена.
            this.equipment_info_viewTableAdapter.Fill(this.inventory_cabinetsDataSet.equipment_info_view);

        }

        private void insert_equipment_Click(object sender, EventArgs e)
        {
            // Получить значения из текстовых полей
            int inventory_number = Convert.ToInt32(equipment_inventory_numberTextBox.Text);
            string name = equipment_nameTextBox.Text;
            string type = equipment_typeTextBox.Text;
            int quantity = Convert.ToInt32(equipment_quantityTextBox.Text);
            string room_name = room_nameTextBox.Text;

            // Создать подключение к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открыть соединение с базой данных
                    connection.Open();

                    // Создать объект SqlCommand для вызова хранимой процедуры
                    SqlCommand command = new SqlCommand("insert_equipment_proc", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Добавить параметры к команде
                    command.Parameters.AddWithValue("@inventory_number", inventory_number);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@room_name", room_name);

                    // Выполнить команду
                    command.ExecuteNonQuery();

                    // Вывести сообщение об успешном добавлении
                    MessageBox.Show("Запись успешно добавлена в таблицу equipment.");

                    // обновляем таблицу equipment_info_viewDataGridView
                    UpdateEquipmentInfoView();
                }
                catch (Exception ex)
                {
                    // Вывести сообщение об ошибке
                    MessageBox.Show($"Ошибка при добавлении записи в таблицу equipment: {ex.Message}");
                }
            }
        }

        private void delete_equipment_Click(object sender, EventArgs e)
        {
            if (equipment_info_viewDataGridView.SelectedRows.Count > 0)
            {
                // получаем ID выбранной записи
                int selectedRowID = (int)equipment_info_viewDataGridView.SelectedRows[0].Cells[0].Value;

                // создаем SQL-запрос на удаление записи из таблицы equipment
                string sql = "DELETE FROM equipment WHERE equipment_id = @id";

                // создаем команду SQL-запроса
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // добавляем параметры команды
                    command.Parameters.AddWithValue("@id", selectedRowID);

                    // открываем подключение
                    connection.Open();

                    // выполняем команду
                    int rowsAffected = command.ExecuteNonQuery();

                    // выводим сообщение об успешном удалении записи
                    MessageBox.Show("Запись успешно удалена из таблицы equipment.");

                    // обновляем таблицу equipment_info_viewDataGridView
                    UpdateEquipmentInfoView();
                }
            }
        }

        // метод для обновления таблицы equipment_info_viewDataGridView
        private void UpdateEquipmentInfoView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM equipment_info_view";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    equipment_info_viewDataGridView.DataSource = dt;
                }
                conn.Close();
            }

            // Обновление equipment_info_viewBindingSource
            equipment_info_viewBindingSource.ResetBindings(false);

            // Обновление equipment_info_viewDataGridView
            equipment_info_viewDataGridView.Refresh();
        }

        private void ApplyFilters()
        {
            // Формируем фильтрующую строку на основе состояний всех чекбоксов и текстовых полей
            string filterString = "";
            if (equipment_inventory_number_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(filterString))
                    filterString += " AND ";
                filterString += "Convert(equipment_inventory_number, 'System.String') LIKE '%" + equipment_inventory_numberTextBox.Text + "%'";
            }
            if (equipment_name_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(filterString))
                    filterString += " AND ";
                filterString += "equipment_name LIKE '%" + equipment_nameTextBox.Text + "%'";
            }
            if (equipment_type_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(filterString))
                    filterString += " AND ";
                filterString += "equipment_type LIKE '%" + equipment_typeTextBox.Text + "%'";
            }
            if (equipment_quantity_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(filterString))
                    filterString += " AND ";
                filterString += "Convert(equipment_quantity, 'System.String') LIKE '%" + equipment_quantityTextBox.Text + "%'";
            }
            if (room_name_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(filterString))
                    filterString += " AND ";
                filterString += "room_name LIKE '%" + room_nameTextBox.Text + "%'";
            }

            // Применяем фильтрующую строку к источнику данных
            equipment_info_viewBindingSource.Filter = filterString;
        }

        private void equipment_inventory_numberTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_nameTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_typeTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void room_nameTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_inventory_number_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_type_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void equipment_quantity_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void room_name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

    }
}

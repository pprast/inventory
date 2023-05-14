using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=DESKTOP-6HOINII;Initial Catalog=inventory_cabinets;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventory_cabinetsDataSet.inventory_view". При необходимости она может быть перемещена или удалена.
            this.inventory_viewTableAdapter.Fill(this.inventory_cabinetsDataSet.inventory_view);

        }

        private void FilterData()
        {
            string filterString = "";

            if (teacher_name_checkBox.Checked && !string.IsNullOrEmpty(teacher_nameTextBox.Text))
            {
                filterString += "teacher_name LIKE '%" + teacher_nameTextBox.Text + "%' AND ";
            }

            if (equipment_inventory_number_checkBox.Checked && !string.IsNullOrEmpty(equipment_inventory_numberTextBox.Text))
            {
                filterString += "Convert(equipment_inventory_number, 'System.String') LIKE '%" + equipment_inventory_numberTextBox.Text + "%' AND ";
            }

            if (equipment_name_checkBox.Checked && !string.IsNullOrEmpty(equipment_nameTextBox.Text))
            {
                filterString += "equipment_name LIKE '%" + equipment_nameTextBox.Text + "%' AND ";
            }

            if (equipment_type_checkBox.Checked && !string.IsNullOrEmpty(equipment_typeTextBox.Text))
            {
                filterString += "equipment_type LIKE '%" + equipment_typeTextBox.Text + "%' AND ";
            }

            if (equipment_quantity_checkBox.Checked && !string.IsNullOrEmpty(equipment_quantityTextBox.Text))
            {
                filterString += "Convert(equipment_quantity, 'System.String') LIKE '%" + equipment_quantityTextBox.Text + "%' AND ";
            }

            // Remove the trailing " AND " if there is one
            if (filterString.EndsWith(" AND "))
            {
                filterString = filterString.Substring(0, filterString.Length - 5);
            }

            inventory_viewBindingSource.Filter = filterString;
        }

        private void ClearFilter()
        {
            inventory_viewBindingSource.RemoveFilter();
        }

        private void teacher_nameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void equipment_inventory_numberTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void equipment_nameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void equipment_typeTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void equipment_quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void teacher_name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!teacher_name_checkBox.Checked)
            {
                ClearFilter();
            }
            else
            {
                FilterData();
            }
        }

        private void equipment_inventory_number_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!equipment_inventory_number_checkBox.Checked)
            {
                ClearFilter();
            }
            else
            {
                FilterData();
            }
        }

        private void equipment_name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!equipment_name_checkBox.Checked)
            {
                ClearFilter();
            }
            else
            {
                FilterData();
            }
        }

        private void equipment_type_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!equipment_type_checkBox.Checked)
            {
                ClearFilter();
            }
            else
            {
                FilterData();
            }
        }

        private void equipment_quantity_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!equipment_quantity_checkBox.Checked)
            {
                ClearFilter();
            }
            else
            {
                FilterData();
            }
        }



    }
}

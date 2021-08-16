using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class OperationsForm : Form
    {
        public List<Teacher> list, res_list;
        public OperationsForm(List<Teacher> list)
        {
            InitializeComponent();
            this.list = list;
            add_dgv(ref dataGridView_info, list);
            comboBox_method.SelectedIndex = 0;
        }
        private void add_dgv(ref DataGridView dgv, List<Teacher> teachers)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 9;
            dgv.RowCount = teachers.Count;
            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 60;
            dgv.Columns[2].Width = 90;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 70;
            dgv.Columns[5].Width = 80;
            dgv.Columns[6].Width = 80;
            dgv.Columns[7].Width = 50;
            dgv.Columns[8].Width = 50;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Имя";
            dgv.Columns[2].HeaderText = "Фамилия";
            dgv.Columns[3].HeaderText = "Отчество";
            dgv.Columns[4].HeaderText = "Дата рождения";
            dgv.Columns[5].HeaderText = "Кафедра";
            dgv.Columns[6].HeaderText = "Должность";
            dgv.Columns[7].HeaderText = "Стаж работы";
            dgv.Columns[8].HeaderText = "Зарплата";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv[0, i].Value = teachers[i].id;
                dgv[1, i].Value = teachers[i].name;
                dgv[2, i].Value = teachers[i].surname;
                dgv[3, i].Value = teachers[i].patronymic;
                dgv[4, i].Value = teachers[i].birth_date.ToShortDateString();
                dgv[5, i].Value = teachers[i].cathedra;
                dgv[6, i].Value = teachers[i].position;
                dgv[7, i].Value = teachers[i].experience;
                dgv[8, i].Value = teachers[i].salary;
            } 
        }

        private void comboBox_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_variant.Items.Clear();
            if (comboBox_method.SelectedIndex == 0) 
            {
                comboBox_variant.Items.Add("По зарплате (↑)");
                comboBox_variant.Items.Add("По стажу (↓)");
                comboBox_variant.Items.Add("По фамилии (↓)");
            }
            if (comboBox_method.SelectedIndex == 1)
            {
                comboBox_variant.Items.Add("Старше 1970 года");
                comboBox_variant.Items.Add("Зарплата больше 12 тысяч");
                comboBox_variant.Items.Add("Стаж больше 20 лет");
                comboBox_variant.Items.Add("В имени больше 6 букв");
            }
            if (comboBox_method.SelectedIndex == 2)
            {
                comboBox_variant.Items.Add("По кафедре");
                comboBox_variant.Items.Add("По должности");
                comboBox_variant.Items.Add("По фамилии");
            }
        }

        private void comboBox_variant_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox_method.SelectedIndex)
            {
                case 0:
                    {
                        switch(comboBox_variant.SelectedIndex)
                        {
                            case 0:
                                res_list = Operations.calculate(list, 1);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 1:
                                res_list = Operations.calculate(list, 2);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 2:
                                res_list = Operations.calculate(list, 3);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                        }
                        break;
                    }
                case 1:
                    {
                        switch (comboBox_variant.SelectedIndex)
                        {
                            case 0:
                                res_list = Operations.calculate(list, 4);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 1:
                                res_list = Operations.calculate(list, 5);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 2:
                                res_list = Operations.calculate(list, 6);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 3:
                                res_list = Operations.calculate(list, 7);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                        }
                        break;
                    }
                case 2:
                    {
                        switch (comboBox_variant.SelectedIndex)
                        {
                            case 0:
                                res_list = Operations.calculate(list, 8);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 1:
                                res_list = Operations.calculate(list, 9);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                            case 2:
                                res_list = Operations.calculate(list, 10);
                                add_dgv(ref dataGridView_info, res_list);
                                break;
                        }
                        break;
                    }
            }
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            add_dgv(ref dataGridView_info, list);
        }

        private void button_comparison_Click(object sender, EventArgs e)
        {
            ComparisonForm cf = new ComparisonForm();
            cf.ShowDialog();
        }
    }
}

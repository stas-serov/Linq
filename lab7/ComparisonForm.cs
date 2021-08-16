using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab7
{
    public partial class ComparisonForm : Form
    {
        long [] xval = new long[3];
        long [] yval = new long[3];
        List<string> list_names = new List<string>();
        List<string> res_list_names1, res_list_names2, res_list_names3;
        string[] names = new string[] {"Осип", "Роза", "Марк", "Нина", "Саид", "Рафик", "Олеся", "Семен", 
            "Ксана", "Тарас", "Степан", "Нинель", "Самсон", "Полина", "Эдуард", "Клемент", "Лукерья", "Клавдий", 
            "Снежана", "Никанор", "Августин", "Мальвина", "Всеволод", "Марианна", "Прокофий", "Святополк", "Маргарита", 
            "Кондратий", "Милослава", "Владислав", "Костантин", "Святослава", "Бартоломей", "Климентина", "Полиместор"};
        Random rd = new Random();
        Stopwatch sw1, sw2, sw3;
        public ComparisonForm()
        {
            InitializeComponent();
        }

        private void button_compare_Click(object sender, EventArgs e)
        {
            list_names.Clear();
            label_default.Text = "Default: \n";
            label_linq.Text = "Linq: \n";
            label_paralel_linq.Text = "Paralel linq: \n";
            label_custom.Text = "Custom: \n";
            for(int i = 0; i < (int)numericUpDown_count.Value; i++)
            {
                list_names.Add(names[rd.Next(0, names.Length)]);
            }
            res_list_names1 = Operations.linq_sort(list_names, ref sw1);
            res_list_names2 = Operations.paralel_linq_sort(list_names, ref sw2);
            res_list_names3 = Operations.custom_sort(list_names, ref sw3);
            dgv_add();
            foreach(string str in list_names)
                label_default.Text += str + "\n";
            foreach(string str in res_list_names1)
                label_linq.Text += str + "\n";
            foreach (string str in res_list_names2)
                label_paralel_linq.Text += str + "\n";
            foreach (string str in res_list_names3)
                label_custom.Text += str + "\n";
            yval[0] = sw1.Elapsed.Ticks;
            yval[1] = sw2.Elapsed.Ticks;
            yval[2] = sw3.Elapsed.Ticks;
            xval[0] = 1;
            xval[1] = 2;
            xval[2] = 3;
            chart_info.Series[0].Name = "Ser1";
            chart_info.Series[0].Points.DataBindXY(xval, yval);
            chart_info.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart_info.Titles[0].Text = "Сравнение графиков";
            chart_info.ChartAreas[0].AxisX.Title = "Ось Х";
            chart_info.ChartAreas[0].AxisY.Title = "Ось Y";
        }
        private void dgv_add()
        {
            dataGridView_info.RowHeadersVisible = false;
            dataGridView_info.Columns.Clear();
            dataGridView_info.ColumnCount = 2;
            dataGridView_info.RowCount = 3;
            dataGridView_info.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_info.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_info.Columns[0].HeaderText = "Method";
            dataGridView_info.Columns[1].HeaderText = "Time";
            for (int i = 0; i < dataGridView_info.ColumnCount; i++ )
                dataGridView_info.Columns[i].Width = 100;
            dataGridView_info[0, 0].Value = "Linq";
            dataGridView_info[0, 1].Value = "Paralel linq";
            dataGridView_info[0, 2].Value = "Custom";
            dataGridView_info[1, 0].Value = sw1.Elapsed.Ticks;
            dataGridView_info[1, 1].Value = sw2.Elapsed.Ticks;
            dataGridView_info[1, 2].Value = sw3.Elapsed.Ticks;
        }
    }
}

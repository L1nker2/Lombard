using Kursovaya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Lombard
{
    public partial class ProductForm : Form
    {
        public void LoadData()
        {
            using (ProductDbContext context = new())
            {
                var products = context.Products.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер товара", typeof(int));
                dataTable.Columns.Add("Название товара", typeof(string));
                dataTable.Columns.Add("Тип товара", typeof(string));
                dataTable.Columns.Add("Цена товара", typeof(int));
                foreach (var product in products)
                {
                    dataTable.Rows.Add(product.Product_Id, product.Product_Name, product.Product_Type, product.Product_Price);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public ProductForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(12, 437);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер товара"].Value.ToString();
                ProductDbContext.RemoveProduct(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно");
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(12, 437);
            panel2.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Name = row.Cells["Название товара"].Value.ToString();
                string Price = row.Cells["Цена товара"].Value.ToString();
                textBox3.Text = Price;
                textBox4.Text = Name;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Name, Type, Price;
            Name = textBox1.Text;
            Type = comboBox1.SelectedItem.ToString();
            Price = textBox2.Text;
            if (Name == "" || Price == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            ProductDbContext.AddProduct(Name, Type, int.Parse(Price));
            MessageBox.Show("Добавление прошло успешно");
            LoadData();
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Id = row.Cells["Номер товара"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
            string Name = textBox4.Text;
            string Type = comboBox2.SelectedItem.ToString();
            string Price = textBox3.Text;
            if (Name == "" || Type == "" || Price == "")
            {
                MessageBox.Show("необходимо заполнить все поля");
                return;
            }
            ProductDbContext.EditProduct(int.Parse(Id), Name, Type, int.Parse(Price));
            MessageBox.Show("Изменение прошло успешно");
            LoadData();
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filtre = comboBox3.SelectedItem.ToString();
            using (ProductDbContext context = new())
            {
                var products = context.Products.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер товара", typeof(int));
                dataTable.Columns.Add("Название товара", typeof(string));
                dataTable.Columns.Add("Тип товара", typeof(string));
                dataTable.Columns.Add("Цена товара", typeof(int));
                foreach (var product in products)
                {
                    if (product.Product_Type == filtre)
                    {
                        dataTable.Rows.Add(product.Product_Id, product.Product_Name, product.Product_Type, product.Product_Price);
                    }
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

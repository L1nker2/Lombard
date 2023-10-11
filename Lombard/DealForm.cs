using Kursovaya;
using System.Data;
namespace Lombard
{
    public partial class DealForm : Form
    {
        public void LoadData()
        {
            using (DealDbContext context = new DealDbContext())
            {
                var deals = context.Deals.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер сделки", typeof(int));
                dataTable.Columns.Add("ФИО клиента", typeof(string));
                dataTable.Columns.Add("ФИО менеджера", typeof(string));
                dataTable.Columns.Add("Продукт", typeof(string));
                using (BuyerDbContext context1 = new BuyerDbContext())
                {
                    using (ManagerDbContext context2 = new ManagerDbContext())
                    {
                        using (ProductDbContext context3 = new ProductDbContext())
                        {
                            foreach (var deal in deals)
                            {
                                var buyer = context1.Buyers.FirstOrDefault(el => el.Buyer_Id == deal.Buyer_Id);
                                var manager = context2.Managers.FirstOrDefault(el => el.Manager_Id == deal.Manager_Id);
                                var product = context3.Products.FirstOrDefault(el => el.Product_Id == deal.Product_Id);
                                dataTable.Rows.Add(deal.Deal_Id, buyer.Buyer_Fio, manager.Manager_Fio, product.Product_Name);
                            }
                            var buyers = context1.Buyers.ToList();
                            var managers = context2.Managers.ToList();
                            var products = context3.Products.ToList();
                            foreach (var buyer in buyers)
                            {
                                comboBox3.Items.Add(buyer.Buyer_Fio);
                                comboBox4.Items.Add(buyer.Buyer_Fio);
                            }
                            foreach (var manager in managers)
                            {
                                comboBox2.Items.Add(manager.Manager_Fio);
                                comboBox5.Items.Add(manager.Manager_Fio);
                            }
                            foreach (var product in products)
                            {
                                comboBox1.Items.Add(product.Product_Name);
                                comboBox6.Items.Add(product.Product_Name);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public DealForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(12, 514);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(12, 514);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер сделки"].ColumnIndex.ToString();
                DealDbContext.RemoveDeal(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно");
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string DealId = row.Cells["Номер сделки"].Value.ToString();
                string NewClient = comboBox4.SelectedItem.ToString();
                string NewManager = comboBox5.SelectedItem.ToString();
                string NewProduct = comboBox6.SelectedItem.ToString();
                using (BuyerDbContext context1 = new())
                {
                    using (ManagerDbContext context2 = new())
                    {
                        using (ProductDbContext context3 = new())
                        {
                            var buyer = context1.Buyers.FirstOrDefault(el => el.Buyer_Fio == NewClient);
                            var manager = context2.Managers.FirstOrDefault(el => el.Manager_Fio == NewManager);
                            var product = context3.Products.FirstOrDefault(el => el.Product_Name == NewProduct);
                            DealDbContext.EditDeal(int.Parse(DealId), buyer.Buyer_Id, manager.Manager_Id, product.Product_Id);
                            MessageBox.Show("Изменение прошло успешно");
                            LoadData();
                            panel2.Visible = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string Client = comboBox3.SelectedItem.ToString();
            string Manager = comboBox2.SelectedItem.ToString();
            string Product = comboBox1.SelectedItem.ToString();
            using (BuyerDbContext context1 = new())
            {
                using (ManagerDbContext context2 = new())
                {
                    using (ProductDbContext context3 = new())
                    {
                        var buyer = context1.Buyers.FirstOrDefault(el => el.Buyer_Fio == Client);
                        var manager = context2.Managers.FirstOrDefault(el => el.Manager_Fio == Manager);
                        var product = context3.Products.FirstOrDefault(el => el.Product_Name == Product);
                        DealDbContext.AddDeal(buyer.Buyer_Id, manager.Manager_Id, product.Product_Id);
                        MessageBox.Show("Добавление прошло успешно");
                        LoadData();
                        panel1.Visible = false;
                    }
                }
            }
        }
    }
}

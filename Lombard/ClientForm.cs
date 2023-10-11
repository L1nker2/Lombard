using Kursovaya;
using System.Data;
namespace Lombard
{
    public partial class ClientForm : Form
    {
        public void LoadData()
        {
            using (BuyerDbContext context = new BuyerDbContext())
            {
                var buers = context.Buyers.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер клиента", typeof(int));
                dataTable.Columns.Add("ФИО клиента", typeof(string));
                dataTable.Columns.Add("Телефон клиента", typeof(string));
                foreach (var buyer in buers)
                {
                    dataTable.Rows.Add(buyer.Buyer_Id, buyer.Buyer_Fio, buyer.Buyer_Phone);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public ClientForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(12, 511);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер клиента"].Value.ToString();
                BuyerDbContext.RemoveBuyer(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно");
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(12, 511);
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Fio = row.Cells["ФИО клиента"].Value.ToString();
                string Phone = row.Cells["Телефон клиента"].Value.ToString();
                textBox3.Text = Fio;
                textBox4.Text = Phone;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string Fio = textBox2.Text;
            string Phone = textBox1.Text;
            if(Fio == "" || Phone == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            BuyerDbContext.AddBuyer(Fio, Phone);
            MessageBox.Show("Добавление прошло успешно");
            panel1.Visible = false;
            LoadData();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string Fio = textBox3.Text;
            string Phone = textBox4.Text;
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер клиента"].Value.ToString();
                if(Fio == "" || Phone == "")
                {
                    MessageBox.Show("Необходимо заполнить все поля");
                    return;
                }
                BuyerDbContext.EditBuyer(int.Parse(Id), Fio, Phone);
                MessageBox.Show("Изменение прошло успешно");
                panel2.Visible = false;
                LoadData();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }
    }
}

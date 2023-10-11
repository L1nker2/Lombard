using Kursovaya;
using System.Data;
namespace Lombard
{
    public partial class ManagerForm : Form
    {
        public void LoadData()
        {
            using (ManagerDbContext context = new ManagerDbContext())
            {
                var managers = context.Managers.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер менеджера", typeof(int));
                dataTable.Columns.Add("ФИО менеджера", typeof(string));
                dataTable.Columns.Add("Телефон менеджера", typeof(string));
                foreach (var manager in managers)
                {
                    dataTable.Rows.Add(manager.Manager_Id, manager.Manager_Fio, manager.Manager_Phone);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public ManagerForm()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel1.Visible = false;
            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(12, 511);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(12, 511);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Fio = row.Cells["ФИО менеджера"].Value.ToString();
                string Phone = row.Cells["Телефон менеджера"].Value.ToString();
                textBox1.Text = Fio;
                textBox2.Text = Phone;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер менеджера"].Value.ToString();
                ManagerDbContext.RemoveManager(int.Parse(Id));
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
            string Fio = textBox3.Text;
            string Phone = textBox4.Text;
            ManagerDbContext.AddManager(Fio, Phone);
            MessageBox.Show("Добавление прошло успешно");
            panel2.Visible = false;
            LoadData();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string Fio = textBox1.Text;
            string Phone = textBox2.Text;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер менеджера"].Value.ToString();
                if (Fio == "" || Phone == "")
                {
                    MessageBox.Show("Необходимо заполнить все поля");
                    return;
                }
                ManagerDbContext.EditManager(int.Parse(Id), Fio, Phone);
                MessageBox.Show("Изменение прошло успешно");
                panel1.Visible = false;
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

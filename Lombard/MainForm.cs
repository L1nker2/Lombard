using Kursovaya;
using System.Data;
namespace Lombard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана студентом группы 404-ИС\n Корецкий Владислав Игоревич");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm f = new ClientForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerForm f = new ManagerForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm f = new ProductForm();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DealForm f = new DealForm();
            f.Show();
        }
    }
}
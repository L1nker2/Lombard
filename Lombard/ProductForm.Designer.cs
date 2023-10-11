namespace Lombard
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            button5 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(982, 419);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 680);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(138, 679);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 680);
            button3.Name = "button3";
            button3.Size = new Size(120, 30);
            button3.TabIndex = 3;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 236);
            panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 34);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 34);
            textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Телефон", "Телевизор", "Холодильник", "Стиральная машина", "Посудомойка", "Фен", "Микроволновка", "Другое..." });
            comboBox1.Location = new Point(120, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 34);
            comboBox1.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(120, 132);
            button4.Name = "button4";
            button4.Size = new Size(249, 30);
            button4.TabIndex = 6;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 85);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 2;
            label3.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 45);
            label2.Name = "label2";
            label2.Size = new Size(55, 26);
            label2.TabIndex = 1;
            label2.Text = "Тип:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(390, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 236);
            panel2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 34);
            textBox3.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point(118, 132);
            button5.Name = "button5";
            button5.Size = new Size(252, 30);
            button5.TabIndex = 6;
            button5.Text = "Изменить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(118, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 34);
            textBox4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(107, 26);
            label6.TabIndex = 10;
            label6.Text = "Название:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(118, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(252, 34);
            comboBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 45);
            label5.Name = "label5";
            label5.Size = new Size(55, 26);
            label5.TabIndex = 11;
            label5.Text = "Тип:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 85);
            label4.Name = "label4";
            label4.Size = new Size(65, 26);
            label4.TabIndex = 12;
            label4.Text = "Цена:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 683);
            label7.Name = "label7";
            label7.Size = new Size(175, 26);
            label7.TabIndex = 8;
            label7.Text = "Показать только:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Телефон", "Телевизор", "Холодильник", "Стиральная машина", "Посудомойка", "Фен", "Микроволновка", "Другое..." });
            comboBox3.Location = new Point(571, 679);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(186, 34);
            comboBox3.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(763, 680);
            button6.Name = "button6";
            button6.Size = new Size(113, 33);
            button6.TabIndex = 10;
            button6.Text = "Показать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(882, 680);
            button7.Name = "button7";
            button7.Size = new Size(113, 33);
            button7.TabIndex = 11;
            button7.Text = "Отмена";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProductForm";
            Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Panel panel2;
        private Button button5;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private Label label4;
        private Label label7;
        private ComboBox comboBox3;
        private Button button6;
        private Button button7;
    }
}
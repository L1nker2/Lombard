namespace Lombard
{
    partial class ManagerForm
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
            panel2 = new Panel();
            button5 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            dataGridView1.Size = new Size(982, 494);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 680);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 680);
            button2.Name = "button2";
            button2.Size = new Size(140, 30);
            button2.TabIndex = 2;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(158, 679);
            button3.Name = "button3";
            button3.Size = new Size(140, 30);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 512);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 162);
            panel2.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(126, 105);
            button5.Name = "button5";
            button5.Size = new Size(120, 30);
            button5.TabIndex = 5;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 34);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(112, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 34);
            textBox4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 45);
            label3.Name = "label3";
            label3.Size = new Size(101, 26);
            label3.TabIndex = 1;
            label3.Text = "Телефон:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 5);
            label4.Name = "label4";
            label4.Size = new Size(68, 26);
            label4.TabIndex = 0;
            label4.Text = "ФИО:";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(450, 514);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 162);
            panel1.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(126, 105);
            button4.Name = "button4";
            button4.Size = new Size(120, 30);
            button4.TabIndex = 5;
            button4.Text = "Изменить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 34);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 45);
            label1.Name = "label1";
            label1.Size = new Size(101, 26);
            label1.TabIndex = 1;
            label1.Text = "Телефон:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 5);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 0;
            label2.Text = "ФИО:";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ManagerForm";
            Text = "Менеджеры";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Button button5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}
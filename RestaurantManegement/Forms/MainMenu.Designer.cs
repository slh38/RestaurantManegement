namespace RestaurantManegement
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            BtnReservasyonEkle = new Button();
            btnMenuEkle = new Button();
            btnSiparisEkle = new Button();
            dataSiparis = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSiparis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Reservasyon";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Menü";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(89, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 23);
            comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(89, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "Sipariş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Miktar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 7;
            // 
            // BtnReservasyonEkle
            // 
            BtnReservasyonEkle.Location = new Point(283, 6);
            BtnReservasyonEkle.Name = "BtnReservasyonEkle";
            BtnReservasyonEkle.Size = new Size(145, 23);
            BtnReservasyonEkle.TabIndex = 8;
            BtnReservasyonEkle.Text = "Reservasyon Ekle";
            BtnReservasyonEkle.UseVisualStyleBackColor = true;
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Location = new Point(283, 35);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(145, 23);
            btnMenuEkle.TabIndex = 8;
            btnMenuEkle.Text = "Menü Ekle";
            btnMenuEkle.UseVisualStyleBackColor = true;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(89, 122);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(176, 30);
            btnSiparisEkle.TabIndex = 9;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            // 
            // dataSiparis
            // 
            dataSiparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSiparis.Location = new Point(12, 169);
            dataSiparis.Name = "dataSiparis";
            dataSiparis.Size = new Size(811, 303);
            dataSiparis.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(271, 122);
            button1.Name = "button1";
            button1.Size = new Size(176, 30);
            button1.TabIndex = 9;
            button1.Text = "Sipariş Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(453, 122);
            button2.Name = "button2";
            button2.Size = new Size(176, 30);
            button2.TabIndex = 9;
            button2.Text = "Sipariş Ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 484);
            Controls.Add(dataSiparis);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSiparisEkle);
            Controls.Add(btnMenuEkle);
            Controls.Add(BtnReservasyonEkle);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Orders Form";
            ((System.ComponentModel.ISupportInitialize)dataSiparis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Button BtnReservasyonEkle;
        private Button btnMenuEkle;
        private Button btnSiparisEkle;
        private DataGridView dataSiparis;
        private Button button1;
        private Button button2;
    }
}

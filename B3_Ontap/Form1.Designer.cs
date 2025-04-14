namespace B3_Ontap
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            textBoxMaSach = new TextBox();
            textBoxTenSach = new TextBox();
            textBoxDonGia = new TextBox();
            radioButton100 = new RadioButton();
            radioButton1000 = new RadioButton();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 67);
            label1.Name = "label1";
            label1.Size = new Size(149, 31);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 236);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 143);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã sách ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 143);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 240);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 3;
            label5.Text = "Số trang";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 321);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(502, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxMaSach
            // 
            textBoxMaSach.Location = new Point(114, 143);
            textBoxMaSach.Name = "textBoxMaSach";
            textBoxMaSach.Size = new Size(173, 27);
            textBoxMaSach.TabIndex = 6;
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Location = new Point(114, 233);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(173, 27);
            textBoxTenSach.TabIndex = 7;
            // 
            // textBoxDonGia
            // 
            textBoxDonGia.Location = new Point(594, 143);
            textBoxDonGia.Name = "textBoxDonGia";
            textBoxDonGia.Size = new Size(173, 27);
            textBoxDonGia.TabIndex = 8;
            // 
            // radioButton100
            // 
            radioButton100.AutoSize = true;
            radioButton100.Location = new Point(594, 240);
            radioButton100.Name = "radioButton100";
            radioButton100.Size = new Size(54, 24);
            radioButton100.TabIndex = 9;
            radioButton100.TabStop = true;
            radioButton100.Text = "100";
            radioButton100.UseVisualStyleBackColor = true;
            // 
            // radioButton1000
            // 
            radioButton1000.AutoSize = true;
            radioButton1000.Location = new Point(717, 240);
            radioButton1000.Name = "radioButton1000";
            radioButton1000.Size = new Size(62, 24);
            radioButton1000.TabIndex = 10;
            radioButton1000.TabStop = true;
            radioButton1000.Text = "1000";
            radioButton1000.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(666, 337);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 11;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(666, 400);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 12;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(666, 466);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 13;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 557);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(radioButton1000);
            Controls.Add(radioButton100);
            Controls.Add(textBoxDonGia);
            Controls.Add(textBoxTenSach);
            Controls.Add(textBoxMaSach);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox textBoxMaSach;
        private TextBox textBoxTenSach;
        private TextBox textBoxDonGia;
        private RadioButton radioButton100;
        private RadioButton radioButton1000;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
    }
}

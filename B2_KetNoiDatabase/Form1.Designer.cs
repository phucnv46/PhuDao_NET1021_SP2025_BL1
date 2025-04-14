namespace B2_KetNoiDatabase
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
            labelTen = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxMNV = new TextBox();
            textBoxTen = new TextBox();
            textBoxCV = new TextBox();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            dataGridView1 = new DataGridView();
            buttonThem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(282, 25);
            label1.Name = "label1";
            label1.Size = new Size(214, 35);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 127);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(24, 222);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(99, 20);
            labelTen.TabIndex = 3;
            labelTen.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 127);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 229);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Giới tính ";
            // 
            // textBoxMNV
            // 
            textBoxMNV.Location = new Point(142, 127);
            textBoxMNV.Name = "textBoxMNV";
            textBoxMNV.Size = new Size(198, 27);
            textBoxMNV.TabIndex = 5;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(142, 222);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(198, 27);
            textBoxTen.TabIndex = 6;
            // 
            // textBoxCV
            // 
            textBoxCV.Location = new Point(556, 120);
            textBoxCV.Name = "textBoxCV";
            textBoxCV.Size = new Size(198, 27);
            textBoxCV.TabIndex = 7;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(547, 229);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 8;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(656, 229);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 9;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 285);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(507, 189);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(625, 285);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 11;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(625, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(button1);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(textBoxCV);
            Controls.Add(textBoxTen);
            Controls.Add(textBoxMNV);
            Controls.Add(label5);
            Controls.Add(labelTen);
            Controls.Add(label4);
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
        private Label labelTen;
        private Label label4;
        private Label label5;
        private TextBox textBoxMNV;
        private TextBox textBoxTen;
        private TextBox textBoxCV;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private DataGridView dataGridView1;
        private Button buttonThem;
        private Button button1;
    }
}

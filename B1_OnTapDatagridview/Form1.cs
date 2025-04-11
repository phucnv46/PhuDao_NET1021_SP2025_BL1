using System.ComponentModel;

namespace B1_OnTapDatagridview
{
    public partial class Form1 : Form
    {
        BindingList<SinhVien> _sinhViens = new BindingList<SinhVien>() {
           new SinhVien(){MaSinhVien="SV1",TenSinhVien="Nam",MaLop="SD20302",GioiTinh=true,NgaySinh = new DateTime(2000,7,7)},
           new SinhVien(){MaSinhVien="SV2",TenSinhVien="Hanh",MaLop="MD20305",GioiTinh=false,NgaySinh = new DateTime(2008,1,7)},
           new SinhVien(){MaSinhVien="SV3",TenSinhVien="Thuy",MaLop="GD20304",GioiTinh=false,NgaySinh = new DateTime(2003,3,7)},
        };

        List<Lop> _lops = new List<Lop>() {
         new Lop(){MaLop="SD20302", TenLop="Lập trình C#"},
         new Lop(){MaLop="GD20304", TenLop="Lập trình Java"},
         new Lop(){MaLop="MD20305", TenLop="Lập trình Python"},
        };
        public Form1()
        {
            InitializeComponent();
        }


        private void LoadTable()
        {
            dataGridView1.DataSource = _sinhViens;
            comboBox1.DataSource = _lops;
            comboBox1.DisplayMember = "TenLop";
            comboBox1.ValueMember = "MaLop";
            radioButtonNam.Checked = true;
        }


        private SinhVien BindingToModel(SinhVien sinhVien)
        {
            sinhVien.MaSinhVien = textBoxMaSinhVien.Text;
            sinhVien.TenSinhVien = textBoxTen.Text;
            sinhVien.MaLop = (string)comboBox1.SelectedValue;
            sinhVien.GioiTinh = radioButtonNam.Checked;
            sinhVien.NgaySinh = dateTimePicker1.Value;
            return sinhVien;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTable();
        }



        private void buttonThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            BindingToModel(sinhVien);
            _sinhViens.Add(sinhVien);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVien sinhVien = (SinhVien)dataGridView1.SelectedRows[0].DataBoundItem;
            textBoxMaSinhVien.Text = sinhVien.MaSinhVien;
            textBoxTen.Text = sinhVien.TenSinhVien;
            dateTimePicker1.Value = sinhVien.NgaySinh;
            comboBox1.SelectedValue = sinhVien.MaLop;
            radioButtonNam.Checked = sinhVien.GioiTinh;
            radioButtonNu.Checked = sinhVien.GioiTinh == false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = (SinhVien)dataGridView1.SelectedRows[0].DataBoundItem;
            int index = _sinhViens.IndexOf(sinhVien);
            _sinhViens[index] = BindingToModel(sinhVien);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = (SinhVien)dataGridView1.SelectedRows[0].DataBoundItem;

            _sinhViens.Remove(sinhVien);
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            textBoxMaSinhVien.ResetText();
            textBoxTen.ResetText();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
            radioButtonNam.Checked = true;
            LoadTable();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            BindingList<SinhVien> listimKiem = new BindingList<SinhVien>();
            foreach (var sinhVien in _sinhViens)
            {
                if (sinhVien.MaSinhVien.Contains(textBoxTK.Text, StringComparison.OrdinalIgnoreCase)) 
                listimKiem.Add(sinhVien);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listimKiem;
            listimKiem = null;
        }
    }
}

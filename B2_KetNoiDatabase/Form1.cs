using B2_KetNoiDatabase.Models;
using B2_KetNoiDatabase.Repositories;
using System.ComponentModel;

namespace B2_KetNoiDatabase
{
    public partial class Form1 : Form
    {
        BindingList<NhanVien> _nhanViens;
        NhanVienRepository _repository = new NhanVienRepository();
        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            List<NhanVien> listLayTuDatabase = _repository.LayDanhSach(); // Lấy danh sachs từ database
            _nhanViens = new BindingList<NhanVien>(listLayTuDatabase);// chuyển list thành bindinglist

            dataGridView1.DataSource = _nhanViens;
            radioButtonNam.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_nhanViens.Count > 0) // Kiểm tra xem list có trống không
            {
                // NhanVien nhanVien= _nhanViens[_nhanViens.Count - 1]; // Lấy thằng cuối cùng
                // Tiếng anh : cuối cùng là Last()
                NhanVien nhanVienCuoiCung = _nhanViens.Last();
                textBoxTen.Text = nhanVienCuoiCung.TenNhanVien;
                textBoxMNV.Text = nhanVienCuoiCung.MaNhanVien;
                textBoxCV.Text = nhanVienCuoiCung.ChucVu;
                radioButtonNam.Checked = nhanVienCuoiCung.GioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);
                radioButtonNu.Checked = nhanVienCuoiCung.GioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase);
                int index = _nhanViens.IndexOf(nhanVienCuoiCung); // Tìm index của nhân viên cuối cùng
                dataGridView1.Rows[index].Selected = true; // chọn index đó
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhanVienCuoiCung = (NhanVien)dataGridView1.SelectedRows[0].DataBoundItem as NhanVien; //Ép kiểu
            textBoxTen.Text = nhanVienCuoiCung.TenNhanVien;
            textBoxMNV.Text = nhanVienCuoiCung.MaNhanVien;
            textBoxCV.Text = nhanVienCuoiCung.ChucVu;
            radioButtonNam.Checked = nhanVienCuoiCung.GioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);
            radioButtonNu.Checked = nhanVienCuoiCung.GioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

            if (CheckTrong())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = textBoxMNV.Text;
                nhanVien.ChucVu = textBoxCV.Text;
                nhanVien.TenNhanVien = textBoxTen.Text;
                nhanVien.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                _repository.Them(nhanVien);
                LoadTable();
            }
            /*if (radioButtonNam.Checked) nhanVien.GioiTinh = "Nam";
            else nhanVien.GioiTinh = "Nữ";*/
        }

        private bool CheckTrong()
        {
            if (
                string.IsNullOrEmpty(textBoxMNV.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxCV.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxTen.Text.Trim())
                )
            {
                MessageBox.Show("Có trường đang trống");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

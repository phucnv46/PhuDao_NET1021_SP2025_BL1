using B3_Ontap.Models;
using B3_Ontap.Resipotories;
using System.ComponentModel;

namespace B3_Ontap
{
    public partial class Form1 : Form
    {
        BindingList<Sach> _saches;
        SachRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new SachRepository();
        }

        private void LoadDuLieuLenBang()
        {
            _saches = new BindingList<Sach>(_repository.LaySachTuDatabase()); // Chuyển sách từ database thành binding list
            dataGridView1.DataSource = _saches;
            dataGridView1.Columns[0].HeaderText = "Mã sách";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieuLenBang();
            if (_saches.Any()) // Kiểm tra list có phần tử nào chưa
            {
                Sach sach = _saches.Last(); // Tìm phần tử cuối cùng của danh sách
                textBoxDonGia.Text = sach.DonGia.ToString();
                textBoxMaSach.Text = sach.MaSach;
                textBoxTenSach.Text = sach.TenSach;
                radioButton100.Checked = sach.SoTrang == 100;
                radioButton1000.Checked = sach.SoTrang == 1000;
                dataGridView1.Rows[_saches.Count - 1].Selected = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra người chọn chưa
            {
                Sach sach = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
                textBoxDonGia.Text = sach.DonGia.ToString();
                textBoxMaSach.Text = sach.MaSach;
                textBoxTenSach.Text = sach.TenSach;
                radioButton100.Checked = sach.SoTrang == 100;
                radioButton1000.Checked = sach.SoTrang == 1000;
            }
        }

        private bool KiemTraKhiThem()
        {
            foreach (var sach in _saches)
            {
                if (sach.MaSach.Equals(textBoxMaSach.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sách đã trùng");
                    return false;
                }

            }
            return true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (KiemTraKhiThem())
            {
                Sach sach = new Sach();
                sach.MaSach = textBoxMaSach.Text;
                sach.TenSach = textBoxTenSach.Text;
                sach.DonGia = decimal.Parse(textBoxDonGia.Text);
                sach.SoTrang = radioButton100.Checked ? 100 : 1000;
                _repository.Them(sach);
                MessageBox.Show("Thêm thành công");
                LoadDuLieuLenBang();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Sach sach = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
            // sach.MaSach = textBoxMaSach.Text;
            sach.TenSach = textBoxTenSach.Text;
            sach.DonGia = decimal.Parse(textBoxDonGia.Text);
            sach.SoTrang = radioButton100.Checked ? 100 : 1000;

            _repository.Sua(sach);
            LoadDuLieuLenBang();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Sach sach = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
            
         

            DialogResult result = MessageBox.Show("Bạn có muốn xoá không", "Cảnh báo",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _repository.Xoa(sach);
            }

            LoadDuLieuLenBang();
        }
    }
}

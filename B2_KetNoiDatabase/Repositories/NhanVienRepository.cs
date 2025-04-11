using B2_KetNoiDatabase.DataContext;
using B2_KetNoiDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_KetNoiDatabase.Repositories
{
    public class NhanVienRepository // Sẽ tương tác chính database
    {
        // Tạo ra thể hiện của context
        PhuDaoNet1021Context _context = new PhuDaoNet1021Context();

        public List<NhanVien> LayDanhSach()
        {
            return _context.NhanViens.ToList();
        }

        public void Them(NhanVien nhanVien)
        {
            _context.NhanViens.Add(nhanVien); // Thêm nhân viên vào bảng
            _context.SaveChanges(); // Lưu thay đổi của database
        }
    }
}

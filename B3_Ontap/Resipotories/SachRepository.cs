using B3_Ontap.DataContext;
using B3_Ontap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_Ontap.Resipotories
{
    public class SachRepository
    {
        PhuDaoNet1021Context _context = new PhuDaoNet1021Context();
        
        public List<Sach> LaySachTuDatabase()
        {
            return _context.Saches.ToList(); // Lấy bảng sách từ database rồi chuyển thành list
        }

        public void Them(Sach sach)
        {
            _context.Saches.Add(sach); // thêm vào database
            _context.SaveChanges(); // lưu thay đổi
        } 
        public void Sua(Sach sach)
        {
            _context.Saches.Update(sach); // thêm vào database
            _context.SaveChanges(); // lưu thay đổi
        } 
        public void Xoa(Sach sach)
        {
            _context.Saches.Remove(sach); // thêm vào database
            _context.SaveChanges(); // lưu thay đổi
        }
    }
}

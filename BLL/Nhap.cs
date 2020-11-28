using Quanlicuahangdienthoai;
using Quanlicuahangphukien;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanlicuaHangphukien
{
    class Nhap
    {

        public void Nhapkhachhang(ArrayList arrayList)
        {
            
            
            arrayList.Add(new Khachhhang(Tenkhachhang(), Sodienthoaikhachhang(), Dienthoaikhachmua()));
        }
        public string Tenkhachhang()
        {
            Console.Write("Nhập tên khách hàng: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string Sodienthoaikhachhang()
        {
            Console.WriteLine("Nhập số điện thoại khách hàng: ");
            string sdt = Console.ReadLine();
            return sdt;
        }
        public string Dienthoaikhachmua()
        {
            Console.WriteLine("Nhập phụ kiện điện thoại khách mua: ");
            string dienthoai = Console.ReadLine();
            return dienthoai;

        }
        public void Nhapdienthoai(ArrayList arrayList)
        {
            
            arrayList.Add(new Dienthoai(Tenphukien(), Hangphukien(), Giaphukien(), Danhcho(), Loai(), Chatluong(), soluong()));
        }
        //string Tenphukien,string Hangphukien,int Giaphukien, string Danhcho, string Loai,string Chatluong
        public string Tenphukien()
        {
            Console.Write("Nhập tên phụ kiện điện thoại: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string Hangphukien()
        {
            Console.Write("Nhập hãng phụ kiện điện thoại: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public int Giaphukien()
        {
            Console.Write("Nhập giá phụ kiện điện thoại: ");
            int gia = int.Parse(Console.ReadLine());
            return gia;
        }
        public string Danhcho()
        {
            Console.Write("Phụ kiện dành cho : ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string Loai()
        {
            Console.Write("Nhập loại phụ kiện : ");
            string ten = Console.ReadLine();
            return ten;
        }
        public string Chatluong()
        {
            Console.Write("Nhập chất lượng phụ kiện: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public int soluong()
        {
            Console.WriteLine("Nhập số lượng: ");
            int sl = int.Parse(Console.ReadLine());
            return sl;
        }
    }
}

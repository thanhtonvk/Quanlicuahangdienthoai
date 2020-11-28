using Quanlicuahangdienthoai;
using Quanlicuahangdienthoai.BLL.Interface;
using Quanlicuahangphukien;
using System;
using System.Collections;

namespace QuanlicuaHangphukien
{
    class Chucnang_BLL: Chucnang_IF
    {
       
        static DocGhifile_DAL docGhifile = new DocGhifile_DAL();
        public void Hiendienthoai(Dienthoai dienthoai)
        {
            Console.WriteLine("{0,20}|{1,20}|{2,20}|{3,20}|{4,20}|{5,20}|{6,20}|", dienthoai.Tenphukien, dienthoai.Hangphukien, dienthoai.Giaphukien, dienthoai.Loai, dienthoai.Danhcho, dienthoai.Chatluong, dienthoai.Soluong);
        }
        public void Hientatcadienthoai(ArrayList arrayList)
        {
           
         
            Console.WriteLine("{0,20}|{1,20}|{2,20}|{3,20}|{4,20}|{5,20}|{6,20}|", "Tên", "Hãng", "Giá", "Loại", "Dành cho", "Chất lượng", "Số lượng");
            foreach (Dienthoai dienthoai in arrayList)
            {
                Hiendienthoai(dienthoai);
            }
        }
        public void Timdienthoai(ArrayList arrayList, string keyword)
        {
            bool kt = false;
            foreach (Dienthoai dienthoai in arrayList)
            {
                if (dienthoai.Tenphukien.ToLower().Equals(keyword.ToLower()) || dienthoai.Hangphukien.ToLower().Equals(keyword.ToLower()) || dienthoai.Chatluong.ToLower().Equals(keyword.ToLower()) || dienthoai.Giaphukien.ToString().ToLower().Equals(keyword.ToLower()) || dienthoai.Loai.ToLower().Equals(keyword.ToLower()))
                {
                    Hiendienthoai(dienthoai);
                    kt = true;
                }

            }
            if (kt == false) Console.WriteLine("Không tìm thầy điện thoại cần tìm!");
        }
        public void Hienkhachhang(Khachhhang khachhang)
        {
            Console.WriteLine("{0}\t{1}\t{2}", khachhang.Tenkhachhang, khachhang.Sodienthoai, khachhang.Phukienkhachmua);
        }
        public void Hientatcakhachhang(ArrayList arrayList)
        {
           
            foreach (Khachhhang khachhang in arrayList)
            {
                Hienkhachhang(khachhang);
            }
        }
        public void Timkhachhang(ArrayList arrayList, string keyword)
        {
            bool kt = false;
            foreach (Khachhhang khachhang in arrayList)
            {
                if (khachhang.Phukienkhachmua.ToLower().Equals(keyword.ToLower()) || khachhang.Sodienthoai.ToLower().Equals(keyword.ToLower()) || khachhang.Tenkhachhang.ToLower().Equals(keyword.ToLower()))
                {
                    Hienkhachhang(khachhang);
                    kt = true;
                }

            }
            if (kt == false) Console.WriteLine("Không tìm thầy phụ kiện cần tìm!");
        }

        public class SortAZ : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Dienthoai dt1 = x as Dienthoai;
                Dienthoai dt2 = y as Dienthoai;
                return String.Compare(dt1.Tenphukien, dt2.Tenphukien);
            }
        }
        public class SortZA : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Dienthoai dt1 = x as Dienthoai;
                Dienthoai dt2 = y as Dienthoai;
                return String.Compare(dt2.Tenphukien, dt1.Tenphukien);
            }
        }
        public class SortGiathapcao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Dienthoai dt1 = x as Dienthoai;
                Dienthoai dt2 = y as Dienthoai;
                if (dt1.Giaphukien > dt2.Giaphukien) return 1;
                else return -1;
            }
        }
        public class SortGiatcaothap : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Dienthoai dt1 = x as Dienthoai;
                Dienthoai dt2 = y as Dienthoai;
                if (dt1.Giaphukien > dt2.Giaphukien) return -1;
                else return 1;
            }
        }
        public void SapxepAZ(ArrayList arrayList)
        {
            arrayList.Sort(new SortAZ());
        }
        public void SapxepZA(ArrayList arrayList)
        {
            arrayList.Sort(new SortZA());
        }
        public void Sapxepthaptoicao(ArrayList arrayList)
        {
            arrayList.Sort(new SortGiathapcao());
        }
        public void Sapxepcaotoithap(ArrayList arrayList)
        {
            arrayList.Sort(new SortGiatcaothap());
        }
        public void Xoa(ArrayList arrayList,string keyword)
        {
            int dem = 0;
            foreach(Dienthoai dienthoai in arrayList)
            {
                if (dienthoai.Tenphukien.ToLower().Equals(keyword.ToLower()) == false) dem++;
                else break;
            }
            arrayList.RemoveAt(dem);
        }
        public void Suathongtindienthoai(ArrayList arrayList, string keyword)
        {
            Nhap nhap = new Nhap();
            foreach(Dienthoai dienthoai in arrayList)
            {
                if (dienthoai.Tenphukien.ToLower().Equals(keyword.ToLower()))
                {
                    //Tenphukien + "" + Hangphukien + "" + Giaphukien + "" + Danhcho + "" + Loai + "" + Chatluong + "" + soluong;
                    Console.WriteLine("Nhập 0 để bỏ qua");
                    string Tenphukien = nhap.Tenphukien();
                    if (Tenphukien.Equals("0")==false)
                    {
                        dienthoai.Tenphukien = Tenphukien;
                    }
                    string Hangphukien = nhap.Hangphukien();
                    if (Hangphukien.Equals("0") == false)
                    {
                        dienthoai.Hangphukien = Hangphukien;
                    }
                  
                    int Giaphukien = nhap.Giaphukien();
                    if (Giaphukien != 0)
                    {
                        dienthoai.Giaphukien = Giaphukien;
                    }
                    string Danhcho = nhap.Danhcho();
                    if (Danhcho.Equals("0") == false)
                    {
                        dienthoai.Danhcho = Danhcho;
                    }
                    string Loai=nhap.Loai();
                    if (Loai.Equals("0") == false)
                    {
                        dienthoai.Loai = Loai;
                    }
                    string Chatluong= nhap.Chatluong();
                    if (Chatluong.Equals("0") == false)
                    {
                        dienthoai.Chatluong = Chatluong;
                    }
                    int soluong= nhap.soluong();
                    if (soluong.Equals("0") == false)
                    {
                        dienthoai.Soluong = soluong;
                    }
                }
            }
            Console.WriteLine("Sửa thông tin thành công!");
        }
    }
}

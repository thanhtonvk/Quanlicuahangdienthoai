using Quanlicuahangdienthoai.GUI.Interface;
using Quanlicuahangphukien;
using QuanlicuaHangphukien;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Quanlicuahangdienthoai
{
    class Program: Menu_IF
    {
        public  void MenuSort(ArrayList DTArrayList, ArrayList KHArrayList, Dienthoai dienthoai, Khachhhang khachhhang, Nhap nhap, DocGhifile_DAL docGhifile, Chucnang_BLL chucnang)
        {
            while (true)
            {
                Console.WriteLine("1.Sắp xếp từ A-Z \n2.Sắp xếp từ Z-A\n3.Sắp xếp theo giá từ thấp - cao\n4.Sắp xếp theo giá từ cao - thấp\nẤn phím khác để về menu chính");
                Console.Write("Chọn: ");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        chucnang.SapxepAZ(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        chucnang.SapxepZA(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        chucnang.Sapxepthaptoicao(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        chucnang.Sapxepcaotoithap(DTArrayList);
                        Console.WriteLine("Sắp xếp thành công ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                      MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;

                }
            }

        }
        public  void MenuDienThoai(ArrayList DTArrayList, ArrayList KHArrayList, Dienthoai dienthoai, Khachhhang khachhhang, Nhap nhap, DocGhifile_DAL docGhifile, Chucnang_BLL chucnang)
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("| CHƯƠNG TRÌNH QUẢN LÍ CỬA HÀNG PHỤ KIỆN ĐIỆN THOẠI|");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm phụ kiện điện thoại                  |");
            Console.WriteLine("|2. Hiện thị danh sách phụ kiện điện thoại         |");
            Console.WriteLine("|3. Sửa thông tin                                  |");
            Console.WriteLine("|4. Xóa phụ kiện điện thoại                        |");
            Console.WriteLine("|5. Sắp xếp phụ kiện                               |");
            Console.WriteLine("|6. Tìm kiếm phụ kiện điện thoại                   |");
            Console.WriteLine("|7. Nhập thông tin khách hàng                      |");
            Console.WriteLine("|8. Hiện thị khách hàng đã mua                     |");
            Console.WriteLine("|9.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
            while (true)
            {
                Console.Write("Nhập tùy chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        string kt;
                        while (true)
                        {
                            
                            nhap.Nhapdienthoai(DTArrayList);
                            docGhifile.GhifileDienthoai(DTArrayList);
                            Console.WriteLine("Ấn enter để tiếp tục hoặc Ấn phím 0 để dừng nhập ");
                            kt = Console.ReadLine();
                            if (kt == "0") break;
                        }
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 2:
                        chucnang.Hientatcadienthoai(DTArrayList);
                        Console.ReadLine();
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 3:
                        string keyword;
                        chucnang.Hientatcadienthoai(DTArrayList);
                        do
                        {
                            Console.WriteLine("Nhập tên phụ kiện điện thoại cần sửa ");
                            keyword = Console.ReadLine();
                        } while (keyword.Equals(""));
                        chucnang.Suathongtindienthoai(DTArrayList, keyword);
                        docGhifile.GhifileDienthoai(DTArrayList);
                        Console.ReadLine();
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 4:
                        string keyworddelete;
                        chucnang.Hientatcadienthoai(DTArrayList);
                        do
                        {
                            Console.WriteLine("Nhập tên phụ kiện điện thoại cần xóa ");
                            keyworddelete = Console.ReadLine();
                        } while (keyworddelete.Equals(""));
                        chucnang.Xoa(DTArrayList, keyworddelete);
                        docGhifile.GhifileDienthoai(DTArrayList);
                        Console.WriteLine("Xóa phụ kiện điện thoại thành công");
                        Console.ReadLine();
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 5:
                        MenuSort(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 6:
                        string keywordsearch;
                        do
                        {
                            Console.WriteLine("Nhập tên phụ kiện điện thoại cần tìm ");
                            keywordsearch = Console.ReadLine();
                        } while (keywordsearch.Equals(""));
                        chucnang.Timdienthoai(DTArrayList,keywordsearch);
                        Console.ReadLine();
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 7:
                        
                        nhap.Nhapkhachhang(KHArrayList);
                        docGhifile.GhifileKhachhang(KHArrayList);
                        Console.ReadLine();
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    case 8:
                       
                        chucnang.Hientatcakhachhang(KHArrayList);
                        Console.ReadLine();
                        Console.Clear();
                        MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại ");
                        break;

                }
                if (chon == 9) break;
            }

        }

        static void Main(string[] args)
        {
            
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList DTArrayList = new ArrayList();
            ArrayList KHArrayList = new ArrayList();
            DocGhifile_DAL docGhifile = new DocGhifile_DAL();
            Nhap nhap = new Nhap();
            Khachhhang khachhhang = new Khachhhang();
            Dienthoai dienthoai = new Dienthoai();
            Chucnang_BLL chucnang = new Chucnang_BLL();
            docGhifile.DocfileDienthoai(DTArrayList);
            docGhifile.DocfileKhachhang(KHArrayList);
            Program run = new Program();
            run.MenuDienThoai(DTArrayList, KHArrayList, dienthoai, khachhhang, nhap, docGhifile, chucnang);
         
        }
    }
}

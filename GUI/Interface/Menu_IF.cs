using Quanlicuahangphukien;
using QuanlicuaHangphukien;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Quanlicuahangdienthoai.GUI.Interface
{
    interface Menu_IF
    {
        void MenuSort(ArrayList DTArrayList, ArrayList KHArrayList, Dienthoai dienthoai, Khachhhang khachhhang, Nhap nhap, DocGhifile_DAL docGhifile, Chucnang_BLL chucnang);

        void MenuDienThoai(ArrayList DTArrayList, ArrayList KHArrayList, Dienthoai dienthoai, Khachhhang khachhhang, Nhap nhap, DocGhifile_DAL docGhifile, Chucnang_BLL chucnang);
        
    }
}

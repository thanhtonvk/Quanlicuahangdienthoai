using Quanlicuahangphukien;
using System;
using System.Collections;
using System.Text;

namespace Quanlicuahangdienthoai.BLL.Interface
{
    interface Chucnang_IF
    {
        void Hiendienthoai(Dienthoai dienthoai);


        void Hientatcadienthoai(ArrayList arrayList);


        void Timdienthoai(ArrayList arrayList, string keyword);


        void Hienkhachhang(Khachhhang khachhang);


        void Hientatcakhachhang(ArrayList arrayList);


        void Timkhachhang(ArrayList arrayList, string keyword);

        void SapxepAZ(ArrayList arrayList);

        void SapxepZA(ArrayList arrayList);


        void Sapxepthaptoicao(ArrayList arrayList);


        void Sapxepcaotoithap(ArrayList arrayList);


        void Xoa(ArrayList arrayList, string keyword);


        void Suathongtindienthoai(ArrayList arrayList, string keyword);


    }
}

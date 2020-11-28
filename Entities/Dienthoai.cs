using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlicuahangphukien
{
    class Dienthoai
    {
        private string tenphukien;
        private string hangphukien;
        private int giaphukien;
        private string loai;
        private string danhcho;
        private string chatluong;
        private int soluong;

        public string Tenphukien { get => tenphukien; set => tenphukien = value; }
        public string Hangphukien { get => hangphukien; set => hangphukien = value; }
        public int Giaphukien { get => giaphukien; set => giaphukien = value; }
        public string Loai { get => loai; set => loai = value; }
        public string Danhcho { get => danhcho; set => danhcho = value; }
        public string Chatluong { get => chatluong; set => chatluong = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public Dienthoai(string tenphukien,string hangphukien,int giaphukien, string loai, string danhcho,string chatluong,int soluong)
        {
            this.Tenphukien = tenphukien;
            this.Hangphukien = hangphukien;
            this.Giaphukien = giaphukien;
            this.Loai = loai;
            this.Danhcho = danhcho;
            this.Chatluong = chatluong;
            this.Soluong = soluong;
        }
        override
            public String ToString()
        {
            return Tenphukien + ";" + Hangphukien + ";" + Giaphukien + ";" + Loai + ";" + Danhcho +  ";" + Chatluong + ";" + Soluong;
        }
        public Dienthoai()
        {

        }

    }
}

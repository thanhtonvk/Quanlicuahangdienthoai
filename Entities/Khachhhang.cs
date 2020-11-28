using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlicuahangdienthoai
{
    class Khachhhang
    {
        private string tenkhachhang;
        private string sodienthoai;
        private string phukienkhachmua;

        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Phukienkhachmua { get => phukienkhachmua; set => phukienkhachmua = value; }

        public Khachhhang(string tenkhachhang,string sodienthoai,string phukienkhachmua)
        {
            this.Tenkhachhang = tenkhachhang;
            this.Sodienthoai = sodienthoai;
            this.Phukienkhachmua = phukienkhachmua;
          
        }
        public Khachhhang()
        {

        }
        override
        public String ToString()
        {
            return Tenkhachhang + ";" + Sodienthoai + ";" + Phukienkhachmua;
        }

      
    }
}

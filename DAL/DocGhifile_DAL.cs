using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Quanlicuahangphukien;
using Quanlicuahangdienthoai.DAL.Interface;
namespace Quanlicuahangdienthoai
{
    class DocGhifile_DAL: DocGhiFile_IF
    {
        
        public void DocfileDienthoai(ArrayList arrayList)
        {
            StreamReader streamReader = new StreamReader("dienthoai.txt");
            string line;
            
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;
               
                arrayList.Add(new Dienthoai(line.Split(";")[0], line.Split(";")[1], int.Parse(line.Split(";")[2]), line.Split(";")[3], line.Split(";")[4], line.Split(";")[5], int.Parse(line.Split(";")[6])));

            }
            streamReader.Close();
        }
        public void GhifileDienthoai(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("dienthoai.txt");
            foreach(Dienthoai dienthoai in arrayList)
            {
                streamWriter.WriteLine(dienthoai.ToString());
            }
            streamWriter.Close();
        }
        public void GhifileKhachhang(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("khachhang.txt");
            foreach (Khachhhang khachhang in arrayList)
            {
                streamWriter.WriteLine(khachhang.ToString());
            }
            streamWriter.Close();
        }
        public void DocfileKhachhang(ArrayList arrayList)
        {
            StreamReader streamReader = new StreamReader("khachhang.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
               
                arrayList.Add(new Khachhhang(line.Split(";")[0], line.Split(";")[1], line.Split(";")[2]));

            }
            streamReader.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class PhanSo
    {
        int TuSo;
        int MauSo;

        public void nhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        
        public void xuatPhanSo()
        {
            // Console.WriteLine("Phân số của bạn là:" );
            Console.WriteLine(TuSo);
            if (TuSo > 9 || MauSo > 9)
            {
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("--");
            }
            Console.WriteLine(MauSo);
        }
        public int LayTuSo()
        {
            return TuSo;
        }
        public int LayMauSo()
        {
            return MauSo;
        }
        public void GanTuSo() {TuSo = int.Parse(Console.ReadLine());}
        public void GanMauSo(){MauSo = int.Parse(Console.ReadLine());}
        public void NghichDao()
        {
            int TuSoDao = MauSo;
            int MauSoDao = TuSo;
            Console.WriteLine("Phân số nghịch đảo là: ");
            Console.WriteLine(TuSoDao);
            Console.WriteLine("--");
            Console.WriteLine(MauSoDao);
        }
        public void RutGon()
        {
        }
        public void CongPhanSo()
        {
            int TuSo2;
            int MauSo2;
            Console.Write("Nhap tu so cua phan so ban muon cong them: ");
            TuSo2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so cua phan so ban muon cong them: ");
            MauSo2 = int.Parse(Console.ReadLine());
            //Quy dong mau va cong
            if ( MauSo == MauSo2)
            {
                TuSo = TuSo + TuSo2;
                MauSo = MauSo + MauSo2;
            }
            else
            {
                MauSo = MauSo * MauSo2;
                TuSo = TuSo * MauSo2 + MauSo * TuSo2;
            }
            Console.WriteLine("Phan so moi la: " + TuSo + "/" + MauSo);
        }
        public void TruPhanSo()
        {

        }
        public void NhanPhanSo()
        {

        }
        public void ChiaPhanSo()
        {

        }
        public bool SoSanhPhanSo()
        {
             return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROMETHEE
{
    class Program
    {
        public static int Ham_thich_hon(int a, int b)
        {
            Console.WriteLine(a - b);
            Console.ReadLine();
            return (a - b);
        }

        public static double Ham_thich_hon_trung_binh(Cophieu a, Cophieu b, double trongso)
        {
            double ketqua = Ham_thich_hon(a.diemtieuchi_1.giatri, b.diemtieuchi_1.giatri) * trongso;
            Console.WriteLine(ketqua);
            Console.ReadLine();
            return ketqua;
        }

        public static double Dong_hon_cap_duong(int i, Cophieu[] A)
        {
            if (i < A.Length)
            {
                double ketqua = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (j != i) ketqua = ketqua + Ham_thich_hon_trung_binh(A[i], A[j], 0.5);
                };
                ketqua = ketqua / A.Length;
                return ketqua;
            }
            else return 0;
        }

        static void Main(string[] args)
        {
            DiemTieuchi tieuchi_1_FPT = new DiemTieuchi("tieuchi_1_FPT", 1);
            Cophieu FPT = new Cophieu("FPT", "FPT", tieuchi_1_FPT);

            DiemTieuchi tieuchi_1_VTC = new DiemTieuchi("tieuchi_1_VTC", 2);
            Cophieu VTC = new Cophieu("VTC", "VTC", tieuchi_1_VTC);

            DiemTieuchi tieuchi_1_VTV = new DiemTieuchi("tieuchi_1_VTV", 4);
            Cophieu VTV = new Cophieu("VTV", "VTV", tieuchi_1_VTV);

            //Console.WriteLine(FPT.tieuchi_1.ten + " " + FPT.tieuchi_1.giatri + " " + FPT.tieuchi_1.trongso);
            //Console.ReadLine();

            Cophieu[] A = new Cophieu[3] {FPT, VTC, VTV};
            FPT.dong_hon_cap = Dong_hon_cap_duong(0, A);
            VTC.dong_hon_cap = Dong_hon_cap_duong(1, A);
            VTV.dong_hon_cap = Dong_hon_cap_duong(2, A);

            Console.WriteLine(FPT.dong_hon_cap + " " + VTC.dong_hon_cap + " " + VTV.dong_hon_cap);
            Console.ReadLine();
        }
    }
}

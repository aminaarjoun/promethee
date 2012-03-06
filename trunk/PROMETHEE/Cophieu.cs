using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROMETHEE
{
    class Cophieu
    {
        public string ID;
        public string ten;
        public DiemTieuchi diemtieuchi_1;
        public double dong_hon_cap;

        public Cophieu()
		{
		}

        public Cophieu(string _ID, string _ten, DiemTieuchi _diemtieuchi_1)
        {
            ID = _ID;
            ten = _ten;
            diemtieuchi_1 = _diemtieuchi_1;
            //dong_hon_cap = _dong_hon_cap;
        }
    }
}

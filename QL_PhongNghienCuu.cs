using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ql_pnc
{
    public abstract class NhaKhoaHoc : NhanVienCapCao
    {
        private int sobai;      
        public int Sobai { get => sobai; set => sobai = value; }
        public NhaKhoaHoc(string fullname,int dob,string chucvu, int bacluong,int songaycong, int sobai) : base(fullname,dob,chucvu,bacluong,songaycong)
        {
            this.sobai = sobai;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("so bai bao cao da cong bo: ");
            sobai = Console.Read();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("so bai bao cao da cong bo: "+sobai); 

        }
        
    }
}

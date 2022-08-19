using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Classes
{
    internal class FamilyCar : PrivateCar
    {
        private int _storge;
        public FamilyCar(int y, int pass, int km, string c, Date d,bool flag, int speed,int s) : base(y, pass, km, c, d,flag,speed)
        {
            this._storge = s;
        }
        public int getStorge()
        {
            return this._storge;
        }
        public void setStorge(int s)
        {
            this._storge = s;
        }
    }
}

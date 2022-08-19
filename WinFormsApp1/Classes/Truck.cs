using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Classes
{
    class Truck : Vechile
    {
        private string _role;

        public Truck(int y, int pass, int km, string c, Date d, string r) : base(y, pass, km, c, d)
        {
            this._role = r;
        }

        // Gets & Sets
        public string getRole()
        {
            return this._role;
        }
        public void setRole(string r)
        {
            this._role = r;
        }
        public override Date fixTime()
        {
            throw new NotImplementedException();
        }

        public override void siren()
        {
            throw new NotImplementedException();
        }
    }
}

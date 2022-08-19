using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Classes
{
    class MarineVechile : Vechile
    {
        private int _weight;
        public MarineVechile(int y, int pass, int km, string c, Date d, int w) : base(y, pass, km, c, d)
        {
            this._weight = w;
        }
        public int getWeight()
        {
            return this._weight;
        }
        public void setWeight(int w)
        {
            this._weight = w;
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

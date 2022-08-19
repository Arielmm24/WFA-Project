using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Classes;

namespace WinFormsApp1.Classes
{
    class PrivateCar : Vechile
    {
       private bool _kidSafe;
       private int _maxSpeed;

        //Constructors 
        public PrivateCar(int y,int pass,int km,string c,Date d,bool flag,int speed): base(y,pass,km,c,d)
        {
            this._kidSafe = flag;
            this._maxSpeed = speed;
        }
        //public PrivateCar(PrivateCar p):base(p._year,p._passenger_load,p._km,p._company,p._lastFix)
        //{
        //    this._kidSafe = p._kidSafe;
        //    this._maxSpeed = p._maxSpeed;
        //}

        // Gets & Sets
        public bool getIfSafe()
        {
            return this._kidSafe;
        }
        public int getMaxSpeed()
        {
            return this._maxSpeed;
        }
        public void setIfSafe(bool f)
        {
            this._kidSafe=f;
        }
        public void setMaxSpeed(int s)
        {
            this._maxSpeed = s;
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

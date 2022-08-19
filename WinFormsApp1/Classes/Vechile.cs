using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Classes
{
    abstract class Vechile
    {
        private int _year;
        private int _passenger_load;
        private int _km;
        private string _company;
        private Date _lastFix;

        //Constructors
        public Vechile(int y,int pass,int km,string c,Date d)
        {
            this._year = y;
            this._passenger_load = pass;
            this._km = km;
            this._company = c;
            this._lastFix.setDay(d.getDay());
            this._lastFix.setMonth(d.getMonth());
            this._lastFix.setYear(d.getYear());
        }
        public Vechile(Vechile v)
        {
            this._year = v._year;
            this._passenger_load = v._passenger_load;
            this._km = v._km;
            this._company = v._company;
            this._lastFix.setDay(v._lastFix.getDay());
            this._lastFix.setMonth(v._lastFix.getMonth());
            this._lastFix.setYear(v._lastFix.getYear());
        }
        // Gets & Sets
        public int getYear()
        {
            return _year;
        }
        public int getPassLoad()
        {
            return _passenger_load;
        }
        public int getKM()
        {
            return _km;
        }
        public string getCompany()
        {
            return _company;
        }
        public Date getLastFix()
        {
            return _lastFix;
        }
        public void setYear(int y)
        {
            this._year = y;
        }
        public void setPassLoad(int x)
        {
            this._passenger_load = x;
        }
        public void setKM(int k)
        {
            this._km= k;
        }
        public void setCompany(string s)
        {
            this._company = s;
        }
        public void setLastFix(Date d)
        {
            this._lastFix.setDay(d.getDay());
            this._lastFix.setMonth(d.getMonth());
            this._lastFix.setYear(d.getYear());
        }

        public abstract Date fixTime();     // return date of the next fixTime
        public abstract void siren();       // return the siren noise of the specipic vechile
    }
}

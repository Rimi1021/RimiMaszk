using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba5._5
{
    class MaszkAruk
    {
        private string _Maszknev;
        private string _Maszktipus;
        private int _KeszletraktarBudapest;
        private int _KeszletraktarGyor;
        private int _KeszletraktarDebrecen;
        private double _Ar_db;
        private double _Akcio;
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (value >= 0) _Id = value;
                else throw new Exception("A ID nem lehet negatív érték!");
            }
        }

        public string Maszktipus
        {
            get 
            {
                return _Maszktipus;
            }
            set 
            {
                if (value.Length <= 30) _Maszktipus = value;
                else throw new Exception("A mező maximum 30 karakter hosszú lehet!");
            }
        }
        public string Maszknev
        {
            get
            {
                return _Maszknev;
            }
            set
            {
                if (value.Length <= 30) _Maszknev = value;
                else throw new Exception("A mező maximum 30 karakter hosszú lehet!");
            }
        }

        public int KeszletraktarBudapest
        {
            get
            {
                return _KeszletraktarBudapest;
            }
            set
            {
                if (value >= 0 && value <= 1) _KeszletraktarBudapest = value;
                else throw new Exception("A mennyiseg 1 vagy 0 erteket vehet fel!");
            }
        }

        public int KeszletraktarGyor
        {
            get
            {
                return _KeszletraktarGyor;
            }
            set
            {
                if (value >= 0 && value <= 1) _KeszletraktarGyor = value;
                else throw new Exception("A mennyiseg 1 vagy 0 erteket vehet fel!");
            }
        }

        public int KeszletraktarDebrecen
        {
            get
            {
                return _KeszletraktarDebrecen;
            }
            set
            {
                if (value >= 0 && value <= 1) _KeszletraktarDebrecen = value;
                else throw new Exception("A mennyiseg 1 vagy 0 erteket vehet fel!");
            }
        }

        public double Ar_db
        {
            get
            {
                return _Ar_db;
            }
            set
            {
                if (value >= 300 && value <= 5000) _Ar_db = value;
                else throw new Exception("A Maszk erteke 50 es 5000 k0ze eshet!");
            }
        }

        public double Akcio
        {
            get
            {
                return _Akcio;
            }
            set
            {
                if (value >= 1 && value <= 99) _Akcio = value;
                else throw new Exception("Az akció 1-99 értéket vehet fel!");
            }
        }
        public MaszkAruk(int Id, string Maszknev, string Maszktipus, int KeszletraktarBudapest, int KeszletraktarGyor, int KeszletraktarDebrecen, double Ar_db, double Akcio)
        {
            this.Id = Id;
            this.Maszknev = Maszknev;
            this.Maszktipus = Maszktipus;
            this.KeszletraktarBudapest = KeszletraktarBudapest;
            this.KeszletraktarGyor = KeszletraktarGyor;
            this.KeszletraktarDebrecen = KeszletraktarDebrecen;
            this.Ar_db = Ar_db;
            this.Akcio = Akcio;
        }
    }
}

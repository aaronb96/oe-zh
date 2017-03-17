using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obudai_zh_gyakorlas
{
    public class Burkolo : Mesterember
    {
        public enum Szakterület
        {
            belso,
            kulso
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////
        /// </summary>
        private Szakterület SzakTerület;


        public Burkolo(string _nev,int _napidij,Szakterület _szakterület) : base(_nev,_napidij)
        {
            this.szakterulet = _szakterület;
        }

        public Szakterület szakterulet
        {
            get
            {
                return SzakTerület;
            }

            set
            {
                switch (value)
                {
                    case Szakterület.belso:
                    case Szakterület.kulso: break;
                    default: throw new Exception("....");
                }
            }
        }

       

        public int összesSzabadnap()
        {
            int szabad = 0;
            foreach(bool b in foglaltnapok)
            {
                if(b)
                {
                    szabad++;
                   
                }
                
            }
            return szabad;
        }

        public override string mindenadat()
        {
            StringBuilder sb = new StringBuilder(base.mindenadat());
            sb.AppendFormat("szakterület:{0}", szakterulet.ToString());
            return sb.ToString();
        }

        
        public override bool munkatvallal(int nap)
        {
            if (nap > 31)
            {
                return false;
            }

            if (foglaltnapok[nap] == true)
            {
                foglaltnapok[nap] = false;
                return true;
            }

            return false;
        }
    }
}
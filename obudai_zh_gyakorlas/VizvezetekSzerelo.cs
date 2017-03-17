using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obudai_zh_gyakorlas
{
    public class VizvezetekSzerelo : Mesterember
    {
        private int Tapasztalat;

        public VizvezetekSzerelo(int _tapsztalat,string _nev,int _napidij):base(_nev,_napidij)
        {
            this.Tapasztalat = _tapsztalat;
        }

        public int tapasztalat
        {
            get
            {
                return tapasztalat;
            }

            set
            {
                if (value <= tapasztalat)
                    throw new Exception("...");
                tapasztalat = value;
            }
        }

        public override string mindenadat()
        {
            StringBuilder sb = new StringBuilder(base.mindenadat());
            sb.AppendFormat("tapasztalat:{0}", tapasztalat.ToString());
            return sb.ToString();
        }

        public override bool munkatvallal(int nap)
        {
            if (nap < 1 || nap > 29)
                throw new Exception("nemjó");

            if (foglaltnapok[nap - 1]&&foglaltnapok[nap]&&foglaltnapok[nap + 1])
            {
                foglaltnapok[nap - 1] = false;
                foglaltnapok[nap] = false;
                foglaltnapok[nap + 1] = false;
                return true;
            }

            return false;
        }
    }
}
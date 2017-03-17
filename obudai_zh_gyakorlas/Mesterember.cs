using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obudai_zh_gyakorlas
{
    public abstract class Mesterember
    {
        private string nev;
        private int napidij;
        public bool[] foglaltnapok = new bool[31];


        public Mesterember(string _nev, int _napidij)
        {

            this.nev = _nev;
            this.napidij = _napidij;

            for (int i = 0; i < 31; i++)
            {

                foglaltnapok[i] = true;

            }
        }

        public virtual string mindenadat()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Név:{0} Napidij:{1} ", nev, napidij);
            sb.AppendLine();

            for (int i = 0; i < 31; i++)
            {
                if (foglaltnapok[i])
                    sb.Append("1,");
                else
                    sb.Append("0,");
            }

            return ToString();
        }

        public abstract bool munkatvallal(int nap);

    }
}
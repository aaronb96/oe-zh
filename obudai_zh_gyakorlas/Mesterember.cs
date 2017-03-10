using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obudai_zh_gyakorlas
{
    public class Mesterember
    {


        private string nev;
        private int napidij;
        private bool[] foglaltnapok = new bool[31];






        public Mesterember(string nev, int napidij)
        {
            for(int i= 0;i<31;i++)
            {
                foglaltnapok[i] = true;
                
            }
        }

        public string mindenadat()
        {
            return ToString();
        }

        public bool munkatvallal()
        {
            throw new System.NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obudai_zh_gyakorlas
{
    public class Test
    {
        public Mesterember[] mester = new Mesterember[6];

        public Test()
        {
            mester[0] = new Burkolo("Tapéta Lajos", 60000, Burkolo.Szakterület.belso);
            mester[1] = new VizvezetekSzerelo(3, "Megszer Elek", 12000);
            mester[2] = new Burkolo("Vakolat Péter", 50000, Burkolo.Szakterület.kulso);
            mester[3] = new VizvezetekSzerelo(5, "Víz elek", 15000);
            mester[4] = new Burkolo("Eresz János", 30000, Burkolo.Szakterület.kulso);

            Console.WriteLine("mely típusú mesteremberek adataira kíváncsi?");
            List<StringBuilder> sb = new List<StringBuilder>();


            Console.ReadKey();
        }




        
    }
}
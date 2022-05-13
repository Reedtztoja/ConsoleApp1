using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisująca konkretny rodzaj itemu w sklepie
     */
    public class LongSword : Item
    {
        //deprecated???
        //public int bonusAD = 10;
        public LongSword()
        {
            //ustalamy nazwe itemu
            name = "Long Sword";
            // jego cene
            price = 350;
            //i atrybuty
            AddStat(Stat.AD, 10);
        }
    }
}

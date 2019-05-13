using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    class HouYi : HeroBase
    {
        public HouYi() {
            Name = "houyi";
            Attact = 50;
        }
        public override void  AttractType()
        {
            Console.WriteLine("xiuxiuxiu");
        }

        public override void Introduce()
        {
            Console.WriteLine("my name is houyi");
        }
    }
}

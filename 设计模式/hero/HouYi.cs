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
            interval = 500;
        }
        public override void  AttractType()
        {
            Console.WriteLine("xiuxiuxiu");
        }

        public override void Introduce()
        {
            Console.WriteLine("我是无敌射手");
        }
    }
}

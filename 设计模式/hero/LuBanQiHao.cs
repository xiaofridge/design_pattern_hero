using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    class LuBanQiHao:HeroBase
    {
        public LuBanQiHao() {
            Name = "LuBanQiHao";
            Attact = 30;
            interval = 300;
        }

        public override void AttractType()
        {
            Console.WriteLine("dadadadadada");
        }

        public override void Introduce()
        {
            Console.WriteLine("hi,我是鲁班七号");
        }
    }
}

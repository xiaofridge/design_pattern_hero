using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    class LuBanQiHao:HeroBase
    {
        public LuBanQiHao() {
            Name = "LuBanQ33333iHao";
            Attact = 30;
            interval = 300;
        }

        public override void AttractType()
        {
            Console.WriteLine("dad33333adadadada");
        }

        public override void Introduce()
        {
            Console.WriteLine("hi,我是鲁3333班七号");
        }
    }
}

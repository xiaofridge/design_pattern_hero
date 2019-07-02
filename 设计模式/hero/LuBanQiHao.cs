using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    class LuBanQiHao:HeroBase
    {
        public LuBanQiHao() {
            Name = "LuBanQ222iHao";
            Attact = 30;
            interval = 300;
        }

        public override void AttractType()
        {
            Console.WriteLine("dad222adadadada");
        }

        public override void Introduce()
        {
            Console.WriteLine("hi,我是鲁2222班七号");
        }
    }
}

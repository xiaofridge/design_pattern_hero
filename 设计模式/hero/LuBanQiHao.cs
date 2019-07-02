using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    class LuBanQiHao:HeroBase
    {
        public LuBanQiHao() {
            Name = "07031";
            Attact = 30;
            interval = 300;
        }

        public override void AttractType()
        {
            Console.WriteLine("07031");
        }

        public override void Introduce()
        {
            Console.WriteLine("hi,07031");
        }
    }
}

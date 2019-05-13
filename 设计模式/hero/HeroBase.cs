using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    abstract class HeroBase
    {
        public string Name { get; set; }
        public int Attact { get; set; }
        public int interval { get; set; }
        public abstract void Introduce();
        public abstract void AttractType();
        public IUserSkill UserSkill { get; set; }
        public void DoUserSkill()
        {
            UserSkill.UserSKill();
        }
    }
}

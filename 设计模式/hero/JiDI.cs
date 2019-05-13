using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.hero
{
    class JiDI
    {
        private static JiDI _JiDI ;
        private JiDI() { }
        public static JiDI CreateInstance() {
            if (_JiDI == null) {
                _JiDI =  new JiDI();
                _JiDI.Health = 1000;
            }
            return _JiDI;
        }
        public int Health { get; set; }
    }
}

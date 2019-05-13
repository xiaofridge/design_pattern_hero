using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DesignPattern.hero;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("game start--------------");
            HeroBase hero;
            hero = new HouYi();
            Console.WriteLine($"我是{hero.Name},攻击力{hero.Attact}");
            hero.Introduce();
            hero.AttractType();
            IUserSkill KuangBao = new KuangBao();
            hero.UserSkill = KuangBao;
            Console.WriteLine("使用英雄技能：");
            hero.DoUserSkill();

            HeroBase hero2;
            hero2 = new LuBanQiHao();
            Console.WriteLine($"我是{hero2.Name},攻击力{hero2.Attact}");
            hero2.Introduce();
            hero2.AttractType();
            IUserSkill JiPao = new JiPao();
            hero2.UserSkill = JiPao;
            Console.WriteLine("使用英雄技能：");
            hero2.DoUserSkill();

            TaskFactory taskFactory = new TaskFactory();
            List<Task> taskList = new List<Task>();
            taskList.Add(taskFactory.StartNew(() =>
            {
                AttachJidi(hero);
            }));
            taskList.Add(taskFactory.StartNew(() =>
            {
                AttachJidi(hero2);
            }));
            Console.ReadKey();
        }
        public static void AttachJidi(HeroBase hero) {
            var newJiDI = JiDI.CreateInstance();
            while (true){
                lock (newJiDI)
                {
                    if (newJiDI.Health > 0)
                    {
                        Console.Write($"基地之前有{newJiDI.Health}点血，");
                        newJiDI.Health = newJiDI.Health - hero.Attact;
                        Console.WriteLine($"{hero.Name}对基地造成{hero.Attact}点伤害，基地剩余血量{newJiDI.Health}");
                        if (newJiDI.Health <= 0) {
                            Console.WriteLine("基地爆炸");
                        }
                    }
                    else {
                        break;
                    }
                }
                Thread.Sleep(hero.interval);

            }

        }
    }
}

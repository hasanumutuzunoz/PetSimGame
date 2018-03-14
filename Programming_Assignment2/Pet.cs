using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment2
{
    class Pet
    {
        //Pet class variables 
        private int m_iSleepiness;
        private int m_iHappiness;
        private int m_iHunger;
        private int m_iMoney;
        private string m_sName;
        private int m_iDay;

        //New classes with the name Pet
        public Pet(string name)
        {
            m_sName = name;
            m_iSleepiness = 5;
            m_iHappiness = 5;
            m_iHunger = 5;
            m_iMoney = 0;
            m_iDay = 1;
        }

        //When pet sleeps, increase hunger and decrease sleepiness. 
        public void Sleep()
        {
            m_iSleepiness -= 4;
            m_iHunger += 1;

            //Sleepiness can not be negative
            if (m_iSleepiness < 0)
            {
                m_iSleepiness = 0;
            }

            Console.WriteLine(m_sName + " has slept");
        }

        //When pet eats, increase sleepiness, decrease hunger and happiness.
        public void Eat()
        {
            m_iHappiness -= 1;
            m_iHunger -= 3;
            m_iSleepiness += 1;

            if (m_iHunger < 0)
            {
                m_iHunger = 0;
            }

            if (m_iHappiness < 0)
            {
                m_iHappiness = 0;
            }
            
            Console.WriteLine(m_sName + " has eaten");
        }

        public void Play()
        {
            m_iHunger += 4;
            m_iSleepiness += 4;
            m_iHappiness += 4;
            Console.WriteLine(m_sName + " has rolled over");
        }

        public void WatchMovie()
        {
            m_iHunger += 2;
            m_iSleepiness += 3;
            m_iHappiness += 4;
            Console.WriteLine(m_sName + " has watched a new movie");
        }

        public void Work()
        {
            m_iHunger += 4;
            m_iSleepiness += 5;
            m_iHappiness -= 3;
            m_iMoney += 1;
            if (m_iHappiness < 0)
            {
                m_iHappiness = 0;
            }
            Console.WriteLine(m_sName + " has worked");
        }


        //Pet stats menu at the top of the screen
        public void Stats()
        {
            Console.Write("STATS :");
            Console.Write("      Sleepiness : " + m_iSleepiness);
            Console.Write("      Happiness : " + m_iHappiness);
            Console.Write("      Hunger : " + m_iHunger);
            Console.WriteLine("      Money : " + m_iMoney);
            Console.WriteLine("DAY   : " + m_iDay);
        }
            


        //Report at the and of the day
        public void Report()
        {
            //If sleepiness is between 2 and 5, write report
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (m_iSleepiness > 2 && m_iSleepiness <=5)
            {
                Console.WriteLine("I feel tired\n");
            }

            else if (m_iSleepiness > 5)
            {
                Console.WriteLine("ZZZZZzzzz... UHHHHH.. OH MAN I`m so sleepy please let me sleep\n");
            }

           if (m_iHappiness == 0)
            {
                Console.WriteLine("AAAHHH I`m sooo boring please lets play something\n");
            }

           else if (m_iHappiness > 0 && m_iHappiness < 3)
            {
                Console.WriteLine("I feel a little bit boring\n");
            }

           if (m_iHunger > 4)
            {
                Console.WriteLine("I`m starving PLEASE GIVE ME FOOD!!!!\n");
            }

           else if (m_iHunger > 2 && m_iHunger < 5)
            {
                Console.WriteLine("Food please\n");
            }

           if (m_iMoney == 0)
            {
                Console.WriteLine("MOOONEYYY PLEASE GIVE ME MONEY. I`m so poor :(\n");
            }

           else if (m_iMoney > 0 && m_iMoney < 3)
            {
                Console.WriteLine("We need money man. I need to work more!\n");
            }

           else if (m_iMoney > 10)
            {
                Console.WriteLine("Waow we are rich HAHA :)\n");
            }
            Console.ResetColor();
        }

        //Increase day
        public void increaseDay ()
        {
            m_iDay++;
        }
    }
}

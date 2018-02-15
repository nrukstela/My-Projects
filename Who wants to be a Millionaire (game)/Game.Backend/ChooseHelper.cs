using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Backend
{
    class ChooseHelper
    {
        public static void CreateChoose()
        {
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {

                case 1:
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

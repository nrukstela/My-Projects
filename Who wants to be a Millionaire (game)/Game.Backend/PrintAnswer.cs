using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Backend
{
    class PrintAnswer
    {
        public static void PrintAllAnswers(List<Answer> answer)
        {

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer.ElementAt(i).text);
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}

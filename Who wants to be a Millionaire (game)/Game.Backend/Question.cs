using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Backend
{
    class Question
    {
        public string text;
        public int value;
        public string correctAnswer;
        public List<Answer> answers;
    }
}

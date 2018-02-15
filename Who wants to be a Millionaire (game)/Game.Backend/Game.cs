using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Backend
{
    class Game
    {
        public void PlayGame()
        {
            List<Question> questionList = QuestionHelper.CreateQuestion();
            int helpingCount = 0;
            int deleteIncorrectAnswer = 0;
            while (true)
            {
                helpingCount = 0;
                deleteIncorrectAnswer = 0;
                for (int i = 0; i < questionList.Count; i++)
                {

                    Question question = questionList.ElementAt(i);
                    string answer = questionList.ElementAt(i).correctAnswer;
                    Console.WriteLine(question.text);
                    Console.Write("Klausimo verte: ");
                    Console.WriteLine(question.value + " EUR");
                    PrintAnswer.PrintAllAnswers(question.answers);
                    Console.WriteLine("Spekite varianta: A, B, C ar D");



                    if (helpingCount == 0)
                    {
                        Console.WriteLine("Reikia pagalbos ar nereikia pagalbos?  (1/2)");
                        int choose1 = Convert.ToInt32(Console.ReadLine());
                        switch (choose1)
                        {
                            case 1:
                                helpingCount = helpingCount + 1;

                                for (int u = 0; u < question.answers.Count; u++)
                                {
                                    if (question.answers.ElementAt(u).text == question.correctAnswer)
                                    {
                                        Console.WriteLine(answer);

                                    }
                                    if (question.answers.ElementAt(u).text != answer & deleteIncorrectAnswer != 1)
                                    {
                                        deleteIncorrectAnswer = deleteIncorrectAnswer + 1;
                                        Console.WriteLine(question.answers.ElementAt(u).text);
                                    }
                                    if (deleteIncorrectAnswer == 2)
                                    {
                                        break;
                                    }

                                }
                                break;
                            case 2:
                                break;
                        }
                    }


                    string letterFirstCharacter = (Console.ReadLine());
                    string letterBig = letterFirstCharacter.ToUpper();


                    if (letterBig == question.correctAnswer.Substring(0, 1))
                    {
                        Console.WriteLine("Atsakete Teisingai");
                        Console.WriteLine($"Jus turite {question.value} EUR");
                        Console.WriteLine("----------------------------------------------------------------------------");
                        if (i == 4)
                        {
                            Console.WriteLine("Jus laimejote Milijona!");
                        }
                        Console.WriteLine("Norite testi ar baigti zaidima? (1/2)");
                        ChooseHelper.CreateChoose();

                    }
                    else
                    {
                        Console.WriteLine("Zaidimas baigtas");
                        Console.WriteLine("Norite kartoti zaidia ar baigti? (1/2)");

                        int choose = Convert.ToInt32(Console.ReadLine());
                        if (1 == choose)
                        {
                            break;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }

                }
            }

        }
    }
}

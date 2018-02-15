using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Backend
{
    class QuestionHelper
    {
        public static List<Question> CreateQuestion()
        {
            List<Question> QuestionsList = new List<Question>();
            List<Answer> firstAnswersList = new List<Answer>();
            Question firstQuestions = new Question();
            firstQuestions.text = " 1.Kaip vadinamas popierinių piniginių ženklų kolekcionavimas? ";
            firstQuestions.value = 100;
            firstQuestions.correctAnswer = "A Bonistika";





            Answer answer1 = new Answer();
            answer1.text = "A Bonistika";
            firstAnswersList.Add(answer1);
            Answer answer2 = new Answer();
            answer2.text = "B Filokartija";
            firstAnswersList.Add(answer2);
            Answer answer3 = new Answer();
            answer3.text = "C Filatelija";
            firstAnswersList.Add(answer3);
            Answer answer4 = new Answer();
            answer4.text = "D Numizmatika";
            firstAnswersList.Add(answer4);

            firstQuestions.answers = firstAnswersList;
            QuestionsList.Add(firstQuestions);

            Question secondQuestions = new Question();
            secondQuestions.text = "2. Vienas iš Liudviko XV dvariškių, Fransua Kenė, pirmasis 1756 metais sukūrė valstybės ekonomikos modelį, pavaizduodamas prekių ir pinigų srautus, tarp valstybės, žmonių ir įmonių. Kokios buvo Fransua Kenė pareigos Liudviko dvare?";
            secondQuestions.value = 1000;
            secondQuestions.correctAnswer = "C Gydytojas";

            List<Answer> secondAnswersList = new List<Answer>();
            Answer answer11 = new Answer();
            answer11.text = "A Patarėjas";
            secondAnswersList.Add(answer11);
            Answer answer12 = new Answer();
            answer12.text = "B Iždininkas";
            secondAnswersList.Add(answer12);
            Answer answer13 = new Answer();
            answer13.text = "C Gydytojas";
            secondAnswersList.Add(answer13);
            Answer answer14 = new Answer();
            answer14.text = "D Astronomas";
            secondAnswersList.Add(answer14);

            secondQuestions.answers = (secondAnswersList);
            QuestionsList.Add(secondQuestions);


            Question thirdQuestions = new Question();
            thirdQuestions.text = "3. 1861 metais JAV buvo pradėti spausdinti popieriniai pinigai. Kas tai sąlygojo?";
            thirdQuestions.value = 10000;
            thirdQuestions.correctAnswer = "B Monetų trūkumas, būtinybė finansuoti pilietinį karą";

            List<Answer> thirdAnswersList = new List<Answer>();
            Answer answer21 = new Answer();
            answer21.text = "A Ryškus popieriaus gamybos kainos sumažėjimas";
            thirdAnswersList.Add(answer21);
            Answer answer22 = new Answer();
            answer22.text = "B Monetų trūkumas, būtinybė finansuoti pilietinį karą";
            thirdAnswersList.Add(answer22);
            Answer answer23 = new Answer();
            answer23.text = "C Karo sąlygomis transportuoti popierinius pinigus yra paprasčiau";
            thirdAnswersList.Add(answer23);
            Answer answer24 = new Answer();
            answer24.text = "D Tauriųjų metalų šalyje trūkumas";
            thirdAnswersList.Add(answer24);

            thirdQuestions.answers = (thirdAnswersList);
            QuestionsList.Add(thirdQuestions);

            Question fourthQuestions = new Question();
            fourthQuestions.text = "4. Kuriais metais pirmą kartą buvo sudarytas kasmetinis turtingiausių žmonių reitingas?";
            fourthQuestions.value = 100000;
            fourthQuestions.correctAnswer = "D 1987";

            List<Answer> fourthAnswersList = new List<Answer>();
            Answer answer31 = new Answer();
            answer31.text = "A 1985";
            fourthAnswersList.Add(answer31);
            Answer answer32 = new Answer();
            answer32.text = "B 1999";
            fourthAnswersList.Add(answer32);
            Answer answer33 = new Answer();
            answer33.text = "C 1980";
            fourthAnswersList.Add(answer33);
            Answer answer34 = new Answer();
            answer34.text = "D 1987";
            fourthAnswersList.Add(answer34);
            fourthQuestions.answers = (fourthAnswersList);
            QuestionsList.Add(fourthQuestions);

            Question fifthQuestions = new Question();
            fifthQuestions.text = "5. Kaip vadinasi oficiali Mongolijos valiuta?";
            fifthQuestions.value = 1000000;
            fifthQuestions.correctAnswer = "A Tugrikas";

            List<Answer> fifthAnswersList = new List<Answer>();
            Answer answer41 = new Answer();
            answer41.text = "A Tugrikas";
            fifthAnswersList.Add(answer41);
            Answer answer42 = new Answer();
            answer42.text = "B Rupija";
            fifthAnswersList.Add(answer12);
            Answer answer43 = new Answer();
            answer43.text = "C Balboa";
            fifthAnswersList.Add(answer43);
            Answer answer44 = new Answer();
            answer44.text = "D Realas";
            fifthAnswersList.Add(answer44);


            fifthQuestions.answers = (fifthAnswersList);
            QuestionsList.Add(fifthQuestions);

            return QuestionsList;
        }
    }
}

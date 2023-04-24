using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Йгшя
{
    class Quiz
    {
        private List<Question> questions;
        private int score;

        public Quiz()
        {
            questions = new List<Question>();
            score = 0;
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public void Start()
        {
            score = 0;

            Console.WriteLine("Начинаем новую викторину!");

            foreach (Question question in questions)
            {
                Console.WriteLine(question.Text);
                Console.WriteLine("Варианты ответов:");
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                Console.Write("Введите номер ответа: ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == question.CorrectOption)
                {
                    Console.WriteLine("Правильно!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Неправильно! Правильный ответ: {question.CorrectOption}");
                }
            }

            Console.WriteLine($"Вы набрали {score} баллов!");
        }
    }

    class Question
    {
        public string Text;
        public List<string> Options;
        public int CorrectOption;

        public Question(string text, List<string> options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            // добавляем вопросы
            quiz.AddQuestion(new Question("Сколько будет 2 + 2?", new List<string> { "3", "4", "5" }, 2));
            quiz.AddQuestion(new Question("Какой год был основан Рим?", new List<string> { "753 г. до н.э.", "44 г. до н.э.", "476 г. н.э." }, 1));

            // запускаем викторину
            quiz.Start();

            Console.ReadLine();
        }
    }
}

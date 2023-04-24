using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Йгшя;
using static System.Console;

namespace Quiz

{

    static void Register(string login, string password)
    {
       
        System.IO.File.WriteAllText(login + ".txt", password);
    }

    static void Main(string[] args)
    {
        bool loggedIn = false; 

        while (!loggedIn) 
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

          
            
                Console.WriteLine("Пользователь с таким логином и паролем не найден. Хотите зарегистрироваться? (да/нет)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "да") 
                {
                    Register(login, password); 
                    Console.WriteLine("Регистрация прошла успешно. Теперь вы можете войти в систему.");
                }
                else 
                {
                    Console.WriteLine("Выход из программы.");
                    return; // выходим из программы
                }
            
        }

        Quiz quiz = new Quiz();

        // добавляем вопросы
        quiz.AddQuestion(new Question("Сколько будет 2 + 2?", new List<string> { "3", "4", "5" }, 2));
        quiz.AddQuestion(new Question("Какой год был основан Рим?", new List<string> { "753 г. до н.э.", "44 г. до н.э.", "476 г. н.э." }, 1));

        // запускаем викторину
        quiz.Start();

        Console.ReadLine();
    }

   

    
}


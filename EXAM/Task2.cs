//using EXAM;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;

//namespace EXAM
//{

//    //    Создать приложение «Викторина».
//    //Основная задача проекта: предоставить пользователю возможность проверить свои
//    //знания в разных областях.
//    //Интерфейс приложения должен предоставлять такие возможности:
//    //■ При старте приложения пользователь вводит логин и пароль для входа.Если пользователь не зарегистрирован, он должен пройти процесс регистрации.
//    //■ При регистрации нужно указать:
//    //• логин (нельзя зарегистрировать уже существующий логин);
//    //• пароль;
//    //• дату рождения.


//    //■ После входа в систему пользователь может:
//    //• стартовать новую викторину;
//    //• посмотреть результаты своих прошлых викторин;
//    //• посмотреть Топ-20 по конкретной викторине;
//    //• изменить настройки: можно менять пароль и дату рождения;
//    //• выход.
//    //■ Для старта новой викторины пользователь должен выбрать раздел знаний викторины.Например: «История», «География», «Биология» и т.д.Также нужно
//    //предусмотреть смешанную викторину, когда вопросы будут выбираться из разных
//    //викторин по случайному принципу.
//    //■ Конкретная викторина состоит из двадцати вопросов. У каждого вопроса может
//    //быть один или несколько правильных вариантов ответа.Если вопрос предполагает
//    //несколько правильных ответов, а пользователь указал не все, вопрос не засчитывается.
//    //■ По завершении викторины пользователь получает количество правильно отвеченных вопросов, а также свое место в таблице результатов игроков викторины.
//    //Необходимо также разработать утилиту для создания и редактирования викторин
//    //и их вопросов. Это приложение должно предусматривать вход по логину и паролю.
//    internal class Task2
//    {
//        public static void Main()
//        {

//            List<User> users = new List<User>();
//            users.Sort();
//            Console.BackgroundColor = ConsoleColor.Magenta;
//            Console.ForegroundColor = ConsoleColor.Green;

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("---------------------------------- Викторина --------------------------------");


//                Console.WriteLine();

//                Console.WriteLine("                                   Войти -1\n                                   Зарегестрироваться -2");
//                int choice = Convert.ToInt32(Console.ReadLine());
//                string login = "";
//                string password = "";

//                if (choice == 1)
//                {
//                    Console.WriteLine("Введите логин->");
//                    login = Console.ReadLine();
//                    Console.WriteLine("Введите пароль->");
//                    password = Console.ReadLine();
//                    bool a = false;
//                    if (users.Count > 0)
//                    {
//                        foreach (var item in users)
//                        {
//                            if (item.Login == login && item.Password == password)
//                            {
//                                Console.Clear();
//                                MainMenu(item,users);
//                                a = true;
//                            }


//                        }
//                        if (!a)
//                        {
//                            Console.WriteLine("нету такого пользевателя");

//                        }
//                    }
                 
                   
//                }
//                if (choice == 2)
//                {
//                    Console.WriteLine("Введите логин->");
//                    login = Console.ReadLine();
//                    bool f = true;
//                    foreach (var item in users)
//                    {
//                        if (item.Login == login)
//                        {
//                            Console.WriteLine("Такой логин уже существует");
//                            f = false;

//                        }
//                    }
//                    if (f)
//                    {
//                        Console.WriteLine("Введите пароль->");
//                        password = Console.ReadLine();

//                        Console.WriteLine("Введите день рождения->");
//                        int day = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Введите месяц рождения->");
//                        int month = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Введите год рождения->");
//                        int year = Convert.ToInt32(Console.ReadLine());
//                        DateTime date = new DateTime(year, month, day);
//                        users.Add(new User(login, password, date));
//                        Console.Clear();
//                        MainMenu(users[users.Count - 1],users);
//                    }
                   
                   
                  
//                }


//                Console.WriteLine("Завершить приложение?(1-да 0-нет)");
//                int c= Convert.ToInt32(Console.ReadLine());
//                if (c== 0)
//                {
//                    break;
//                }
//                Console.Clear();
//            }
//        }


//        public static int MainMenu(User user, List<User> users)
//        {
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("---------------------------------- Викторина --------------------------------");

//                Console.WriteLine("1- Начать новую викторину");
//                Console.WriteLine("2- Статистика");
//                Console.WriteLine("3- Топ-20 по викторине");
//                Console.WriteLine("4- Изменить настройки");
//                Console.WriteLine("5- Выход");
//                int choice = Convert.ToInt32(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Console.Clear();
//                        Console.WriteLine("Выберите тему викторины->\n1-Математика\n2-История\n3-география\n4-Рандом");
//                        int choice3= Convert.ToInt32(Console.ReadLine());   
//                        if(choice3== 1)
//                        {
//                            MathQuiz mathQuiz = new MathQuiz(user);
//                            user.MathGoals.Add(mathQuiz.Play());
//                            Top.SortByMath(users);

//                        }
//                        else if(choice3== 2)
//                        {
//                            HistoryQuiz hQuiz = new HistoryQuiz(user);
//                            user.HistoryGoals.Add(hQuiz.Play());
//                            Top.SortByHistory(users);

//                        }
//                        else if (choice3 == 3)
//                        {
//                            GeographyQuiz gQuiz = new GeographyQuiz(user);
//                            user.GeografyGoals.Add(gQuiz.Play());
//                            Top.SortByGeography(users);

//                        }
//                        else if (choice3 == 4)
//                        {
//                            RandomQuiz rQuiz = new RandomQuiz(user);
//                            user.RandomGoals.Add(rQuiz.Play());
//                        }
//                        break;
//                    case 2:
                        
//                        user.Statistics();
//                        break;
//                    case 3:
//                        Console.Clear();
//                        Console.WriteLine("               Топ-20 по викторинам");
//                        Console.WriteLine("В какой викторине хотите посмотреть топ-20");
//                        Console.WriteLine("1-Математика\n2-История\n3-География");
//                        int choice4 = Convert.ToInt32(Console.ReadLine());
//                        if (choice4 == 1)
//                        {
//                            Top.SortByMath(users);
//                        }else if (choice4 == 2)
//                        {
//                            Top.SortByHistory(users);

//                        }
//                        else if (choice4 == 3)
//                        {
//                            Top.SortByGeography(users);

//                        }

//                        break;
//                    case 4:
//                        Console.WriteLine("Логин-> "+user.Login);
//                        Console.WriteLine("Пароль-> "+user.Password);
//                        Console.WriteLine( "----------------------------------");
//                        Console.WriteLine("изменить логин-1");
//                        Console.WriteLine("изменить пароль-2");
//                        int choice2 = Convert.ToInt32(Console.ReadLine());
//                        if (choice2 == 1)
//                        {
//                            Console.WriteLine("Введите новый логин");
//                            string newlogin=Console.ReadLine();
//                            user.Login = newlogin;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Введите новый пароль");
//                            string newpassword = Console.ReadLine();
//                            user.Password = newpassword;
//                        }

//                        break;
//                    case 5:
//                        Console.Clear();
//                        return 0;

//                }

//                Console.WriteLine("Хотите продолжить?(1-да 0-нет)");
//                int b = Convert.ToInt32(Console.ReadLine());
//                if (b == 0)
//                {
//                    break;
//                }
//                Console.Clear();
//            }
//            return 0;

//        }
//    }

//    class Top
//    {
       
//        public static void  SortByMath(List<User> array)
//        {
//            var len = array.Count;
//            for (var i = 1; i < len; i++)
//            {
//                for (var j = 0; j < len - i; j++)
//                {
//                    if ((array[j]).MathGoals.Max() < (array[j+1]).MathGoals.Max())
//                    {

//                        User temp = array[j+1];
//                        array[j+1]= array[j];
//                        array[j] = temp;
//                    }
//                }
//            }
//            int k = 1;
//            foreach(var item in array)
//            {
//                Console.WriteLine(k+"-"+item.Login+" Best score in Math-> "+item.MathGoals.Max());
//                k++;
//            }

//        }




//        public static void SortByHistory(List<User>array)
//        {
//            var len = array.Count;
//            for (var i = 1; i < len; i++)
//            {
//                for (var j = 0; j < len - i; j++)
//                {
//                    if ((array[j]).HistoryGoals.Max() > (array[j + 1]).HistoryGoals.Max())
//                    {

//                        User temp = array[j + 1];
//                        array[j + 1] = array[j];
//                        array[j] = temp;
//                    }
//                }
//            }
//            int k = 0;
//            foreach (var item in array)
//            {
//                Console.WriteLine(k+"-"+item.Login + " Best score in history-> " + item.MathGoals.Max());
//                k++;
//            }

//        }

//        public static void SortByGeography(List<User>array)
//        {
//            var len = array.Count;
//            for (var i = 1; i < len; i++)
//            {
//                for (var j = 0; j < len - i; j++)
//                {
//                    if ((array[j]).GeografyGoals.Max() > (array[j + 1]).GeografyGoals.Max())
//                    {

//                        User temp = array[j + 1];
//                        array[j + 1] = array[j];
//                        array[j] = temp;
//                    }
//                }
//            }
//            int k = 0;
//            foreach (var item in array)
//            {
//                Console.WriteLine(k+"-"+item.Login + " Best score in Geografy-> " + item.MathGoals.Max());
//                k++;
//            }

//        }




//    }





//    class MathQuiz
//    {
//        List<string> questions = new List<string>();
//        List<int> answers= new List<int>();
//        User User = new User();
//        public MathQuiz(User u)
//        {
//            questions.Add("1+1=");
//            questions.Add("9^2=");
//            questions.Add("5*(2+1)=");
//            questions.Add("12^2=");
//            questions.Add("6*6=");
//            questions.Add("8/8=");
//            questions.Add("0*6=");
//            questions.Add("5+7*5=");
//            questions.Add("90+17=");
//            questions.Add("10*10*10=");
//            questions.Add("100/10=");
//            questions.Add("5+5=");
//            questions.Add("8/4=");
//            questions.Add("5*6=");
//            questions.Add("20*2=");
//            questions.Add("0*7=");
//            questions.Add("3*11=");
//            questions.Add("13*2=");
//            questions.Add("9/3=");
//            questions.Add("7*7=");



//            answers.Add(2);
//            answers.Add(81);
//            answers.Add(15);
//            answers.Add(24);
//            answers.Add(36);
//            answers.Add(1);
//            answers.Add(0);
//            answers.Add(40);
//            answers.Add(107);
//            answers.Add(1000);
//            answers.Add(10);
//            answers.Add(10);
//            answers.Add(2);
//            answers.Add(30);
//            answers.Add(40);
//            answers.Add(0);
//            answers.Add(33);
//            answers.Add(26);
//            answers.Add(3);
//            answers.Add(49);

//            User = u;
//        }
//        public int Play()
//        {
//            Console.Clear();
//            Random r = new Random();
//            int[] randomNumbers=new int[5];
//            int[]userAnswers=new int[5];
//            for(int i = 0; i < 5; i++)
//            {
//                randomNumbers[i] = r.Next(0,20);
//            }
//            for (int i = 0; i < 5; i++)
//            {

//                Console.WriteLine(questions[randomNumbers[i]]);
//                Console.WriteLine("Ваш ответ ->");
//                userAnswers[i] = Convert.ToInt32(Console.ReadLine());

//            }
//            int count=0;
//            for (int i = 0; i < 5; i++)
//            {

//                if (userAnswers[i] == answers[randomNumbers[i]])
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("Правильных ответов-> "+count);
//            return count;

//        }


//    }




//    class HistoryQuiz
//    {
//        List<string> questions = new List<string>();
//        List<string> answers = new List<string>();
//        User User = new User();
//        public HistoryQuiz(User u)
//        {
//            questions.Add("Где располагался Древний Египет?");
//            questions.Add("Как называлась первая столица Египетского государства?");
//            questions.Add(" Какой был основной вид удобрений на полях Древнего Египта?");
//            questions.Add("Кому принадлежала высшая власть в Древнем Египте:");
//            questions.Add("Что такое Шадуф?");
//            questions.Add("Как называли сборщиков налогов в Древнем Египте?");
//            questions.Add("Какую пирамиду называют «Матерью всех египетских пирамид»?");
//            questions.Add("Главная река Египта называется:");
//            questions.Add("Как называли служителей древнеегипетских храмов?");
//            questions.Add("Что называли «Священным письмом» в Древнем Египте?");
//            questions.Add("Какое название носит самая высокая пирамида Египта?");
//            questions.Add("Кто из перечисленных богов не относится к египетским?");
//            questions.Add("Сколько имён в совокупности составляли титул фараона?");
//            questions.Add("Какая женщина первой получила титул фараона?");
//            questions.Add("Какое религиозное мировоззрение характерно для Древнего Египта?");
//            questions.Add("Из какого металла состояло оружие египтян?");
//            questions.Add("Какое из следующих понятий не относится к истории Древнего Египта?");
//            questions.Add("Какое ремесло отсутствовало в Древнем Египте?");
//            questions.Add("Как назывался бог Солнца у древних египтян?");
//            questions.Add("Какая часть населения Египта была самой многочисленной?");



//            answers.Add("в Африке");
//            answers.Add("Мемфис");
//            answers.Add("Ил");
//            answers.Add("Фараону");
//            answers.Add("Приспособление");
//            answers.Add("Писцы");
//            answers.Add("Пирамида Джосера");
//            answers.Add("Нил");
//            answers.Add("Жрецы");
//            answers.Add("Иероглифы");
//            answers.Add("Пирамида Хеопса");
//            answers.Add("Локи");
//            answers.Add("Пять");
//            answers.Add("Хатшепсут");
//            answers.Add("Политеизм");
//            answers.Add("Бронза");
//            answers.Add("Брахман");
//            answers.Add("Каллиграфия");
//            answers.Add("Ра");
//            answers.Add("Земледельцы");

//            User = u;
//        }
//        public int Play()
//        {
//            Console.Clear();
//            Random r = new Random();
//            int[] randomNumbers = new int[5];
//            string[] userAnswers = new string[5];
//            for (int i = 0; i < 5; i++)
//            {
//                randomNumbers[i] = r.Next(0, 20);
//            }
//            for (int i = 0; i < 5; i++)
//            {

//                Console.WriteLine(questions[randomNumbers[i]]);
//                Console.WriteLine("Ваш ответ ->");
//                userAnswers[i] = Console.ReadLine();

//            }
//            int count = 0;
//            for (int i = 0; i < 5; i++)
//            {

//                if (userAnswers[i] == answers[randomNumbers[i]])
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("Правильных ответов-> " + count);
//            return count;

//        }


//    }






//    class RandomQuiz
//    {
//        List<string> questions = new List<string>();
//        List<string> answers = new List<string>();
//        User User = new User();
//        public RandomQuiz(User u)
//        {
//            questions.Add("Где располагался Древний Египет?");
//            questions.Add("Как называлась первая столица Египетского государства?");
//            questions.Add(" Какой был основной вид удобрений на полях Древнего Египта?");
//            questions.Add("Кому принадлежала высшая власть в Древнем Египте:");
//            questions.Add("Что такое Шадуф?");
//            questions.Add("Как называли сборщиков налогов в Древнем Египте?");
//            questions.Add("Какую пирамиду называют «Матерью всех египетских пирамид»?");
//            questions.Add("Главная река Египта называется:");
//            questions.Add("Как называли служителей древнеегипетских храмов?");
//            questions.Add("Что называли «Священным письмом» в Древнем Египте?");
//            questions.Add("Какое название носит самая высокая пирамида Египта?");
//            questions.Add("Кто из перечисленных богов не относится к египетским?");
//            questions.Add("Сколько имён в совокупности составляли титул фараона?");
//            questions.Add("Какая женщина первой получила титул фараона?");
//            questions.Add("Какое религиозное мировоззрение характерно для Древнего Египта?");
//            questions.Add("Из какого металла состояло оружие египтян?");
//            questions.Add("Какое из следующих понятий не относится к истории Древнего Египта?");
//            questions.Add("Какое ремесло отсутствовало в Древнем Египте?");
//            questions.Add("Как назывался бог Солнца у древних египтян?");
//            questions.Add("Какая часть населения Египта была самой многочисленной?");



//            answers.Add("в Африке");
//            answers.Add("Мемфис");
//            answers.Add("Ил");
//            answers.Add("Фараону");
//            answers.Add("Приспособление");
//            answers.Add("Писцы");
//            answers.Add("Пирамида Джосера");
//            answers.Add("Нил");
//            answers.Add("Жрецы");
//            answers.Add("Иероглифы");
//            answers.Add("Пирамида Хеопса");
//            answers.Add("Локи");
//            answers.Add("Пять");
//            answers.Add("Хатшепсут");
//            answers.Add("Политеизм");
//            answers.Add("Бронза");
//            answers.Add("Брахман");
//            answers.Add("Каллиграфия");
//            answers.Add("Ра");
//            answers.Add("Земледельцы");

//            User = u;
//        }
//        public int Play()
//        {
//            Console.Clear();
//            Random r = new Random();
//            int[] randomNumbers = new int[5];
//            string[] userAnswers = new string[5];
//            for (int i = 0; i < 5; i++)
//            {
//                randomNumbers[i] = r.Next(0, 20);
//            }
//            for (int i = 0; i < 5; i++)
//            {

//                Console.WriteLine(questions[randomNumbers[i]]);
//                Console.WriteLine("Ваш ответ ->");
//                userAnswers[i] = Console.ReadLine();

//            }
//            int count = 0;
//            for (int i = 0; i < 5; i++)
//            {

//                if (userAnswers[i] == answers[randomNumbers[i]])
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("Правильных ответов-> " + count);
//            return count;

//        }


//    }

















//    class GeographyQuiz
//    {
//        List<string> questions = new List<string>();
//        List<string> answers = new List<string>();
//        User User = new User();
//        public GeographyQuiz(User u)
//        {
//            questions.Add("Какая столица Азербайджана?");
//            questions.Add("Какая столица Объединенных Арабских Эмиратов?\r\n\r\n");
//            questions.Add("Какая столица Экваториальной Гвинеи?");
//            questions.Add("Какая столица Южной Кореи?");
//            questions.Add("Какая столица Бутана?");
//            questions.Add("Какая столица Индии?");
//            questions.Add("Какая столица Камбоджи?");
//            questions.Add("Какая столица Монголии?");
//            questions.Add("Какая столица Мальдив?");
//            questions.Add("Какая столица Никарагуа?");
//            questions.Add("Какая столица Казахстана?");
//            questions.Add("Какая столица Японии?");
//            questions.Add("Какая столица Нигерии?");
//            questions.Add("Какая столица Эфиопии?");
//            questions.Add("Какая столица Зимбабве?");
//            questions.Add("Какая столица Таджикистана?");
//            questions.Add("Какая столица Израиля?");
//            questions.Add("Какая столица Китая?");
//            questions.Add("Какая столица Канады?");
//            questions.Add("Какая столица Бразилии?");




//            answers.Add("Баку");
//            answers.Add("Абу-Даби");
//            answers.Add("Малабо");
//            answers.Add("Сеул");
//            answers.Add("Тхимпху");
//            answers.Add("Нью-Дели");
//            answers.Add("Пномпень");
//            answers.Add("Улан-Батор");
//            answers.Add("Мале");
//            answers.Add("Манагуа");
//            answers.Add("Астана");
//            answers.Add("Токио");
//            answers.Add("Абуджа");
//            answers.Add("Аддис-Абеба");
//            answers.Add("Хараре");
//            answers.Add("Душанбе");
//            answers.Add("Иерусалим");
//            answers.Add("Пекин");
//            answers.Add("Оттава");
//            answers.Add("Бразилиа");

//            User = u;
//        }
//        public int Play()
//        {
//            Console.Clear();
//            Random r = new Random();
//            int[] randomNumbers = new int[5];
//            string[] userAnswers = new string[5];
//            for (int i = 0; i < 5; i++)
//            {
//                randomNumbers[i] = r.Next(0, 20);
//            }
//            for (int i = 0; i < 5; i++)
//            {

//                Console.WriteLine(questions[randomNumbers[i]]);
//                Console.WriteLine("Ваш ответ ->");
//                userAnswers[i] = Console.ReadLine();

//            }
//            int count = 0;
//            for (int i = 0; i < 5; i++)
//            {

//                if (userAnswers[i] == answers[randomNumbers[i]])
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("Правильных ответов-> " + count);
//            return count;

//        }

//    }





//    class User
//    {


//        public string Login { get; set; }
//        public string Password { get; set; }
//        public DateTime Date { get; set; }
//        public List<int> MathGoals=new List<int>();
//        public List<int> HistoryGoals =new List<int> ();
//        public List<int> GeografyGoals =new List<int>() ;
//    public List<int> RandomGoals= new List<int>() ;
//        public User()
//        {
//            Login = "";
//            Password = "";
          
//        }
//        public User(string login, string password, DateTime d)
//        {
//            Login = login;
//            Password = password;
//            Date = d;
//        }
//        public void Statistics()
//        {
//            Console.Clear();
            
//            Console.Write("Goals in Math:");
//            foreach(var item in MathGoals)
//            {
//                Console.Write("|"+item+"|");
//            }
//            Console.WriteLine();
//            Console.Write("Goals in history:");
//            foreach (var item in HistoryGoals)
//            {
//                Console.Write("|" + item + "|");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Goals in geography:");
//            foreach (var item in GeografyGoals)
//            {
//                Console.Write("|" + item + "|");
//            }
//            Console.WriteLine();
//            Console.Write("Goals in random quiz:");
//            foreach (var item in RandomGoals)
//            {
//                Console.Write("|" + item + "|");
//            }
//            Console.WriteLine();
//        }
//    }



//}

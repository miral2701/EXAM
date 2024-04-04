//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading;
//namespace EXAM
//{

//    //    Задание 1
//    //Создать приложение «Словари».
//    //Основная задача проекта: хранить словари на разных языках и разрешать пользователю находить перевод нужного слова или фразы.
//    //Интерфейс приложения должен предоставлять такие возможности:
//    //■ Создавать словарь. При создании нужно указать тип словаря.
//    //Например, англо-русский или русско-английский.
//    //■ Добавлять слово и его перевод в уже существующий словарь.Так как у слова может быть несколько переводов, необходимо поддерживать возможность создания
//    //нескольких вариантов перевода.
//    //■ Заменять слово или его перевод в словаре.
//    //■ Удалять слово или перевод. Если удаляется слово, все его переводы удаляются
//    //вместе с ним.Нельзя удалить перевод слова, если это последний вариант перевода.
//    //■ Искать перевод слова.
//    //■ Словари должны храниться в файлах. ------------------------
//    //■ Слово и варианты его переводов можно экспортировать в отдельный файл результата.-----------------------------
//    //■ При старте программы необходимо показывать меню для работы с программой.
//    //Если выбор пункта меню открывает подменю, то тогда в нем требуется предусмотреть возможность возврата в предыдущее меню.



//    internal class Task1
//    {
//        static void Main(string[] args)
//        {
//            Console.BackgroundColor = ConsoleColor.DarkYellow;
//            Console.ForegroundColor = ConsoleColor.Black;

//            List<MyDictionary> list = new List<MyDictionary>();



//            while (true)
//            {

//                switch (Control.Menu())
//                {
//                    case 1:

//                        Console.Clear();
//                        Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));

//                        Console.WriteLine("Какой словарь хотите создать\n 1- англо-руский\n 2-руско-английский");
//                        string type = Console.ReadLine();
//                        Console.WriteLine("Введите название словаря->");
//                        string name = Console.ReadLine();
//                        list.Add(new MyDictionary(name, type));
//                        break;

//                    case 2:

//                        Console.Clear();
//                        Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));

//                        Console.WriteLine("В какой словарь хотите добавить слово?");

//                        foreach (var item in list)
//                        {
//                            Console.WriteLine(item.Name);
//                        }

//                        string res = Console.ReadLine();


//                        Console.WriteLine("Добавить слово -1\nДобавить перевод-2");
//                        int choice = Convert.ToInt32(Console.ReadLine());

//                        if (choice == 1)
//                        {
//                            Console.WriteLine("Введите слово ");
//                            string word = Console.ReadLine();

//                            Console.WriteLine("Введите перевод");
//                            string translate = Console.ReadLine();

//                            foreach (var item in list)
//                            {
//                                if (item.Name == res)
//                                {
//                                    item.AddWord(word, translate);
//                                }
//                            }
//                        }
//                        else
//                        {



//                            Console.WriteLine("Какой перевод добавить");
//                            string translate = Console.ReadLine();
//                            foreach (var item in list)
//                            {
//                                if (item.Name == res)
//                                {
//                                    item.AddTranslation(translate);
//                                }
//                            }
//                        }




//                        break;
//                    case 3:
//                        Console.Clear();
//                        Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));


//                        Console.WriteLine("В каком словаре хотите заменить слово?");

//                        foreach (var item in list)
//                        {
//                            Console.WriteLine(item.Name);
//                        }

//                        string res3 = Console.ReadLine();

//                        Console.WriteLine("Введите слово которое хотите заменить");
//                        string word3 = Console.ReadLine();
//                        Console.WriteLine("Введите слово которым хотите заменить");
//                        string worda = Console.ReadLine();



//                        foreach (var item in list)
//                        {
//                            if (item.Name == res3)
//                            {
//                                item.ChangeWord(word3, worda);
//                            }
//                        }



//                        break;
//                    case 4:
//                        Console.Clear();
//                        Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));

//                        Console.WriteLine("В каком словаре хотите удалить слово или перевод");

//                        foreach (var item in list)
//                        {
//                            Console.WriteLine(item.Name);
//                        }

//                        string res2 = Console.ReadLine();

//                        Console.WriteLine("Введите слово ");
//                        string word2 = Console.ReadLine();



//                        foreach (var item in list)
//                        {
//                            if (item.Name == res2)
//                            {
//                                item.DeleteWord(word2);
//                            }
//                        }




//                        break;
//                    case 5:
//                        Console.Clear();

//                        Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));

//                        Console.WriteLine("В каком словаре будете искать слово?");

//                        foreach (var item in list)
//                        {
//                            Console.WriteLine(item.Name);
//                        }

//                        string res1 = Console.ReadLine();

//                        Console.WriteLine("Введите слово ");
//                        string word1 = Console.ReadLine();



//                        foreach (var item in list)
//                        {
//                            if (item.Name == res1)
//                            {
//                                Console.WriteLine("Переводы слова " + res1 + " - " + item.TranslateWord(word1));
//                            }
//                        }




//                        break;
//                    case 6:

//                        Console.Clear();
//                        Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));

//                        foreach (var item in list)
//                        {
//                            item.ShowDictionary();
//                            Console.WriteLine();
//                        }
//                        break;

//                }
//                Console.WriteLine("Хотите продолжить?(1-да 0-нет)");
//                int a = Convert.ToInt32(Console.ReadLine());
//                if (a == 0)
//                {
//                    break;
//                }
//                Console.Clear();
//            }




//        }

//    }
//    public class Control
//    {
//        public static int Menu()
//        {
//            Console.WriteLine(new string('-', 30) + "Dictionaries" + new string('-', 30));

//            Console.WriteLine(" 1 - Создавать словарь");
//            Console.WriteLine(" 2 - Добавлять слово и его перевод ");
//            Console.WriteLine(" 3 - Заменять слово или его перевод в словаре");
//            Console.WriteLine(" 4 - Удалять слово или перевод");
//            Console.WriteLine(" 5 - Искать перевод слова");
//            Console.WriteLine(" 6 - Показать словари");

//            Console.Write("Введите выбор->");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            return choice;
//        }



//    }


//    public interface IDictionary
//    {
//        public void AddWord(string word, string trans); //■ Добавлять слово и его перевод в уже существующий словарь.Так как у слова может быть несколько переводов, необходимо поддерживать возможность создания
//        //нескольких вариантов перевода.
    
//        public void ChangeWord(string wordbefore, string wordafter); //■ Заменять слово или его перевод в словаре.

//        public void DeleteWord(string word);//■ Удалять слово или перевод. Если удаляется слово, все его переводы удаляются
//        //вместе с ним.Нельзя удалить перевод слова, если это последний вариант перевода.
//        public string TranslateWord(string word); //■ Искать перевод слова.

//        public void ShowDictionary(); //■ Искать перевод слова.



//    }

//    public class MyDictionary : IDictionary
//    {
//        public string Name { get; set; }
//        public string Type { get; set; }


//        public Dictionary<string, List<string>> Dict = new Dictionary<string, List<string>>();


//        public MyDictionary(string n, string type)
//        {
//            Name = n;
//            Type = type;
//        }
//        public void AddWord(string word, string trans)
//        {
//            List<string> list = new List<string>();


//            if (!Dict.ContainsKey(word))
//            {
//                list.Add(trans);
//                Dict.Add(word, list);

//            }
//            else
//            {
//                Console.WriteLine("Такое слово уже есть в словаре");
//            }




//        }





//        public void AddTranslation(string trans)
//        {


//            Console.WriteLine("К какому слову хотите добавить перевод");
//            string a = Console.ReadLine();

//            KeyValuePair<string, List<string>> b = new KeyValuePair<string, List<string>>();
//            foreach (var item in Dict)
//            {
//                if (item.Key == a)
//                {
//                    b = item;
//                }
//            }
//            b.Value.Add(trans);




//        }







//        public void ChangeWord(string wordb, string worda)
//        {
//            string tempKey = new string("");
//            List<string> tempValue = new List<string>();
//            string res = new string("");
//            int a = 0;

//            foreach (var item in Dict)
//            {
//                if (item.Key == wordb)
//                {
//                    tempKey = item.Key;
//                    tempValue = item.Value;

//                    a = 1;

//                }
//                else
//                {
//                    foreach (var item2 in item.Value)
//                    {
//                        if (item2 == wordb)
//                        {
//                            tempValue = item.Value;
//                            tempKey = item.Key;

//                            a = 2;
//                        }
//                    }
//                }


//            }

//            if (a == 1)
//            {
//                Dict.Remove(tempKey);
//                Dict.Add(worda, tempValue);
//            }
//            else if (a == 2)
//            {
//                tempValue[Array.IndexOf(tempValue.ToArray(), wordb)] = worda;

//            }

//        }



//        public void DeleteWord(string word)
//        {

//            string tempKey = new string("");
//            List<string> tempValue = new List<string>();

//            int a = 0;
//            foreach (var item in Dict)
//            {
//                if (item.Key == word)
//                {
//                    tempKey = item.Key;
//                    tempValue = item.Value;

//                    a = 1;

//                }



//                foreach (var item2 in item.Value)
//                {
//                    if (item2 == word)
//                    {
//                        tempKey = item.Key;
//                        tempValue = item.Value;

//                        a = 2;


//                    }
//                }

//            }

//            if (a == 1)
//            {
//                Dict.Remove(tempKey);
//            }
//            else if (a == 2)
//            {
//                if (tempValue.Count > 1)
//                {
//                    tempValue.Remove(word);
//                }
//            }

//        }

//        public void ShowDictionary()
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("|          " + Name + "               ");
//            Console.WriteLine("|         " + Type + "            ");
//            Console.WriteLine("---------------------------------");

//            foreach (var item in Dict)
//            {
//                Console.WriteLine(item.Key + " - " + (Extansions.ToString(item.Value)));
//            }
//            Console.WriteLine("---------------------------------");

//        }

//        public string TranslateWord(string word)
//        {



//            foreach (var item in Dict)
//            {
//                if (item.Key == word)
//                {
//                    return Extansions.ToString(item.Value);

//                }

//            }
//            return "No such words in dictionary";
//        }
//    }



//    static class Extansions
//    {
//        public static string ToString(List<string> a)
//        {
//            StringBuilder b = new StringBuilder();
//            foreach (var item in a)
//            {
//                b.Append(item + " ");
//            }
//            return b.ToString();
//        }
//    }




//}
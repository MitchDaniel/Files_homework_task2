namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceWors = "слов";
            string newWord = "СЛОВ";
            string parth = @"C:\Users\Brill\Desktop\WordFilter.txt";
            if (!File.Exists(parth))
            {
                throw new FileNotFoundException();
            }
            string[] strings = File.ReadAllLines(parth);
            int replaceCount = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                string temp = strings[i];
                strings[i] = strings[i].Replace(sourceWors, newWord);
                if(temp == strings[i])
                {
                    replaceCount++;
                }
            }
            if (replaceCount > 0)
            {
                File.WriteAllLines(parth, strings);
                Console.WriteLine($"Count of replace: {replaceCount}");
            }
            
        }
    }
}

//Задание 2:
//Пользователь вводит с клавиатуры слово для поиска в файле и слово для замены. 
//Приложение должно изменить все вхождения искомого слова на слово для замены. 
//Статистику работы приложения нужно отобразить на экран.
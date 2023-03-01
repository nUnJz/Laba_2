using System;
using System.Collections.Generic;
using System.IO;

namespace Laba_2_1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            /*List<Students> students = new List<Students>();
            students.Sort((x, y) => x.name.CompareTo(y.name));
            Console.WriteLine(String.Join(Environment.NewLine, students));*/

            /*using (FileStream fs = new FileStream("Список успішності студентів.txt", FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default)
            }*/

            //List<string> LS = new List<string>();//
            /*static bool ConvertLinesFileToList(string filename, out List<string> LS)
            {
                // 1. Объявить файловую переменную
                StreamReader sr;

                // 2. Открыть файл
                try
                {
                    // Попытка открыть файл для чтения
                    sr = new StreamReader("Список успішності студентів.txt");
                }
                catch (FileNotFoundException e)
                {
                    // Если файл не найден, то обработать исключение
                    Console.WriteLine(e.Message);
                    LS = null;
                    return false;
                }

                // 3. Прочитать строки файла в список LS
                LS = new List<string>(0);
                string s;

                // цикл чтения строк из файла и создание списка
                while ((s = sr.ReadLine()) != null)
                    LS.Add(s);

                // 4. Закрыть файл
                sr.Close();

                // 5. Вернуть результат
                return true;
            }

            List<string> LS = new List<string>();
            for (int i = 0; i < LS.Count; i++)
            {
                Console.WriteLine(LS[i]);
            }*/

            /*string writePath = "Список успішності студентів.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var item in yourListBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }*/
            /*List<string> LS = new List<string>(0);
            LS.Add(Str);
            //Чтение файла
            /*if (File.Exists("Список успішності студентів.txt"))
            {
                FileStream fsR = new FileStream("Список успішності студентів.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fsR);
                while ((Str = sr.ReadLine()) != null)
                LS.Add(Str);

                Console.WriteLine(Str);
                sr.Close();
                fsR.Close();
            }*/
            string Str;
            if (File.Exists("Список успішності студентів.txt"))
            {
                FileStream fsR = new FileStream("Список успішності студентів.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fsR);
                while ((Str = sr.ReadLine()) != null)
                Console.WriteLine(Str);
                sr.Close();
                fsR.Close();
            }

            Console.ReadLine();
        }
    }
}
namespace TextBox;

using System.Diagnostics;

public class Program
{
  public static void Main(string[] args) {
    Console.WriteLine("Выбирете действие \n 1. Открыть файл \n 2. Прочесть открытый файл \n 3. Заменить файл \n 4. Сохранить изменения в файл");
    int choice = Convert.ToInt32(Console.ReadLine());
    string filePath = " ";

    switch (choice) {
      case 1:
        Console.Clear();
        Console.WriteLine("Введите точный путь до файла \n(Подсказка: C:/Users/User/RiderProjects/file)");
        filePath = Console.ReadLine();
        
        break;
    }
  }
}
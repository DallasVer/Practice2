namespace TextBox;

using System.Diagnostics;

public class Program
{
  public static void Main(string[] args) {
    FileOperations operations = new FileOperations();
    string filePath = " ";

    while (true) {
      Console.WriteLine("Выберете действие \n 1. Открыть файл \n 2. Прочесть открытый файл \n 3. Заменить файл \n 4. Сохранить изменения в файл \n 5. Выход");
      int choice = Convert.ToInt32(Console.ReadLine());
      
      switch (choice) {
        case 1:
          Console.Clear();
          Console.WriteLine("Введите точный путь до файла \n(Подсказка: C:/Users/User/RiderProjects/file)");
          filePath = Console.ReadLine();
          string loadResult = operations.loudFile(filePath);
          Console.WriteLine(loadResult + "\n ");
          break;
      
        case 2: 
          Console.Clear();
          operations.ReadFile();
          break;
        
        case 3:
          Console.Clear();
          Console.WriteLine("Введите новый текст");
          string newText = Console.ReadLine();
          operations.modyFile(newText);
          break;
        case 4:
          Console.Clear();
          if (filePath == " ") {
            Console.WriteLine("Нет файлв для его изменения.");
            break;
          }
          operations.SaveFile();
          break;
        case 5:
          return;
      
        default: 
          Console.Clear();
          Console.WriteLine("Нет такого поля! \n ");
          break;
      }
    }
  }
}
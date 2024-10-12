namespace TextBox;

public class FileOperations
{
  public string fileContent, filePath;

  public string loudFile(string fileMainPath) {
    if (File.Exists(fileMainPath)){
      fileContent = File.ReadAllText(fileMainPath); 
      filePath = fileMainPath;
      return "Загрузка прошла успешно!";
    }
    else {
      return "Ошибка файл не найден!";
    }  
  }
  public void ReadFile() {
    if (fileContent != null) {
      Console.Write(fileContent);
    }
    else {
      Console.Write("Файл пуст, либо загружен некорректно!");
    }
  }

  public void modyFile(string newContent) {
    fileContent = newContent;
    Console.Write("Файл изменён.");
  }

  public void SaveFile() {
    if (fileContent != null) {
      File.WriteAllText(filePath, fileContent);
      Console.WriteLine("Файл сохранён");
    }
    else {
      Console.WriteLine("Неудалось сохранить файл");
    }
  }
}
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
}
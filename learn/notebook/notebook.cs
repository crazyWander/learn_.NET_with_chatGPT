using System.Net;
using System.Text;

namespace learn.notebook;


public class Notebook
{
    private readonly string _fileName;
    private readonly string _filePath = Directory.GetCurrentDirectory();
    private string _fullPath;
    private string[] _line;

    /// <summary>
    /// Вызов класса для тестирования
    /// </summary>
    /// <param name="fileName"></param>
    public Notebook(string fileName)
    {
        _fileName = fileName;
        _fullPath = Path.Combine(_filePath, _fileName);
        if (File.Exists(_fullPath))
        {
            using (StreamReader reader = new StreamReader(_fullPath))
            {
                var _content = reader.ReadToEnd();
                _line = _content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                Console.WriteLine(_content);
            }
        }
        else
        {
            Console.WriteLine("Данного файла не существует");
        }
    }

    public Notebook()
    {
        
    }

    public void openFile(string fileName)
    {
        _fullPath = Path.Combine(_filePath, fileName);
        if (File.Exists(_fullPath))
        {
            using (StreamReader reader = new StreamReader(_fullPath))
            {
                var _content = reader.ReadToEnd();
                _line = _content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                Console.WriteLine(_content);
            }
        }
        else
        {
            Console.WriteLine("файла не существует");
        }
    }

    public void openFile(string filePath, string fileName)
    {
        _fullPath = Path.Combine(filePath, fileName);
        using (StreamReader reader = new StreamReader(_fullPath))
        {
            var _content = reader.ReadToEnd();
            _line = _content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            Console.WriteLine(_content);
        }
    }

    public void editFile()
    {
        int idLine;
        
        if (_line != null)
        for (int i = 0; i < _line.Length-1; i++)
        {
            Console.WriteLine($"{{{i}}} {_line[i]}");
        }

        Console.WriteLine("Введите строку для редактирования");
        while (!int.TryParse(Console.ReadLine(), out idLine))
        {
            Console.WriteLine("Значение введено некорректно");
        }
        Console.WriteLine("Введите текст");
        _line[idLine] = Console.ReadLine();
        Console.WriteLine("Добавлено");
        
    }

    public void seeText()
    {
        foreach (var i in _line)
        {
            Console.WriteLine(i);
        }
    }

    public void saveFile()
    {
        Console.WriteLine("Введите название файла(по умолчанию перезаписывается открытый файл)");
        var fileName = Console.ReadLine();
        if (fileName != null)
            _fullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
        using (StreamWriter writer = new StreamWriter(_fullPath))
        {
            foreach (var i in _line)
            {
                writer.WriteLine(i);
            }
        }
        Console.WriteLine("Сохранено");
    }
}
namespace learn;

public class Viselica
{
    private string _word;
    private char[] _progress;
    private int _tryCountLimit = 5;
    public Viselica(string word)
    {
        _word = word;
        _progress = new char[_word.Length];
        Array.Fill(_progress, '*');
    }

    public void StartGame()
    {
        int tryCount = 0;
        bool isFind = false;
        int intProgressCount = _word.Length;
        while (tryCount < _tryCountLimit)
        {
            Console.WriteLine($"Введите символ (попытка {tryCount+1}/{_word.Length})");
            char word = Console.ReadKey().KeyChar;
            for (int i = 0; (i < _word.Length) && (tryCount < _word.Length); i++)
            {
                if (_word[i] == word)
                {
                    _progress[i] = word;
                    isFind = true;
                    intProgressCount--;
                }
            }

            if (!isFind)
            {
                tryCount++;
                Console.WriteLine($"\nБуква {word} не найдена");
                Console.WriteLine($"Прогресс {new string(_progress)}");
                isFind = false;
            }
            else
            {
                {
                    Console.WriteLine($"\nБуква {word} найдена");
                    Console.WriteLine($"Прогресс {new string(_progress)}");
                    isFind = false;
                    if (intProgressCount == 0)
                    {
                        Console.WriteLine("Вы победили");
                        return;
                    }
                }
            }
        }
        Console.WriteLine("Вы проиграли");
    }
}
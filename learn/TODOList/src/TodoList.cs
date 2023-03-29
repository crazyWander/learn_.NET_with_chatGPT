using learn.src.TODOList;

namespace learn.src.TODOList;

public class TodoList
{
    private Tacker task = new Tacker();
    //private Dictionary<Guid, Tacker> _tackers = new Dictionary<Guid, Tacker> {};
    private List<Tacker> _tacker;
    public TodoList()
    {
        _tacker = new List<Tacker>();
    }

    void createTask(string title, string description)
    {
        _tacker.Add(task.createTask(title, description));
    }

    void createDeadline(Tacker tack, DateTime date)
    {
        tack.setDeadline(date);
    }

    void setStatus(Tacker tack)
    {
        Console.WriteLine(@"Укажите статус 
         1 - На рассмотрении 
         2 - В работе
         3 - Выполнено
         4 - Провалено
         5 - Отменено");
        while (true)
        {
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                {
                    tack.setStatus(statusTask.planed);
                    return;
                }
                case '2':
                {
                    tack.setStatus(statusTask.inProgress);
                    return;
                }
                case '3':
                {
                    tack.setStatus(statusTask.complite);
                    return;
                }
                case '4':
                {
                    tack.setStatus(statusTask.faled);
                    return;
                }
                case '5':
                {
                    tack.setStatus(statusTask.canseled);
                    return;
                }
                default:
                {
                    Console.WriteLine("Введено некорректное значение");
                    break;
                }
            }
        }
    }

    void updateStatus()
    {
        foreach (var i in _tacker)
        {
            if(i.daedline.HasValue && i.daedline.Value > DateTime.Now)
            i.setStatus(statusTask.faled);
        }
    }

    void sortPriority()
    {
        _tacker.Sort((x,y) => x.status.CompareTo(y.status));
    }

    void sortByDeadline()
    {

        _tacker.Sort((x, y) =>
        {
            if (x.daedline == null && y.daedline == null) return 0;
            if (x.daedline == null) return 1;
            if (y.daedline == null) return -1;
            return x.daedline.Value.CompareTo(y.daedline.Value);
        });

    }
}
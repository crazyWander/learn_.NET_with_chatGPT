namespace learn.src.TODOList;

/// <summary>
/// 
/// </summary>
public class Tacker
{
    public Guid idTask { get; private set; }
    public DateTime createDate{ get; private set; }
    
    public DateTime? daedline{ get; private set; }
    public DateTime leftTime{ get; private set; }
    public string title{ get; private set; }
    public string description{ get; private set; }
    public float progress{ get; private set; }
    public statusTask status{ get; private set; }

    public Tacker() {}
    
    public Tacker createTask(string title, string description)
    {
        return new Tacker()
        {
            createDate = DateTime.Now,
            idTask = Guid.NewGuid(),
            title = title,
            description = description,
            progress = 0,
            status = statusTask.newTask
        };
    }

    public void setDeadline(DateTime data)
    {
        this.daedline = data;
    }

    public void setProgress(float progress)
    {
        this.progress = progress;
    }

    /// <summary>
    /// установка статуса заявки
    /// </summary>
    /// <param name="status">
    ///planed, newTask, inProgress, complite, faled, canseled
    /// </param>
    public void setStatus(statusTask status)
    {
        this.status = status;
    }

}
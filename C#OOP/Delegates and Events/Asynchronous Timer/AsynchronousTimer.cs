using System;
using System.Threading;
public class AsynchronousTimer
{
    private Action<string> actionMethod;
    private int interval;
    private int ticks;
    private Thread thread;
    public AsynchronousTimer(Action<string> actionMethod, int interval, int ticks)
    {
        this.ticks = ticks;
        this.interval = interval;
        this.actionMethod = actionMethod;
    }
    private void ExecuteTimer()
    {
        while (this.ticks > 0)
        {
            Thread.Sleep(this.interval);
            if (actionMethod != null)
            {
                actionMethod(this.ticks + "");
            }
            this.ticks--;
        }
    }
    public void Start()
    {
        this.thread = new Thread(this.ExecuteTimer);
        thread.Start();
    }

    public void Stop()
    {
        this.thread.Abort();
    }
}
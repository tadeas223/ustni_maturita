static async Task DoWorkAsync()
{
    Console.WriteLine("start");
    await Task.Delay(1000);
    Console.WriteLine("stop");
}

static void DoWork()
{
    Console.WriteLine("start");
    Thread.Sleep(1000);
    Console.WriteLine("stop");
}

Thread t1 = new Thread(DoWork);
Thread t2 = new Thread(DoWork);

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Task task1 = DoWorkAsync();
Task task2 = DoWorkAsync();


Task.WaitAll(task1, task2);

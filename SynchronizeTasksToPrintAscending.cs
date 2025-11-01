// Task: Modify the PrintOdd() and PrintEven() methods so that the numbers are printed in ascending order from 1 to 9
// Keep using two separate tasks (Task.Factory.StartNew or similar)
// Use appropriate synchronization mechanisms

int[] _odd = [1, 3, 5, 7, 9];
int[] _even = [2, 4, 6, 8,];

var semaphoreOdd = new SemaphoreSlim(1, 1);
var semaphoreEven = new SemaphoreSlim(0, 1);

void PrintOdd()
{
    foreach (var item in _odd)
    {
        semaphoreOdd.Wait();
        Console.WriteLine(item);
        semaphoreEven.Release();
    }
}

void PrintEven()
{
    foreach (var item in _even)
    {
        semaphoreEven.Wait();
        Console.WriteLine(item);
        semaphoreOdd.Release();
    }
}

var odd = Task.Factory.StartNew(PrintOdd);
var even = Task.Factory.StartNew(PrintEven);

odd.Wait();
even.Wait();
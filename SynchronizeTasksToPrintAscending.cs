// Task: Modify the PrintOdd() and PrintEven() methods so that the numbers are printed in ascending order from 1 to 9
// Keep using two separate tasks (Task.Factory.StartNew or similar)
// Use appropriate synchronization mechanisms

int[] _odd = [1, 3, 5, 7, 9];
int[] _even = [2, 4, 6, 8];

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

// Multiple tasks
//var first = new int[] { 1, 5, 9 };
//var second = new int[] { 2, 6, 10 };
//var third = new int[] { 3, 7, 11 };
//var fourth = new int[] { 4, 8, 12 };

//object _lock = new();
//var current = 1;

//var max = 4;

//var t1 = Task.Factory.StartNew(() => Print(first, 1));
//var t2 = Task.Factory.StartNew(() => Print(second, 2));
//var t3 = Task.Factory.StartNew(() => Print(third, 3));
//var t4 = Task.Factory.StartNew(() => Print(fourth, 4));

//t1.Wait();
//t2.Wait();
//t3.Wait();
//t4.Wait();

//void Print(int[] arr, int order)
//{
//    foreach (var item in arr)
//    {
//        lock (_lock)
//        {
//            while (current != order)
//            {
//                Monitor.Wait(_lock);
//            }
            
//            current = current == max ? 1 : ++current;

//            Console.WriteLine(item);

//            Monitor.PulseAll(_lock);
//        }
//    }
//}

//AutoResetEvent oddTurn = new AutoResetEvent(true);
//AutoResetEvent evenTurn = new AutoResetEvent(false);

//int[] _odd = [1, 3, 5, 7, 9];
//int[] _even = [2, 4, 6, 8];

//void PrintOdd()
//{
//    foreach (var item in _odd)
//    {
//        oddTurn.WaitOne();
//        Console.WriteLine(item);
//        evenTurn.Set();
//    }
//}

//void PrintEven()
//{
//    foreach (var item in _even)
//    {
//        evenTurn.WaitOne();
//        Console.WriteLine(item);
//        oddTurn.Set();
//    }
//}

//var odd = Task.Run(PrintOdd);
//var even = Task.Run(PrintEven);

//odd.Wait();
//even.Wait();

//// Constructor for ManualResetEvent: Initializes a ManualResetEvent instance, allowing the initial state to be specified.
//var oddTurn = new ManualResetEventSlim(true);
//var evenTurn = new ManualResetEventSlim(false);

//int[] _odd = [1, 3, 5, 7, 9];
//int[] _even = [2, 4, 6, 8];

//void PrintOdd()
//{
//    foreach (var item in _odd)
//    {
//        // Wait() method: Blocks the current thread until a signal is received.
//        oddTurn.Wait();
//        Console.WriteLine(item);
//        // Reset() method: Sets the ManualResetEvent to a non-signaled state, blocking the waiting threads from continuing execution.
//        oddTurn.Reset();
//        // Set() method: Set the ManualResetEvent to the signaled state, allowing waiting threads to continue execution.
//        evenTurn.Set();
//    }
//}

//void PrintEven()
//{
//    foreach (var item in _even)
//    {
//        evenTurn.Wait();
//        Console.WriteLine(item);
//        evenTurn.Reset();
//        oddTurn.Set();
//    }
//}

//var odd = Task.Run(PrintOdd);
//var even = Task.Run(PrintEven);

//odd.Wait();
//even.Wait();

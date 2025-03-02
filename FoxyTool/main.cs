// main.cs
using System;
using System.Threading.Tasks;

namespace MainProgram
{
    class Program
    {
        static async Task ExecuteAsync()
        {
            Console.WriteLine("这是来自 main.cs 的输出。");
            await Task.Delay(1000); // 模拟异步操作
        }
    }
}
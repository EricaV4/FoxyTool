using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static async Task Main(string[] args)
    {
        DateTime now = DateTime.Now; // 获取时间
        Console.WriteLine(" /$$$$$$$$                         /$$$$$$$$                  /$$\r\n| $$_____/                        |__  $$__/                 | $$\r\n| $$     /$$$$$$  /$$   /$$ /$$   /$$| $$  /$$$$$$   /$$$$$$ | $$\r\n| $$$$$ /$$__  $$|  $$ /$$/| $$  | $$| $$ /$$__  $$ /$$__  $$| $$\r\n| $$__/| $$  \\ $$ \\  $$$$/ | $$  | $$| $$| $$  \\ $$| $$  \\ $$| $$\r\n| $$   | $$  | $$  >$$  $$ | $$  | $$| $$| $$  | $$| $$  | $$| $$\r\n| $$   |  $$$$$$/ /$$/\\  $$|  $$$$$$$| $$|  $$$$$$/|  $$$$$$/| $$\r\n|__/    \\______/ |__/  \\__/ \\____  $$|__/ \\______/  \\______/ |__/\r\n                            /$$  | $$                            \r\n                           |  $$$$$$/                            \r\n                            \\______/                             ");

        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"); Console.WriteLine("  b1 tool by EricaV4       Time " + now);
        Console.WriteLine("  输入要下载的文件前面的编号即可下载 例如 1 2 无需输入#");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine("#1 DoomsDay   #2 水影生存整合包   #3 无   #4 无");
        string userChoice = Console.ReadLine(); // 获取用户输入

        switch (userChoice)
        {
            case "1":
                Console.WriteLine("\n--------------------------\n关于DoomsDay\n全版本热注入 支持Fabric与Forge 幽灵客户端\n2.26 MB\n--------------------------\n");
                Console.WriteLine("是否下载?(y/n)");
                string yesorno = Console.ReadLine(); // 获取用户输入

                if (yesorno == "y")
                {
                    try
                    {
                        await DownloadFileAsync("https://api.hanximeng.com/lanzou/?url=https://wwua.lanzou.com/i8xCL2p32i1c&type=down&pwd=4gda", @"C:\Users\Administrator\Downloads\doomsday.jar");
                        Console.WriteLine("文件下载完成。");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("下载失败，可能是网络问题或链接无效。请检查链接的合法性或稍后重试。");
                        Console.WriteLine("错误信息: " + ex.Message);
                    }
                }
                else if (yesorno == "n")
                {
                    // 清空控制台并重新显示菜单
                    Console.Clear();
                    Main(args).Wait(); // 递归调用 Main 方法重新开始程序
                }
                break;
            case "2":
                Console.WriteLine("\n--------------------------\n关于水影生存整合包\n背包整理 种子反推 自动挖矿 客户端命令\n需要 1.21.4 Fabric 0.16.10\n77.7 MB\n--------------------------\n");
                Console.WriteLine("是否下载?(y/n)");
                string yesorno1 = Console.ReadLine(); // 获取用户输入

                if (yesorno1 == "y")
                {
                    try
                    {
                        await DownloadFileAsync("https://api.hanximeng.com/lanzou/?url=https://wwua.lanzouo.com/iIzvU2pe2wxe&type=down&pwd=3dfh", @"C:\Users\Administrator\Downloads\mods.rar");
                        Console.WriteLine("文件下载完成。");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("下载失败，可能是网络问题或链接无效。请检查链接的合法性或稍后重试。");
                        Console.WriteLine("错误信息: " + ex.Message);
                    }
                }
                else if (yesorno1 == "n")
                {
                    // 清空控制台并重新显示菜单
                    Console.Clear();
                    Main(args).Wait(); // 递归调用 Main 方法重新开始程序
                }
                break;
            case "3":
                // 其他逻辑
                break;
            case "4":
                // 其他逻辑
                break;
            default:
                Console.WriteLine("无效的输入。");
                break;
        }

        // 清空控制台并重新显示菜单
        await Task.Delay(2000);
        Console.Clear();
        Main(args).Wait(); // 递归调用 Main 方法重新开始程序
    }

    static async Task DownloadFileAsync(string url, string filePath)
    {
        using (var client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await response.Content.CopyToAsync(fileStream);
            }
        }
    }
}
using System;

using System.Text;



namespace ConsoleApp3
{
    class Program
    {
      

        static void Main(string[] args)
        {
           
            IntPtr hWnd;
            hWnd = WinApi.GetForegroundWindow();
            IntPtr count = hWnd;
            StringBuilder WindowTEXT = new StringBuilder(150);


            bool Admin = WinApi.IsUserAnAdmin();
            Console.WriteLine($"Программма запущена от имени администратора : {Admin}");

            while (true)
            {
                
                 hWnd = WinApi.GetForegroundWindow();
                if (hWnd != count)
                {

                    WinApi.GetWindowText(hWnd, WindowTEXT, WindowTEXT.Capacity);

                    if (WindowTEXT.Length > 0)
                    {
                        Console.WriteLine($" Передний план {WindowTEXT}");
                    }
                    count = hWnd;
                }
            }
        }  // на коментарии сил уже не осталось 
    }

    
}

// using System;
// using System.Threading;

// namespace myApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Create new thread...\n");

//             // Created a child thread, which runs parallel with the main thread
//             Thread newThread = new Thread(WriteB);

//             Console.WriteLine("Start newThread...\n");
            
//             // Start the thread
//             newThread.Start();

//             Console.WriteLine("Call Write('-') in main Thread...\n");

//             // In the main thread print out character '-'
//             for(int i = 0;i<50;i++)
//             {
//                 Console.Write('-');

//                 // Sleep 70 miliseconds
//                 Thread.Sleep(70);
//             }
//             Console.WriteLine("Main Thread finished\n");
//             Console.Read();
//         }
//         public static void WriteB() 
//         {
//             // Print out 'B' 100 times.
//             for(int i = 0;i<100;i++)
//             {
//                 Console.Write('B');

//                 // Sleep 100 miliseconds
//                 Thread.Sleep(100);
//             }
//         }
//     }
// }

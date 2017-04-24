using System;
using System.Diagnostics;
using System.Linq;
using static System.Console;
using static System.Diagnostics.Process;

namespace _06_vs2017
{
    class Recorder
    {
        static Stopwatch timer = new Stopwatch();
        static long bytesPhysicalBefore = 0, bytesVirtualBefore = 0,
            bytesPhysicalAfter = 0, bytesVirtualAfter = 0;

        public static void Start() {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            bytesPhysicalBefore = GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
            timer.Restart();
            WriteLine("Recording...\n");
        }

        public static void Stop() {
            timer.Stop();
            bytesPhysicalAfter = GetCurrentProcess().WorkingSet64;
            bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;
            WriteLine("Stopped recording.\n");
            WriteLine($"{bytesPhysicalAfter - bytesPhysicalBefore:N0} virtual bytes used.");
            WriteLine($"{timer.Elapsed} time span elapsed.");
            WriteLine($"{timer.ElapsedMilliseconds:N0} total milliseconds elapsed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string input = "";

            while(!done) {
                WriteLine("\nPress ENTER to START");
                WriteLine("Type \"QUIT\" to EXIT program");
                input = ReadLine();
                input = input.ToLower();

                if (input=="quit") { done=true; }
                else if (input!="quit") {
                    Recorder.Start();

                    int[] maniacs = Enumerable.Range(0x0001, 0x2710).ToArray();
            
                    WriteLine("Press ENTER to STOP");
                    ReadLine();
                    Recorder.Stop();
                }
            }
            return;
        }
    }
}
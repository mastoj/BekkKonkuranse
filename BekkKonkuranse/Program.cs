using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BekkKonkuranse
{
    class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG
            Console.SetOut(new DebugTextWriter());
#endif

            int antall_oppgaver = int.Parse(Console.ReadLine());
            for (int i = 0; i < antall_oppgaver; i++)
            {
                string input = Console.ReadLine().Trim();
                Console.WriteLine("Hello {0}!", input);
            }
        }

        public class DebugTextWriter : TextWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }

            public override void Write(char value)
            {
                Debug.Write(value);
            }

            public override void Write(string value)
            {
                Debug.Write(value);
            }

            public override void WriteLine(string value)
            {
                Debug.WriteLine(value);
            }
        }
    }
}

using RustSharp.Load;

namespace RustSharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Func.add(10, 150));
            Console.WriteLine(Func.hello("C#"));

            // Always returns "True" >:(
            Console.WriteLine(Func.is_bool(101));
        }
    }
}

using RustSharp.Load;

namespace RustSharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Func.add(10, 150));

            Func.hello("C#");
            Func.hello("World");

            Console.WriteLine(Func.is_bool(99));
            Console.WriteLine(Func.is_bool(101));
        }
    }
}

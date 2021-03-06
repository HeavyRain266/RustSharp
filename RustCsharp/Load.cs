using System.Runtime.InteropServices;

namespace RustSharp.Load {
    public class Func {
        [DllImport("rust_sharp")]
        public static extern Int32 add(Int32 left, Int32 right);

        [DllImport("rust_sharp")]
        public static extern void hello(string name);

        [DllImport("rust_sharp")]
        public static extern bool is_even(Int32 i);
    }
}

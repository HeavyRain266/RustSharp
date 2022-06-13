using System.Runtime.InteropServices;

namespace RustSharp.Load {
    public class Func {
        [DllImport("rust_csharp.dll")]
        public static extern Int32 add(Int32 left, Int32 right);

        [DllImport("rust_csharp.dll")]
        public static extern string hello(string name);

        [DllImport("rust_csharp.dll")]
        public static extern bool is_bool(Int32 i);
    }
}

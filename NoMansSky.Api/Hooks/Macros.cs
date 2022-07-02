using System;

namespace NoMansSky.Api.Hooks
{
    /// <summary>
    /// Macros for Assembly hooks.
    /// <br/>Taken from https://github.com/Reloaded-Project/Reloaded.Hooks/blob/2f58cee30ffc144cd33142ab46f194a4fdf2cdef/Source/Reloaded.Hooks.Tests.Shared/Macros/Macros.cs
    /// </summary>
    public static class Macros
    {
        /// <summary>
        /// Reflects whether or not this process is 64bit or not.
        /// </summary>
        public static bool Is64Bit = Environment.Is64BitProcess;

        /// <summary>
        /// ASM opcodes that reflect whether or not the following asm will be 32bit or 64bit
        /// </summary>
        public static string _use32 = Is64Bit ? "use64" : "use32";

        /// <summary>
        /// The name of RAX or EAX register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _eax = Is64Bit ? "rax" : "eax";

        /// <summary>
        /// The name of RBX or EBX register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _ebx = Is64Bit ? "rbx" : "ebx";

        /// <summary>
        /// The name of RCX or ECX register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _ecx = Is64Bit ? "rcx" : "ecx";

        /// <summary>
        /// The name of RDX or EDX register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _edx = Is64Bit ? "rdx" : "edx";

        /// <summary>
        /// The name of RSI or ESI register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _esi = Is64Bit ? "rsi" : "esi";

        /// <summary>
        /// The name of RDI or EDI register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _edi = Is64Bit ? "rdi" : "edi";

        /// <summary>
        /// The name of RBP or EBP register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _ebp = Is64Bit ? "rbp" : "ebp";

        /// <summary>
        /// The name of RSP or ESP register depending on whether or not the processs is 64bit
        /// </summary>
        public static string _esp = Is64Bit ? "rsp" : "esp";

        /// <summary>
        /// Represents the full word operand size for current architecture.
        /// </summary>
        public static string _word = Is64Bit ? "qword" : "dword";
    }
}

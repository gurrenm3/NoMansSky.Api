using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api.Hooks
{
    /// <summary>
    /// Macros for Assembly hooks.
    /// <br/>Taken from https://github.com/Reloaded-Project/Reloaded.Hooks/blob/2f58cee30ffc144cd33142ab46f194a4fdf2cdef/Source/Reloaded.Hooks.Tests.Shared/Macros/Macros.cs
    /// </summary>
    public static class Macros
    {
        public static bool Is64Bit = Environment.Is64BitProcess;

        public static string _use32 = Is64Bit ? "use64" : "use32";
        public static string _eax = Is64Bit ? "rax" : "eax";
        public static string _ebx = Is64Bit ? "rbx" : "ebx";
        public static string _ecx = Is64Bit ? "rcx" : "ecx";
        public static string _edx = Is64Bit ? "rdx" : "edx";
        public static string _esi = Is64Bit ? "rsi" : "esi";
        public static string _edi = Is64Bit ? "rdi" : "edi";
        public static string _ebp = Is64Bit ? "rbp" : "ebp";
        public static string _esp = Is64Bit ? "rsp" : "esp";

        /// <summary>
        /// Represents the full word operand size for current architecture.
        /// </summary>
        public static string _word = Is64Bit ? "qword" : "dword";
    }
}

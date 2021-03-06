﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace IronFrame.Win32
{
    internal partial class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CreatePipe(out SafeFileHandle phReadPipe, out SafeFileHandle phWritePipe,
            SecurityAttributes lpPipeAttributes, uint nSize);
    }
}

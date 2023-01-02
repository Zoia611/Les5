using Microsoft.Win32;
using System;

namespace Les5wpf
{
    internal class SeveFileDialog
    {
        public static implicit operator SeveFileDialog(SaveFileDialog v)
        {
            throw new NotImplementedException();
        }
    }
}
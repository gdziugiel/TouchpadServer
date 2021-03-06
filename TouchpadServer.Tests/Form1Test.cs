using System.Drawing;
// <copyright file="Form1Test.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TouchpadServer;

namespace TouchpadServer.Tests
{
    [TestClass]
    [PexClass(typeof(Form1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Form1Test
    {

        [PexMethod(MaxBranches = 320000)]
        public Form1 Constructor()
        {
            Form1 target = new Form1();
            return target;
            // TODO: dodaj asercje do metoda Form1Test.Constructor()
        }

        [PexMethod]
        public bool GetCursorPos(out Point point)
        {
            bool result = Form1.GetCursorPos(out point);
            return result;
            // TODO: dodaj asercje do metoda Form1Test.GetCursorPos(Point&)
        }

        [PexMethod]
        public bool SetCursorPos(int x, int y)
        {
            bool result = Form1.SetCursorPos(x, y);
            return result;
            // TODO: dodaj asercje do metoda Form1Test.SetCursorPos(Int32, Int32)
        }

        [PexMethod]
        public void mouse_event(
            uint dwFlags,
            int dx,
            int dy,
            int dwData,
            uint dwExtraInfo
        )
        {
            Form1.mouse_event(dwFlags, dx, dy, dwData, dwExtraInfo);
            // TODO: dodaj asercje do metoda Form1Test.mouse_event(UInt32, Int32, Int32, Int32, UInt32)
        }
    }
}

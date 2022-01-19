using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace MultiThread{
    class Clock{
        public delegate void ChangeSecondsHandler();
        public event ChangeSecondsHandler OnChange = delegate{};
        public void Raise(){
            OnChange();
        }
    }
}
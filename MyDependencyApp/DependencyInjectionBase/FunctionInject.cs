using System;
using System.Diagnostics;

namespace MyDependencyApp.DependencyInjectionBase
{
    class FunctionInject
    {
        private Func<IArgs, bool> _Func = null;
        public void SetFunction(Func<IArgs, bool> func) {
            _Func = func;
        }
        public bool Invoke(IArgs arg) {
            Debug.Assert(_Func != null);
            return _Func.Invoke(arg);
        }
    }
}

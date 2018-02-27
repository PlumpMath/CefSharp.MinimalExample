using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefSharp.MinimalExample.WinForms
{
    public class ExampleBoundObject
    {
        public string SayHello(string name) { return $"Hello {name}!"; }

        public ChildBoundObject GetSubObject() { return new ChildBoundObject(); }
    }

    public class ChildBoundObject
    {
        public string SayGoodbye(string name) { return $"Goodbye {name}!"; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefSharp.MinimalExample.WinForms
{
    public class ExampleBoundObject
    {
        public string Name { get; set; }

        public void SetName(string name) { Name = name; }

        public string GetName() { return Name; }

        public string SayHello() { return $"Hello {Name}!"; }

        public ChildBoundObject GetSubObject(string name) { return new ChildBoundObject { Name = name }; }

        public ChildBoundObject[] GetSubObjects(object namess)
        {
            var names = new[] { "Yuri", "Boris", "Cleo" };

            var objects = new List<ChildBoundObject>(names.Length);

            foreach(var name in names)
            {
                objects.Add(new ChildBoundObject() { Name = name.ToString() });
            }

            return objects.ToArray();
        }
    }

    public class ChildBoundObject
    {
        public string Name { get; set; }

        public void SetName(string name) { Name = name; }

        public string GetName() { return Name; }

        public string SayGoodbye() { return $"Goodbye {Name}!"; }
    }
}

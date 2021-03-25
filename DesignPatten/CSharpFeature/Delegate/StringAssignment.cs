using System.Collections.Generic;

namespace Joezhouman.DesignPattern.CSharpFeature.Delegate {
    public delegate void StringAssignmentEventHandler();

    public class InvokeList {
        private string[] _message = new string[3];

        public InvokeList() {
            StringAssignmentEventHandler handlers = null;
            handlers += delegate { _message[0] = "Hello"; };
            handlers += delegate { _message[1] = " "; };
            handlers += delegate { _message[2] = "World"; };
            handlers.Invoke();
        }

        public string this[int index] => _message[index];
    }
}
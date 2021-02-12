using System;
using System.Collections.Generic;
using System.Linq;
using CodeKata.Interfaces;

namespace CodeKata {
    public class TestIOSystem : IIOSystem {

        private List<string> _inputs;
        private List<string> _outputs = new List<string>();

        public TestIOSystem(params string[] input) {
            _inputs = input.ToList();
        }
        public string ReadInput() {

            var s = _inputs.First();
            _inputs.RemoveAt(0);

            return s;
        }

        public void WriteOutput(string output) {
            _outputs.Add(output);
        }

        public List<string> Outputs => _outputs;
    }
}

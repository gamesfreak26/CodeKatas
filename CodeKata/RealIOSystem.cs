using System;
using System.Collections.Generic;
using System.Text;
using CodeKata.Interfaces;

namespace CodeKata {
    public class RealIOSystem : IIOSystem {
        public string ReadInput() {
            Console.Write("Please enter your input: ");
            var input = Console.ReadLine();
            return input;
        }

        public void WriteOutput(string output) {
            Console.WriteLine(output);
        }
    }
}

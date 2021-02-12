using Kata21_Simple_Lists;
using NUnit.Framework;

namespace Tests {
    public class Tests {

        private SinglyLinkedList sl;

        [SetUp]
        public void Setup() {
            sl = new SinglyLinkedList();
        }

        [TearDown]
        public void CleanUp() {
            sl.Clear();
        }

        [Test]
        public void ListDoesNotContainStringToFind() {   
            var result = sl.Contains("Fred");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void ListDoesContainStringToFind() {
            sl.Add("Fred");
            var result = sl.Contains("Fred");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void List2ValuesDoesContainStringToFind() {
            sl.Add("Fred");
            sl.Add("Wilma");
            var result = sl.Contains("Wilma");
            Assert.AreEqual(true, result);

        }

        [Test]
        public void LengthOfDefinedList() {
            sl.Add("Fred");
            sl.Add("Wilma");
            sl.Add("Daphne");
            var result = sl.Count();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void LengthOfUndefinedList() {
            var result = sl.Count();
            Assert.AreEqual(0, result);
        }

        
        public void DeleteAnItem() {
            sl.Add("Fred");
            sl.Add("Wilma");
            Assert.AreEqual(2, sl.Count());
            sl.Delete("Fred");
            Assert.AreEqual(1, sl.Count());
        }
    }
}
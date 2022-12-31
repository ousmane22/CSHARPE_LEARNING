using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    
    public  class EnumerableTest
    {
        IEnumerable<string> _string;

        [Setup]
        public void Setup()
        {
            _string = new List<string> {"a","b","c","d" };
        }

        [Test]
        public void Count()
        {
            Assert.AreEqual(3, _string.Count());
            var list = new StringList();
            Assert.AreEqual(3, list.Count());
        }
    }
}

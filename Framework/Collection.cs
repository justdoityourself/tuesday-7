using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EchoPractice4Test.Framework
{
    class Collection : IEnumerable<Test>
    {
        List<Test> mTests;

        public Collection()
        {
            mTests = new List<Test>();
        }

        public void AddTest(Test test)
        {
            mTests.Add(test);
        }

        public IEnumerator<Test> GetEnumerator()
        {
            foreach (Test test in mTests)
            {
                yield return test;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

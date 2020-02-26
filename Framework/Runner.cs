using System;
using System.Collections.Generic;
using System.Text;

namespace Tuesday7.Framework
{
    class Runner
    {
        Collection mCollection;
        public Runner(Collection _collection)
        {
            mCollection = _collection;
        }

        public void Start()
        {
            foreach (Test test in mCollection)
            {
                test.Run();
            }
        }
    }
}

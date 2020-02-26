using System;
using System.Collections.Generic;
using System.Text;

namespace EchoPractice4Test.Framework
{
    abstract class TestInstruction
    {
        public abstract void Run(State state);
    }

    class Test
    {
        List<TestInstruction> mInstructions;

        public Test(List<TestInstruction> l)
        {
            mInstructions = l;
        }
        ~Test()
        {

        }

        public void Run()
        {
            State state = new State();
            foreach (var instruction in mInstructions)
            {
                instruction.Run(state);
            }
        }
    }
}

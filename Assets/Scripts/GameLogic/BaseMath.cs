using System.Collections.Generic;

namespace UnNumber
{
    public class BaseMath : IMath
    {
        public Dictionary<MathOperations, IMath.MathAction> Operations { get; private set; }

        public BaseMath()
        {
            Operations = new Dictionary<MathOperations, IMath.MathAction>()
            {
                { MathOperations.Plus, (int a, int b) => a + b },
                { MathOperations.Minus, (int a, int b) => a - b },
                { MathOperations.Multiplication, (int a, int b) => a * b },
                { MathOperations.Division, (int a, int b) => a / b }
            };
        }
    }
}

using System.Collections.Generic;

namespace UnNumber
{
    public interface IMath
    {
        delegate int MathAction(int a, int b);
        public Dictionary<MathOperations, MathAction> Operations { get; }
    }
}

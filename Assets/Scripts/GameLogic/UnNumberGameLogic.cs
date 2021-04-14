namespace UnNumber
{
    public class UnNumberLogic : IMathGameLogic
    {
        public IMath MathematicsOperations { get; set; }

        public UnNumberLogic()
        {
            MathematicsOperations = new BaseMath();
        }
    }
}



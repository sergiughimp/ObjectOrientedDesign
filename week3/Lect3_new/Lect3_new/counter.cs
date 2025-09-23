namespace counter
{
    public class Counter
    {
        // public static int MyCounter = 0;
        static int MyCounter = 0;
        public static void IncreaseCounter()
        {
            MyCounter++;
        }
        public static int GetCounter()
        {
            return MyCounter;
        }
    }
}
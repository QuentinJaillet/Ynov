namespace YnovTdd
{
    public class FlipFlop
    {
        public string Show(int minNumber, int maxNumber)
        {
            var result = string.Empty;

            while (minNumber <= maxNumber)
                result += Process(minNumber++);

            return result;
        }

        private static string Process(int number)
        {
            if (number % 15 == 0)
                return "FlipFlop";
            else if (number % 3 == 0)
                return "Flip";
            else if (number % 5 == 0)
                return "Flop";

            return number.ToString();
        }
    }
}

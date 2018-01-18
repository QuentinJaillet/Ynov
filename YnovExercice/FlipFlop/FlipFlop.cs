using System;

namespace FormationTestUnitaire
{
    public class FlipFlop
    {
        public string Process(uint number)
        {
            if (number == 0)
                return string.Empty;

            if (IsModulo3(number) && IsModulo5(number))
                return "FlipFlop";

            if (IsModulo3(number))
                return "Flip";

            if (IsModulo5(number))
                return "Flop";

            return number.ToString();
        }

        private static bool IsModulo5(uint number)
        {
            return number % 5 == 0;
        }

        private static bool IsModulo3(uint number)
        {
            return number % 3 == 0;
        }
    }
}

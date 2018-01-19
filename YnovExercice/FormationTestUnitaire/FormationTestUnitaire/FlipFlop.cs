using System;

namespace FormationTestUnitaire
{




    public class FlipFlop
    {
        public static void Main()
        {

        }

        private readonly IWindows _windows;

        public FlipFlop(IWindows windows)
        {
            _windows = windows;
        }

        public void Process(uint number)
        {
            if (number == 0)
                _windows.Show(string.Empty);

            else if (IsModulo3(number) && IsModulo5(number))
                _windows.Show("FlipFlop");

            else if (IsModulo3(number))
                _windows.Show("Flip");

            else if (IsModulo5(number))
                _windows.Show("Flop");

            else _windows.Show(number.ToString());
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

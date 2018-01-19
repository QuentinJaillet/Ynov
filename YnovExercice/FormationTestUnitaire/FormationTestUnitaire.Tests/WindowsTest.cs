namespace FormationTestUnitaire.Tests
{
    public class WindowsTest : IWindows
    {
        public string Message { get; private set; }

        public void Show(string message)
        {
            Message = message;
        }
    }
}

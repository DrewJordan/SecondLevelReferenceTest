namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var primary = new FirstLevel.FirstLevel();

            primary.reference.DoSomething(); // will cause compiler error telling you to reference "Second Level"

            primary.DoSomethingWithReferencedClass(); // no compiler error: does the same thing the right way.
        }
    }
}

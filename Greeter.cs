namespace ReproSonarLintRules
{
    /// <summary>
    /// Class that computes a greeting.
    /// </summary>
    /// <code>
    ///     var greeter = new Greeter("World");
    ///     var greeting = greeeter.GetGreeting();
    /// </code>
    public class Greeter
    {
        private readonly string whom;

        public Greeter(string whom)
        {
            this.whom = whom;
        }

        public string GetGreeting()
        {
            return $"Hello, {whom}";
        }
    }
}

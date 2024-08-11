using Serilog;
using Serilog.Formatting.Compact;

namespace SerilogLogGenerator
{
    /// <summary>
    /// Small program that generates structured logging using Serilog.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog to output structured logs in JSON format.
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(new CompactJsonFormatter())
                .CreateLogger();
            Random rnd = new();
            int counter = 0;

            while (true)
            {
                var userId = Guid.NewGuid();
                var action = new[] { "Login", "Logout", "Update", "Delete" }[rnd.Next(4)];

                Log.Information("User {UserId} performed action {Action}, counter is {Counter}", userId, action, counter);

                counter++;
                Thread.Sleep(1000);
            }
        }
    }
}

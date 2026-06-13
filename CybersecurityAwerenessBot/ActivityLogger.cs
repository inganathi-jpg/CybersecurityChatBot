using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityAwarenessBot
{
    public class ActivityLogger
    {
        private readonly List<string> log = new();

        public void Log(string action)
        {
            log.Add($"[{DateTime.Now:HH:mm}] {action}");
        }

        public string GetRecentLog()
        {
            return string.Join("\n",
                log.TakeLast(10));
        }

        public string GetFullLog()
        {
            return string.Join("\n", log);
        }

        public int Count()
        {
            return log.Count;
        }
    }
}
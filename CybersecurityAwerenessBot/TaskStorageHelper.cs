using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CybersecurityAwarenessBot
{
    public class TaskStorageHelper
    {
        private const string FilePath = "tasks.json";

        public List<CyberTask> LoadTasks()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new List<CyberTask>();

                string json = File.ReadAllText(FilePath);

                return JsonConvert.DeserializeObject<List<CyberTask>>(json)
                       ?? new List<CyberTask>();
            }
            catch
            {
                return new List<CyberTask>();
            }
        }

        public void SaveTasks(List<CyberTask> tasks)
        {
            string json =
                JsonConvert.SerializeObject(tasks, Formatting.Indented);

            File.WriteAllText(FilePath, json);
        }
    }
}
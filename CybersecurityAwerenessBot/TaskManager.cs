using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityAwarenessBot
{
    public class TaskManager
    {
        private readonly TaskStorageHelper storage =
            new();

        public void AddTask(
            string title,
            string description,
            string reminder)
        {
            List<CyberTask> tasks =
                storage.LoadTasks();

            int id =
                tasks.Count == 0
                ? 1
                : tasks.Max(x => x.Id) + 1;

            tasks.Add(new CyberTask
            {
                Id = id,
                Title = title,
                Description = description,
                Reminder = reminder,
                CreatedAt =
                    DateTime.Now.ToString(),
                IsComplete = false
            });

            storage.SaveTasks(tasks);
        }

        public List<CyberTask> GetTasks()
        {
            return storage.LoadTasks();
        }

        public void DeleteTask(int id)
        {
            var tasks = storage.LoadTasks();

            tasks.RemoveAll(x => x.Id == id);

            storage.SaveTasks(tasks);
        }

        public void CompleteTask(int id)
        {
            var tasks = storage.LoadTasks();

            var task =
                tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                task.IsComplete = true;
                storage.SaveTasks(tasks);
            }
        }
    }
}
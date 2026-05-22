using System.Collections.Generic;

namespace CybersecurityChatbot
{
    // Stores user information and chatbot memory
    public class MemoryStore
    {
        // Store username
        public string UserName { get; set; }

        // Store favourite cybersecurity topic
        public string FavouriteTopic { get; set; }

        // Dictionary memory storage
        private Dictionary<string, string> memory =
            new Dictionary<string, string>();

        // Store information
        public void StoreMemory(string key, string value)
        {
            memory[key] = value;
        }

        // Recall information
        public string RecallMemory(string key)
        {
            if (memory.ContainsKey(key))
            {
                return memory[key];
            }

            return "";
        }
    }
}
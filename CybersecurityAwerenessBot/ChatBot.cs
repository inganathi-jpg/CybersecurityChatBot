using System;

namespace CybersecurityChatbot
{
    // Main chatbot logic controller
    public class ChatBot
    {
        // Objects from other classes
        private KeywordResponder keywordResponder;
        private SentimentDetector sentimentDetector;
        private MemoryStore memoryStore;

        // Check if bot still needs username
        private bool awaitingName = true;

        // Stores previous topic
        private string lastTopic = "";

        // Random object
        private Random random = new Random();

        // Constructor
        public ChatBot()
        {
            keywordResponder = new KeywordResponder();
            sentimentDetector = new SentimentDetector();
            memoryStore = new MemoryStore();
        }

        // Starting greeting
        public string GetGreeting()
        {
            return "Hello and welcome to the Cybersecurity Awareness Chatbot.\n\nWhat is your name?";
        }

        // Main processing method
        public string ProcessInput(string input)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Please enter a message.";
            }

            // Convert input to lowercase
            string lowerInput = input.ToLower();

            // FIRST USER MESSAGE = NAME
            if (awaitingName)
            {
                memoryStore.UserName = input;
                awaitingName = false;

                return "Nice to meet you, " +
                       memoryStore.UserName +
                       ".\n\nYou can ask me about:\n" +
                       "- Password safety\n" +
                       "- Phishing\n" +
                       "- Scams\n" +
                       "- Privacy\n" +
                       "- Malware\n" +
                       "- Hacking\n" +
                       "- Safe browsing\n" +
                       "- Two-factor authentication\n" +
                       "- Social media safety";
            }

            // HELP MENU
            if (lowerInput.Contains("help") ||
                lowerInput.Contains("menu") ||
                lowerInput.Contains("what can you do"))
            {
                return "I can help you learn about:\n\n" +
                       "- Password safety\n" +
                       "- Phishing attacks\n" +
                       "- Online scams\n" +
                       "- Malware\n" +
                       "- Online privacy\n" +
                       "- Safe browsing\n" +
                       "- Hacking awareness\n" +
                       "- Social media safety\n" +
                       "- Two-factor authentication\n\n" +
                       "You can also ask follow-up questions like:\n" +
                       "- Tell me more\n" +
                       "- Explain more\n" +
                       "- How do I stay safe?";
            }

            // HOW ARE YOU
            if (lowerInput.Contains("how are you"))
            {
                return "I am functioning well, " +
                       memoryStore.UserName +
                       ". I am ready to help you stay safe online.";
            }

            // THANK YOU
            if (lowerInput.Contains("thank"))
            {
                return "You are welcome, " +
                       memoryStore.UserName +
                       ". Staying informed about cybersecurity is important.";
            }

            // WHO MADE YOU
            if (lowerInput.Contains("who made you"))
            {
                return "I was developed as a cybersecurity awareness chatbot project using C# and WPF.";
            }

            // WHAT IS CYBERSECURITY
            if (lowerInput.Contains("what is cybersecurity"))
            {
                return "Cybersecurity is the protection of computers, systems, networks, and data from cyberattacks, hacking, scams, and unauthorised access.";
            }

            // FOLLOW-UP QUESTIONS
            if (lowerInput.Contains("tell me more") ||
                lowerInput.Contains("another tip") ||
                lowerInput.Contains("explain more"))
            {
                return GetFollowUpResponse();
            }

            // HOW TO STAY SAFE
            if (lowerInput.Contains("how do i stay safe") ||
                lowerInput.Contains("how can i protect myself"))
            {
                return GetProtectionAdvice();
            }

            // SENTIMENT DETECTION
            string sentiment =
                sentimentDetector.DetectSentiment(lowerInput);

            string sentimentResponse =
                sentimentDetector.GetSentimentResponse(sentiment);

            // KEYWORD RESPONSE
            string keywordResponse =
                keywordResponder.GetResponse(lowerInput);

            // IF KEYWORD FOUND
            if (keywordResponse != null)
            {
                // Store last topic
                if (lowerInput.Contains("password"))
                    lastTopic = "password";

                else if (lowerInput.Contains("phishing"))
                    lastTopic = "phishing";

                else if (lowerInput.Contains("privacy"))
                    lastTopic = "privacy";

                else if (lowerInput.Contains("scam"))
                    lastTopic = "scam";

                else if (lowerInput.Contains("malware"))
                    lastTopic = "malware";

                else if (lowerInput.Contains("hacking"))
                    lastTopic = "hacking";

                else if (lowerInput.Contains("safe browsing"))
                    lastTopic = "safe browsing";

                else if (lowerInput.Contains("social media"))
                    lastTopic = "social media";

                else if (lowerInput.Contains("two-factor"))
                    lastTopic = "two-factor";

                else if (lowerInput.Contains("cybersecurity"))
                    lastTopic = "cybersecurity";

                // Store favourite topic
                memoryStore.FavouriteTopic = lastTopic;

                // Personalised response
                return sentimentResponse +
                       memoryStore.UserName +
                       ", " +
                       keywordResponse;
            }

            // FAVOURITE TOPIC
            if (lowerInput.Contains("favourite topic"))
            {
                return "Your favourite cybersecurity topic appears to be " +
                       memoryStore.FavouriteTopic + ".";
            }

            // FALLBACK RESPONSES
            string[] fallbackResponses =
            {
                "I am not sure I understand. Please ask a cybersecurity-related question.",

                "Could you rephrase your cybersecurity question?",

                "Try asking me about phishing, passwords, scams, or privacy.",

                "I can help explain cybersecurity concepts and online safety tips.",

                "Please ask something related to cybersecurity awareness."
            };

            return fallbackResponses[random.Next(fallbackResponses.Length)];
        }

        // FOLLOW-UP RESPONSES
        private string GetFollowUpResponse()
        {
            switch (lastTopic)
            {
                case "password":
                    return "A good password should be long, unique, and difficult to guess. Using a password manager can help you create and store strong passwords safely.";

                case "phishing":
                    return "Phishing attacks often create urgency to pressure victims into acting quickly. Always verify suspicious messages before responding.";

                case "privacy":
                    return "Protecting your privacy online includes limiting what you share publicly and reviewing account privacy settings regularly.";

                case "scam":
                    return "Online scams often target emotions such as fear or excitement. Be cautious of urgent requests or unrealistic offers.";

                case "malware":
                    return "Malware infections can spread through unsafe downloads and email attachments. Antivirus software helps reduce the risk.";

                case "hacking":
                    return "Hackers often exploit weak passwords and outdated software. Keeping systems updated improves security.";

                case "safe browsing":
                    return "Safe browsing habits include checking website legitimacy and avoiding suspicious downloads or advertisements.";

                case "social media":
                    return "Social media safety involves protecting personal information and avoiding suspicious links or fake accounts.";

                case "two-factor":
                    return "Two-factor authentication provides additional protection by requiring another verification method besides your password.";

                case "cybersecurity":
                    return "Cybersecurity awareness helps users recognise threats such as scams, phishing, malware, and hacking attempts.";

                default:
                    return "Please ask about a cybersecurity topic first.";
            }
        }

        // PROTECTION ADVICE
        private string GetProtectionAdvice()
        {
            switch (lastTopic)
            {
                case "password":
                    return "You can stay safe by using strong passwords, changing them regularly, and enabling two-factor authentication.";

                case "phishing":
                    return "You can protect yourself from phishing by avoiding suspicious links and verifying email senders carefully.";

                case "privacy":
                    return "Protect your privacy by limiting personal information shared online and using secure websites.";

                case "scam":
                    return "Stay safe from scams by verifying information before making payments or sharing sensitive details.";

                case "malware":
                    return "Reduce malware risks by avoiding unsafe downloads and keeping antivirus software updated.";

                default:
                    return "Good cybersecurity habits include strong passwords, software updates, and cautious online behaviour.";
            }
        }
    }
}
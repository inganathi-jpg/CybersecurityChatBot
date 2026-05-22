namespace CybersecurityChatbot
{
    // Detects user emotions
    public class SentimentDetector
    {
        public string DetectSentiment(string input)
        {
            input = input.ToLower();

            // Worried sentiment
            if (input.Contains("worried") ||
                input.Contains("scared") ||
                input.Contains("afraid"))
            {
                return "worried";
            }

            // Curious sentiment
            if (input.Contains("curious") ||
                input.Contains("interested") ||
                input.Contains("wondering"))
            {
                return "curious";
            }

            // Frustrated sentiment
            if (input.Contains("frustrated") ||
                input.Contains("confused") ||
                input.Contains("annoyed"))
            {
                return "frustrated";
            }

            return "neutral";
        }

        // Return emotional response
        public string GetSentimentResponse(string sentiment)
        {
            switch (sentiment)
            {
                case "worried":
                    return "It is understandable to feel worried about cyber threats. Let me help you stay safe.\n";

                case "curious":
                    return "Curiosity is great when learning cybersecurity.\n";

                case "frustrated":
                    return "Cybersecurity can feel confusing at first, but I will explain it clearly.\n";

                default:
                    return "";
            }
        }
    }
}
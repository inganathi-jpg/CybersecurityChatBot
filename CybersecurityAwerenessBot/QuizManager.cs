using System.Collections.Generic;

namespace CybersecurityAwarenessBot
{
    public class QuizManager
    {
        public List<QuizQuestion> Questions { get; set; }

        public QuizManager()
        {
            Questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Question =
                    "What is phishing?",

                    Options =
                    new List<string>
                    {
                        "A scam email",
                        "A game",
                        "An antivirus",
                        "A password"
                    },

                    CorrectAnswer =
                    "A scam email",

                    Explanation =
                    "Phishing tricks users into giving information."
                },

                new QuizQuestion
                {
                    Question =
                    "Should you share passwords?",

                    Options =
                    new List<string>
                    {
                        "Yes",
                        "No"
                    },

                    CorrectAnswer =
                    "No",

                    Explanation =
                    "Passwords should remain private."
                }
            };
        }
    }
}
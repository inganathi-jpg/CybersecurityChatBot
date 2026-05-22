using System;
using System.Collections.Generic;

namespace CybersecurityChatbot
{
    // Handles cybersecurity keyword recognition and responses
    public class KeywordResponder
    {
        // Dictionary storing keywords and their response lists
        private Dictionary<string, List<string>> responses;

        // Random object for random responses
        private Random random = new Random();

        // Constructor
        public KeywordResponder()
        {
            responses = new Dictionary<string, List<string>>();

            // PASSWORD RESPONSES
            responses["password"] = new List<string>()
            {
                "Passwords are your first line of defence against cybercriminals. Always create strong passwords using uppercase letters, lowercase letters, numbers, and symbols. Avoid using personal details like your name or birth date.",

                "Password safety is extremely important in cybersecurity. Weak passwords make it easier for hackers to access your accounts. Use unique passwords for every account and change them regularly.",

                "A strong password helps protect your personal information from hackers. Consider using a password manager to safely store complex passwords instead of reusing the same password everywhere.",

                "Cybercriminals often use password attacks to steal information. Enable two-factor authentication along with strong passwords for better account security.",

                "Never share your passwords with anyone online. Legitimate companies will never ask for your password through email or messages."
            };

            // PHISHING RESPONSES
            responses["phishing"] = new List<string>()
            {
                "Phishing is a cyberattack where scammers pretend to be trusted organisations to steal sensitive information such as passwords or banking details. Always verify emails before clicking links.",

                "Phishing attacks usually happen through fake emails, messages, or websites. Cybercriminals try to trick users into revealing personal information. Never click suspicious links or attachments.",

                "A phishing scam may look like a real message from a bank, school, or company. Look carefully for spelling mistakes, suspicious links, and urgent requests for personal information.",

                "To stay safe from phishing attacks, avoid opening unknown email attachments and never enter personal information on websites you do not trust.",

                "Cybercriminals use phishing to steal usernames, passwords, and financial details. Always double-check the sender and website address before responding."
            };

            // PRIVACY RESPONSES
            responses["privacy"] = new List<string>()
            {
                "Online privacy means protecting your personal information from being accessed by unauthorised people. Always review your privacy settings on apps and websites.",

                "Protecting your privacy online helps reduce the risk of identity theft and cybercrime. Avoid sharing sensitive personal information publicly on social media.",

                "Privacy is an important part of cybersecurity. Use strong passwords and secure websites to help protect your personal data online.",

                "Many apps collect personal information about users. Check app permissions carefully and only allow access that is necessary.",

                "Using public WiFi without protection can expose your private information to hackers. Avoid accessing sensitive accounts on unsecured networks."
            };

            // SCAM RESPONSES
            responses["scam"] = new List<string>()
            {
                "Online scams are fraudulent attempts to trick people into giving away money or personal information. Be cautious of offers that seem too good to be true.",

                "Scammers often create fake competitions, fake job offers, or fake investment opportunities to target victims online. Always verify information before responding.",

                "Cyber scams can happen through emails, phone calls, social media, or fake websites. Never send money or personal information to unknown individuals online.",

                "One way to protect yourself from scams is to avoid sharing banking details through messages or emails. Trusted companies usually do not request sensitive information this way.",

                "Scammers often pressure victims to act quickly. Take your time and verify information before making payments or sharing personal data."
            };

            // MALWARE RESPONSES
            responses["malware"] = new List<string>()
            {
                "Malware is harmful software designed to damage devices or steal information. Install trusted antivirus software to help protect your computer.",

                "Cybercriminals use malware to gain unauthorised access to systems and personal data. Avoid downloading files from unknown websites.",

                "Keeping your operating system and applications updated helps reduce the risk of malware infections.",

                "Malware can spread through unsafe downloads, infected USB devices, and malicious email attachments.",

                "Regularly scanning your computer for threats can help detect and remove malware before it causes damage."
            };

            // CYBERSECURITY RESPONSES
            responses["cybersecurity"] = new List<string>()
            {
                "Cybersecurity is the practice of protecting systems, networks, and data from cyber threats and attacks.",

                "Cybersecurity helps individuals and businesses stay safe online by preventing hacking, scams, and data theft.",

                "Learning cybersecurity awareness is important because cybercriminals constantly develop new attack methods.",

                "Cybersecurity includes password safety, phishing awareness, privacy protection, and safe browsing practices.",

                "Strong cybersecurity habits help protect your personal and financial information online."
            };

            // SAFE BROWSING RESPONSES
            responses["safe browsing"] = new List<string>()
            {
                "Safe browsing means using the internet carefully to avoid harmful websites, scams, and malware infections.",

                "Only visit trusted websites and check for HTTPS before entering personal information online.",

                "Avoid downloading files or software from websites you do not trust because they may contain malware.",

                "Be cautious when clicking advertisements or pop-ups because some may redirect you to malicious websites.",

                "Keeping your web browser updated improves security and helps protect against cyber threats."
            };

            // HACKING RESPONSES
            responses["hacking"] = new List<string>()
            {
                "Hacking involves gaining unauthorised access to systems, networks, or accounts. Weak passwords often make hacking easier.",

                "Hackers use different methods such as phishing, malware, and password attacks to steal information.",

                "Updating software regularly helps protect devices against hacking vulnerabilities.",

                "Never share login credentials online because hackers may use them to access your accounts.",

                "Using two-factor authentication provides extra protection against hacking attempts."
            };

            // TWO-FACTOR AUTHENTICATION RESPONSES
            responses["two-factor"] = new List<string>()
            {
                "Two-factor authentication adds an extra layer of security by requiring a second verification step in addition to your password.",

                "Enabling two-factor authentication helps protect your accounts even if your password becomes compromised.",

                "Authenticator apps are usually safer than SMS verification methods for two-factor authentication.",

                "Many online services support two-factor authentication for better account security.",

                "Using two-factor authentication greatly reduces the risk of unauthorised account access."
            };

            // SOCIAL MEDIA SAFETY RESPONSES
            responses["social media"] = new List<string>()
            {
                "Be careful about the personal information you share on social media platforms because cybercriminals may misuse it.",

                "Review your social media privacy settings regularly to control who can view your content.",

                "Avoid accepting friend requests from strangers because fake accounts are commonly used in scams.",

                "Scammers often use fake giveaways and links on social media to trick users into sharing information.",

                "Think carefully before posting sensitive information online because it may remain public permanently."

                "Cybersecurity awareness on social media helps protect your privacy and reduces the risk of falling victim to scams."

                "Always verify the authenticity of accounts and links on social media to stay safe from cyber threats."
            };
        }

        // Method to return a random response
        public string GetResponse(string input)
        {
            // Convert input to lowercase
            input = input.ToLower();

            // Remove question marks
            input = input.Replace("?", "");

            // Loop through all keywords
            foreach (var keyword in responses.Keys)
            {
                // Check if keyword exists in user input
                if (input.Contains(keyword.ToLower()))
                {
                    // Get list of responses
                    List<string> possibleResponses = responses[keyword];

                    // Randomly select a response
                    int index = random.Next(possibleResponses.Count);

                    return possibleResponses[index];
                }
            }

            // Return null if no keyword found
            return null;
        }
    }
}
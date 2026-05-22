using System.Windows.Input;
using System.Windows;

namespace CybersecurityChatbot
{
    public partial class MainWindow : Window
    {
        // Create chatbot object
        private ChatBot chatbot;
        private AudioPlayer audioPlayer;

        public MainWindow() 
        {
            InitializeComponent();

            // Create chatbot
            chatbot = new ChatBot();
            audioPlayer = new AudioPlayer();
            audioPlayer.PlayGreeting();

            // Display greeting
            ChatDisplay.Text =
"=====================================\n" +
" CYBERSECURITY AWARENESS CHATBOT\n" +
"=====================================\n\n" +
"BOT: " + chatbot.GetGreeting();
        }

        // Runs when SEND button is clicked
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            // Get user input
            string userMessage = UserInput.Text;

            // Ignore empty input
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                return;
            }

            // Display user message
            ChatDisplay.Text += "\n\n-----------------------------------";
            ChatDisplay.Text += "\nYOU: " + userMessage;

            // Get chatbot response
            string response = chatbot.ProcessInput(userMessage);

            // Display chatbot response
            ChatDisplay.Text += "\nBOT: " + response;
            ChatDisplay.Text += "\n-----------------------------------";

            // Clear textbox
            UserInput.Clear();

            // Scroll automatically
            ChatScrollViewer.ScrollToEnd();
        }
        private void UserInput_KeyDown(object sender, KeyEventArgs e)
        {
            // Send message when Enter is pressed
            if (e.Key == Key.Enter)
            {
                SendButton_Click(sender, e);
            }
        }
    }
}
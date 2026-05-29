# Cybersecurity Awareness Chatbot

## Project Description

The Cybersecurity Awareness Chatbot is a WPF-based chatbot application developed in C# for PROG6221 Part 2. The chatbot helps users learn about cybersecurity topics such as phishing, password safety, scams, malware, privacy, safe browsing, hacking, and social media safety.

The chatbot includes sentiment detection, memory recall, random responses, conversation flow, voice greeting functionality, and a graphical user interface.

---

## Student Information

- Name: Inganathi Mancam
- Student Number: ST10484781
- Module: PROG6221 Programming 2A

---

## Features Implemented

### GUI Features
- WPF graphical user interface
- Chat display area
- User input textbox
- Send button
- Enter key support
- Styled interface with colours and spacing

### Cybersecurity Features
- Keyword recognition
- Random responses
- Follow-up conversation flow
- Cybersecurity awareness tips
- Input validation
- Fallback responses

### Advanced Features
- Sentiment detection
- Memory and recall
- Personalised responses
- Topic continuation
- Multiple cybersecurity topics

### Multimedia Features
- Voice greeting using WAV audio
- ASCII art display

### GitHub Features
- GitHub Actions CI workflow
- Multiple commits
- Tagged releases

---

## Cybersecurity Topics Supported

The chatbot can respond to questions about:
- Password safety
- Phishing
- Malware
- Online scams
- Privacy
- Hacking
- Safe browsing
- Social media safety
- Two-factor authentication
- Cybersecurity awareness

---

## Technologies Used

- C#
- WPF
- .NET 8
- Visual Studio 2022
- GitHub Actions

---

## How to Run the Application

### Prerequisites

Install the following:
- Visual Studio 2022
- .NET 8 SDK
- Windows Operating System

---

### Steps to Run

1. Clone the repository:

```bash
git clone https://github.com/inganathi-jpg/CybersecurityChatBot
```

2. Open the solution file in Visual Studio 2022.

3. Build the solution.

4. Run the application.

---

## WAV File Setup

The `greeting.wav` file must be placed inside the project output folder for the voice greeting to work correctly.

Make sure the file property is set to:

```plaintext
Copy to Output Directory = Copy Always
```

---

## Screenshot of Application

PASTE YOUR SCREENSHOT HERE

---

## GitHub Actions CI

The project uses GitHub Actions for Continuous Integration.

---

## Project Structure

```plaintext
CybersecurityChatbot/
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── ChatBot.cs
├── KeywordResponder.cs
├── SentimentDetector.cs
├── MemoryStore.cs
├── App.xaml
├── App.xaml.cs
├── greeting.wav
├── README.md
└── .github/workflows/
```

---

## GitHub Repository

Repository Link:

https://github.com/inganathi-jpg/CybersecurityChatBot

---

## Author

Developed by Inganathi Mancam for PROG6221 Programming 2A.

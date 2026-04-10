# CyberAwareBot

## Overview

CyberAwareBot is a console-based cybersecurity awareness chatbot built in C#. It combines a voice greeting, ASCII art header, personalized user interaction, and an engaging console UI to help users learn about password safety, phishing, and safe browsing.

## Features

- Voice greeting plays when the application starts
- ASCII art logo and stylized console interface
- Personalized welcome prompt using the user's name
- Menu-driven learning sections for password safety, phishing, and safe browsing
- Interactive chatbot mode with cybersecurity answers and follow-up guidance
- Graceful handling of invalid or empty input
- Audio playback via `greeting.wav`
- Clear code structure with separate classes for UI, audio, and chatbot logic

## Project Structure

- `Program.cs` - application entry point, menu, startup flow, and question sections
- `UIHelper.cs` - ASCII art display and welcome screens
- `Chatbot.cs` - interactive chatbot session with personalized responses
- `AudioPlayer.cs` - voice greeting playback logic
- `greeting.wav` - recorded welcome audio file
- `CyberAwareBot.csproj` - project configuration and output settings

## How to Run

1. Open a terminal in the `CyberAwareBot` folder
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

## Usage

- The application plays a voice greeting on launch.
- Enter your name when prompted.
- Choose a menu option:
  - `1` Password Safety
  - `2` Phishing
  - `3` Safe Browsing
  - `4` Chat with Bot
  - `5` Play Greeting
  - `6` Exit
- In chatbot mode, ask questions about cybersecurity or type `play` to hear the greeting again.

## Notes

- The audio playback currently uses `afplay`, which works on macOS.
- `greeting.wav` is included in the project output so playback works at runtime.

## Improvements

Potential enhancements include:

- More advanced natural language conversation handling
- Cross-platform audio playback support
- Additional cybersecurity topics and interactive lessons
- Logging of session activity and user progress

## Contact

This project is designed for cybersecurity awareness and education. If you want to extend it further, add new response patterns, or improve the interactive experience, the code is structured for easy enhancement.

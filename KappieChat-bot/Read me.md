# CyberSecurityBot – C# Console Application

## Project Overview

CyberSecurityBot is a C# Console Application developed using the .NET Framework. The purpose of this application is to create an interactive chatbot that educates users about basic cybersecurity practices while demonstrating fundamental programming concepts.

The chatbot responds to users through a conversational interface, plays a voice greeting at startup, and displays a visually appealing ASCII art logo. It accepts user input, responds to common cybersecurity related questions, and provides guidance on staying safe online. The project also focuses on clean code structure, user interaction, and enhanced console styling.

## Technical Features

The application includes the following key technical features:

* **Voice Greeting**

  * Plays a `.wav` audio file when the application starts using the `System.Media` namespace.

* **ASCII Art Display**

  * Displays a cybersecurity themed logo in the console using multi-line strings.

* **User Interaction**

  * Prompts the user to enter their name and personalizes responses.

* **Chatbot Response System**

  * Handles predefined queries such as:

    * “How are you?”
    * “What is your purpose?”
    * Cybersecurity topics like passwords and phishing

* **Input Validation**

  * Prevents empty input and handles unknown queries gracefully.

* **Enhanced Console UI**

  * Uses colors, formatted text, and typing effects to improve user experience.

* **Typing Animation**

  * Simulates real-time typing using delays (`Thread.Sleep`).

* **Modular Code Structure**

  * Separates logic into multiple classes for better maintainability.

## How to Run the Application

### Prerequisites

* Visual Studio (recommended)
* .NET Framework installed

### Steps

1. Clone or download the project from your repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Ensure the `Greeting.wav` file is placed inside:

   ```
   bin/Debug/
   ```
4. Build the solution:

   ```
   Build → Build Solution
   ```
5. Run the application:

   ```
   Debug → Start Without Debugging (Ctrl + F5)
   ```

### Usage

* Enter your name when prompted.
* Ask questions related to cybersecurity.
* Type **"exit"** to close the application.

## Class Architecture

The project follows a modular object oriented design with the following classes:

### 1. `Program.cs`

* Entry point of the application.
* Responsible for:

  * Playing the greeting audio
  * Displaying ASCII art
  * Initializing user and chatbot objects

### 2. `User.cs`

* Handles user-related data.
* Responsibilities:

  * Captures and validates user name
  * Stores user information for personalization

### 3. `Chatbot.cs`

* Core logic of the application.
* Responsibilities:

  * Manages the conversation loop
  * Processes user input
  * Generates responses
  * Displays styled output and typing effects

### 4. `AudioPlayer.cs`

* Handles audio playback.
* Responsibilities:

  * Loads and plays the `.wav` greeting file at startup

## Project Structure

CyberSecurityBot/
 Program.cs
 Chatbot.cs
 User.cs
 AudioPlayer.cs
 Greeting.wav

## Conclusion

This project demonstrates the use of C# and .NET Framework to build an interactive console-based chatbot. It highlights key programming concepts such as object oriented design, user interaction, input validation, and basic multimedia integration. Additionally, it raises awareness about cybersecurity practices in an engaging and user friendly manner.


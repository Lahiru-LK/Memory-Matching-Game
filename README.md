

# 🧠 Memory Matching Game 🎮

Welcome to the **Memory Matching Game**! This project is a fun and engaging Windows Forms application built using C# in Microsoft Visual Studio 2022 with .NET. The game challenges players to match pairs of cards within a limited amount of time while keeping track of their lives and points. 


![image](https://github.com/user-attachments/assets/a74d7669-7ef1-4748-823b-6966a570f64a)

https://github.com/user-attachments/assets/7f5a8fb7-4758-4f6e-899b-dba90544784b



## 📜 Table of Contents

- [Features](#features)
- [Gameplay](#gameplay)
- [Installation](#installation)
- [How to Play](#how-to-play)
- [Code Highlights](#code-highlights)
- [Credits](#credits)

## 🌟 Features

- 🖼️ **Visuals**: Attractive and colorful game design.
- 🎵 **Sound Effects**: Includes background music and sound effects for card clicks, matches, and game over.
- ⏱️ **Timer**: Players have 60 seconds to complete the game.
- ❤️ **Lives**: Players have 6 lives, losing one for each incorrect match.
- 🔀 **Randomized Cards**: Each game shuffles the card positions for a unique experience every time.

## 🕹️ Gameplay

Match all pairs of cards before time runs out and avoid losing all your lives!

- **Points**: Earn points for each correct match.
- **Lives**: Lose a life for each incorrect match.
- **Timer**: The game ends if the timer reaches zero.

## 🛠️ Installation

1. **Clone the Repository**: Clone the repository to your local machine:
    ```sh
    git clone https://github.com/yourusername/Memory-Matching-Game.git
    ```
2. **Open the Project**: Open the project in Microsoft Visual Studio 2022.
3. **Restore NuGet Packages**: Restore NuGet packages if needed.
4. **Build the Solution**: Build the solution to restore dependencies and resources.

## 🎮 How to Play

1. **Start the Game**: Click the "Start" button to begin.
2. **Match Cards**: Click on cards to reveal their images and try to match pairs.
3. **Points and Lives**: Keep track of your points and lives displayed on the screen.
4. **Win or Lose**: Match all pairs before time runs out or before losing all your lives.

## 💻 Code Highlights

Here are some key parts of the code that make the game work:

### Timer Initialization
```csharp
gameTimer = new System.Windows.Forms.Timer();
gameTimer.Interval = 1000; // 1 second intervals
gameTimer.Tick += timer_Left_Tick;
gameTimer.Start();
```

### Card Click Handling
```csharp
private void pb1_Click(object sender, EventArgs e)
{
    // Play the click sound using a new SoundPlayer instance
    using (SoundPlayer clickSoundPlayer = new SoundPlayer("click_sound_01.wav"))
    {
        clickSoundPlayer.Play();
    }
    
    // Card matching logic...
}
```

### Background Music Setup
```csharp
backgroundMusicPlayer = new WindowsMediaPlayer();
backgroundMusicPlayer.URL = "background_music.wav";
backgroundMusicPlayer.settings.setMode("loop", true);
backgroundMusicPlayer.controls.play();
```

## 📚 .NET Framework Details

This project utilizes the .NET framework to create a Windows Forms application. Here are some key details about the .NET components used:

- **Windows Forms**: The graphical user interface (GUI) of the game is built using Windows Forms, a UI framework for creating Windows desktop applications.
- **System.Drawing**: Utilized for handling images and graphics within the game.
- **System.Media**: Used to incorporate sound effects for various game events.
- **System.Windows.Forms.Timer**: Provides a timer control that triggers events at set intervals, used for the game countdown and other timed actions.
- **Windows Media Player (WMPLib)**: Integrated to play background music throughout the game.

### Example of Using Windows Forms and .NET Components
```csharp
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Memory_Matching_Game
{
    public partial class Form1 : Form
    {
        // Your game logic here...
    }
}
```

## 🙏 Credits

- Developed by [Lahiru Prasad([https://github.com/yourusername](https://github.com/Lahiru-LK/))
- Sound effects from [[Source](https://www.soundsnap.com/)]
- Background music from [[Source](https://www.soundsnap.com/)]

---

Feel free to customize and add any additional details or sections as needed! Let me know if you need any more help.

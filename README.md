# Connect4WinForms

A classic **Connect 4** implementation built using **C#** and **Windows Forms**. This project features a modular design, separating the core game mechanics from the graphical user interface.

## 🚀 Features
* **Player vs. Player:** Play locally with a friend.
* **Player vs. Computer:** Challenge an automated opponent.
* **Customizable Board:** Support for dynamic row and column sizes (as seen in the `GameBoard` constructor).
* **Score Tracking:** Real-time updates for player scores.
* **Visual Feedback:** Interactive UI with smooth game-state transitions.

## 🏗️ Project Structure
The solution is divided into two main projects to ensure a clean **Separation of Concerns**:

* **`Connect4GameLogic`**: A Class Library containing the backend engine. It handles win-detection, player turns, and the internal board state.
* **`Connect4WinFormsUI`**: The Windows Forms front-end. It manages the event-driven UI, including button grids (`m_JitonButtons`) and timers for computer delays.

## 🛠️ Requirements
* **Visual Studio 2019/2022**
* **.NET Framework** or **.NET 6+** (depending on your project target)

## ⚙️ Installation & Setup
1.  **Clone the repository:**
    ```bash
    git clone https://github.com/YourUsername/Connect4WinForms.git
    ```
2.  Open the `Connect4WinForms.sln` file in **Visual Studio**.
3.  Restore NuGet packages (if any).
4.  Press **F5** to build and run the application.

# Bowling VR Game

### Introduction
This is a simple **Bowling VR Game** developed using **Unity 3D** with the **XR Interaction Toolkit**. The game features a basic bowling lane, pins, and a ball that the player can grab, interact with, and throw using VR controls. The project demonstrates fundamental VR interactions like grabbing objects, detecting collisions, and implementing game mechanics such as scoring.

### Features
- Full VR interaction using Unity’s XR Interaction Toolkit.
- Realistic bowling physics with pins and ball interactions.
- Automatic scoring system that counts fallen pins.
- Customizable environment with lighting and skybox effects.
- Audio integration for background music and interactions.

### Project Workflow

#### 1. Setup Unity Project and VR Environment
- Created a Unity project in 3D URP.
- Configured VR environment by installing the XR Interaction Toolkit and XR Plugin Management packages.
- Created necessary VR components like `XR Device Simulator` and `XR Interaction Manager`.

#### 2. Environment Setup
- Added a ground plane and applied a skybox from the Unity Asset Store.
- Created a basic bowling lane and set up materials for the floor and environment.

#### 3. Bowling Pins and Ball
- Imported a bowling pin mesh, adjusted its scale, and added colliders (Capsule and Box Colliders) for accurate collision detection.
- Configured the ball with an `XR Grab Interactable` component, enabling it to be picked up and thrown.

#### 4. Lighting and Shadows
- Adjusted directional lighting to match the scene and applied hard shadows for a realistic environment.

#### 5. Audio Integration
- Added background music and interaction sounds using the Unity Audio Source component. Configured it to play on awake and loop.

#### 6. VR Interaction
- Implemented ball-to-pin interaction with the help of colliders and custom scripts.
- Developed a `Pin Manager` script to detect fallen pins and count them.

#### 7. Scoring Mechanism
- Created a UI text element to display the score.
- Added logic to count fallen pins and update the score based on pin collisions with the ball.

### Screenshots
1. **Game Scene**:  
   ![Game Scene](images/screenshot1)

2. **VR Gameplay**:  
   ![VR Gameplay](images/screenshot2)


### Steps to Run the Game
1. Download and install **Unity 2021** or newer.
2. Clone the repository:
   ```bash
   git clone https://github.com/username/bowling-vr-game.git
3. Open the project in Unity Hub.
4. Ensure the necessary packages (XR Interaction Toolkit, URP, etc.) are installed via Package Manager.
5. Press the Play button to test the game in the Unity Editor or build the project for your VR device.

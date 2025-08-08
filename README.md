![Banner](https://img.itch.zone/aW1nLzIwMDEzNDUyLnBuZw==/original/HTzeDg.png)

# Going Up! - Physics-Based First-Person Platformer

[![Unity](https://img.shields.io/badge/Unity-6000.0.33f1-black.svg?style=for-the-badge&logo=unity)](https://unity.com/)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Status](https://img.shields.io/badge/Status-Game%20Jam%20Complete-red?style=for-the-badge)](https://github.com/Albvasper/GoingUp)

> **A 3D platformer featuring physics based movement and vertical climbing challenges where one wrong step sends you back to the start. Built in Unity during a one-week game jam.**

## Project Overview

This project demonstrates advanced movement programming and rapid prototyping skills through a complete first-person platformer built under tight time constraints. The game challenges players to climb a tall building with precise platforming mechanics, featuring a risk-reward system where falling means likely starting over. Developed as a two-person collaboration focusing on tight controls and satisfying physics-based movement.

### Key Technical Achievements
- **Physics Based Movement System** with realistic momentum and air control
- **Responsive Player Controls** optimized for precision platforming
- **First Person Camera System** with smooth mouse-look and vertical constraints
- **Trigger-Based Event System** for interactive feedback and level progression
- **Performance-Optimized Architecture** maintaining stable framerate during gameplay

## Technical Stack

| **Category** | **Technology** | **Purpose** |
|--------------|----------------|-------------|
| **Engine** | Unity 6000.0.33f1 LTS | Core game development platform |
| **Language** | C# | Primary programming language |
| **Physics** | Unity Rigidbody | Physics-based movement system |
| **Input System** | Unity Input System | Responsive player controls |
| **Architecture** | Component Pattern, Event System | Clean, modular code organization |

## Core Systems Architecture

### Movement Controller Hierarchy
```
PlayerMovement (MonoBehaviour)
├── Physics Integration
│   ├── Rigidbody Control → Custom physics parameters
│   ├── Ground Detection → Reliable surface checking
│   └── Jump Mechanics → Responsive and precise jumping
├── State Management
│   ├── Grounded State → Normal movement and jumping
│   ├── Airborne State → Air control and landing
│   └── Falling State → Reset trigger management
└── Input Handling
    ├── Movement Input → WASD with momentum
    ├── Jump Input → Spacebar with buffering
    └── Camera Input → Mouse look integration
```


## Game Features

### Precision Platforming
- **High Stakes Gameplay**: One mistake sends players back to the beginning
- **Physics Based Movement**: Realistic momentum and air control
- **Responsive Controls**: Zero-latency input with immediate feedback
- **Vertical Challenge**: Building climbing testing patience and skill

### Player Experience
- **Risk vs. Reward**: Strategic decision making for each jump
- **Mastery Through Repetition**: Tight gameplay loop encouraging skill development
- **Satisfying Feel**: Carefully tuned movement physics for optimal player satisfaction

## Project Structure

```
Going Up/
├── Assets/
│   ├── Scripts/
│   │   ├── PlayerMovement.cs                  # Core movement controller
│   │   ├── PlayerCamera.cs                    # First-person camera system
│   │   └── GameStateManager.cs                # Game state and reset handling
│   ├── Prefabs/
│   │   ├── FirstPersonCharacter.prefab        # Player controller prefab
│   ├── Scenes/
│   │   ├── Level.unity                        # Climbing level
│   │   └── MainMenu.unity                     # Menu scene
│   ├── Materials/                             # Visual and physics materials
│   ├── Models/                                # 3D assets
└────── UI/                                    # 2D UI assets
```

## Key Scripts

| Script | Description |
|--------|-------------|
| [`PlayerMovement.cs`](https://github.com/Albvasper/GoingUp/blob/74d82557064b6a2a7d7f2a708615eb2caad17a49/Going%20Up/Assets/Scripts/PlayerMovement.cs) | Handles player movement, jumping, and falling behavior |
| [`PlayerCamera.cs`](https://github.com/Albvasper/GoingUp/blob/74d82557064b6a2a7d7f2a708615eb2caad17a49/Going%20Up/Assets/Scripts/PlayerCamera.cs) | Manages Player camera with smooth mouse-look controls |


## Performance Metrics

- **Development Time**: Game built in one week
- **Team Size**: 2-person collaboration (programmer + 3D artist)  
- **Framerate**: Stable 144+ FPS throughout vertical level
- **Input Latency**: Responsive controls with immediate feedback
- **Code Quality**: Clean, maintainable architecture supporting rapid iteration

## Installation & Setup

### Prerequisites
- Unity 6000.0.33f1 LTS or later
- Visual Studio 2019/2022 or VS Code  
- Git for version control

### Quick Start
```bash
# Clone the repository
git clone https://github.com/Albvasper/GoingUp.git

# Open in Unity
# File → Open Project → Select "Going Up" folder

# Play in Editor  
# Open MainLevel scene and press Play button
```

## Play Game

[![Download on Itch.io](https://img.shields.io/badge/Download-itch.io-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white)](https://albvasper.itch.io/going-up)

## Screenshots

![Gameplay Screenshot](https://img.itch.zone/aW1hZ2UvMzM0NDk0OC8yMTc1MTIzMi5wbmc=/original/6fC%2B8a.png)

![Gameplay Screenshot](https://img.itch.zone/aW1hZ2UvMzM0NDk0OC8yMTc1MTIzMS5wbmc=/original/zxOSSZ.png)

![Gameplay Screenshot](https://img.itch.zone/aW1hZ2UvMzM0NDk0OC8yMTc1MTIzMy5wbmc=/original/UD7gFB.png)

## Technical Highlights

### Advanced Programming Concepts
- **Physics Programming**: Custom movement system balancing realism and responsiveness
- **Component Architecture**: Clean separation of concerns with modular design
- **Event-Driven Systems**: Trigger-based interactions with Unity Events
- **Performance Optimization**: Efficient update cycles and memory management

### Unity Expertise  
- **Rigidbody Mastery**: Deep understanding of Unity's physics system
- **Input System Integration**: Responsive controls with modern Unity input
- **Camera Programming**: Smooth first-person camera with proper constraints
- **Collision Detection**: Reliable trigger and collision systems

### Problem-Solving Skills
- **Rapid Prototyping**: Complete game systems built under tight constraints
- **Cross-Disciplinary Collaboration**: Effective programmer-artist workflow
- **Player Experience Focus**: Feel-first programming prioritizing satisfaction
- **Edge Case Handling**: Robust systems preventing gameplay-breaking bugs

## Contact

**Alberto Vásquez** - Game Programmer  
[albert.vp09@gmail.com]  
[https://codebyalberto.framer.website/]

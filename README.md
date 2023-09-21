# Unity-Secured-Variables

## Description

Provides secured way of storing variables in memory.

Explained more [here](https://www.alanzucconi.com/2015/09/02/a-practical-tutorial-to-hack-and-protect-unity-games/) (in **Hacking into the game’s memory** and **How to protect the memory of your game** topics)

[(link)](https://gamedev.stackexchange.com/questions/48629/how-do-i-prevent-memory-modification-cheats#answer-205541) There are downsides to this:
- Increased RAM usage because of the extra values stored in memory
- Increased CPU usage due to the constant updates of the fake variables
- A Cheater can edit the binary to remove the fake variables
- A Cheater can find the real variable after some time

## Installation

Install via Package Manager from git URL.

## License

This package is licensed under the MIT License, see [LICENSE](./LICENSE) for more information.

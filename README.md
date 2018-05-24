# Wheelchair Experience prototype - Animal Crossing, The Vicious Cycle!
Developed by Joseph Hesketh and Cristiana Pacheco

## Concept
This project aims to provide a proof of concept: representing a wheelchair in a Unity environment with the aid of an arduino, to allow wheelchair users to play VR games. To do so, for the prototype, the concept was simpler: create a miniature of a single wheel, "send" its movement information to Unity and use it to spin a wheel object in the scene. The success of such prototype proves that this could easily be reproduced for two wheels and introduced into a VR game as a form of locomotion.

## Design
The design of the prototype consisted of two parts: manufacturing the wheel and implementing it in a simple game in Unity.

### Wheel
The wheel was to be a one-dimensional controller. We would measure the direction and velocity at which the wheel was spinning. This would be done identically to how rotary encoders measure these values (see Implementation). The direction and velocity would be calculated on an Arduino Uno micro-controller and sent as a string through serial ports to Unity.

### Game
With a wheel that would provide a one dimensional direction (forward or backwards), we needed a simple game in which the player merely goes in one direction. For such, we decided to use something close to Frogger but reskinned - a wheel that has to reach the end of the path while facing obstacles coming from the sides in a random-like order. Hitting these would provide consequences.

## Implementation 

### Wheel
The wheel uses the same principles of measuring angular rotation and velocity as a rotary encoder. The freely rotating wheel (the one that players spin) has equally spaced slits branching from the centre (every 15 degrees). On one side of the wheel is a stationary light emitting diode (LED) while on the other side there are two stationary light receiving diodes (LRDs).

When a slit passes between the LED and LRDs, the LRDs send a value back to the Arduino indicating they have received a large amount of light. The number of these pulses measured within a time frame can provide an approximation to the angular velocity of the wheel. Whilst a single LRD is sufficient to measure the velocity, two LRDs are required to measure the direction the wheel is spinning. By placing the LRDs slightly out of phase (1/4 of a cycle out of phase so that the LRDs are 3.75 degrees apart), we can measure which LRD receives light before the other. The calculation for this is handled by the Arduino Uno and passed to Unity as a string.

### Game
A simple Unity scene was put together called Prototype. It features a basic environment with forestry for decoration. The player - a wheel - starts at the bottom of this track and has to cross to the other end. By rotating the physical wheel, a force is applied to the game wheel prompting it forwards or backwards. Several spawners are showcased at the sides of the game which radomly spawn farm animals within a speed range. All of these features can be adjusted for different dificulties. Animals have different sizes and shapes. If the player gets hit, the wheel will spin which could result in its fall - at which point the player can restart the game or quit - or it could simply change direction - if this is the case, the player can attempt to be hit once again to perhaps get back to its original direction and still try to complete the game. If the player takes too long it can also simply fall, as the wheel is "wobly" on purpose to increase difficulty. 

## Videos

Physical Demo: https://photos.app.goo.gl/RB6864WTT6dOkIVf2

Ingame Footage: https://photos.app.goo.gl/DaLJlCaraAhgu4i13

## To Do in the Future


Here are things to do on the project in general:
- Add a second wheel in the Arduino code.
- Create a physics based wheelchair in Unity.
- Control the wheelchair with both wheels.
- **Get a wheelchair and spend time living in it.**
- **Speak to wheelchair users about their experiences.**
- Connect the controller to the wheelchair.
- Add VR.
- Design the experience for the wheelchair.
- Implement the experience into a game.

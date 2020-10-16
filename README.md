# Axy, the Barbarian

## Part 4

- Refactor your code to implement the Separation of segments of code into their own methods, like Input and Movement and State Updates
- Change your movement codes and timers to use time.deltaTimeso it can take real time into account 

## Part 5

- Add visible walls to your dungeon (at least 4 large walls surrounding most of the area) as Game Objects
- Detect when the player collides into an enemy or wall, and prevent him from moving in that direction
- Make the game play a sound when this happens
- PRO TIP: You can use EditorApplication.Beep() for a beep sound
- You can use AudioSourcecomponents with specific clips to play when there’s a collision with AudioSource.Play()
- Use 2D colliders for the sake of collision
- void OnCollisionEnter2D() is your friend
- If it’s not detecting the collision, add a “Rigidbody2D” to the player that is set to “dynamic” with gravity = 0
- Make sure the walls are visible
# Axy, the Barbarian

## Part 1, Moving Around

Goal: game must have a simple avatar that can move around the console (can be a square or circle)
Use arrow keys (or WASD) to move
Write all code in one file, do not write extra scripts, code it as simple as possible
Bonus: change background or character color

Do not use: Physics.Rigidbody2D for now
- Use transforms instead

Methods and properties to use:
- Input.GetKey(Keycode) 
- new Vector2(x,y)
- transform.Translate(Vector2)

Optional
- Change Background Color
- Change avatar Color
- Make movement speed a variable

## Part 2, Adding an enemy: a blind gazer

Adding an enemy: a blind gazer
- Build on previous game
- Gazer will be patrolling an area
- Moving from top to bottom, then back from bottom to top, from position (2, -3) to (2, 3) and back
- You also have tobe able to move your main character around
- Use only one script for the Gazer

PRO TIP: you may need to use a state tracker:
- Moving up or down with a boolean

Problems found?
- We block inputs from player if not careful
- We have tocontrol the speed of objects (too fast if set to 1)

## Part 3, Adding an enemy: a drunk skeleton archer, stationary enemy that shoots projectiles

Projectile will show up as a sprite that appears randomly anywhere within a 3 unit radius
- When a new arrow is shot, the previous one disappears
- Frequency of shooting has tobe offset from speed of the blind gazer’s movement
- Use GameObject.Instantiate() for the arrow
- PRO TIP: you can use Random.Range() method for the random location generation

Problems encountered?
- Code to update state is getting longer and mixed up
- Will get hard to maintain

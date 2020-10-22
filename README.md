# Axy, the Barbarian

## Part 6

- Implement the Component pattern for your Playergame object
    - Components must communicate by “modifying other components”
    - You must create an InputController, a PhysicsController, StateControllerand an AudioController(with an AuidoSourceComponent)
    - transform.GetComponent<Component>() is useful here
- Protip:In the Start() method, Get the components

## Part 7

- Implement the Component pattern for all ofyour objects
    - There should only be scripts and components
    - Skeleton must have a shooting script, and a timing script 
    - Gazer must have a movement script and an update state script2.
- Add a win condition: when a player reaches/collides with a new “exit” object3
- Add a lose condition: If a player and an enemy/arrow collide, the game ends/restarts
- Tips:
    - One generic script may be enough to be used by several objects, but only if truly generic.
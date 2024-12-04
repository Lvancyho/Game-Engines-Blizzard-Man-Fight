# Game Engines Blizzard Man Fight
 
Diagrams:

![image](https://github.com/user-attachments/assets/bed9c9cd-50e9-41c2-bea3-421c51fdd122)


What was done:
Player spawns with snowflakes, singleton makes sure only one game manager is activated at all times, object pooling works ish? (destroying game objects bugged so not really) WASD to move

How it was done:
Game Manager: Makes sure only one is active at a time and if theres more then one then it destroys the duplicates.
Snowflakes: Randomly spawns every 2~ seconds, spawns randomly on the map. Initially loads with 10 unactive snowflakes and if theres snowflakes in the pool then it spawns from the pool and if not then it creates more to add towards the pool.

Why it was done:
Snowflake optimization or else the game will get really laggy over time.
Game manager singleton created because every game should have one otherwise bugs may occure and memory may be overloaded.

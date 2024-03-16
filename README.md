# 10-Spatial-Partitioning
This tutorial is inspired by the Spatial Partitioning sections presented in Robert Nystrom's Game Programming Patterns. The book has lots of great game dev programming theory and is officially online for free! You should, at least briefly, [check it out](https://gameprogrammingpatterns.com/contents.html).

In the past, I have presented you with many step-by-step tutorials to achieve certain goals, but for the upcoming assessment you need to be comfortable progamming your own solutions. Because of this, I have set some optimisation challenges for you. Don't be afraid to Google, Stack Overflow, use [the Programming Patterns book](https://gameprogrammingpatterns.com/contents.html), or even GPT (use [Bing Chat](https://www.bing.com/chat) if you do, it's a more powerful system than ChatGPT) to find your solution.

Some of today's work is in Unity 🙌 but the theory will carry across to Python... I also hope there's a chance what you create will be useful for your major project.

## Challenges
### 1a (using Unity)
1. Open the Unity project. This contains cylinders spaced out on a plane and a player that you can move across the 2D plane. Currently, the script contains a list of the positions of all the cylinders, finds the nearest one, then rotates to face it.
2. Optimise the scene by splitting the plane into a grid and creating multiple lists (rather than one big list) with the positions of the cylinders located inside each cell. Then check the position of the player and find what position it is in. If it is in cell coordinate (0, 0), then only check which cylinder is nearest by checking against the cylinders in that cell. 
<div align="center">
  <a href="Images/Challenge One.PNG" target="_blank">
    <img src="Images/Challenge One.PNG"/>
  </a>
</div>

#### 1b (alternate challenge (similar idea to 1a))
1. Beginning with the provided Unity project, attach audio sources to each of the cylinders and attach some audio of your choosing to them (I gave a whole list of free audio sources in [Week 2](https://github.com/danmilneusw/02-Audio). Make it so that the volume of the audio is based on the distance from the player. Specifically, the volume is max when the player is very close and silent when the player is more than X (whatever you want) units away. Make sure your audio receiver is positioned on the player, not the camera. Test it out, does it work?
2. Optimise this scene by only updating the audio source's volume if the player camera is positioned on a grid near the audio source. To do this, split the scene into a 2D grid. Make a script that checks which cell the camera is in. Create a list that contains the cell grid the audio source is in. If the camera is in cell coordinate (0, 0), then check the distance to only the audio sources that are in cell coordinate (0,0).

### 2 (using Python)
1. Load the Pygame Jet_Game from [Week 9 - DLSS](https://github.com/danmilneusw/08-DLSS). The current system constantly checks if the jet is colliding with all missiles.
2. Optimise the game by splitting the viewport into an invisible grid (or visible for testing purposes). If the jet is inside cell coordinate (0, 0), then check for collisions only with missiles inside the same cell. Unlike in Challenge 1, there are moving objects in this example (the missiles), so this will be a more challenging implementation.
<div align="center">
  <a href="https://github.com/danmilneusw/08-DLSS/blob/main/Extra/image.png?raw=true" target="_blank">
    <img src="https://github.com/danmilneusw/08-DLSS/blob/main/Extra/image.png?raw=true"/>
  </a>
</div>

## Extra Resources
- [Programming Patterns (Official): Spatial Partitioning](https://gameprogrammingpatterns.com/spatial-partition.html)
### Grid
- [Programming Patterns: Spatial Partitioning](https://www.habrador.com/tutorials/programming-patterns/19-spatial-partition-pattern/)
### Quad-tree
- [Quad-tree in 22 Lines of Code](https://lisyarus.github.io/blog/programming/2022/12/21/quadtrees.html)
- [In-depth Stack Overflow Discussion](https://stackoverflow.com/questions/41946007/efficient-and-well-explained-implementation-of-a-quadtree-for-2d-collision-det)

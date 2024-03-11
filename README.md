# 10-Spatial-Partitioning
This tutorial is inspired by the Spatial Partitioning sections presented in Robert Nystrom's Game Programming Patterns. The book has lots of great game dev programming theory and is officially online for free! You should, at least briefly, [check it out](https://gameprogrammingpatterns.com/contents.html).

In the past, I have presented you with many step-by-step tutorials to achieve certain goals, but for the upcoming assessment you need to be comfortable progamming your own solutions. Because of this, I have set some optimisation challenges for you. Don't be afraid to Google, Stackoverflow, use [the Programming Patterns book](https://gameprogrammingpatterns.com/contents.html), or even GPT (use [Bing Chat](https://www.bing.com/chat) if you do, it's a more powerful system than ChatGPT) to find your solution.

Today's work is back in Unity but the theory will carry across to Python... I also hope what you create will be useful for your major project.

## Challenges
### One
1. Create a new Unity project where the player camera can move (use the below camera script unless you want to make your own). Position audio sources randomly around the scene (maybe position them on cubes placed on a plane so it's easy to see where they are) and attached some audio of your choosing to them (I gave a whole list of free audio sources in [Week 2](https://github.com/danmilneusw/02-Audio). Make the audio source 2D and set the volume based on the distance from the player. Make it so that the volume is max when the player is very close and silent when the player is more than 5 units away. Test it out, does it work?
2. Optimise this scene by only updating the audio source's volume if the player camera is positioned on a grid near the audio source. To do this, split the scene into a 2D grid. Make a script that checks which cell the camera is in. Create a list that contains the cell grid the audio source is in. If the camera is in cell coordinate (0, 0), then check the distance to only the audio sources that are in cell coordinate (0,0).

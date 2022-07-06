# Game Loop Variables!
This page contains info on the variables in the GameLoop class.


### Time
A time manager that keeps track of the passage of time within the game.
Lets you see how long the game has been running, the total time between this frame and the last (deltaTime), etc.
Structured after Unity's Time class.


Code example:
```cs
float deltaTime = GameLoop.Time.DeltaTime; // time between this frame and the last.
long totalSeconds = GameLoop.Time.TotalSeconds; // total seconds since the game started.
```



### LoopCount
Shows how many frames have passed since the game started.
Each time the Game Loop runs it will increase by 1.


Code example:
```cs
long frameCount = GameLoop.LoopCount; // how many times the loop ran (number of frames)
```
# PathfindingAStar

![Pathfinding15](https://github.com/TrongHieu90/PathfindingAStar/blob/master/ImgDocs/Pathfind_grid_15.jpg)
![Pathfinding30](https://github.com/TrongHieu90/PathfindingAStar/blob/master/ImgDocs/Pathfind_grid_30.jpg)

### Translation of p5/javascript code from the CodingTrain channel into Windows Form with C#

**Video tutorial is from this link**
https://www.youtube.com/watch?v=aKYlikFAV4k

The main algorithm is inside the form.cs file. There are some modifications to make it work inside Windows Form (which makes you appreciate the p5 library even more with how it simplifies things)

Because we can move diagonally in any direction, the heuristic function is Euclidean distance which yields accepted running time. There are many other heuristic algorithms inside the source to be implemented and further developed.

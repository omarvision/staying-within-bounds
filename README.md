# staying-within-bounds
So you are making a 3D game and you are wondering how do I keep my players and gameobjects from moving right off the screen -or- from moving off the world?  You can do it a number of ways. I used my imagination and came up with two ways.   1st way I tried was placing some walls around my scene that the player would collide with and no be able to pass. I can make the walls invisible by turning off the mesh renderer.  2nd way is a little more thoughful. I use an very large 3D object to encase my scene within. Then I use the Is Trigger flag on the collider. I detect when the player exits the object and push player back in.  Check out the video to see how I did both ways...

YouTube:   https://youtu.be/jxsSvXRnA6Y

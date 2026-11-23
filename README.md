# MG7
## Devlog
Write your Devlog here. :3

The function of this TreeOfBirds script is to detect the player. The sparrow will get out while player is near the trees base on the distance set inside the inspector. 

This scripet use a array to store the sparrow game objects of sparrow without the Sparrow_Start. Thus, in every frame every birds will be check one by one by the script.

Also, it uses vector3 to deal with the position and distance. Vector3 firstly record the sparrow and player's position and use Vector3.Distance() to calculate the distance between them. In this case, when the interact distant's conditions have been met. The sparrow will unlock unhide.


## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models

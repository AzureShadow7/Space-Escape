# Space-Escape
This project is a first person shooter style game.
The game is currently in development and below are the features that the game intends to have

### Intended Game Features
- Player Movement
- First Person Camera
- Player aiming and shooting
- Player UI i.e health, ammo, abilities available
- World Interactions
- Enemy detection by player
- Player detection by enemy
- Enemy AI and states

## Development
### Player Movement
The first part of the project's development was allowing the player to move freely around the game world and having it so the player moves in the direction that the player / the player camera is facing.
![Look Around](https://github.com/AzureShadow7/Space-Escape/assets/106389001/7ef6bc1e-2f00-40b6-8cc4-d20ca9682b42)
![Move Around](https://github.com/AzureShadow7/Space-Escape/assets/106389001/7a72a8b0-fdfe-4d6b-9041-424d6d627855)
This movement is done through the player's mouse and keyboard for the camera and player respectively. The inputs given are done using Unity's new input system.
![image](https://github.com/AzureShadow7/Space-Escape/assets/106389001/6857e51f-bed7-47df-9152-2e0a044f7d36)
![image](https://github.com/AzureShadow7/Space-Escape/assets/106389001/e20a5d6d-c21d-4c3c-b9e1-725cc161222d)
![image](https://github.com/AzureShadow7/Space-Escape/assets/106389001/97327057-14c8-40f6-bb7b-fc7f7b363e0f)

### Aiming and Shooting
The first person shooter aspect of the game means that the player's camera is what the player used to look around as well as to aim in order to shoot the enemies. This brought about the need for a cross hair to be placed on the camera to allow the player to aim at their intened target.
The cross hair is a UI eleement that is drawn in the very centre of the screen by taking half the screen height and width to get the centre point, the next part of this is to have a projectile shot from the player's weapon to the space the crosshair is overlapped with, this part has not been implemented yet.

### Enemy detection
This is currently being worked on but the idea is that the player will push a button and have a scan of the area which will reveal enemeies within a certain radius, making the enemy visible through walls and this effect will last for a certain duration.
To create this effect a shader on the camera will be used to create a different visual effect in the game world that highlights the enemies and dulls out other assets in the scene.

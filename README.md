# Game Engine Exam Final

Build has been shared via Google Drive below - this was due to size issues when submitting as a zipped release.

Google Drive:

Implementations:
- AudioManager (Singleton)
Inherits from the Singleton class, and in the PlaySFX() method, it checks if there is an Audio Source, returns null if not, otherwise plays the audio. This simply helps with debugging should there be any issues with sounds being played, and can be called from anywhere. In this scenario, it is used during bullet firing (SFX is of my own creation).

- Bullet Functionality (Singleton/Object Pooling)
Created classes Bullet (stores bullet velocity as a vector and uses an OnCollisionEnter2D() to check if the bullet collides with anything), BulletPool (Creates a pool of bullets using a queue and int poolSize, returns using ReturnBullet();, setting it inactive and returning it to the queue, and gives a bullet using GetBullet();, setting it active), and PlayerShooting, which takes a transform variable to set the bullet's initial location to (in this case, the Shooter gameObject), plays SFX with the help of AudioManager, and fires the bullet on the Y-Axis from the spawn location. These were done to improve performance as the bullets are dynamic objects that would've been constantly created and destroyed in the scene.

- Target Functionality
This moves the target side-to-side on the X-Axis using Update(), and stores an OnCollisionEnter2D() to check if the target collides with anything tagged "Wall". Upon hitting the wall, the speed's value is changed to negative, which is how the target moves back and forth. This was done to simplify the movement of the target - instead of moving it a set distance, it checks for something to collide with.



Attempted Implementations:
- ShootSwitch (Command)
This was to use a command pattern to switch the firing from vertical to horizontal, by changing the vector created in PlayerShooting once the target was destroyed. This would've been called from a ShootSwitchCommand class, which had its Execute() function called from the Target class, modifying it in PlayerShooting to change the vector.

- Target Spawn/Pooling (Object Pooling)
This was to initialize and spawn a pool of targets in the scene, allowing for ease if desiring to create multiple targets. This is very similar to my BulletPool implementation. However, my implementation affected the bullet velocities, so was commented out.


Command Diagram:
![image](https://github.com/user-attachments/assets/a9591c64-d9b5-4335-82a6-80ee65a6691b)


using UnityEngine;

public class ShootSwitchCommand : Command
{
    public override void Execute()
    {
        //PlayerShooting.SpawnBullet(new Vector2(10f, 0));
    }

    // Update is called once per frame
    public override void Undo()
    {
        //nothing
    }
}

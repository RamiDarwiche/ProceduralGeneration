using UnityEngine;

public class DefaultWallStrategy : WallsStrategy
{
    public override Wall[] GenerateWalls(BuildingSettings settings, RectInt bounds, int level)
    {
        return new Wall[(bounds.size.x + bounds.size.y) * 2];
    }
}

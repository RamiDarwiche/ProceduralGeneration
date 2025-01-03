using UnityEngine;

public class DefaultRoofStrategy : RoofStrategy
{
    public override Roof GenerateRoof(BuildingSettings settings, RectInt bounds)
    {
        return new Roof();
    }
}

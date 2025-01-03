using UnityEngine;

public abstract class WingStrategy : ScriptableObject
{
    public abstract Wing GenerateWing(BuildingSettings settings, RectInt bounds, int numberOfStories);

}

using UnityEngine;

public abstract class StoriesStrategy : ScriptableObject
{
    public abstract Story[] GenerateStories(BuildingSettings settings, RectInt bounds, int numberOfStories);

}

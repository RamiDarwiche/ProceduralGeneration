using UnityEngine;

public class DefaultStoryStrategy : StoryStrategy
{
    public override Story GenerateStory(BuildingSettings settings, RectInt bounds, int level)
    {
        return new Story(level, settings.wallsStrategy != null ? 
        settings.wallsStrategy.GenerateWalls(settings, bounds, level) : 
        ((WallsStrategy)ScriptableObject.CreateInstance<DefaultWallStrategy>()).GenerateWalls(settings, bounds, level));
    }
}

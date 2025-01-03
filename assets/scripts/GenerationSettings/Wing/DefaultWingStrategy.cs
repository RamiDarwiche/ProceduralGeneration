using UnityEngine;

public class DefaultWingStrategy : WingStrategy
{
    public override Wing GenerateWing(BuildingSettings settings, RectInt bounds, int numberOfStories)
    {
        return new Wing(bounds,
        settings.storiesStrategies != null ? settings.storiesStrategies.GenerateStories(settings, bounds, numberOfStories) : ((StoriesStrategy)ScriptableObject.CreateInstance<DefaultStoriesStrategy>()).GenerateStories(settings, bounds, numberOfStories),
        settings.roofStrategy != null ? settings.roofStrategy.GenerateRoof(settings, bounds) : ((RoofStrategy)ScriptableObject.CreateInstance<DefaultRoofStrategy>()).GenerateRoof(settings, bounds));
    }
}

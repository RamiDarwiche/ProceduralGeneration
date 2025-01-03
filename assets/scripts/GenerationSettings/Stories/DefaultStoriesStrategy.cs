using UnityEngine;

public class DefaultStoriesStrategy : StoriesStrategy
{
    public override Story[] GenerateStories(BuildingSettings settings, RectInt bounds, int numberOfStories)
    {
        Story[] stories = new Story[numberOfStories];

        for (int i = 0; i < numberOfStories; i++)
        {
            stories[i] = settings.storyStrategy != null
                ? settings.storyStrategy.GenerateStory(settings, bounds, i)
                : ((StoryStrategy)ScriptableObject.CreateInstance<DefaultStoryStrategy>())
                    .GenerateStory(settings, bounds, i);
        }

        return stories;
    }
}

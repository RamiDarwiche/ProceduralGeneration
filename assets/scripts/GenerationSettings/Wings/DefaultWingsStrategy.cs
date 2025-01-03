using UnityEngine;

public class DefaultWingsStrategy : WingsStrategy 
{

public override Wing[] GenerateWings(BuildingSettings settings)
    {
        return new Wing[] {
            settings.wingStrategy != null ? settings.wingStrategy.GenerateWing(settings, new RectInt(0, 0, settings.Size.x, settings.Size.y), settings.StoryCount) :
            ((WingStrategy)ScriptableObject.CreateInstance<DefaultWingStrategy>()).GenerateWing(settings, new RectInt(0,0, settings.Size.x, settings.Size.y), settings.StoryCount) 
             };
    }

}


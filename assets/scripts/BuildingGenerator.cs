using UnityEngine;

public static class BuildingGenerator
{
    public static Building Generate(BuildingSettings settings)
    {
        
        Building building = new Building(settings.Size.x, settings.Size.x, settings.wingsStrategy != null ? 
        settings.wingsStrategy.GenerateWings(settings) : 
        ((WingsStrategy)ScriptableObject.CreateInstance<DefaultWingsStrategy>()).GenerateWings(settings));
     
        return building;
    }
}

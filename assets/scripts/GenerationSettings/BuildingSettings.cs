using UnityEngine;

[CreateAssetMenu(menuName = "Building Generation/Building Settings")]
public class BuildingSettings : ScriptableObject
{
    [Range(1, 1000)] public int seed = 500;
    [Range(1, 100)] public int buildingWidth = 10;
    [Range(1, 100)] public int buildingHeight = 10;
    [Range(1, 4)] public int storyCount = 1;

    public RoofStrategy roofStrategy;
    public WallsStrategy wallsStrategy;
    public StoryStrategy storyStrategy;
    public StoriesStrategy storiesStrategies;
    public WingStrategy wingStrategy;
    public WingsStrategy wingsStrategy;
    public DuctStrategy ductStrategy;


    public Vector2Int Size => new Vector2Int(buildingWidth, buildingHeight);
    public int StoryCount => storyCount;

    private void OnValidate()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorUtility.SetDirty(this);
        #endif
    }
}

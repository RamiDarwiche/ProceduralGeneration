using System.Collections.Generic;
using UnityEngine;

public class BuildingDemo : MonoBehaviour
{
    public BuildingSettings settings;

    private Vector2Int previousSize;
    private int previousStories;
    private List<GameObject> generatedObjects = new List<GameObject>();

    void Start()
    {
        GenerateAndRenderBuilding();
        previousSize = settings.Size;
        previousStories = settings.StoryCount;
    }

    void Update()
    {
        if (previousSize != settings.Size || previousStories != settings.StoryCount)
        {
            GenerateAndRenderBuilding();
            previousSize = settings.Size;
            previousStories = settings.StoryCount;
        }
    }

    private void GenerateAndRenderBuilding()
    {
        ClearGeneratedObjects();

        Building b = BuildingGenerator.Generate(settings);
        BuildingRenderer renderer = GetComponent<BuildingRenderer>();
        renderer.Render(b);

        foreach (Transform child in transform)
        {
            generatedObjects.Add(child.gameObject);
        }

        Debug.Log($"Building updated: {b}");

    }

    private void ClearGeneratedObjects()
    {
        foreach (GameObject obj in generatedObjects)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }

        generatedObjects.Clear();
    }
}

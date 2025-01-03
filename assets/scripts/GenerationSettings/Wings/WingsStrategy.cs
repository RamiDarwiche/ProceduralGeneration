using UnityEngine;

public abstract class WingsStrategy : ScriptableObject
{
    public abstract Wing[] GenerateWings(BuildingSettings settings);

}

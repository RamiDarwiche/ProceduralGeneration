using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class DuctStrategy : ScriptableObject
{
    public abstract List<DuctSystem> GenerateDuctSystems(BuildingSettings settings);
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Building Generation/Duct Strategy/Default Duct Strategy")]
public class DefaultDuctStrategy : DuctStrategy
{
    public override List<DuctSystem> GenerateDuctSystems(BuildingSettings settings)
    {
        var ductSystem = new DuctSystem(DuctSystemType.SupplyAir);
        
        // Example: Generate ducts procedurally based on building size
        for (int i = 0; i < settings.Size.x; i++)
        {
            for (int j = 0; j < settings.Size.y; j++)
            {
                Vector3 startPos = new Vector3(i * 3f, 2f, j * 3f);
                Vector3 endPos = startPos + new Vector3(1.5f, 0f, 0f);
                ductSystem.AddDuct(new Duct(5, 5, startPos, endPos, DuctType.Rectangular ));
            }
        }
        
        return new List<DuctSystem> { ductSystem };
    }
}

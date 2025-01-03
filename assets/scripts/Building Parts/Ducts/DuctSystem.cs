using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Controls;
public class DuctSystem 
{
    DuctSystemType type;
    List<Duct> ducts;
    int ductCount;

    public DuctSystemType Type { get => type; }
    public List<Duct> Ducts { get => ducts; }
    public int DuctCount { get => ductCount; }

    public DuctSystem(DuctSystemType type = DuctSystemType.SupplyAir) 
    {
        this.type = type;
    }

    public void AddDuct(Duct duct)
    {
        ducts.Add(duct);
        ductCount+= 1;
    }

    public override string ToString()
    {
        string ductSystem =  "Duct System: " + type.ToString() + "\n";
        foreach (Duct d in ducts)
        {
            ductSystem += "\t" + d.ToString() + "\n";
        }
        return ductSystem;
    }
}

public enum DuctSystemType 
{
    SupplyAir,
    ReturnAir,
    ExhaustAir
}
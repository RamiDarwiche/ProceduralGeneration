using UnityEngine;

// how to handle transitions?
public class Duct
{
    Vector2Int size; // for round ducts, radius = x
    Vector3 startPos;
    Vector3 endPos;
    DuctType type;
    Duct[] connections;

    public Vector2Int Size { get => size; }
    public Vector3 StartPos { get => startPos; }
    public Vector3 EndPos { get => endPos; }
    public DuctType Type { get => type; }
    public Duct[] Ducts { get => connections; }

    public Duct(int sizeX=5, int sizeY=0, Vector3 startPos=default(Vector3), Vector3 endPos=default(Vector3) , DuctType type=DuctType.Rectangular, Duct[] connections = null) {
        size = new Vector2Int(sizeX, sizeY);
        this.startPos = startPos;
        this.endPos = endPos;
        this.type = type;
        this.connections = connections;
    }

    public override string ToString()
    {
        int i = 1;
        string duct = "Duct starting at: " + startPos.ToString() + " and ending at: " + endPos.ToString() + "\n";
        duct += "of type: " + type + " with size: " + size + "\n Connections: \n";
        foreach(Duct d in connections) {
            duct += "\t Connection " + i + " Start: " + d.startPos.ToString() + " End: " + d.endPos.ToString()
             + " Size: " + d.size + " Type: " + d.type + "\n";
            i++;
        }
        return duct;
    }
}

public enum DuctType
{
    Rectangular,
    Round,
    Flex
}
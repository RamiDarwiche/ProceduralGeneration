using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuctTransition
{
    public Duct StartDuct { get; }
    public Duct EndDuct { get; }
    public Vector3 Position { get; }
    public DuctType Type { get; }

    public DuctTransition(Duct start, Duct end, Vector3 position, DuctType type)
    {
        if (!CanConnect(start, end))
            throw new ArgumentException("Ducts cannot connect due to incompatible properties.");

        StartDuct = start;
        EndDuct = end;
        Position = position;
        Type = type;
    }

    private bool CanConnect(Duct start, Duct end)
    {
        // Example rules for connection
        return start.Type == end.Type &&
               (start.Size == end.Size || start.Type == DuctType.Flex || end.Type == DuctType.Flex);
    }
}

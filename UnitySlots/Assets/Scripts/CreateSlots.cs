using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSlots : MonoBehaviour
{
    public int pillars;
    public int lines;

    public float tileCellSizeX;
    public float tileCellSizeY;

    public Lines line;
    public Pillar pillar;

    private void Awake()
    {
        line.tileCellSize = tileCellSizeX;
        pillar.tileCellSize = tileCellSizeY;

        line.numberOfPillar = pillars;
        pillar.numberOfElement = lines;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public GameObject slotPrefab;
    public int numberOfElement;
    public List<GameObject> slotList;
    public Transform slotContainer;
    public float tileCellSize;

    private void Start()
    {
        slotList = new List<GameObject>();
        InstantiatePillar();
    }

    public void InstantiatePillar()
    {
        var posX = slotContainer.position.x;
        var posY = slotContainer.position.y;
        for (int i = 0; i < numberOfElement + 2; i++)
        {
            var slots = Instantiate(slotPrefab, slotContainer);
            slots.transform.position = new Vector2(posX, posY - (i * tileCellSize));
            slotList.Add(slots);
        }
    }
}

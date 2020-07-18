using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lines : MonoBehaviour
{
    public GameObject pillarPrefab;
    public int numberOfPillar;
    public List<GameObject> pillarList;
    public Transform pillarContainer;
    public float tileCellSize;
    private void Start()
    {
        pillarList = new List<GameObject>();
        InstantiateLines();
    }

    public void InstantiateLines()
    {
        var posX = pillarContainer.position.x;
        var posY = pillarContainer.position.y;
        for (int i = 0; i < numberOfPillar; i++)
        {
            var pillars = Instantiate(pillarPrefab, pillarContainer);
            pillars.transform.position = new Vector2(posX + (i * tileCellSize), posY);
            pillarList.Add(pillars);
        } 
    }
}

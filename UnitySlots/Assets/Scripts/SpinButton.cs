using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinButton : MonoBehaviour
{
    public GameObject[] slots;
    public bool isSpinned = false;
    private void Start()
    {
        
    }

    public void Spin()
    {
        
    }
    private void Update()
    {
        slots = GameObject.FindGameObjectsWithTag("Slot");
        if (isSpinned)
        {
            foreach(GameObject slot in slots)
            {
                slot.transform.position = new Vector2(slot.transform.position.x, slot.transform.position.y -0.1f * Time.deltaTime);
            }
        }
    }
}

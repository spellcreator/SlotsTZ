using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private SpriteRenderer image;
    public Elements element;
    private void Awake()
    {
        image = GetComponent<SpriteRenderer>();
        image.sprite = element.image;
    }

    private void Update()
    {
        if(element.isSpined == true)
        {
            image.sprite = element.spinedImage;
        }
        else
        {
            image.sprite = element.image;
        }
    }
}

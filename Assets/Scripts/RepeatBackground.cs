using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public float scrollSpeed = 2f;
    private float spriteWidth;

    void Start()
    {
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x + spriteWidth <= 45)
        {
            transform.position = new Vector3(100f + spriteWidth / 2, transform.position.y, transform.position.z);
        }
    }
}


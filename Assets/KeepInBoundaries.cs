using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInBoundaries : MonoBehaviour
{
    //Screen boundaries variables
    private Vector2 screenBoundaries;

    //Variables to hold properties of parent sprite
    private SpriteRenderer parentSprite;
    private float spriteHeight;
    private float spriteWidth;
    private Vector3 netPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the screen boundaries
        screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Get the parent's height and width
        parentSprite = transform.GetComponent<SpriteRenderer>();
        spriteWidth = parentSprite.bounds.extents.x;
        spriteHeight = parentSprite.bounds.extents.y;
    }

    // Late update
    void LateUpdate()
    {
        //Get the current position of the net
        netPosition = transform.position;

        //Clamp the position to within the boundaries of the screen
        netPosition.x = Mathf.Clamp(netPosition.x, screenBoundaries.x * -1 + spriteWidth, screenBoundaries.x - spriteWidth);
        netPosition.y = Mathf.Clamp(netPosition.y, screenBoundaries.y * -1 + spriteHeight, screenBoundaries.y - spriteHeight);

        //Set this as our position
        transform.position = netPosition;
    }
}

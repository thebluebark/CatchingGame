using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    //Used to kill only bombs or fish when they pass the floor
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Fish" || collision.tag == "Bomb")
        {
            Destroy(collision.gameObject);
        }
    }
}

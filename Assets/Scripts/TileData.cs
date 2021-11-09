using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData : MonoBehaviour
{
    public bool tileSpeed;
    public int gridX;
    public int gridY;
    public BoxCollider2D collidertop;
    public BoxCollider2D colliderbottom;
    public BoxCollider2D colliderleft;
    public BoxCollider2D colliderright;

    public void OnMouseDown()
    {
        Debug.Log(gridX + ", " + gridY);
    }
}

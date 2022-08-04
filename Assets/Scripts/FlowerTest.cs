using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTest : MonoBehaviour
{
    public GameObject flowerColor;
    private Collider2D flowerWhite;


    private void Start()
    {
        flowerWhite = GetComponent<Collider2D>();
    }


    public void  ActivateFlower()
    {
        flowerColor.gameObject.SetActive(true);
        flowerColor.transform.position = new Vector3(MouseManager.instance.MouseWorldPos.x, MouseManager.instance.MouseWorldPos.y, 0);
    }

}

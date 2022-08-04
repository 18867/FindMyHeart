using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseManager : MonoBehaviour
{
    public static MouseManager instance;

    private bool canClick;
   
    public Vector3 MouseWorldPos => Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

    private void Awake()
    {
        instance = this;
    }


    private void Update()
    {
        canClick = ObjectAtMousePosition();//这个方法每一帧都会执行
        

        if (canClick && Input.GetMouseButtonDown(0))
        {
            Debug.Log("点到啦");
            ClickAction(ObjectAtMousePosition().gameObject);
        }

    }




    private void ClickAction(GameObject clickObject)
    {
        switch (clickObject.tag)
        {
            /*case "Flower":
                Debug.Log("点到flower了");
                var flower = clickObject.GetComponent<FlowerTest>();
                flower?.ActivateFlower();*/
            case "Heart":
                Debug.Log("You have touched my heart");
                var heart = clickObject.GetComponent<Heart>();
                heart?.ActivateHeart();
                break;
           
        }
    }

    private Collider2D ObjectAtMousePosition()
    {

        return Physics2D.OverlapPoint(MouseWorldPos);
    }


}

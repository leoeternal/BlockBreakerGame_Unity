using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    float minX=1f;
    float maxX=15f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.mousePosition.x / Screen.width * screenWidthInUnits);
        float mousePositionX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePosition=new Vector2(transform.position.x,transform.position.y);
        paddlePosition.x=Mathf.Clamp(mousePositionX,minX,maxX);
        transform.position=paddlePosition;
    }
}

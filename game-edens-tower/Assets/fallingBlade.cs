using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBlade : MonoBehaviour
{
    Vector3 deltaPost=new Vector3();
    Vector3 currentSpeed=new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //caida libre
        //Yf= y0+V0y * tiempo + (aT^2)/2
        deltaPost.y=currentSpeed.y*Time.deltaTime+Physics.gravity.y*Mathf.Pow(Time.deltaTime,2)/2;
        gameObject.transform.Translate(deltaPost);   
        currentSpeed+=Physics.gravity*Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Ground")){
            Destroy(gameObject);
        }
    }

}

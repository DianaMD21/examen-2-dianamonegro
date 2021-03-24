using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingTrapController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject secondLimit;
    public GameObject thirdLimit;
    public GameObject player;
    public GameObject trapToFall;
    Vector3 startingPosition=new Vector3(0,4.5f);
    float lastTime=0,nextTime;
    const float MIN_TIME=0.5f, MAX_TIME=1f;
    float MIN_X=0,MAX_X=0;

    void Start()
    {
        nextTime=Time.time+(Random.Range(MIN_TIME,MAX_TIME));
        MIN_X=secondLimit.transform.position.x;
        MAX_X=thirdLimit.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(secondLimit.activeSelf==false && thirdLimit.activeSelf){
            if(Time.time>nextTime){
                startingPosition.x=Random.Range(MIN_X,MAX_X);
                Instantiate(trapToFall,startingPosition,Quaternion.identity);
                nextTime=getNextTime();
            }
        }
        if(player.transform.position.x>=(thirdLimit.transform.position.x-1)){
            thirdLimit.SetActive(false);
        }
    }
    float getNextTime(){
        return Time.time+Random.Range(MIN_TIME,MAX_TIME);
    }
}

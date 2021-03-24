using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpBow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bowPlayer;
    public GameObject player;
    public GameObject bowDisappear;
    public GameObject arrowDisappear;
    public GameObject firstLimit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x>29.0f && firstLimit.activeSelf){
            player.GetComponent<PlayerControllerV2>().enableKeys(false);
            if(Input.GetKeyDown(KeyCode.W)){
                bowPlayer.SetActive(true);
                bowDisappear.SetActive(false);
                arrowDisappear.SetActive(false);
                firstLimit.SetActive(false);
                player.GetComponent<PlayerControllerV2>().enableKeys(true);
            }
        }
    }
}

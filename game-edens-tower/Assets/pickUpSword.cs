using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSword : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject sword;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x> 5.4f && sword.activeSelf==false){
            player.GetComponent<PlayerControllerV2>().enableKeys(false);
            if(Input.GetKeyDown(KeyCode.W)){
                sword.SetActive(true);
                gameObject.SetActive(false);
                player.GetComponent<PlayerControllerV2>().enableKeys(true);
            }
        }
    }
}

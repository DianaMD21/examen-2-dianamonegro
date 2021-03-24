using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circularBladeController : MonoBehaviour
{
   public GameObject _Shield;
    const float shieldDistance = 1f;
    public GameObject firstLimit;
    private int veces=0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (firstLimit.activeSelf==false && veces==0)
        {
            Instantiate(_Shield, gameObject.transform.position, Quaternion.identity).GetComponent<circularBlade>().Shoot
            (gameObject, shieldDistance);
            veces++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endd : MonoBehaviour
{
    public GameObject Endscrn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CollectibleObj")
        {
            Endscrn.gameObject.SetActive(true);
        }
    }



}

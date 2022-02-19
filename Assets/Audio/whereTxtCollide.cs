using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class whereTxtCollide : MonoBehaviour
{
    
    public TMP_Text whereAppear;
    public GameObject player;
    public float interactionDist;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < interactionDist)
        {
            whereAppear.gameObject.SetActive(true);
        }
        else
        {
            whereAppear.gameObject.SetActive(false);
        }
        Invoke("Test", 5f);
    }

    private void Test()
    {

    }
}

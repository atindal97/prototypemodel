using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioCollide : MonoBehaviour
{

    public AudioSource whereSource;
    // Start is called before the first frame update
    void Start()
    {
        whereSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            whereSource.Play();
        }
    }
}

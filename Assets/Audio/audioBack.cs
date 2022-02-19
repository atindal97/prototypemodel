using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBack : MonoBehaviour
{
    public AudioSource backSource;

    // Start is called before the first frame update
    void Start()
    {
        backSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            backSource.Play();
        }
    }
}

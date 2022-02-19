using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioCollideLeft : MonoBehaviour
{
    public AudioSource leftSource;
    public float time;
    public float timeLimit = 5;

    // Start is called before the first frame update
    void Start()
    {
        leftSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            leftSource.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            time += Time.fixedDeltaTime;


            if (time > timeLimit)
            {
                leftSource.Play();
                time = 0;
            }
        }
    }
}

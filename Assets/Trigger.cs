using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    public UnityEvent myEventFanOn, myEventFanOff;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myEventFanOn.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myEventFanOff.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
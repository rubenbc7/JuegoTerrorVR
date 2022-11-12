using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject screamer;
    public float delay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PointerClick()
    {
        screamer.SetActive(true);
        StartCoroutine(WaitAndDestroy());
    }
    IEnumerator WaitAndDestroy(){
    yield return new WaitForSeconds(delay);
    screamer.SetActive(false); 
    }
}

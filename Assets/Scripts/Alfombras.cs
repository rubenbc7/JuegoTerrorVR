using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alfombras : MonoBehaviour
{
    private Renderer renderer;
    public GameObject player;
    public GameObject TeleportTo;
    public float offsetTP = 1.50f;
    public float horizontaloffsetTP = 0f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        
        renderer.material.color = Color.red;
        player.transform.position = (new Vector3(TeleportTo.transform.position.x + horizontaloffsetTP, TeleportTo.transform.position.y + offsetTP , TeleportTo.transform.position.z));;
    }
    public void OnEnxit()
    {
        renderer.material.color = Color.white;
    }
}

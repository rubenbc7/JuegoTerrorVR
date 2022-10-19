using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpeechLib;
public class EventListener : MonoBehaviour
{
    //private Renderer renderer;
    [SerializeField] GameObject panel;
    [SerializeField] float offsetY;
    [SerializeField] AudioClip ganso;
    public AudioSource audioSource {get{return GetComponent<AudioSource>();}}
    private SpVoice voice;

    
    void Start()
    {
        //renderer = gameObject.GetComponent<Renderer>();
        gameObject.AddComponent<AudioSource>();
        voice=new SpVoice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        //renderer.material.color = Color.red;
        voice.Volume = 100;
        voice.Rate = 0;
        
        if(this.gameObject.tag == "ganso")
        {
            audioSource.PlayOneShot(ganso);
            panel.gameObject.SetActive(true);
            voice.Speak("You'll die", SpeechVoiceSpeakFlags.SVSFlagsAsync);
            //dialogo.GetComponent<Text>().text = voice.ToString();
        }    }
  
    public void OnEnxit()
    {
       if(this.gameObject.tag == "ganso"){
             panel.gameObject.SetActive(false);
             voice.Speak("ADIOS AMIGO HOMO", SpeechVoiceSpeakFlags.SVSFlagsAsync);
            voice.Volume = 0;
        } 
    }

    
}

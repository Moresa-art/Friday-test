using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioAndText : MonoBehaviour
{
    public AudioClip audioClip;
    public string myText;
    public Text displayText;
    public Image displayImage;
    Sprite mySprite;
    // Start is called before the first frame update
    
    void OnEnable()
    {
        Debug.Log("i am here");
        GetComponent<AudioSource>().PlayOneShot(audioClip,1f);
        displayText.text = myText;
        displayImage.sprite = GetComponent<SpriteRenderer>().sprite;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

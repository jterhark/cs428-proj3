using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BooksPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource winSound;
    
    private Queue<string> answers = new Queue<string>();

    public GameObject clue;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushState(string c)
    {
        answers.Enqueue(c);
        while(answers.Count > 3)
        {
            answers.Dequeue();
        }
        
        if (string.Join("", answers).Equals("rgb"))
        {
            winSound.Play();
            clue.SetActive(true);
        }
        
    }
}

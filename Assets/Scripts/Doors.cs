using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject Door;

    public Light Left, Right;

    private bool leftDone = false;

    private bool rightDone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightDone()
    {
        rightDone = true;
        Right.color = Color.green;
        Done();
    }

    public void LeftDone()
    {
        leftDone = true;
        Left.color = Color.green;
        Done();
    }

    private void Done()
    {
        if (leftDone && rightDone && Door!=null)
        {
            Door.SetActive(false);
        }
    }
}

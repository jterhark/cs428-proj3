using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Locomotion.Teleporters;
using Zinnia.Data.Type;

public class Teleporter : MonoBehaviour
{
    public GameObject target;
    public TeleporterFacade facade;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Teleport()
    {
        facade.Teleport(new TransformData(target));
        Console.WriteLine("Teleport Triggered");
        
    }

}

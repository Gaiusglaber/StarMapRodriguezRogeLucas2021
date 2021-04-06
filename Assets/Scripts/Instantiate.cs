﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Planet planetPrefab;
    public List<Planet> gerenatedPlanets;
    public float time = 0;
    void Start()
    {
        for (short i=0;i<10;i++)
        {
            GameObject instantiator = Instantiate(planetPrefab, new Vector3(i * 20, 0, 0), Quaternion.identity).gameObject;
            Planet planetaux = instantiator.GetComponent<Planet>();
            gerenatedPlanets.Add(planetaux);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMotion : MonoBehaviour {
    
    #region Variabels

    //In jurul cui se invarte
    public GameObject point;

    //Dimensiunle orbitei
    public float xAxis;
    public float yAxis;
    public float zAxis;

    //Unghiul care il formeaza cu Axa x
    public float angleX;

    //Distanta de la Axa x
    public float distanceX = 0;

    //Daca orbiteaza obiectul
    public bool isOrbitting = true;

    //Obiectul care orbiteaza
    public Transform currentObject;

    //Cat timp ii ia sa orbiteze
    public float orbitPeriod = 3f;

    //Progres orbitei
    public float progress;

    //Viteza de orbitare
    private float speed;

    #endregion

    #region Unity functions

    /// <summary>
    /// Cand se porneste
    /// </summary>
    void Start()
    {
        calculateVariabales();
    }

    /// <summary>
    ///  Update is called once per frame
    /// </summary>
    void FixedUpdate()
    {
        progress += Time.deltaTime * speed;
        if (isOrbitting)
            SetOrbit();
    }

    #endregion

    #region Functions

    /// <summary>
    /// Calculeaza viteza de deplasares si distanta de la Axa x 
    /// </summary>
    void calculateVariabales()
    {
        speed = 1f / orbitPeriod;
        float currentAngel = angleX;
        if (currentAngel != 0) 
            distanceX = (Mathf.Cos(currentAngel) * yAxis) / Mathf.Sin(currentAngel);
    }

    /// <summary>
    /// Seteaza obiectul pe orbita
    /// </summary>
    void SetOrbit()
    {
        Vector3 pozition = calculatePoint(progress);
        currentObject.localPosition = new Vector3(pozition.x, pozition.y, pozition.z);
    }

    /// <summary>
    /// Claculeaza punctul in spatiu in functie de unghi
    /// </summary>
    /// <param name="angel">Unghiu</param>
    /// <returns></returns>
    public Vector3 calculatePoint(float angel)
    {
        float currentAngel = angel * Mathf.Deg2Rad * 360;
        float x = Mathf.Sin(currentAngel) * (xAxis + (float)(point.transform.localScale.x / 2));
        float z = Mathf.Cos(currentAngel) * (zAxis + (float)(point.transform.localScale.x / 2));
        float y = Mathf.Sin(currentAngel) * distanceX;
        return new Vector3(x, y, z);
    }

    #endregion
}

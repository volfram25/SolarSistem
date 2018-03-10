using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    #region Variables

    //Punctu in jurul caruie orbiteaza
    public GameObject point;

    //Viteza
    public float speed = 3f;

    //Timpu in cat orbiteaza
    public float period;

    #endregion

    #region Unity Functions

    /// <summary>
    /// Cand se porneste
    /// </summary>
    void Start()
    {
        speed = 1f / period;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void FixedUpdate()
    {
        transform.RotateAround(point.transform.position, Vector3.up, Time.deltaTime * speed);
    } 

    #endregion
}

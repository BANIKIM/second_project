using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform Boby;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Boby.position, Vector3.up, 0.1f);
    }
}

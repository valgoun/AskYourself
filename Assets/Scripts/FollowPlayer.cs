using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Target;
    public float Smooth = 0.3f;

    private Vector3 _speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, Target.position, ref _speed, Smooth);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereAnimation : MonoBehaviour
{
    public float Radius;
    public float Speed;
    public float Seed;

    private float _time;
    private float _initialHeight;

    // Start is called before the first frame update
    void Start()
    {
        _initialHeight = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime * Speed * (Mathf.Sin(_time * Mathf.PI) * 0.5f + 1.0f);

        transform.localPosition = new Vector3(Mathf.Cos(_time + Seed) * Radius, _initialHeight + Mathf.Sin( Mathf.PI * _time + Seed) * 0.2f, Mathf.Sin(_time + Seed) * Radius);
    }
}

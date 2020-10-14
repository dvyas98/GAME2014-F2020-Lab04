using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    
    // Update is called once per frame
    void Update()
    {
        _move();
        _checkbounds();
    }


    private void _move()
    {
        transform.position+= new Vector3(horizontalSpeed*direction*Time.deltaTime,0.0f,0.0f);
    }

    private void _checkbounds()
    {
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}

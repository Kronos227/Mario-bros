using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject jugador;
    public Vector2 min;
    public Vector2 max;
    public float mts;
    Vector2 velocity;


    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, jugador.transform.position.x, ref velocity.x, mts);
        float posY = Mathf.SmoothDamp(transform.position.y, jugador.transform.position.y, ref velocity.y, mts);

        transform.position = new Vector3(Mathf.Clamp(posX, min.x, max.x), Mathf.Clamp(posY, min.y, max.y), transform.position.z);
    }

}

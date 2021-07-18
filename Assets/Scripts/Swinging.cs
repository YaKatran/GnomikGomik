using UnityEngine;
using System.Collections;

public class Swinging : MonoBehaviour
{

    public float swingSensitivity = 100.0f;

    void FixedUpdate()
    {

        if (GetComponent<Rigidbody2D>() == null)
        {
            Destroy(this);
            return;
        }

        float swing = InputManager.instance.sidewaysMotion;

        Vector2 force = new Vector2(swing * swingSensitivity, 0);

        GetComponent<Rigidbody2D>().AddForce(force);
    }
}
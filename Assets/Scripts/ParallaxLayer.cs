using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public float speed = 0.02f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

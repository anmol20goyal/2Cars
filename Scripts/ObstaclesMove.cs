using UnityEngine;

public class ObstaclesMove : MonoBehaviour
{

    public float speed = 1f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
    }
}

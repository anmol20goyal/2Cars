using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "gold")
        {
            Destroy(other.gameObject);
        }
    }
}

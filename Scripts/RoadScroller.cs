using UnityEngine;

public class RoadScroller : MonoBehaviour
{
    private Material material;
    private Vector2 offset;

    public float yVel;
    // Start is called before the first frame update
    void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        offset = new Vector2(0 , yVel);
    }

    // Update is called once per frame
    void Update()
    {
        if (CarCollision.GameHasEnded == false)
        {
            material.mainTextureOffset += offset * Time.deltaTime;
        }
        
    }
}

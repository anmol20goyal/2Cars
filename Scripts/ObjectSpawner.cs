using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject[] golds;
    private float timer;
    public float delayTimer;


    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (CarCollision.GameHasEnded == false)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                int ball = Random.Range(0, 4);
                if (Random.Range(0, 2) == 0)
                {
                    Instantiate(golds[ball], new Vector3(-0.358f, transform.position.y, transform.position.z), transform.rotation);
                }
                else
                {
                    Instantiate(golds[ball], new Vector3(-0.129f, transform.position.y, transform.position.z), transform.rotation);
                }

                timer = delayTimer;
                ForYellowCar();
            }
        }
    }

    private void ForYellowCar()
    {
        {
            int ball = Random.Range(0, 4);
            if (Random.Range(0, 2) == 1)
            {
                Instantiate(golds[ball], new Vector3(0.13f, transform.position.y, transform.position.z), transform.rotation);
            }
            else
            {
                Instantiate(golds[ball], new Vector3(0.359f, transform.position.y, transform.position.z), transform.rotation);
            }
        }
    }
}
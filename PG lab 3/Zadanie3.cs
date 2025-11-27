using UnityEngine;

public class Zadanie3 : MonoBehaviour
{
    public float speed = 3f;
    private Vector3 startPos;
    private int currentSide = 0;
    private float distanceTravelled = 0f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * step);
        distanceTravelled += step;

        if (distanceTravelled >= 10f)
        {
            transform.Rotate(0f, 90f, 0f);
            distanceTravelled = 0f;
            currentSide++;

            if (currentSide >= 4)
            {
                transform.position = startPos;
                currentSide = 0;
            }
        }
    }
}

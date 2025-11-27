using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public Transform openPosition;
    public Transform closedPosition;
    public float speed = 3f;

    private Vector3 target;

    private void Start()
    {
        target = closedPosition.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    public void OpenDoor()
    {
        target = openPosition.position;
    }

    public void CloseDoor()
    {
        target = closedPosition.position;
    }
}
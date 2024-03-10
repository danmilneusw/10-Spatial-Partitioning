using System.Collections;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 targetPosition;

    void Start()
    {
        // Generate a new target position
        GenerateTargetPosition();
    }

    void Update()
    {
        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // If the object has reached its target position, generate a new target position
        if (transform.position == targetPosition)
        {
            GenerateTargetPosition();
        }
    }

    void GenerateTargetPosition()
    {
        // Generate a random target position within a certain range
        targetPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
    }
}
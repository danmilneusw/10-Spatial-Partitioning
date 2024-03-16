using System.Collections.Generic;
using UnityEngine;

public class NearestCylinder : MonoBehaviour
{
    private GameObject nearestCylinder;
    private List<GameObject> cylinders = new List<GameObject>();

    void Start()
    {
        StoreCylinders();
        // PrintCylinderNamesAndPositions();
    }

    void Update()
    {
        // Debug.Log("Player Position: " + transform.position);
        FindNearestCylinder();
        RotateTowardsNearestCylinder();
    }

    void StoreCylinders()
    {
        cylinders.AddRange(GameObject.FindGameObjectsWithTag("CylinderTag"));
    }

    // void PrintCylinderNamesAndPositions()
    // {
    //     Debug.Log("Cylinders:");
    //     foreach (GameObject cylinder in cylinders)
    //     {
    //         Debug.Log("Name: " + cylinder.name + ", Position: " + cylinder.transform.position);
    //     }
    // }

    void FindNearestCylinder()
    {
        float minDistance = Mathf.Infinity;

        foreach (GameObject cylinder in cylinders)
        {
            float distance = Vector3.Distance(transform.position, cylinder.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestCylinder = cylinder;
            }
        }

        if (nearestCylinder != null)
        {
            Debug.Log("Nearest Cylinder: " + nearestCylinder.name + ", Position: " + nearestCylinder.transform.position);
        }
    }

    void RotateTowardsNearestCylinder()
    {
        if (nearestCylinder != null)
        {
            Vector3 direction = (nearestCylinder.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            float rotationSpeed = 2.0f; // Increase this value to make the rotation faster
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }
    }
}

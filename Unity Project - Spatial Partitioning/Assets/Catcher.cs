using UnityEngine;

public class Catcher : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Find the nearest sphere
        GameObject nearestSphere = FindNearestSphere();

        // If a sphere was found, move towards it
        if (nearestSphere != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, nearestSphere.transform.position, speed * Time.deltaTime);
        }
    }

    GameObject FindNearestSphere()
    {
        // Find all spheres in the scene
        GameObject[] spheres = GameObject.FindGameObjectsWithTag("Sphere");

        // If no spheres were found, return null
        if (spheres.Length == 0)
        {
            return null;
        }

        // Find the nearest sphere
        GameObject nearestSphere = spheres[0];
        float minDistance = Vector3.Distance(transform.position, nearestSphere.transform.position);

        foreach (GameObject sphere in spheres)
        {
            float distance = Vector3.Distance(transform.position, sphere.transform.position);
            if (distance < minDistance)
            {
                nearestSphere = sphere;
                minDistance = distance;
            }
        }

        return nearestSphere;
    }
}

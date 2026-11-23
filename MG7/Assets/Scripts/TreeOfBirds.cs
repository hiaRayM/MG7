using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [Header("Sparrows")]
    public GameObject[] sparrows;

    [Header("Distance")]
    public float interactionDistance = 5f;

    private void Update()
    {
        Transform player = Camera.main.transform;
        foreach (GameObject bird in sparrows)
        {
            if (bird == null) continue;
            float dist = Vector3.Distance(bird.transform.position, player.position);
            bird.SetActive(dist <= interactionDistance);
        }
    }
}
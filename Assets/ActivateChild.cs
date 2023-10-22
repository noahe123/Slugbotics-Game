using UnityEngine;

public class ActivateRandomChild : MonoBehaviour
{
    public float activationInterval = 10000;  // Time between activating children.
    private Transform[] children;
    private float timer = 0.0f;

    private void Start()
    {
        // Get all the children of the GameObject.
        children = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            children[i] = transform.GetChild(i);
            children[i].gameObject.SetActive(false);
        }

        // Activate a random child initially.
        ActivateRandomChildObject();
    }

    /*
    private void Update()
    {
        // Check if it's time to activate a random child.
        timer += Time.deltaTime;
        if (timer >= activationInterval)
        {
            timer = 0.0f;
            ActivateRandomChildObject();
        }
    }*/

    private void ActivateRandomChildObject()
    {
        // Deactivate all children.
        foreach (Transform child in children)
        {
            child.gameObject.SetActive(false);
        }

        // Activate a random child.
        int randomIndex = Random.Range(0, children.Length);
        children[randomIndex].gameObject.SetActive(true);
    }
}

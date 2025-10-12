using UnityEngine;

public class IndividualRockSpawnerScript : MonoBehaviour
{
    [Header("Components")]
    public GameObject rock;
    SpriteRenderer mySpriteRenderer;
    [Header("Variables")]
    private float timeToSpawn = 1f;
    private float timer = 0f;
    private bool hasSpawned = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rock.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hasSpawned)
        {
            return;
        }
        if (timer < timeToSpawn)
        {
            timer = timer + Time.fixedDeltaTime;
        }
        else
        {
            hasSpawned = true;
            spawnRock();
        }
    }
    public void startSpawningRock()
    {
        mySpriteRenderer.enabled = true;
        timer = 0f;
        hasSpawned = false;
    }
    private void spawnRock()
    {
        mySpriteRenderer.enabled = false;
        rock.transform.position = transform.position;
        rock.SetActive(true);
    }
    public GameObject returnRock()
    {
        return rock;
    }
}

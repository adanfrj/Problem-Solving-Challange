using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    //prefab instantiate
    public GameObject cube;

    private Rigidbody2D rb;

    public float respawnTime = 2f;

    //next spawn time
    float nextSpawn = 0f;

    void Start()
    {
        
    }

    private void SpawnCube()
    {
        GameObject cb = Instantiate(cube) as GameObject;
        cb.transform.position = new Vector2 (Random.Range(-1f, 1f), Random.Range(-2f, 2f));
    }

    public IEnumerator CubeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds (respawnTime);
             SpawnCube();
        }
    }
}

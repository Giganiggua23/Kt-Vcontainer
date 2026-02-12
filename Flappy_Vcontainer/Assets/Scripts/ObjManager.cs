using UnityEngine;
using System.Collections;

public class ObjManager : MonoBehaviour
{
    [SerializeField] private GameObject objectA;
    [SerializeField] private GameObject objectB;
    [SerializeField] private float offsetY = 2f;
    [SerializeField] private float spawnInterval = 1f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            Instantiate(objectA, transform.position, Quaternion.identity);

            Vector3 spawnPositionB = new Vector3(
                transform.position.x,
                transform.position.y - offsetY,
                transform.position.z
            );
            Instantiate(objectB, spawnPositionB, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

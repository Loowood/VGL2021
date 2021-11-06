using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPiece : MonoBehaviour
{
    public GameObject pieceToSpawn;
    public bool posAleatoire = true;

    public float leftestPos = -3f;
    public float rightestPos = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (posAleatoire) {
                Instantiate(pieceToSpawn, gameObject.transform.position + new Vector3(Random.Range(leftestPos, rightestPos), 0f, 0f), Quaternion.identity);
            } else
            {
                Instantiate(pieceToSpawn, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}

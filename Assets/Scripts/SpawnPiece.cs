using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPiece : MonoBehaviour
{
    public GameObject pieceToSpawn;
    public bool posAleatoire = true;

    public float leftestPos = -3f;
    public float rightestPos = 3f;
    public bool moveRight = true;
    public float speed = 1f;
    Vector3 movingDirection;
    float maxRightPosition;
    float maxLeftPosition;
    float maxPos;
    float minPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (moveRight)
        {
            movingDirection = Vector3.forward;
        }
        else
        {
            movingDirection = Vector3.back;
        }
        gameObject.transform.Translate(movingDirection * speed * Time.deltaTime);
        if (gameObject.transform.position.z > maxPos && moveRight)
        {
            moveRight = false;
        }
        if (gameObject.transform.position.z < minPos && !moveRight)
        {
            moveRight = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && JetonManager.instance.getNbJetons() > 0)
        {
            if (posAleatoire)
            {
                Instantiate(pieceToSpawn, gameObject.transform.position + new Vector3(Random.Range(leftestPos, rightestPos), 0f, 0f), Quaternion.identity);
            }
            else
            {
                Instantiate(pieceToSpawn, gameObject.transform.position, pieceToSpawn.transform.rotation);
            }

            JetonManager.instance.removeJeton(1);
        }
    }
}

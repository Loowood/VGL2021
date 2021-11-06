using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrilleMoves : MonoBehaviour
{
    [SerializeField]
    bool advance = true;
    public float speed = 1.0f;
    Vector3 movingDirection;
    public float minPos;
    public float maxPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (advance)
        {
            movingDirection = Vector3.forward;
        }
        else
        {
            movingDirection = Vector3.back;
        }
        gameObject.transform.Translate(movingDirection * speed * Time.deltaTime);
        if (gameObject.transform.position.y > maxPos && advance)
        {
            advance = false;
        }
        if (gameObject.transform.position.y < minPos && !advance)
        {
            advance = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherMoves : MonoBehaviour
{
    [SerializeField]
    bool advance = true;
    public float baseChrono = 20;
    float chrono;
    public float speed = 1.0f;
    Vector3 movingDirection;

    private void Awake()
    {
        //rigidbody = gameObject.GetComponent<Rigidbody>();
        chrono = baseChrono;
    }

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
        chrono -= Time.deltaTime;
        if (gameObject.transform.position.z > -8 && advance)
        {
            advance = false;
            chrono = baseChrono;
        }
        if (gameObject.transform.position.z < -13 && !advance)
        {
            advance = true;
            chrono = baseChrono;
        }
    }
}

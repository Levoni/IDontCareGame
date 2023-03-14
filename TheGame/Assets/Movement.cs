using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform tempTransform = gameObject.GetComponent<Transform>();
        Vector3 tempPosition = new Vector3(tempTransform.position.x, tempTransform.position.y, tempTransform.position.z);

        if (Input.GetKeyDown(KeyCode.A))
        {
            tempPosition.x = tempPosition.x - speed;
            tempTransform.position = tempPosition;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            tempPosition.x = tempPosition.x + speed;
            tempTransform.position = tempPosition;
        }
        
    }
}

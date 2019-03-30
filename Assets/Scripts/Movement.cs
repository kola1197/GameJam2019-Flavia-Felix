using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 12.0f;
    private Vector3 desiredMovement;
    private CharacterController charController;
    public bool canMove = true;
    // Start is called before the first frame update
    public Vector3 MovementVector
    {
        get
        {
            return desiredMovement;
        }
        set
        {
            if (value != Vector3.zero)
            {
                //Debug.Log(value);
                desiredMovement = Vector3.Normalize(value);
            }
        }
    }

    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {

            //Debug.Log(desiredMovement);
            if (desiredMovement != Vector3.zero)
            {
                charController.Move(desiredMovement * movementSpeed);
                desiredMovement = Vector3.zero;
                //Debug.Log(desiredMovement);
            }
        }
    }
}

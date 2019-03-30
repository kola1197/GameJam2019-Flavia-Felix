using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector3 inputMovement;
    private Movement movSystem;

    void Awake()
    {
        movSystem = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movSystem.MovementVector = inputMovement;
    }
}


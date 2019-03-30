using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreeFilter : MonoBehaviour
{
    public string treeTag = "Tree";

    private Vector3 worldSpacePoint;
    private Ray ray;
    private RaycastHit hit;
    private Camera mainCamera;
    private MeshRenderer lastTree, newTree;

    void Start()
    {
        mainCamera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        ray = mainCamera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        Physics.Raycast(ray, out hit);
        if(hit.collider.tag == treeTag)
        {
            Debug.Log("I see a tree");
            newTree = hit.collider.gameObject.GetComponent<MeshRenderer>();
            if (lastTree != newTree)
            {
                lastTree.enabled = true;
                lastTree = newTree;
                lastTree.enabled = false;
            }
        }
        
    }
}

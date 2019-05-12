using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMoves : MonoBehaviour
{
    public float movSpeed = 10f;
    private Transform target;
    private int nodesIndex = 0;

    private void Start() {
        
        target = BoardNodes.nodes[0];
    }
    private void Update() {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * movSpeed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextNode();
        }
 
    }

    void GetNextNode()
    {
        if (nodesIndex >= BoardNodes.nodes.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        nodesIndex ++;
        target = BoardNodes.nodes[nodesIndex];
    }


}

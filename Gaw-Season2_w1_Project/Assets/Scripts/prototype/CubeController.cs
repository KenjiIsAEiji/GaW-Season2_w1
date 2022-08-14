using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    const int MinLane = -2;
    const int MaxLane = 2;

    const float LaneWidth = 1.0f;

    [SerializeField] float speedX = 10f;

    Rigidbody rb;

    private int targetLane = 0;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float diffX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;
        Vector3 move = new Vector3(diffX * speedX, 0f, 0f);

        rb.AddForce(move * rb.mass * rb.drag / (1f - rb.drag * Time.fixedDeltaTime));
    }

    public void MoveToLeft()
    {
        if (targetLane > MinLane) targetLane--;
    }

    public void MoveToRight()
    {
        if (targetLane < MaxLane) targetLane++;
    }
}

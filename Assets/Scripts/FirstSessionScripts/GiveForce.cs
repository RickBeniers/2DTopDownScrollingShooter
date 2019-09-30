using UnityEngine;

public class GiveForce : MonoBehaviour
{
    //[SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Vector2 moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -0.604f);
    }
}

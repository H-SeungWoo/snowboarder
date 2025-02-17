using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float TorqueAmount = 1f;
    Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(TorqueAmount);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-TorqueAmount);
        }
    }
}

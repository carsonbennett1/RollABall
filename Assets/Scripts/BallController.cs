using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed = 2f;
    void Start()
    {
        
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXYZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXYZPlane * ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) inputVector += Vector2.up;
        if (Input.GetKey(KeyCode.A)) inputVector += Vector2.left;
        if (Input.GetKey(KeyCode.S)) inputVector += Vector2.down;
        if (Input.GetKey(KeyCode.D)) inputVector += Vector2.right;

        Debug.Log("Resultant Vector: " + inputVector);

        Vector3 inputXYZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXYZPlane * ballSpeed);
    }
}

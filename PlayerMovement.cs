using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
  public float ForwardForce = 500f;
  public float SideForce = 100f;
  public float JumpForce = 5f * Time.deltaTime;

  public Vector3 jump;

  public bool isGrounded;

  void OnCollisionStay()
  {
    isGrounded = true;
  }

  void Start()
  {
    jump = new Vector3(0.0f, 1.0f, 0.0f);
  }

  void FixedUpdate()
  {
    rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

    if (Input.GetKey(KeyCode.D))
    {
      rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    else if (Input.GetKey(KeyCode.A))
    {
      rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    else if (Input.GetKey(KeyCode.Space) && isGrounded)
    {
      rb.AddForce(jump * JumpForce, ForceMode.Impulse);
      isGrounded = false;
    }
  }
}

using UnityEngine;

// Controls player movement and rotation.
public class Collectible : MonoBehaviour
{
  public float rotationSpeed = 0.5f;

  private Rigidbody rb;


  private void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(0, rotationSpeed, 0);
  }


}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Controls player movement and rotation.
public class Collectible : MonoBehaviour
{
  public float rotationSpeed = 0.5f;
  public GameObject onCollectEffect;

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
  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      //Destroy the collectible
      Destroy(gameObject);

      //Instantiate the particle effect
      Instantiate(onCollectEffect, transform.position, transform.rotation);
    }
  }


}
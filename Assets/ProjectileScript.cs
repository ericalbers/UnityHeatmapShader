using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
  void Update()
  {
    transform.position = transform.position + new Vector3(0f, 0f, 1f) * Time.deltaTime;
  }
}

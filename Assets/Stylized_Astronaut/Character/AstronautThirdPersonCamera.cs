using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  public class AstronautThirdPersonCamera : MonoBehaviour
  {
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;
    public float distance = 5.0f;

    private float currentX = 0.0f;
    private float currentY = 20.0f;

    private void Start()
    {
        camTransform = transform;
    }


    public IEnumerator Shake(float duration, float magnitude){

          float elapsed = 0.0f;

          while (elapsed < duration){
              float x = Random.Range(-1f, 1f) * magnitude;
              float y = Random.Range(-1f, 1f) * magnitude;

              y = camTransform.position.y - y;
              x = camTransform.position.x - x;

              camTransform.position = new Vector3(x, y, camTransform.position.z);


              elapsed += Time.deltaTime;

              yield return null;
          }


    }


    private void Update()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }


  }


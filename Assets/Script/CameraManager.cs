using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class CameraManager : MonoBehaviour
{

    float mDelta = 20; // Pixels. The width border at the edge in which the movement work

    [SerializeField] private float mSpeed = 20.0f; // Scale. Speed of the movement


    // Update is called once per frame
    void LateUpdate()
    {
        // Check if on the right edge and move accordingly
        if (Input.mousePosition.x >= Screen.width - mDelta)
        {
            transform.position += (Vector3.right + Vector3.back) * Time.deltaTime * mSpeed;
        }
        if (Input.mousePosition.x <= 0 + mDelta)
        {
            transform.position += (Vector3.left + Vector3.forward) * Time.deltaTime * mSpeed;
        }
        if (Input.mousePosition.y >= Screen.height - mDelta)
        {
            transform.position += (Vector3.forward + Vector3.right) * Time.deltaTime * mSpeed;
        }
        if (Input.mousePosition.y <= 0 + mDelta)
        {
            transform.position += (Vector3.back + Vector3.left) * Time.deltaTime * mSpeed;
        }
    }


}

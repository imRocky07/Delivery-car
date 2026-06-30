using System;
using Unity.VisualScripting;
using UnityEngine;

public class Deleviry : MonoBehaviour
{
    [SerializeField] Color32 hasColour = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noColour = new Color32(0,0,0,1);
    SpriteRenderer spriteRenderer;
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    [SerializeField] float DelaySpeed = 0.5f;
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boostup")
        {
            Destroy(other.gameObject,DelaySpeed);
        }
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Recieved");
            hasPackage = true;
            spriteRenderer.color = hasColour;
            Destroy(other.gameObject, DelaySpeed);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            spriteRenderer.color = noColour;
             hasPackage = false;
        }
   
    }

    private void Destroy(Func<GameObject> gameObject, float delaySpeed)
    {
        throw new NotImplementedException();
    }
}

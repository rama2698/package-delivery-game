using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (17, 236, 21, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.3f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // function call on collision with object
    void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Collision");
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Package" && !hasPackage){
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
            Debug.Log("Package Picked");
            Destroy(other.gameObject, destroyDelay);
        }

        if(other.tag == "Customer" && hasPackage){
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
            Debug.Log("package delivered");
        }
    }


}

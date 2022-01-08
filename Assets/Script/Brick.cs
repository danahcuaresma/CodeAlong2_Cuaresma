using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int points = 10;
    public Vector3 rotator;
    public Material hitMaterial;
    Material orgMaterial;
    Renderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        
        _renderer = GetComponent<Renderer>();
        orgMaterial = _renderer.sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter(Collision collision) {
        hits--;
        if(hits <= 0) {
            Destroy(gameObject);
        }

        _renderer.sharedMaterial = hitMaterial;
        Invoke("RestoreMaterial", 0.05f);
    }

    void RestoreMaterial() {
        GetComponent<Renderer>().sharedMaterial = orgMaterial;
    }
}

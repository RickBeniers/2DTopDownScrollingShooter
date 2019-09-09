using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //zoek de meshrenderer en de material die veranderd moet worden.
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;

        //voor de verandering door(in dit geval een andere offset) dit zorgt ervoor dat de material een scrolling effect heeft.
        offset.y += Time.deltaTime / 5f;

        //geef de verandering door aan de material.
        mat.mainTextureOffset = offset;
    }
}

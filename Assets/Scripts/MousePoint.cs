using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour {

    RaycastHit hit;

    public GameObject Target;

    private float raycastLenght = 500;

    void Update()
    {
  

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, raycastLenght))
        {
            if(hit.collider.name == "TerrainMain")
            {
                if(Input.GetMouseButtonDown(1))
                {
                    GameObject TargetObj = Instantiate(Target, hit.point, Quaternion.identity) as GameObject;
                }
            }

        }

        Debug.DrawRay(ray.origin, ray.direction * raycastLenght, Color.yellow);
        Target.name = "Target Instanted";
    }


}

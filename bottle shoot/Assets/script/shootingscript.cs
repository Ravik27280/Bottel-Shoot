using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscript : MonoBehaviour
{
    public GameObject explosion;
    public GameObject gamecamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(gamecamera.transform.position, gamecamera.transform.forward,out hit))
        {
            if (hit.transform.name == "bottle")
            {
                Destroy(hit.transform.gameObject);
                GameObject go = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal)); 
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube")
        {




            other.gameObject.transform.parent.gameObject.GetComponent<PlayerControll>().pos.transform.position += new Vector3(0, 0.6f, 0);
            other.gameObject.transform.parent.gameObject.GetComponent<PlayerControll>().RemoveCube();
            other.gameObject.transform.parent = null;
            Destroy(other.gameObject, 6);

        }

    }
}

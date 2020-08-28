using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*by Alexander*/

public class ScalerTest : MonoBehaviour
{

    public GameObject box = null;

    bool ScaleObject(GameObject myObject, int type = 1, float offset = 0.1f)
    {
        switch (type)
        {
            case -1:
                myObject.transform.localScale = new Vector3(myObject.transform.localScale.x / offset,
                                                            myObject.transform.localScale.y / offset,
                                                            myObject.transform.localScale.z / offset);
                break;
            case 1:
                myObject.transform.localScale = new Vector3(myObject.transform.localScale.x * offset,
                                                            myObject.transform.localScale.y * offset,
                                                            myObject.transform.localScale.z * offset);
                break;
            default:
                break;

        }
        return true;
    }




    void ScaleUp()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ScaleObject(box, 1);
            Debug.Log("Scaled Up!");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ScaleObject(box, -1);
            Debug.Log("Scaled down!");
        }
    }


    void Start() { }
    void Update()
    {
        ScaleUp();
    }
}

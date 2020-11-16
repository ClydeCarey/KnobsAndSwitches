using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //public MeshRenderer meshRenderer;
    //[SerializeField]
    //public bool externalControl;
    [SerializeField]
    public bool _meshEnabler = true;

    // Start is called before the first frame update
    void Start()
    {
        //meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_meshEnabler == true)
        {
            transform.GetComponent<MeshRenderer>().enabled = true;
        }
        else if (_meshEnabler == false)
        {
            transform.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}

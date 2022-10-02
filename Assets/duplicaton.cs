using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class duplicaton : MonoBehaviour
{
    
    
    [SerializeField] float nombre=1f;
    [SerializeField] private GameObject prefabAInstantier;
    private float Pi=3.1415f;
    private float division =0f;
    public float rayon =1f;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.position=new Vector3(rayon*Mathf.Cos((division*0)*(Pi/180)),rayon*Mathf.Sin((division*0)*(Pi/180)),1f);
        division=360/nombre;
        for(int i=1;i<nombre;i++){
            Instantiate(prefabAInstantier,position:new Vector3(rayon*Mathf.Cos((division*i)*(Pi/180)),rayon*Mathf.Sin((division*i)*(Pi/180)),1f),Quaternion.identity);
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


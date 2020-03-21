using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coindisappear : MonoBehaviour
{
    public Text a;
    public float sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
     
            Destroy(gameObject);
        sc = int.Parse(a.text);

        sc += 1;
            a.text=sc.ToString("0");
       
       
    }
}

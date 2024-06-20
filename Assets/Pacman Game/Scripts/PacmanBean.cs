using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanBean : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            PacmanGame.instance.OnEatingBean();
            GameObject.Destroy(gameObject);
        }            
    }
}

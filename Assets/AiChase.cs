using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChase : MonoBehaviour
{
    public GameObject ninja;
    public float speed;
    private float distance;
        // Start is called before the first frame update
   

        // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, ninja.transform.position);
        Vector2 direction = ninja.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, ninja.transform.position, speed * Time.deltaTime);
    }
}

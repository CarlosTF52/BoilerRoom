using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{

    // Update is called once per frame

    private void Start()
    {
        StartCoroutine(PlayerHurt());
    }
    void Update()
    {
        
    }

    private IEnumerator PlayerHurt()
    {
        while (true)
        {
            gameObject.GetComponent<Light>().enabled = false;
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
            gameObject.GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
        }
    }
}

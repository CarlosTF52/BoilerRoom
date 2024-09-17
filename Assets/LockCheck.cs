using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject _lock1;

    [SerializeField]
    private GameObject _lock2;

    [SerializeField]
    private Animator _animation;

    [SerializeField]
    private Material _material;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if((!_lock1.activeInHierarchy) && (!_lock2.activeInHierarchy))
        {
            _animation.SetTrigger("OpenDoor");
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBool : MonoBehaviour
{
    [SerializeField]
    private string _stringOn;

    private bool _boolOn;

    [SerializeField]
    private Animator _animator;

    // Start is called before the first frame update
    public void SetTrue()
    {
        if (!_boolOn)
        {
            _animator.SetBool(_stringOn, true);
            
            _boolOn = true;
        }
        else if(_boolOn)
        {
            _animator.SetBool(_stringOn, false);
            _boolOn = false;
            
        }
        
    }
}

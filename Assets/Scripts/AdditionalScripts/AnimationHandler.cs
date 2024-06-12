using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private string _nameNextAnimation;
    
    private SkeletonAnimation _skeletonAnimation;
    
    void Awake()
    {
        _skeletonAnimation = GetComponent<SkeletonAnimation>();

        if (_skeletonAnimation == null)
            throw new NullReferenceException("SkeletonAnimation component is not found");
    }

    public void ChangeAnimation()
    {
        _skeletonAnimation.AnimationName = _nameNextAnimation;
    }
}

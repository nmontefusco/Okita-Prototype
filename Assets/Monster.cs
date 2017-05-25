using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    public enum MonsterState
    {
        standing,
        wandering,
        chasing,
        attacking
    }
    public MonsterState mState;

    void Start ()
    {
        mState = MonsterState.standing;	
	}

    void Update()
    {
        if (mState == MonsterState.standing) { print("standing monster is standing."); }
        if (mState == MonsterState.wandering) { print("wandering monster is wandering."); }
        if (mState == MonsterState.chasing) { print("chasing monster is chasing."); }
        if (mState == MonsterState.attacking) { print("attacking monster is attacking."); }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {
    public GameObject model;
    [SerializeField] //私有变量不显示到编辑器, SerilizeFiled强制显示
    private Animator anim;
    public PlayerInput pi;

    //尽量在awake方法中getcomponent
    void Awake() {
        anim = model.GetComponent<Animator>();
        pi = GetComponent<PlayerInput>();

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("forward", pi.dirUp);
	}
}

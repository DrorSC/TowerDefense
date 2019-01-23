using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    // Singleton
    public static BuildManager instance;

    private void Awake()
    {
        if(instance!= null)
        {
            Debug.LogError("BuildManager already created in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

    private GameObject turretToBuild;

    
	// Use this for initialization
	void Start () {
        turretToBuild = standardTurretPrefab;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}

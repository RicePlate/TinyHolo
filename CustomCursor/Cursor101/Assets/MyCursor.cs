using UnityEngine;
using System.Collections;

public class MyCursor : MonoBehaviour {
    private MeshRenderer meshRenderer;

	// Use this for initialization
	void Start () {
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        // show the cursor where the user's gaze is
        this.gameObject.transform.position = Camera.main.transform.position;
	}
}

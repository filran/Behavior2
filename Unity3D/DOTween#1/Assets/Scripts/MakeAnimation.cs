using UnityEngine;
using System.Collections.Generic;
using System;

public class MakeAnimation : MonoBehaviour {

	public Transform LifelinePrefab;

	const float LIFELINE_DISTANCE_X = 3f;

	private Dictionary<Instance,Transform> Lifelines = new Dictionary<Instance,Transform>();
	private SequenceDiagram sequencediagram = new SequenceDiagram();
	private Instance instance = new Instance();

	// Use this for initialization
	void Start () {
		GameObject sequencediagramGO = new GameObject();
		sequencediagramGO.name = sequencediagram.Id;

		//Instance the lifelines prefabs ========================================
		if( instance.totalinstances() > 0 ){
			int cont = 1; //used like coordinates

			foreach( Instance inst in instance.instances() ){
				//coordinates
				float x = LIFELINE_DISTANCE_X * (float)cont;
				float y = 2.0f;
				float z = 0.0f;

				//create the instantes
				Transform l = (Transform)Instantiate( LifelinePrefab , new Vector3 (0+x, y, z), Quaternion.identity);
				Debug.Log (l.GetInstanceID().ToString() );
				//put instances like children
				l.transform.parent = sequencediagramGO.transform;

				//add name
				TextMesh text = l.FindChild("Text").GetComponent<TextMesh>();
				text.text = inst.Name;

				//positions of the arrows ===============================================
//				if( instance.totalarrows > 0 ){
//					Debug.Log(  );
//				}

				//add actor or classobject and instances in Arraylist Lifelines
				Lifelines.Add(inst,l);

				cont++;
			}
		}else{
			Debug.Log ( "NAO TEM NADA !!!" );
		} 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

//using UnityEngine;
//using System.Collections;
//using DG.Tweening;
//
//public class MyAnimation : MonoBehaviour
//{
//
//	public Transform lifeline;
//	private float duration = 1;
//	private ArrayList Lifelines = new ArrayList();
//
//	IEnumerator Start()
//	{
//		//Start the Scene
//		yield return new WaitForSeconds(duration);
//
//		//Instantiate the lifelines
//		Lifelines.Add(Instantiate(lifeline, new Vector3 (20, 3, 20), Quaternion.identity));
//		Lifelines.Add(Instantiate(lifeline, new Vector3 (22.75f, 3, 20), Quaternion.identity));
//		Lifelines.Add(Instantiate(lifeline, new Vector3 (25.5f, 3, 20), Quaternion.identity));
//		Lifelines.Add(Instantiate(lifeline, new Vector3 (28.25f, 3, 20), Quaternion.identity));
//		Lifelines.Add(Instantiate(lifeline, new Vector3 (31f, 3, 20), Quaternion.identity));
//
//		foreach( Transform l in Lifelines )
//		{
//			Transform instance = l.FindChild("Instance");
//			Transform dashedline = l.FindChild("Dashedline");
//			Transform boldline = l.FindChild("Boldline");
//			Transform arrowline = l.FindChild("Arrow").FindChild("ArrowLine");
//			Transform arrowtip = l.FindChild("Arrow").FindChild("ArrowTip");
//
//			ArrayList groupchildren = new ArrayList();
//			
//			groupchildren.Add(instance);
//			groupchildren.Add(dashedline);
//			groupchildren.Add(boldline);
//			groupchildren.Add(arrowline);
//			groupchildren.Add(arrowtip);
//			
//			foreach( Transform child in groupchildren )
//			{
//				child.GetComponent<Renderer>().material.DOFade(0,0);
//			}
//		}
//
//		//Move dashedline, boldline and arrow
//		foreach( Transform l in Lifelines )
//		{
//			Transform instance = l.FindChild("Instance");
//			Transform dashedline = l.FindChild("Dashedline");
//			Transform boldline = l.FindChild("Boldline");
//			Transform arrowline = l.FindChild("Arrow").FindChild("ArrowLine");
//			Transform arrowtip = l.FindChild("Arrow").FindChild("ArrowTip");
//
//			ArrayList groupchildren = new ArrayList();
//
//			groupchildren.Add(instance);
//			groupchildren.Add(dashedline);
//			groupchildren.Add(boldline);
//			groupchildren.Add(arrowline);
//			groupchildren.Add(arrowtip);
//
////			for( int i=1; i<=Lifelines.Count ; i++ )
////			{
////				float v = 0.0f + (float)i;
//				yield return new WaitForSeconds(1);
////			}
//
//			l.FindChild("Dashedline").transform.localPosition = new Vector3(0,-1.0f,0.0f) ;
//			l.FindChild("Boldline").transform.localPosition = new Vector3(0,-1.2f,0.0f) ;
//			l.FindChild("Arrow").transform.localPosition = new Vector3(0.1f,-0.8f,0.0f) ;
//
//			foreach( Transform child in groupchildren )
//			{
//				child.GetComponent<Renderer>().material.DOFade(1,duration);
//			}
//
////			yield return new WaitForSeconds(1);
//
//			Sequence s = DOTween.Sequence();
//			s.Append( arrowline.DOScaleX(2.5f,duration) );
//			s.Insert( 0, arrowline.DOLocalMoveX(1.25f,duration) );
//			s.Insert( 0, arrowtip.DOLocalMoveX(2.5f,duration));
//
////			s.Insert( 0, l.DOMoveY(0,5) );
//
//
//		}
//
//	}
//}

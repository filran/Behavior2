using System.Collections;

public abstract class Diagram {}
//
//	public abstract class BehavioralDiagram : Diagrams {}
//
//	public class SequenceDiagram : BehavioralDiagram {
//
//			public string Id {get ; private set;}
//		
//			public SequenceDiagram(){
//				//TEST <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
//				this.Id = "um";
//			}			
//		}
//
//
//			public abstract class Arrow {
//	
//				public string Id {get ; private set;}
//				public ArrayList Instances {get ; set;}
//
//				public Arrow(){}
//								
////				public abstract Instance sender();
//
////				public abstract Instance receiver();
////
////				public abstract string text();
//
//			}
//
//				public class Synchronous : Arrow {		
//
//				}
//
////				public class Asynchronous : Arrow {}
////
////				public class ReturnMessage : Arrow {}
//
//
//			public abstract class Line {}
//
//				public class Lifeline : Line {}
//
//				public class Execution : Line {}
//
//
//			public class Instance {
//				public string Id {get ; protected set;}
//				public string Name {get; protected set;}
//				public ArrayList Instances {get; private set;}
//				public ArrayList Arrows {get; protected set;}
//
//				public Instance(){
//				}
//
//				public Instance(string name){
//					this.Name = name;
//				}
//
//				public ArrayList instances(){
//					ArrayList inst = new ArrayList();
//					inst.Add( new Actor("actor") ); //1
//					inst.Add( new ObjectClass("inst 1") ); //2
//					inst.Add( new ObjectClass("inst 2") ); //3...
//					inst.Add( new Actor("actor 2") );
//					inst.Add( new ObjectClass("inst 4") );
//					inst.Add( new ObjectClass("inst 5") );
//					return inst;
//				}
//
//				public int totalinstances(){
//					return this.instances().Count ;
//				}
//
//				public int totalarrows(){
//					return this.Arrows.Count;
//				}
//			}
//
//				public class Actor : Instance{
//
//					public Actor (string name) : base(name) {
//					}
//
//				}
//
//				public class ObjectClass : Instance{
//
//					public ObjectClass (string name) : base(name) {
//					}
//					
//				}
//

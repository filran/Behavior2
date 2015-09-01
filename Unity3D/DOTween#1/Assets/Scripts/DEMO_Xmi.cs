//using System;
//using System.Collections;
//using System.Collections.Generic;
//
//public class DEMO_Xmi {
//
//	public Dictionary<Array,Array> Lifelines {get;set;}
//
//	public DEMO_Xmi(){
//		//			LIFELINE					OTHER THINGS
//		Dictionary< Dictionary<string,string> , Dictionary<string,string> > L = new Dictionary< Dictionary<string,string> , Dictionary< string, Dictionary<string,string> > >();
//
//			Dictionary<string,string> life1 = new Dictionary<string,string>();
//			life1.Add("type","actor");
//			life1.Add("name","Actor 1");
//
//			Dictionary<string,string> arrow1 = new Dictionary<string,string>();
//			arrow1.Add( "type","sync" );
//			arrow1.Add( "mesage","teste(string teste)" );
//			arrow1.Add( "receiver",":Pessoa" );
//
//			Dictionary<string,string> arrow11 = new Dictionary<string,string>();
//			arrow11.Add( "type","async" );
//			arrow11.Add( "mesage","enviar()" );
//			arrow11.Add( "receiver","Actor 1" );
//
//			Dictionary<string,Dictionary<string,string>> data1 = new Dictionary<string,Dictionary<string,string>>();
//			data1.Add( "arrow" , arrow1 );
//			data1.Add( "arrow" , arrow11 );
//
//		L.Add( life1 , data1 );
//
//			Dictionary<string,string> life2 = new Dictionary<string,string>();
//			life2.Add("type","object");
//			life2.Add("name",":Pessoa");
//
//			Dictionary<string,string> arrow2 = new Dictionary<string,string>();
//			arrow2.Add( "","" );
//
//			Dictionary<string,Dictionary<string,string>> data2 = new Dictionary<string,Dictionary<string,string>>();
//			data2.Add( "" , arrow2 );
//
//		L.Add( life2 , data2 );
//
//	}
//	
//
//}
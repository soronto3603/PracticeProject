using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaviManager : MonoBehaviour {
	public static string a="asd";

	class Point{
		public int x;
		public int y;
		public string name;
		public ArrayList nexts;
		Point(int x,int y,string name){
			this.x=x;
			this.y=y;
			this.name=name;
		}
		public void nextOf(Point next_node){
			this.nexts.Add = next_node;
		}
	}
	//건우 함수
	public Point make_graph(){
		//Point a=new Point(1,2,"디정정문");
		//Point b=new Point(2,5,"본관");
		//a.nextOf(b);
	}
	public void get_object_points(){
	
	}
	public string get_path_to_dst(Point root){
		//알고리즘
	}
	// Use this for initialization
	void Start () {
		NaviManager.a="qweqte";
		//Point root=make_graph();
		//NaviManager.a=this.get_path_to_dst(root);
	}

	// Update is called once per frame
	void Update () {
		
	}

}

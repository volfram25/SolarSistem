using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine;

public class Planet : OrbitMotion {

    //public GameObject planet;
    //public OrbitMotion orbit;

	// Use this for initialization
	void Start () {
        //orbit = new OrbitMotion();
        string path = "URI=file:" + Application.dataPath + "/Andromeda.db";
        IDbConnection conn = (IDbConnection)new SqliteConnection(path);
        conn.Open();

        IDbCommand com = conn.CreateCommand();
        com.CommandText = "SELECT name FROM Bodys Where name = "+currentObject.name+"";
        IDataReader read = com.ExecuteReader(); 

        //Debug.Log(read.GetString(0) + read.GetFloat(1) + read.GetFloat(2) + read.GetFloat(3) + read.GetFloat(4) + read.GetFloat(5) + read.GetFloat(6) + read.GetFloat(7) + read.GetFloat(8));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

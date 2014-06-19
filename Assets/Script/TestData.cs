using UnityEngine;
using System.Collections;

public class TestData : ScriptableObject
{
	public int count;
	public string msg;
	
	public virtual string GetMessage ()
	{
		return null;
	}
}

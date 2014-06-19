using UnityEngine;
using System.Collections;

public class CallTestData : MonoBehaviour
{
//		private TestData m_testData;
		public TestData m_testData;
	
		void Start ()
		{
//				m_testData = Resources.Load<TestData> ("testdata");
		}
	
		void Update ()
		{
				Debug.Log (m_testData.count);
				Debug.Log (m_testData.msg);
		}
}

/*
 * TJS2 CSharp
 */

using System;

namespace Tjs2.Engine
{
	[System.Serializable]
	public class TJSException : Exception
	{
		private const long serialVersionUID = 1942890050230766470L;

		public TJSException()
		{
		}

		public TJSException(string msg) : base(msg)
		{
		}
	}
}

// 
// LinkedHashSet.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;

namespace Tjs2.Sharpen
{
	public class LinkedHashSet<T>: AbstractSet<T>
	{
		private List<T> list = new List<T> ();
		private HashSet<T> table = new HashSet<T> ();
		
		public LinkedHashSet ()
		{
		}
		
		public LinkedHashSet (IEnumerable<T> items)
		{
			foreach (T t in items)
				AddItem (t);
		}
		
		public override bool AddItem (T element)
		{
			if (table.Add (element)) {
				list.Add (element);
				return true;
			}
			return false;
		}
		
		public override void Clear ()
		{
			list.Clear ();
			table.Clear ();
		}
		
		public override bool Contains (object item)
		{
			return table.Contains ((T)item);
		}
		
		public override bool Remove (object element)
		{
			if (table.Remove ((T)element)) {
				list.Remove ((T)element);
				return true;
			}
			return false;
		}
		
		public override int Count {
			get {
				return table.Count;
			}
		}
		
		public override Iterator<T> Iterator ()
		{
			return list.AsIterable ().Iterator ();
		}
	}
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
	public class Region
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Branch> Branches { get; set; } = new List<Branch>();
	}
}

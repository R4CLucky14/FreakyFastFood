﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FFF.Models.ItemSystem
{
	//todo Finish Comment Class
	/// <summary>
	/// Represents a Choice for an Item.
	/// If the Item is to represent a specific ordered item, then the Option value will be populated.
	/// 
	/// </summary>
	public class Choice : DatabaseObject
	{
		/// <summary>
		/// 
		/// </summary>
		public String Title { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public String Description { get; set; }
		/// <summary>
		/// A List of Options for the Choice
		/// </summary>
		public ICollection<Option> Options { get; set; }
		/// <summary>
		/// A List of Comestibles this Choice is applicable for
		/// </summary>
		public ICollection<Item> Items { get; set; }
		
		/// <summary>
		/// 
		/// </summary>
		public Choice()
		{
			this.Options = new Collection<Option>();
			this.Items = new Collection<Item>();
		}
	}
}

﻿using FFF.Models.OrderSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FFF.Models.ItemSystem
{
	public class Product : DatabaseObject
	{
		public decimal Price
		{
			get
			{
				Decimal price = this.Item.Price;
				foreach(var selectedOption in SelectedOptions)
				{
					price += selectedOption.AdditionalPrice;
				}
				return price;
			}
		}
		[Required]
		public virtual Item Item { get; set; }
		public virtual ICollection<Option> SelectedOptions { get; set; }
		public virtual ShoppingCart ShoppingCart { get; set; }
		public virtual Order Order { get; set; }

		public Product()
			: base()
		{
			this.SelectedOptions = new Collection<Option>();
		}
		public Product(Item Item, params Option[] SelectedOptions )
			: base()
		{
			this.Item = Item;
			this.SelectedOptions = new Collection<Option>();
			if(SelectedOptions != null)
			{ 
				foreach(var selectedOption in SelectedOptions)
				{
					this.SelectedOptions.Add( selectedOption );
				}
			}
		}

	}
}

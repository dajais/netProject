using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BijouWorld.Models
{
	public class Product
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		[Required]
		[MaxLength(250)]
		public string Description { get; set; }

		[Required]
		public int Price { get; set; }

		[Required]
		[MaxLength(150)]
		public string Picture { get; set; }

		[Required]
		[MaxLength(50)]
		public string Category { get; set; }



	}
}

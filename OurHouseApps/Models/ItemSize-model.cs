
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class ItemSize
	{

		public ItemSize()
		{
			
		}


		[Required]
		[DisplayName("Id")]
		public int Id { get; set; }

				[Required]
		[DisplayName("Size")]
		public string Size { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		[DisplayName("Created On")]
		public DateTime CreatedOn { get; set; }

		}}



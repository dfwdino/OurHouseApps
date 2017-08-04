
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Stores
	{

		public Stores()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Store Name")]
		public string StoreName { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		}}



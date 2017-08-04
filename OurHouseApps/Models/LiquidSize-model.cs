





using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class LiquidSize
	{

		public LiquidSize()
		{
			
		}


		[Required]
		[DisplayName("Id")]
		public int Id { get; set; }

				[Required]
		[DisplayName("Type")]
		public string Type { get; set; }

				[Required]
		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}



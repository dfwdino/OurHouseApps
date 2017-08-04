
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Actions
	{

		public Actions()
		{
			
		}


		[Required]
		[DisplayName("index")]
		public int index { get; set; }

				[Required]
		[DisplayName("Title")]
		public string Title { get; set; }

				[Required]
		[DisplayName("Delete")]
		public bool Delete { get; set; }

		[DisplayName("Category ID")]
		public Guid CategoryID { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}



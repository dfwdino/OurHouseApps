
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class ActionCategory
	{

		public ActionCategory()
		{
			
		}


		[Required]
		[DisplayName("Index")]
		public Guid Index { get; set; }

				[Required]
		[DisplayName("Category")]
		public string Category { get; set; }

				[Required]
		[DisplayName("Delete")]
		public bool Delete { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}



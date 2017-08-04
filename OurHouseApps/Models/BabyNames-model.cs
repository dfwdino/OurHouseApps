
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class BabyNames
	{

		public BabyNames()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Baby Name")]
		public string BabyName { get; set; }

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



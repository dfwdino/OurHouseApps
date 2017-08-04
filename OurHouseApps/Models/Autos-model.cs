
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Autos
	{

		public Autos()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Whos Car")]
		public int WhosCar { get; set; }

				[Required]
		[DisplayName("Auto Name")]
		public string AutoName { get; set; }

		[DisplayName("Delete")]
		public bool Delete { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}



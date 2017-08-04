
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Gallons
	{

		public Gallons()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Auto ID")]
		public int AutoID { get; set; }

				[Required]
		[DisplayName("Total Miles")]
		public int TotalMiles { get; set; }

				[Required]
		[DisplayName("Driven Miles")]
		public int DrivenMiles { get; set; }

				[Required]
		[DisplayName("Total Gallons")]
		public double TotalGallons { get; set; }

		[DisplayName("Total Price")]
		public decimal TotalPrice { get; set; }

		[DisplayName("Gas Date")]
		public DateTime GasDate { get; set; }

				[Required]
		[DisplayName("Tank Filled")]
		public bool TankFilled { get; set; }

		[DisplayName("Notes")]
		public string Notes { get; set; }

		[DisplayName("Station ID")]
		public int StationID { get; set; }

		[DisplayName("Delete")]
		public bool Delete { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}



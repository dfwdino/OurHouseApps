
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Dreams
	{

		public Dreams()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public Guid ID { get; set; }

				[Required]
		[DisplayName("Date")]
		public DateTime Date { get; set; }

				[Required]
		[DisplayName("Dream")]
		public string Dream { get; set; }

		[DisplayName("Person")]
		public int Person { get; set; }

				[Required]
		[DisplayName("Did Meditation")]
		public bool DidMeditation { get; set; }

				[Required]
		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		[DisplayName("Links")]
		public string Links { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}



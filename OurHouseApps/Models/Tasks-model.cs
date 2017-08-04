
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Tasks
	{

		public Tasks()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Title")]
		public string Title { get; set; }

		[DisplayName("Due Date")]
		public DateTime DueDate { get; set; }

				[Required]
		[DisplayName("Done")]
		public bool Done { get; set; }

				[Required]
		[DisplayName("Person ID")]
		public int PersonID { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		}}




using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class GasNotes
	{

		public GasNotes()
		{
			
		}


		[Required]
		[DisplayName("Notes ID")]
		public int NotesID { get; set; }

				[Required]
		[DisplayName("Note")]
		public string Note { get; set; }

				[Required]
		[DisplayName("Auto ID")]
		public int AutoID { get; set; }

				[Required]
		[DisplayName("Created On")]
		public DateTime CreatedOn { get; set; }

		[DisplayName("Updated On")]
		public DateTime UpdatedOn { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Broswer")]
		public string Broswer { get; set; }

				[Required]
		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		[DisplayName("Note Date")]
		public DateTime NoteDate { get; set; }

		}}



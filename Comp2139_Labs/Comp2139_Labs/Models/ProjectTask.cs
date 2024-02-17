using System;
using System.ComponentModel.DataAnnotations;

namespace Comp2139_Labs.Models
{
	public class ProjectTask
	{
		[Key]

		public int ProjectTaskId { get; set; }

		[Required]
		public string? Title { get; set; }

		public string? Description { get; set; }

		// foreign key

		public int ProjectId { get; set; }

		// navigation property
		// this allows the easy access to the related Project entity from the ProjectTask entity

		public Project? Project { get; set; }

	}
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Courses.GraphQL.Data.Models
{
	public class Review
	{
		[Key]
		public int Id { get; set; }
		public int Rate {  get; set; }
		public string Comment {  get; set; }

		//Relation
		public int CourseId { get; set; }
		[ForeignKey("CourseId")]
		public Course Course { get; set; }


	}
}

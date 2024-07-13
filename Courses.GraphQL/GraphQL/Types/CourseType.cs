using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
	public class CourseType:ObjectGraphType<Course>
	{
		public CourseType()
		{
			Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the GraphQL");
			Field(x => x.Description, type: typeof(StringGraphType)).Description("Description");
			Field(x => x.Name, type: typeof(StringGraphType)).Description("Name");
			//Field(x => x.Review, type: typeof(IntGraphType)).Description("Review");
			Field(x => x.DateAdded, type: typeof(DateTimeGraphType)).Description("DateAdded");
			Field(x => x.DateUpdated, type: typeof(DateTimeGraphType)).Description("DateUpdated");

			//relationship one to many
			Field(x => x.Reviews, type: typeof(ListGraphType<ReviewType>)).Description("List of reviews");
		}
	}
}

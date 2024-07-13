using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
	public class ReviewType:ObjectGraphType<Review>
	{
		public ReviewType()
		{
			Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the GraphQL");
			Field(x => x.Rate, type: typeof(IntGraphType)).Description("Rate");
			Field(x => x.Comment, type: typeof(StringGraphType)).Description("comment");
			
		}
	}
}

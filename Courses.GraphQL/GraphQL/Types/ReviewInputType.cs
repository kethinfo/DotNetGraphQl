using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
	public class ReviewInputType : InputObjectGraphType
	{
        public ReviewInputType()
        {
            Name = "ReviewInputType";

			Field<IntGraphType>("Rate");
			Field<StringGraphType>("Comment");
		
		}
	}
}

using PoeFilterParser.Model;

namespace PoeFilterParser.NUnit.IntegrationTests
{
	public class FakePoeFilterVisitor : PoeFilterBaseVisitor<bool>
	{
		public override bool VisitMain(Model.PoeFilterParser.MainContext context) => true;
	}
}
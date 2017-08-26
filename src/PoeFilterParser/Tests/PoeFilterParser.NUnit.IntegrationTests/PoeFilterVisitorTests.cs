using System;
using System.IO;
using Antlr4.Runtime;
using NUnit.Framework;
using PoeFilterParser.Model;
using System.Collections.Generic;
using System.Linq;

namespace PoeFilterParser.NUnit.IntegrationTests
{
	[TestFixture]
	public class PoeFilterVisitorTests
	{
		[TestCaseSource(nameof(FiltersList))]
		public void Validate(string path)
		{
			using (var fileStream = new StreamReader(path))
			{
				var input = new AntlrInputStream(fileStream);
				var lexer = new PoeFilterLexer(input);
				var tokens = new CommonTokenStream(lexer);
				var parser = new Model.PoeFilterParser(tokens);
				parser.RemoveErrorListeners();
				parser.AddErrorListener(new ErrorListener());
				var tree = parser.main();
				var visitor = new FakePoeFilterVisitor();

				var result = visitor.Visit(tree);

				Assert.IsTrue(result);
			}
		}

		public static IEnumerable<TestCaseData> FiltersList()
		{
			var folder = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)), "filters");
			return Directory.GetFiles(folder).Select(f=>new TestCaseData(f) {TestName = $"Validate_{Path.GetFileNameWithoutExtension(f)}_Success"});
		}

	}
}
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Xunit;

namespace VkNet.SourceGenerator.Tests
{
	public class GeneratorTests
	{
		[Fact]
		public void SimpleGeneratorTest()
		{
			var currentCompilation =
				CreateCompilation(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "AppType.cs"))
					.Replace("AppType", "TestSafetyEnum"));

			var newCompilation = RunGenerators(currentCompilation,
				out var generatorDiagnostics,
				new VkResponseToSafetyEnumCastGenerator());

			var generatedTrees = newCompilation.RemoveSyntaxTrees(currentCompilation.SyntaxTrees).SyntaxTrees;

			Assert.Single(generatedTrees);
			Assert.Empty(generatorDiagnostics);
			Assert.Empty(newCompilation.GetDiagnostics());
		}

		private static Compilation CreateCompilation(string source, OutputKind outputKind = OutputKind.DynamicallyLinkedLibrary)
			=> CSharpCompilation.Create("compilation",
				new[]
				{
					CSharpSyntaxTree.ParseText(source, new CSharpParseOptions(LanguageVersion.Preview))
				},
				new[]
				{
					MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
					MetadataReference.CreateFromFile(typeof(string).Assembly.Location),
					MetadataReference.CreateFromFile(typeof(VkApi).Assembly.Location)
				},
				new CSharpCompilationOptions(outputKind));

		private static GeneratorDriver CreateDriver(Compilation compilation, params ISourceGenerator[] generators) =>
			CSharpGeneratorDriver.Create(generators, parseOptions: (CSharpParseOptions) compilation.SyntaxTrees.First().Options);

		private static Compilation RunGenerators(Compilation currentCompilation, out ImmutableArray<Diagnostic> diagnostics,
												params ISourceGenerator[] generators)
		{
			CreateDriver(currentCompilation, generators)
				.RunGeneratorsAndUpdateCompilation(currentCompilation, out var outputCompilation, out diagnostics);

			return outputCompilation;
		}
	}
}
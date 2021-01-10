using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VkNet.SourceGenerator
{
	public class VkResponseToManualEnumCastsReceiver : ISyntaxReceiver
	{
		public List<string> CandidateClasses { get; } = new();

		public List<string> CandidateUsingList { get; } = new();

		public Dictionary<string, string> DefaultValues { get; } = new();

		/// <inheritdoc />
		public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
		{
			if (syntaxNode is EnumDeclarationSyntax enumDeclarationSyntax
				&& enumDeclarationSyntax.AttributeLists.SelectMany(al => al.Attributes)
					.All(x => x.Name.ToString() != "VkNetIgnoreDefaultValueAttribute" && x.Name.ToString() != "VkNetIgnoreDefaultValue")
				&& SyntaxNodeHelper.TryGetParentSyntax<NamespaceDeclarationSyntax>(enumDeclarationSyntax,
					out var namespaceDeclarationSyntax)
				&& namespaceDeclarationSyntax.Name.ToString().StartsWith("VkNet.Enums")
			)
			{
				var namespaceName = namespaceDeclarationSyntax.Name.ToString();

				if (!CandidateUsingList.Contains(namespaceName))
				{
					CandidateUsingList.Add(namespaceName);
				}

				var enumName = enumDeclarationSyntax.Identifier.Text;
				CandidateClasses.Add(enumName);

				var field = enumDeclarationSyntax.ChildNodes()
					.OfType<EnumMemberDeclarationSyntax>()
					.FirstOrDefault(x =>
						x.AttributeLists.SelectMany(al => al.Attributes)
							.Any(x => x.Name.ToString() == "VkNetDefaultValueAttribute"
									|| x.Name.ToString() == "VkNetDefaultValue"));

				if (field == null)
				{
					return;
				}

				if (!DefaultValues.ContainsKey(enumName))
				{
					DefaultValues.Add(enumName, field.Identifier.Text);
				}
			}
		}
	}
}
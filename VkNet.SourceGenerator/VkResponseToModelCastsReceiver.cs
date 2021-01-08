using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VkNet.SourceGenerator
{
	public class VkResponseToModelCastsReceiver : ISyntaxReceiver
	{
		public List<string> CandidateClasses { get; } = new();

		public List<string> CandidateUsingList { get; } = new();

		/// <inheritdoc />
		public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
		{
			if (syntaxNode is ClassDeclarationSyntax { TypeParameterList: null } classDeclarationSyntax
				&& classDeclarationSyntax.ChildNodes().OfType<MethodDeclarationSyntax>().Any(x => x.Identifier.Text == "FromJson")
				&& SyntaxNodeHelper.TryGetParentSyntax<NamespaceDeclarationSyntax>(classDeclarationSyntax,
					out var namespaceDeclarationSyntax)
				&& !namespaceDeclarationSyntax.Name.ToString().StartsWith("VkNet.Model.RequestParams")
				&& !namespaceDeclarationSyntax.Name.ToString().StartsWith("VkNet.Model.Attachments")
				&& namespaceDeclarationSyntax.Name.ToString().StartsWith("VkNet.Model"))
			{
				var namespaceName = namespaceDeclarationSyntax.Name.ToString();

				if (!CandidateUsingList.Contains(namespaceName))
				{
					CandidateUsingList.Add(namespaceName);
				}

				CandidateClasses.Add(classDeclarationSyntax.Identifier.Text);
			}
		}
	}
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VkNet.SourceGenerator
{
	public class VkResponseToSafetyEnumCastReceiver : ISyntaxReceiver
	{
		public List<string> CandidateClasses { get; } = new List<string>();

		/// <inheritdoc />
		public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
		{
			if (syntaxNode is ClassDeclarationSyntax classDeclarationSyntax
				&& classDeclarationSyntax.BaseList != null
				&& !classDeclarationSyntax.BaseList.IsMissing
				&& classDeclarationSyntax.BaseList.Types.Any(x =>
					x.Type is GenericNameSyntax syntax
					&& syntax.IsKind(SyntaxKind.GenericName)
					&& syntax.Identifier.Text == "SafetyEnum")
			)
			{
				CandidateClasses.Add(classDeclarationSyntax.Identifier.Text);
			}
		}
	}
}
using C4Sharp.Diagrams;
using C4Sharp.Models;
using C4Sharp.Models.Plantuml;
using C4Sharp.Models.Plantuml.Constants;
using C4Sharp.Models.Relationships;
using C4Sharp.Sample.Structures;

namespace C4Sharp.Sample.Diagrams
{
    using static Position;
    using static People;
    using static Systems;

    public class ContextDiagram : DiagramBuildRunner
    {
        protected override string Title => "[System Landscape] Global Sports Group";
        protected override DiagramType DiagramType => DiagramType.Context;

        protected override IEnumerable<Structure> Structures() => new Structure[]
        {
            Customer,
            BankingSystem,
            Mainframe,
            MailSystem,
            Webshop,
            XtCommerce
        };

        protected override IEnumerable<Relationship> Relationships() => new[]
        {
            (Customer > XtCommerce).AddTags("error"),
            (Customer > Webshop).AddTags("ok"),
            (Webshop > XtCommerce),
            (Customer > BankingSystem).AddTags("replace"),
            (Customer < MailSystem)["Sends e-mails to"],
            (BankingSystem > MailSystem)["Sends e-mails", "SMTP"][Neighbor],
            BankingSystem > Mainframe,
        };

        protected override IElementStyle? SetStyle()
        {
            return ElementStyles.ContextStyle;
        }

        protected override IRelationshipTag? SetRelTags()
        {
            return RelationshipTags.ContextTags;
        }
    }
}
using C4Sharp.Models.Plantuml;
using C4Sharp.Models.Plantuml.Constants;

public class RelationshipTags
{
   private static RelationshipTag contextTags = new RelationshipTag()
                .AddRelTag("error", "red", "red", LineStyle.DashedLine)
                .AddRelTag("replace", "blue", "blue", LineStyle.DottedLine)
                .AddRelTag("ok", "green", "green", LineStyle.DashedLine);
   

   public static RelationshipTag ContextTags
   { 
        get { return contextTags; }
        set { contextTags = value; }
   }
}


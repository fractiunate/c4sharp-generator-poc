using C4Sharp.Models.Plantuml;
using C4Sharp.Models.Plantuml.Constants;

public class ElementStyles
{
   private static ElementStyle contextStyle = new ElementStyle()
                .UpdateElementStyle(ElementName.ExternalPerson, "#7f3b08", "#7f3b08")
                .UpdateElementStyle(ElementName.Person, "#55ACEE", "#55ACEE")
                .UpdateElementStyle(ElementName.ExternalSystem, "#3F6684", shape: Shape.RoundedBoxShape);
   

   public static ElementStyle ContextStyle
   { 
        get { return contextStyle; }
        set { contextStyle = value; }

   }
}
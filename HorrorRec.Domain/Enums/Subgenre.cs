using System.ComponentModel;

namespace HorrorRec.Domain.Enums;

public enum Subgenre
{
   [Description("Found Footage")]
   FoundFootage,
   [Description("Body Horror")]
   BodyHorror,
   [Description("Cosmic Horror")]
   Cosmic,
   [Description("Dark Fantasy")]
   DarkFantasy,
   [Description("Erotic Horror")]
   EroticHorror,
   [Description("Gothic Horror")] 
   Gothic,
   [Description("Southern Gothic")]
   SouthernGothic,
   [Description("Horror Western")]
   HorrorWestern,
   [Description("Creature Feature")]
   CreatureFeature,
   [Description("Monster Movie")]
   MonsterMovie,
   [Description("Paranormal")]
   Paranormal,
   [Description("Splatter")]
   Splatter,
   [Description("Horror Comedy")]
   HorrorComedy,
   [Description("Apocalypse")]
   Apocalypse,
   [Description("Surreal")]
   Surreal,
   [Description("Folk Horror")]
   FolkHorror,
   [Description("Survival")]
   Survival,
   [Description("True Crime")]
   TrueCrime,
   [Description("Slasher")]
   Slasher,
   [Description("Gateway Horror")]
   GatewayHorror,
   [Description("Psycho-Biddy")]
   PsychoBiddy,
   [Description("Exploitation")]
   Exploitation,
   [Description("J-Horror")]
   JapaneseHorror,
   [Description("K-Horror")]
   KoreanHorror,
   [Description("Synthwave Horror")]
   SynthwaveHorror,
   [Description("Extreme")]
   Extreme,
   [Description("Cyber Horror")]
   CyberHorror,
   [Description("Surf Horror")]
   SurfHorror,
}
using UnrealBuildTool;

public class UnrealQuest3Target : TargetRules
{
	public UnrealQuest3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("UnrealQuest3");
	}
}

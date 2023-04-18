using UnrealBuildTool;

public class AutogridLoadingTarget : TargetRules
{
	public AutogridLoadingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("AutogridLoading");
	}
}

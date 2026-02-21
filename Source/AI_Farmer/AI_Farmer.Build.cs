// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AI_Farmer : ModuleRules
{
	public AI_Farmer(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AI_Farmer",
			"AI_Farmer/Variant_Platforming",
			"AI_Farmer/Variant_Platforming/Animation",
			"AI_Farmer/Variant_Combat",
			"AI_Farmer/Variant_Combat/AI",
			"AI_Farmer/Variant_Combat/Animation",
			"AI_Farmer/Variant_Combat/Gameplay",
			"AI_Farmer/Variant_Combat/Interfaces",
			"AI_Farmer/Variant_Combat/UI",
			"AI_Farmer/Variant_SideScrolling",
			"AI_Farmer/Variant_SideScrolling/AI",
			"AI_Farmer/Variant_SideScrolling/Gameplay",
			"AI_Farmer/Variant_SideScrolling/Interfaces",
			"AI_Farmer/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

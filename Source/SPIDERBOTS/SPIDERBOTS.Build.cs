// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;


public class SPIDERBOTS : ModuleRules
{
	public SPIDERBOTS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "GameplayAbilities", "GameplayTags", "GameplayTasks", "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "UMG", "ApexDestruction", "PhysicsCore", "Networking", "Sockets" });
	}
}

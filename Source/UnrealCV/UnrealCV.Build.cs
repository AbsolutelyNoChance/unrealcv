// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealCV : ModuleRules
{
    public UnrealCV(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[] {
				// ... add public include paths required here ...
			}
            );


        PrivateIncludePaths.AddRange(
            new string[] {
				// ... add other private include paths required here ...
				"UnrealCV/Private",
                "UnrealCV/Private/Actor",
                "UnrealCV/Public/Actor",
                "UnrealCV/Public/BPFunctionLib",
                "UnrealCV/Public/Component",
                "UnrealCV/Public/Controller",
                "UnrealCV/Public/Sensor",
                "UnrealCV/Public/Sensor/CameraSensor",
                "UnrealCV/Public/Server",
                "UnrealCV/Public/Utils"
            }
            );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "RenderCore",
                "Networking",
                "Sockets",
                "Slate",
                "ImageWrapper",
                "CinematicCamera",
                "Projects", // Support IPluginManager
				"RHI", // Support low-level RHI operation
				"Json",
            }
            );


        if (Target.bBuildEditor == true)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                "UnrealEd", // To support GetGameWorld
                            // This is only available for Editor build
                }
                );
        }


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
				// ... add any modules that your module loads dynamically here ...
				"Renderer"
            }
            );

    }
}

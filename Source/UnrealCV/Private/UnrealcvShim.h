// Weichao Qiu @ 2018
// Provide abstraction for different engine versions
#pragma once

#include "CoreMinimal.h"
#include "Runtime/Launch/Resources/Version.h"
#include "Runtime/Core/Public/Misc/App.h"

inline FString GetProjectName()
{
	FString SceneName = FApp::GetProjectName();
	// This is marked as deprecated in 4.18
	// https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Core/Public/Misc/App.h:L91
	return SceneName;
}
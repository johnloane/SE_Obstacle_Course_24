// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SE_Obstacle_CourseEditorTarget : TargetRules
{
	public SE_Obstacle_CourseEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "SE_Obstacle_Course" } );
	}
}

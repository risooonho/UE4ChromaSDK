// Some copyright should be here...

using UnrealBuildTool;

public class ChromaSDKEditor : ModuleRules
{
	public ChromaSDKEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"ChromaSDKEditor/Public",
				// ... add public include paths required here ...
				"ChromaSDKPlugin/Public",
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"ChromaSDKEditor/Private",
				
				// ... add other private include paths required here ...
				"AssetTools",
				"ChromaSDKPlugin/Private",
				"Editor/DetailCustomizations/Private",
				"EditorStyle",
				"PropertyEditor",
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				
				// ... add other public dependencies that you statically link with here ...
				"AppFramework",
				"ChromaSDKPlugin",
				"DesktopPlatform",
				"InputCore",
				"UnrealEd",
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",

				// ... add private dependencies that you statically link with here ...	
				"AssetTools",
				"ChromaSDKPlugin",
				"DetailCustomizations",
				"EditorStyle",
				"PropertyEditor",
				"Slate",
				"SlateCore",
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
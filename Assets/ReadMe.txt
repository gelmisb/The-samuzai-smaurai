Minimap prototype using the UnityGUI
------------------------------------------
The project requires Unity 4.6 Beta. Tested in 4.6 RC1 (not compatible with the betas).
The scripts are in the Assets/Scripts/Minimap folder. 
The prefabs are in the Assets/Prefabs/Minimap
Example assets are in Assets/Examples.
------------------------------------------
The asset has two different modes either using a rasterized background (shouldn't require PRO version to work) or it renders the minimap background through a secondary camera - RenderTexture (RT) (requires PRO version). Currently it has only been tested in the PRO version.
------------------------------------------
How to use:
--- Minimap:
Run and inspect the example scenes (Assets/Examples/Minimap/Scenes/MinimapXZ) to see how the system works.
Add Minimap_XZ_SS or Minimap_YZ_SS prefab in a UnityGUI screen space canvas. Minimap_XZ_WS can be put in the world space canvas. Again, check the example scenes.
You can use the "Window/AB Minimap/Create new minimap" menu to create a new, simple, minimap that you can further work with.
Add MMActor script on each actor you want to represent in the minimap and assign the MObject you want to associate with it. MObjects are prefabs that appear in the minimap. It could be a pin, a circle, an arrow etc. Example objects can be found in Prefabs/Minimap/Objects
--- Snapshot:
Enable and check the MapSnapshotCameraXZ/MapSnapshotCameraYZ gameobjects in the example scenes.
If you want to take a snapshot, drag the MapSnapshotCameraXZ/MapSnapshotCameraYZ prefab into your scene and enable it. Center the camera so it covers the whole height and press the take snapshot button. The snapshots will appear in Assets/Textures/Minimap/Snapshots and are already of Sprite type with the packing tag.
------------------------------------------
Known issues:
The system is getting a bit complex and there is no proper tutorial as of now
---
Sharing MObjects across different minimaps properly is not implemented yet
------------------------------------------
Known bugs:
Clicking in the world space canvas is not always registered
------------------------------------------

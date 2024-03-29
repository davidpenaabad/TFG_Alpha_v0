﻿//----------------------------------------------
// Ruler 2D
// Copyright © 2015-2020 Pixel Fire™
//----------------------------------------------

namespace R2D 
{	
	public static class R2DD_Lang 
    {
		public const string menuAccess 					= "Window/Ruler 2D/Open %]";
        public const string toggleGuides				= "Window/Ruler 2D/Toggle Guides Display %;";
        public const string toggleGuidesLock            = "Window/Ruler 2D/Toggle Guides Lock &%;";
		public const string toggleGrid					= "Window/Ruler 2D/Toggle Grid %'";
		public const string windowTitle 				= "Ruler 2D";
		public const string editorScene					= "Unity 2D";
		public const string worldUnits					= "Context Units";
		public const string pixels						= "Pixels";
		public const string context						= "Context";
		public const string unitType					= "Unit Type";
		public const string refPixels					= "Reference Pixels";
		public const string referencePixels 			= "Reference Pixels Per Unit";
		public const string displaySelectedCoords 		= "Show Selected Coordinates";
		public const string preferColliders		 		= "Prefer Colliders";
		public const string displayGuides		 		= "Show Guides";
        public const string lockGuides                  = "Lock Guides";
		public const string displayGuideCoords 			= "Show Mouse Over Coords";
		public const string snapGuideToInt 				= "Snap Guides To Integer";
		public const string presets 					= "Presets";
		public const string clearGuides					= "Clear All Guides";
		public const string titleGuides					= " Guides";
		public const string titleRulerSettings			= " Settings";
		public const string titleToolbox				= " Toolbox";
		public const string titleGrid					= " Grid";
		public const string guide						= "Guide";
		public const string guideHelp					= "Drag from the rulers in the Scene to create guides and drag them away to remove.";
		public const string nguiInvalidContext			= "To work with NGUI Widgets, you must change the context to the UI Root from the settings panel.";
		public const string canvasInvalidContext		= "To work with Canvas objects, you must change the context to the Canvas from the settings panel.";
		public const string nguiError					= "NGUI alignment unavailable. Please report this bug to the developer.";
		public const string undo						= "Undo Last Action";
		public const string lblAlign					= "Align";
		public const string lblDistribute				= "Distribute";
		public const string lblSpace					= "Space";
		public const string tipAlignTop					= "Align top edges";
		public const string tipAlignHMid				= "Align vertical centers";
		public const string tipAlignBot					= "Align bottom edges";
		public const string tipAlignLeft				= "Align left edges";
		public const string tipAlignVMid				= "Align horizontal centers";
		public const string tipAlignRight				= "Align right edges";
		public const string tipDistTop					= "Distribute top edges";
		public const string tipDistYMid					= "Distribute vertical centers";
		public const string tipDistBot					= "Distribute bottom edges";
		public const string tipDistLeft					= "Distribute left edges";
		public const string tipDistXMid					= "Distribute horizontal centers";
		public const string tipDistRight				= "Distribute right edges";
		public const string lblSnapToGuide				= "Snap To Guides";
		public const string lblUseEdgesForSnap			= "Snap Edges To Guides";
		public const string lblMeasure					= "Measure";
		public const string tipSnapLeft					= "Snap to nearest guide leftward";
		public const string tipSnapRight				= "Snap to nearest guide rightward";
		public const string tipSnapTop					= "Snap to nearest guide upward";
		public const string tipSnapBot					= "Snap to nearest guide downward";
		public const string tipSpaceX					= "Evenly space out X starting with the lowest X.\n\nHint: Place your objects in the desired sequence on X for best results.";
		public const string tipSpaceY					= "Evenly space out Y starting with the lowest Y.\n\nHint: Place your objects in the desired sequence on Y for best results.";
		public const string tipMeasure					= "Activate measure tool.\n\nHint: Drag on the scene to measure freely.";
		public const string tipMeasureObj				= "Select two objects and press this button to measure the distance between them.";
		public const string tipClearMeasure				= "Clear measure line";
		public const string measureAlert				= "Measure Tool Ready";
		public const string gridX						= "Unit Horizontal Width";
		public const string gridY						= "Unit Vertical Height";
		public const string gridOriginX					= "Origin X";
		public const string gridOriginY					= "Origin Y";
		public const string gridCols					= "Columns";
		public const string gridRows					= "Rows";
		public const string snapToGrid					= "Snap To Grid";
		public const string gridEnabled					= "Display Grid";
		public const string nguiGridHelp				= "Use the standard move tool in order to snap NGUI objects to the grid.";
		public const string sceneModeError				= "Ruler 2D is not available when the Scene View is in 3D mode.";
		public const string set2DSceneMode				= "Switch Scene View to 2D mode.";
		public const string undoAlignTop				= "Align Top Edges";
		public const string undoAlignVertical			= "Align Vertical Centers";
		public const string undoAlignBottom				= "Align Bottom Edges";
		public const string undoAlignLeft				= "Align Left Edges";
		public const string undoAlignHorizontal			= "Align Horizontal Centers";
		public const string undoAlignRight				= "Align Right Edges";
		public const string undoDistroTop				= "Distribute Top Edges";
		public const string undoDistroVertical			= "Distribute Vertical Centers";
		public const string undoDistroBottom			= "Distribute Bottom Edges";
		public const string undoDistroLeft				= "Distribute Left Edges";
		public const string undoDistroHorizontal		= "Distribute Horizontal Centers";
		public const string undoDistroRight				= "Distribute Right Edges";
		public const string undoSpaceX					= "Horizontal Spacing";
		public const string undoSpaceY					= "Vertical Spacing";
		public const string undoSnapLeft				= "Snap Left";
		public const string undoSnapRight				= "Snap Right";
		public const string undoSnapUp					= "Snap Upward";
		public const string undoSnapDown				= "Snap Downward";


        // Heirarchy context menu items
        public const string contextAlignTopEdges = "GameObject/Ruler 2D/Align Top Edges";
        public const string contextAlignVerticalCenters = "GameObject/Ruler 2D/Align Vertical Centers";
        public const string contextAlignBottomEdges = "GameObject/Ruler 2D/Align Bottom Edges";
        public const string contextAlignLeftEdges = "GameObject/Ruler 2D/Align Left Edges";
        public const string contextAlignHorizontalCenters = "GameObject/Ruler 2D/Align Horizontal Centers";
        public const string contextAlignRightEdges = "GameObject/Ruler 2D/Align Right Edges";
        public const string contextDistributeTopEdges = "GameObject/Ruler 2D/Distribute Top Edges";
        public const string contextDistributeVerticalCenters = "GameObject/Ruler 2D/Distribute Vertical Centers";
        public const string contextDistributeBottomEdges = "GameObject/Ruler 2D/Distribute Bottom Edges";
        public const string contextDistributeLeftEdges = "GameObject/Ruler 2D/Distribute Left Edges";
        public const string contextDistributeHorizontalCenters = "GameObject/Ruler 2D/Distribute Horizontal Centers";
        public const string contextDistributeRightEdges = "GameObject/Ruler 2D/Distribute Right Edges";
        public const string contextSnapToGuideLeft = "GameObject/Ruler 2D/Snap To Guide Left";
        public const string contextSnapToGuideRight = "GameObject/Ruler 2D/Snap To Guide Right";
        public const string contextSnapToGuideUp = "GameObject/Ruler 2D/Snap To Guide Up";
        public const string contextSnapToGuideDown = "GameObject/Ruler 2D/Snap To Guide Down";

        // System warnings
        public const string detectMonitorChange = "R2D Warning: Monitor change detected. Please restart R2D to avoid unknown artificats.";
	}
}
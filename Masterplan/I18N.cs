using System;
using System.Collections.Generic;
//using System.Drawing;

//using Masterplan.Controls;
//using Masterplan.Tools;
//using Masterplan.UI;

namespace Masterplan
{
    /// <summary>
    /// Class used to store Lang values.
    /// </summary>
	[Serializable]
    public class I18N
	{
		/// <summary>
		/// No Comment default value.
		/// Program.cs
		/// </summary>
		public string Loading
		{
			get { return fLoading; }
			set { fLoading = value; }
		}
		string fLoading = "Loading";

		/// <summary>
		/// No Comment default value.
		/// Program.cs
		/// </summary>
		public string StartingMasterplan
		{
			get { return fStartingMasterplan; }
			set { fStartingMasterplan = value; }
		}
		string fStartingMasterplan = "Starting Masterplan";

		/// <summary>
		/// No Comment default value.
		/// Program.cs
		/// </summary>
		public string LoadingLibraries
		{
			get { return fLoadingLibraries; }
			set { fLoadingLibraries = value; }
		}
		string fLoadingLibraries = "Loading libraries";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Add
		{
			get { return fAdd; }
			set { fAdd = value; }
		}
		string fAdd = "Add";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Encounter
		{
			get { return fEncounter; }
			set { fEncounter = value; }
		}
		string fEncounter = "Encounter";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SkillChallenge
		{
			get { return fSkillChallenge; }
			set { fSkillChallenge = value; }
		}
		string fSkillChallenge = "Skill Challenge";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string TrapHazzard
		{
			get { return fTrapHazzard; }
			set { fTrapHazzard = value; }
		}
		string fTrapHazzard = "Trap / Hazard";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Quest
		{
			get { return fQuest; }
			set { fQuest = value; }
		}
		string fQuest = "Quest";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Remove
		{
			get { return fRemove; }
			set { fRemove = value; }
		}
		string fRemove = "Remove";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Cut
		{
			get { return fCut; }
			set { fCut = value; }
		}
		string fCut = "Cut";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Copy
		{
			get { return fCopy; }
			set { fCopy = value; }
		}
		string fCopy = "Copy";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Paste
		{
			get { return fPaste; }
			set { fPaste = value; }
		}
		string fPaste = "Paste";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Search
		{
			get { return fSearch; }
			set { fSearch = value; }
		}
		string fSearch = "Search";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string View
		{
			get { return fView; }
			set { fView = value; }
		}
		string fView = "View";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string DefaultView
		{
			get { return fDefaultView; }
			set { fDefaultView = value; }
		}
		string fDefaultView = "Default View";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowEncounters
		{
			get { return fShowEncounters; }
			set { fShowEncounters = value; }
		}
		string fShowEncounters = "Show Encounters";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowTrapsHazards
		{
			get { return fShowTrapsHazards; }
			set { fShowTrapsHazards = value; }
		}
		string fShowTrapsHazards = "Show Traps / Hazards";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowSkillChallenges
		{
			get { return fShowSkillChallenges; }
			set { fShowSkillChallenges = value; }
		}
		string fShowSkillChallenges = "Show Skill Challenges";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowQuests
		{
			get { return fShowQuests; }
			set { fShowQuests = value; }
		}
		string fShowQuests = "Show Quests";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowTreasureParcels
		{
			get { return fShowTreasureParcels; }
			set { fShowTreasureParcels = value; }
		}
		string fShowTreasureParcels = "Show Treasure Parcels";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Highlighting
		{
			get { return fHighlighting; }
			set { fHighlighting = value; }
		}
		string fHighlighting = "Highlighting";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowLinks
		{
			get { return fShowLinks; }
			set { fShowLinks = value; }
		}
		string fShowLinks = "Show Links";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Curved
		{
			get { return fCurved; }
			set { fCurved = value; }
		}
		string fCurved = "Curved";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Angled
		{
			get { return fAngled; }
			set { fAngled = value; }
		}
		string fAngled = "Angled";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Straight
		{
			get { return fStraight; }
			set { fStraight = value; }
		}
		string fStraight = "Straight";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowLevelling
		{
			get { return fShowLevelling; }
			set { fShowLevelling = value; }
		}
		string fShowLevelling = "Show Levelling";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowTooltips
		{
			get { return fShowTooltips; }
			set { fShowTooltips = value; }
		}
		string fShowTooltips = "Show Tooltips";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowNavigation
		{
			get { return fShowNavigation; }
			set { fShowNavigation = value; }
		}
		string fShowNavigation = "Show Navigation";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowPreview
		{
			get { return fShowPreview; }
			set { fShowPreview = value; }
		}
		string fShowPreview = "Show Preview";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Flowchart
		{
			get { return fFlowchart; }
			set { fFlowchart = value; }
		}
		string fFlowchart = "Flowchart";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Print
		{
			get { return fPrint; }
			set { fPrint = value; }
		}
		string fPrint = "Print";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Export
		{
			get { return fExport; }
			set { fExport = value; }
		}
		string fExport = "Export";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string MaximumAvailableXP
		{
			get { return fMaximumAvailableXP; }
			set { fMaximumAvailableXP = value; }
		}
		string fMaximumAvailableXP = "Maximum Available XP";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Advanced
		{
			get { return fAdvanced; }
			set { fAdvanced = value; }
		}
		string fAdvanced = "Advanced";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PlotDesignIssues
		{
			get { return fPlotDesignIssues; }
			set { fPlotDesignIssues = value; }
		}
		string fPlotDesignIssues = "Plot Design Issues";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AdjustDifficulty
		{
			get { return fAdjustDifficulty; }
			set { fAdjustDifficulty = value; }
		}
		string fAdjustDifficulty = "Adjust Difficulty";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AddPoint
		{
			get { return fAddPoint; }
			set { fAddPoint = value; }
		}
		string fAddPoint = "Add Point";


		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string DisconnectPoint
		{
			get { return fDisconnectPoint; }
			set { fDisconnectPoint = value; }
		}
		string fDisconnectPoint = "Disconnect Point";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string DisconnectFrom
		{
			get { return fDisconnectFrom; }
			set { fDisconnectFrom = value; }
		}
		string fDisconnectFrom = "Disconnect From";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string MoveToSubplot
		{
			get { return fMoveToSubplot; }
			set { fMoveToSubplot = value; }
		}
		string fMoveToSubplot = "Move To Subplot";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string State
		{
			get { return fState; }
			set { fState = value; }
		}
		string fState = "State";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Normal
		{
			get { return fNormal; }
			set { fNormal = value; }
		}
		string fNormal = "Normal";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Completed
		{
			get { return fCompleted; }
			set { fCompleted = value; }
		}
		string fCompleted = "Completed";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Skipped
		{
			get { return fSkipped; }
			set { fSkipped = value; }
		}
		string fSkipped = "Skipped";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Edit
		{
			get { return fEdit; }
			set { fEdit = value; }
		}
		string fEdit = "Edit";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExploreSubplot
		{
			get { return fExploreSubplot; }
			set { fExploreSubplot = value; }
		}
		string fExploreSubplot = "Explore Subplot";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string File
		{
			get { return fFile; }
			set { fFile = value; }
		}
		string fFile = "File";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string NewProject
		{
			get { return fNewProject; }
			set { fNewProject = value; }
		}
		string fNewProject = "New Project";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string OpenProject
		{
			get { return fOpenProject; }
			set { fOpenProject = value; }
		}
		string fOpenProject = "Open Project";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SaveProject
		{
			get { return fSaveProject; }
			set { fSaveProject = value; }
		}
		string fSaveProject = "Save Project";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SaveProjectAs
		{
			get { return fSaveProjectAs; }
			set { fSaveProjectAs = value; }
		}
		string fSaveProjectAs = "Save Project As";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string CreateDungeonDelve
		{
			get { return fCreateDungeonDelve; }
			set { fCreateDungeonDelve = value; }
		}
		string fCreateDungeonDelve = "Create a Dungeon Delve";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Exit
		{
			get { return fExit; }
			set { fExit = value; }
		}
		string fExit = "Exit";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Project
		{
			get { return fProject; }
			set { fProject = value; }
		}
		string fProject = "Project";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ProjectProperties
		{
			get { return fProjectProperties; }
			set { fProjectProperties = value; }
		}
		string fProjectProperties = "Project Properties";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ProjectOverview
		{
			get { return fProjectOverview; }
			set { fProjectOverview = value; }
		}
		string fProjectOverview = "Project Overview";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ProjectChecklist
		{
			get { return fProjectChecklist; }
			set { fProjectChecklist = value; }
		}
		string fProjectChecklist = "Project Checklist";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ProjectCampaignSettings
		{
			get { return fProjectCampaignSettings; }
			set { fProjectCampaignSettings = value; }
		}
		string fProjectCampaignSettings = "Campaign Settings";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PasswordProtection
		{
			get { return fPasswordProtection; }
			set { fPasswordProtection = value; }
		}
		string fPasswordProtection = "Password Protection";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string TacticalMaps
		{
			get { return fTacticalMaps; }
			set { fTacticalMaps = value; }
		}
		string fTacticalMaps = "Tactical Maps";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string RegionalMaps
		{
			get { return fRegionalMaps; }
			set { fRegionalMaps = value; }
		}
		string fRegionalMaps = "Regional Maps";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PlayerCharacters
		{
			get { return fPlayerCharacters; }
			set { fPlayerCharacters = value; }
		}
		string fPlayerCharacters = "Player Characters";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string TreasureParcels
		{
			get { return fTreasureParcels; }
			set { fTreasureParcels = value; }
		}
		string fTreasureParcels = "Treasure Parcels";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string EncounterDecks
		{
			get { return fEncounterDecks; }
			set { fEncounterDecks = value; }
		}
		string fEncounterDecks = "Encounter Decks";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string CustomCreaturesNPC
		{
			get { return fCustomCreaturesNPC; }
			set { fCustomCreaturesNPC = value; }
		}
		string fCustomCreaturesNPC = "Custom Creatures and NPCs";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Calendars
		{
			get { return fCalendars; }
			set { fCalendars = value; }
		}
		string fCalendars = "Calendars";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PausedEncounters
		{
			get { return fPausedEncounters; }
			set { fPausedEncounters = value; }
		}
		string fPausedEncounters = "Paused Encounters";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PlayerView
		{
			get { return fPlayerView; }
			set { fPlayerView = value; }
		}
		string fPlayerView = "Player View";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Show
		{
			get { return fShow; }
			set { fShow = value; }
		}
		string fShow = "Show";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Clear
		{
			get { return fClear; }
			set { fClear = value; }
		}
		string fClear = "Clear";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Tools
		{
			get { return fTools; }
			set { fTools = value; }
		}
		string fTools = "Tools";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ImportProject
		{
			get { return fImportProject; }
			set { fImportProject = value; }
		}
		string fImportProject = "Import Project";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExportProject
		{
			get { return fExportProject; }
			set { fExportProject = value; }
		}
		string fExportProject = "Export Project";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExportHandout
		{
			get { return fExportHandout; }
			set { fExportHandout = value; }
		}
		string fExportHandout = "Export Handout";

		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Libraries
		{
			get { return fLibraries; }
			set { fLibraries = value; }
		}
		string fLibraries = "Libraries";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AddIns
		{
			get { return fAddIns; }
			set { fAddIns = value; }
		}
		string fAddIns = "Add-Ins";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Preferences
		{
			get { return fPreferences; }
			set { fPreferences = value; }
		}
		string fPreferences = "Preferences";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string TextSize
		{
			get { return fTextSize; }
			set { fTextSize = value; }
		}
		string fTextSize = "Text Size";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Small
		{
			get { return fSmall; }
			set { fSmall = value; }
		}
		string fSmall = "Small";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Medium
		{
			get { return fMedium; }
			set { fMedium = value; }
		}
		string fMedium = "Medium";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Large
		{
			get { return fLarge; }
			set { fLarge = value; }
		}
		string fLarge = "Large";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ShowOtherDisplay
		{
			get { return fShowOtherDisplay; }
			set { fShowOtherDisplay = value; }
		}
		string fShowOtherDisplay = "Show on Other Display";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Help
		{
			get { return fHelp; }
			set { fHelp = value; }
		}
		string fHelp = "Help";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Manual
		{
			get { return fManual; }
			set { fManual = value; }
		}
		string fManual = "Manual";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string About
		{
			get { return fAbout; }
			set { fAbout = value; }
		}
		string fAbout = "About";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SearchFor
		{
			get { return fSearchFor; }
			set { fSearchFor = value; }
		}
		string fSearchFor = "Search for";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string EditPlotPoint
		{
			get { return fEditPlotPoint; }
			set { fEditPlotPoint = value; }
		}
		string fEditPlotPoint = "Edit Plot Point";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Share
		{
			get { return fShare; }
			set { fShare = value; }
		}
		string fShare = "Share";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SendPlayerView
		{
			get { return fSendPlayerView; }
			set { fSendPlayerView = value; }
		}
		string fSendPlayerView = "Send to Player View";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExportHTML
		{
			get { return fExportHTML; }
			set { fExportHTML = value; }
		}
		string fExportHTML = "Export to HTML";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExportFile
		{
			get { return fExportFile; }
			set { fExportFile = value; }
		}
		string fExportFile = "Export to File";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PlotWorkspace
		{
			get { return fPlotWorkspace; }
			set { fPlotWorkspace = value; }
		}
		string fPlotWorkspace = "Plot Workspace";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Background
		{
			get { return fBackground; }
			set { fBackground = value; }
		}
		string fBackground = "Background";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Information
		{
			get { return fInfoHdr; }
			set { fInfoHdr = value; }
		}
		string fInfoHdr = "Information";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string MoveUp
		{
			get { return fMoveUp; }
			set { fMoveUp = value; }
		}
		string fMoveUp = "Move Up";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string MoveDown
		{
			get { return fMoveDown; }
			set { fMoveDown = value; }
		}
		string fMoveDown = "Move Down";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SelectedItem
		{
			get { return fSelectedItem; }
			set { fSelectedItem = value; }
		}
		string fSelectedItem = "Selected Item";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AllItems
		{
			get { return fAllItems; }
			set { fAllItems = value; }
		}
		string fAllItems = "All Items";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Import
		{
			get { return fImport; }
			set { fImport = value; }
		}
		string fImport = "Import";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Publish
		{
			get { return fPublish; }
			set { fPublish = value; }
		}
		string fPublish = "Publish";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Encyclopedia
		{
			get { return fEncyclopedia; }
			set { fEncyclopedia = value; }
		}
		string fEncyclopedia = "Encyclopedia";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Entries
		{
			get { return fEntries; }
			set { fEntries = value; }
		}
		string fEntries = "Entries";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AddEntry
		{
			get { return fAddEntry; }
			set { fAddEntry = value; }
		}
		string fAddEntry = "Add an Entry";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AddGroup
		{
			get { return fAddGroup; }
			set { fAddGroup = value; }
		}
		string fAddGroup = "Add a Group";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string CampaignRules
		{
			get { return fCampaignRules; }
			set { fCampaignRules = value; }
		}
		string fCampaignRules = "Campaign Rules";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Races
		{
			get { return fRaces; }
			set { fRaces = value; }
		}
		string fRaces = "Races";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Classes
		{
			get { return fClasses; }
			set { fClasses = value; }
		}
		string fClasses = "Classes";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Themes
		{
			get { return fThemes; }
			set { fThemes = value; }
		}
		string fThemes = "Themes";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ParagonPaths
		{
			get { return fParagonPaths; }
			set { fParagonPaths = value; }
		}
		string fParagonPaths = "Paragon Paths";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string EpicDestinies
		{
			get { return fEpicDestinies; }
			set { fEpicDestinies = value; }
		}
		string fEpicDestinies = "Epic Destinies";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Backgrounds
		{
			get { return fBackgrounds; }
			set { fBackgrounds = value; }
		}
		string fBackgrounds = "Backgrounds";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string FeatsHeroicTier
		{
			get { return fFeatsHeroicTier; }
			set { fFeatsHeroicTier = value; }
		}
		string fFeatsHeroicTier = "Feats (heroic tier)";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string FeatsParagonTier
		{
			get { return fFeatsParagonTier; }
			set { fFeatsParagonTier = value; }
		}
		string fFeatsParagonTier = "Feats (paragon tier)";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string FeatsEpicTier
		{
			get { return fFeatsEpicTier; }
			set { fFeatsEpicTier = value; }
		}
		string fFeatsEpicTier = "Feats (epic tier)";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Weapons
		{
			get { return fWeapons; }
			set { fWeapons = value; }
		}
		string fWeapons = "Weapons";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Rituals
		{
			get { return fRituals; }
			set { fRituals = value; }
		}
		string fRituals = "Rituals";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string CreatureLore
		{
			get { return fCreatureLore; }
			set { fCreatureLore = value; }
		}
		string fCreatureLore = "Creature Lore";


		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Diseases
		{
			get { return fDiseases; }
			set { fDiseases = value; }
		}
		string fDiseases = "Diseases";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Poisons
		{
			get { return fPoisons; }
			set { fPoisons = value; }
		}
		string fPoisons = "Poisons";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string RulesElements
		{
			get { return fRulesElements; }
			set { fRulesElements = value; }
		}
		string fRulesElements = "Rules Elements";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Race
		{
			get { return fRace; }
			set { fRace = value; }
		}
		string fRace = "Race";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Class
		{
			get { return fClass; }
			set { fClass = value; }
		}
		string fClass = "Class";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Theme
		{
			get { return fTheme; }
			set { fTheme = value; }
		}
		string fTheme = "Theme";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ParagonPath
		{
			get { return fParagonPath; }
			set { fParagonPath = value; }
		}
		string fParagonPath = "Paragon Path";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string EpicDestiny
		{
			get { return fEpicDestiny; }
			set { fEpicDestiny = value; }
		}
		string fEpicDestiny = "Epic Destiny";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Feat
		{
			get { return fAddFeat; }
			set { fAddFeat = value; }
		}
		string fAddFeat = "Feat";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Weapon
		{
			get { return fWeapon; }
			set { fWeapon = value; }
		}
		string fWeapon = "Weapon";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Ritual
		{
			get { return fRitual; }
			set { fRitual = value; }
		}
		string fRitual = "Ritual";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Disease
		{
			get { return fAddDisease; }
			set { fAddDisease = value; }
		}
		string fAddDisease = "Disease";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Poison
		{
			get { return fAddPoison; }
			set { fAddPoison = value; }
		}
		string fAddPoison = "Poison";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string EncyclopediaEntry
		{
			get { return fEncyclopediaEntry; }
			set { fEncyclopediaEntry = value; }
		}
		string fEncyclopediaEntry = "Encyclopedia Entry";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Attachments
		{
			get { return fAttachments; }
			set { fAttachments = value; }
		}
		string fAttachments = "Attachments";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Attachment
		{
			get { return fAttachment; }
			set { fAttachment = value; }
		}
		string fAttachment = "Attachment";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Size
		{
			get { return fSize; }
			set { fSize = value; }
		}
		string fSize = "Size";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Extract
		{
			get { return fExtract; }
			set { fExtract = value; }
		}
		string fExtract = "Extract";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExtractToDesktop
		{
			get { return fExtractToDesktop; }
			set { fExtractToDesktop = value; }
		}
		string fExtractToDesktop = "Extract to Desktop";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExtractToDesktopAndOpen
		{
			get { return fExtractToDesktopAndOpen; }
			set { fExtractToDesktopAndOpen = value; }
		}
		string fExtractToDesktopAndOpen = "Extract to Desktop and Open";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Jotter
		{
			get { return fJotter; }
			set { fJotter = value; }
		}
		string fJotter = "Jotter";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Issues
		{
			get { return fIssues; }
			set { fIssues = value; }
		}
		string fIssues = "Issues";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Notes
		{
			get { return fNotes; }
			set { fNotes = value; }
		}
		string fNotes = "Notes";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string AddNote
		{
			get { return fAddNote; }
			set { fAddNote = value; }
		}
		string fAddNote = "Add Note";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string RemoveNote
		{
			get { return fRemoveNote; }
			set { fRemoveNote = value; }
		}
		string fRemoveNote = "Remove Note";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string SetCategory
		{
			get { return fSetCategory; }
			set { fSetCategory = value; }
		}
		string fSetCategory = "Set Category";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string InSessionReference
		{
			get { return fInSessionReference; }
			set { fInSessionReference = value; }
		}
		string fInSessionReference = "In-Session Reference";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PartyBreakdown
		{
			get { return fPartyBreakdown; }
			set { fPartyBreakdown = value; }
		}
		string fPartyBreakdown = "Party Breakdown";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string RandomGenerators
		{
			get { return fRandomGenerators; }
			set { fRandomGenerators = value; }
		}
		string fRandomGenerators = "Random Generators";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Generators
		{
			get { return fGenerators; }
			set { fGenerators = value; }
		}
		string fGenerators = "Generators";


		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string toolStrip1
		{
			get { return ftoolStrip1; }
			set { ftoolStrip1 = value; }
		}
		string ftoolStrip1 = "toolStrip1";


		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ElvishNames
		{
			get { return fElvishNames; }
			set { fElvishNames = value; }
		}
		string fElvishNames = "Elvish Names";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string DwarvishNames
		{
			get { return fDwarvishNames; }
			set { fDwarvishNames = value; }
		}
		string fDwarvishNames = "Dwarvish Names";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string HalflingNames
		{
			get { return fHalflingNames; }
			set { fHalflingNames = value; }
		}
		string fHalflingNames = "Halfling Names";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExoticNames
		{
			get { return fExoticNames; }
			set { fExoticNames = value; }
		}
		string fExoticNames = "Exotic Names";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ArtObjects
		{
			get { return fArtObjects; }
			set { fArtObjects = value; }
		}
		string fArtObjects = "Art Objects";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string BookTitles
		{
			get { return fBookTitles; }
			set { fBookTitles = value; }
		}
		string fBookTitles = "Book Titles";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string Potions
		{
			get { return fPotions; }
			set { fPotions = value; }
		}
		string fPotions = "Potions";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string NPCDescription
		{
			get { return fNPCDescription; }
			set { fNPCDescription = value; }
		}
		string fNPCDescription = "NPC Description";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string RoomDescription
		{
			get { return fRoomDescription; }
			set { fRoomDescription = value; }
		}
		string fRoomDescription = "Room Description";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ElvishText
		{
			get { return fElvishText; }
			set { fElvishText = value; }
		}
		string fElvishText = "Elvish Text";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string DwarvishText
		{
			get { return fDwarvishText; }
			set { fDwarvishText = value; }
		}
		string fDwarvishText = "Dwarvish Text";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string PrimordialText
		{
			get { return fPrimordialText; }
			set { fPrimordialText = value; }
		}
		string fPrimordialText = "Primordial Text";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string DieRoller
		{
			get { return fDieRoller; }
			set { fDieRoller = value; }
		}
		string fDieRoller = "Die Roller";

		
		/// <summary>
		/// No Comment default value.
		/// MainForm.Designer.cs
		/// </summary>
		public string ExtraLarge
		{
			get { return fExtraLarge; }
			set { fExtraLarge = value; }
		}
		string fExtraLarge = "Extra Large";

		
		/// <summary>
		/// No Comment default value.
		/// </summary>
		public string Cancel
		{
			get { return fCancel; }
			set { fCancel = value; }
		}
		string fCancel = "Cancel";


		/// <summary>
		/// No Comment default value.
		/// Data/Artifact.cs
		/// </summary>
		public string Pleased
		{
			get { return fPleased; }
			set { fPleased = value; }
		}
		string fPleased = "Pleased";


		/// <summary>
		/// No Comment default value.
		/// Data/Artifact.cs
		/// </summary>
		public string Satisfied
		{
			get { return fSatisfied; }
			set { fSatisfied = value; }
		}
		string fSatisfied = "Satisfied";


		/// <summary>
		/// No Comment default value.
		/// Data/Artifact.cs
		/// </summary>
		public string Unsatisfied
		{
			get { return fUnsatisfied; }
			set { fUnsatisfied = value; }
		}
		string fUnsatisfied = "Unsatisfied";


		/// <summary>
		/// No Comment default value.
		/// Data/Artifact.cs
		/// </summary>
		public string Angered
		{
			get { return fAngered; }
			set { fAngered = value; }
		}
		string fAngered = "Angered";


		/// <summary>
		/// No Comment default value.
		/// Data/Artifact.cs
		/// </summary>
		public string MovingOn
		{
			get { return fMovingOn; }
			set { fMovingOn = value; }
		}
		string fMovingOn = "Moving On";


		/// <summary>
		/// No Comment default value.
		/// Data/CombatState.cs
		/// </summary>
		public string At
		{
			get { return fDateAt; }
			set { fDateAt = value; }
		}
		string fDateAt = "at";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string OngoingDamage
		{
			get { return fOngoingDamage; }
			set { fOngoingDamage = value; }
		}
		string fOngoingDamage = "ongoing damage";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string Ongoing
		{
			get { return fOngoing; }
			set { fOngoing = value; }
		}
		string fOngoing = "ongoing";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string Damage
		{
			get { return fDamage; }
			set { fDamage = value; }
		}
		string fDamage = "damage";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string OngoingDefences
		{
			get { return fOngoingDefences; }
			set { fOngoingDefences = value; }
		}
		string fOngoingDefences = "defences";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string To
		{
			get { return fTo; }
			set { fTo = value; }
		}
		string fTo = "to";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string Regeneration
		{
			get { return fRegeneration; }
			set { fRegeneration = value; }
		}
		string fRegeneration = "Regeneration";


		/// <summary>
		/// No Comment default value.
		/// Data/Conditions.cs
		/// </summary>
		public string Aura
		{
			get { return fAura; }
			set { fAura = value; }
		}
		string fAura = "Aura";


		/// <summary>
		/// No Comment default value.
		/// Data/Creature.cs
		/// </summary>
		public string Squares
		{
			get { return fSquares; }
			set { fSquares = value; }
		}
		string fSquares = "squares";


		/// <summary>
		/// No Comment default value.
		/// Data/Creature.cs
		/// </summary>
		public string Level
		{
			get { return fLevel; }
			set { fLevel = value; }
		}
		string fLevel = "Level";


		/// <summary>
		/// No Comment default value.
		/// Data/Creature.cs
		/// </summary>
		public string MagicalBeast
		{
			get { return fMagicalBeast; }
			set { fMagicalBeast = value; }
		}
		string fMagicalBeast = "magical beast";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LowerMelee
		{
			get { return fLowerMelee; }
			set { fLowerMelee = value; }
		}
		string fLowerMelee = "melee";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LowerRanged
		{
			get { return fLowerRanged; }
			set { fLowerRanged = value; }
		}
		string fLowerRanged = "ranged";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LowerArea
		{
			get { return fLowerArea; }
			set { fLowerArea = value; }
		}
		string fLowerArea = "area";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LowerClose
		{
			get { return fLowerClose; }
			set { fLowerClose = value; }
		}
		string fLowerClose = "close";

		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LowerDouble
		{
			get { return fLowerDouble; }
			set { fLowerDouble = value; }
		}
		string fLowerDouble = "double";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Actions
		{
			get { return fActions; }
			set { fActions = value; }
		}
		string fActions = "Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Traits
		{
			get { return fTraits; }
			set { fTraits = value; }
		}
		string fTraits = "Traits";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string StandardActions
		{
			get { return fStandardActions; }
			set { fStandardActions = value; }
		}
		string fStandardActions = "Standard Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string MoveActions
		{
			get { return fMoveActions; }
			set { fMoveActions = value; }
		}
		string fMoveActions = "Move Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string MinorActions
		{
			get { return fMinorActions; }
			set { fMinorActions = value; }
		}
		string fMinorActions = "Minor Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string FreeActions
		{
			get { return fFreeActions; }
			set { fFreeActions = value; }
		}
		string fFreeActions = "Free Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string TriggeredActions
		{
			get { return fTriggeredActions; }
			set { fTriggeredActions = value; }
		}
		string fTriggeredActions = "Triggered Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string OtherActions
		{
			get { return fOtherActions; }
			set { fOtherActions = value; }
		}
		string fOtherActions = "Other Actions";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelChangeAction
		{
			get { return fLabelChangeAction; }
			set { fLabelChangeAction = value; }
		}
		string fLabelChangeAction = "click here to change the action";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelRechargePower
		{
			get { return fLabelRechargePower; }
			set { fLabelRechargePower = value; }
		}
		string fLabelRechargePower = "recharge this power";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelUsePower
		{
			get { return fLabelUsePower; }
			set { fLabelUsePower = value; }
		}
		string fLabelUsePower = "use this power";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Note
		{
			get { return fNote; }
			set { fNote = value; }
		}
		string fNote = "Note";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelNotePower
		{
			get { return fLabelNotePower; }
			set { fLabelNotePower = value; }
		}
		string fLabelNotePower = "This power is part of a functional template, and so its attack bonus will be increased by the level of the creature it is applied to.";
		
		
		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelReadAloud
		{
			get { return fLabelReadAloud; }
			set { fLabelReadAloud = value; }
		}
		string fLabelReadAloud = "Set read-aloud description(optional)";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string ImmediateInterrupt
		{
			get { return fImmediateInterrupt; }
			set { fImmediateInterrupt = value; }
		}
		string fImmediateInterrupt = "immediate interrupt";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string NoAction
		{
			get { return fNoAction; }
			set { fNoAction = value; }
		}
		string fNoAction = "no action";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string ImmediateReaction
		{
			get { return fImmediateReaction; }
			set { fImmediateReaction = value; }
		}
		string fImmediateReaction = "immediate reaction";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Action
		{
			get { return fAction; }
			set { fAction = value; }
		}
		string fAction = "action";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string NoPrerequisite
		{
			get { return fNoPrerequisite; }
			set { fNoPrerequisite = value; }
		}
		string fNoPrerequisite = "No prerequisite";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Prerequisite
		{
			get { return fPrerequisite; }
			set { fPrerequisite = value; }
		}
		string fPrerequisite = "Prerequisite";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelNoRange
		{
			get { return fLabelNoRange; }
			set { fLabelNoRange = value; }
		}
		string fLabelNoRange = "The power's range and its target(s) are not set";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelSetAttack
		{
			get { return fLabelSetAttack; }
			set { fLabelSetAttack = value; }
		}
		string fLabelSetAttack = "Click here to make this an attack power";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string ClearAttack
		{
			get { return fClearAttack; }
			set { fClearAttack = value; }
		}
		string fClearAttack = "clear attack";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Range
		{
			get { return fRange; }
			set { fRange = value; }
		}
		string fRange = "Range";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string LabelSpecPowEff
		{
			get { return fLabelSpecPowEff; }
			set { fLabelSpecPowEff = value; }
		}
		string fLabelSpecPowEff = "Specify the power's effects";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string NoDetails
		{
			get { return fNoDetails; }
			set { fNoDetails = value; }
		}
		string fNoDetails = "no details";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string AC
		{
			get { return fAC; }
			set { fAC = value; }
		}
		string fAC = "AC";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Fort
		{
			get { return fFort; }
			set { fFort = value; }
		}
		string fFort = "Fort";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Ref
		{
			get { return fRef; }
			set { fRef = value; }
		}
		string fRef = "Ref";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Will
		{
			get { return fWill; }
			set { fWill = value; }
		}
		string fWill = "Will";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string RechargesOn
		{
			get { return fRechargesOn; }
			set { fRechargesOn = value; }
		}
		string fRechargesOn = "Recharges on";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string AtWill
		{
			get { return fAtWill; }
			set { fAtWill = value; }
		}
		string fAtWill = "At-Will";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string BasicAttack
		{
			get { return fBasicAttack; }
			set { fBasicAttack = value; }
		}
		string fBasicAttack = "(basic attack)";

		
		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Daily
		{
			get { return fDaily; }
			set { fDaily = value; }
		}
		string fDaily = "Daily";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Attack
		{
			get { return fAttack; }
			set { fAttack = value; }
		}
		string fAttack = "Attack";


		/// <summary>
		/// No Comment default value.
		/// Data/CreaturePower.cs
		/// </summary>
		public string Sustain
		{
			get { return fSustain; }
			set { fSustain = value; }
		}
		string fSustain = "Sustain";


		/// <summary>
		/// No Comment default value.
		/// Data/CreatureTemplate.cs
		/// </summary>
		public string Elite
		{
			get { return fElite; }
			set { fElite = value; }
		}
		string fElite = "Elite";


		/// <summary>
		/// No Comment default value.
		/// Data/Damage.cs
		/// </summary>
		public string ImmuneTo
		{
			get { return fImmuneTo; }
			set { fImmuneTo = value; }
		}
		string fImmuneTo = "Immune to";


		/// <summary>
		/// No Comment default value.
		/// Data/Damage.cs
		/// </summary>
		public string Resist
		{
			get { return fResist; }
			set { fResist = value; }
		}
		string fResist = "Resist";


		/// <summary>
		/// No Comment default value.
		/// Data/Damage.cs
		/// </summary>
		public string Vulnerable
		{
			get { return fVulnerable; }
			set { fVulnerable = value; }
		}
		string fVulnerable = "Vulnerable";


		/// <summary>
		/// No Comment default value.
		/// Data/Encounter.cs
		/// </summary>
		public string Illumination
		{
			get { return fIllumination; }
			set { fIllumination = value; }
		}
		string fIllumination = "Illumination";


		/// <summary>
		/// No Comment default value.
		/// Data/Encounter.cs
		/// </summary>
		public string LabelFeaturesArea
		{
			get { return fLabelFeaturesArea; }
			set { fLabelFeaturesArea = value; }
		}
		string fLabelFeaturesArea = "Features of the Area";


		/// <summary>
		/// No Comment default value.
		/// Data/Encounter.cs
		/// </summary>
		public string Setup
		{
			get { return fSetup; }
			set { fSetup = value; }
		}
		string fSetup = "Setup";


		/// <summary>
		/// No Comment default value.
		/// Data/Encounter.cs
		/// </summary>
		public string Tactics
		{
			get { return fTactics; }
			set { fTactics = value; }
		}
		string fTactics = "Tactics";


		/// <summary>
		/// No Comment default value.
		/// Data/Encounter.cs
		/// </summary>
		public string VictoryConditions
		{
			get { return fVictoryConditions; }
			set { fVictoryConditions = value; }
		}
		string fVictoryConditions = "Victory Conditions";


		/// <summary>
		/// No Comment default value.
		/// Data/EncounterLog.cs
		/// </summary>
		public string Creature
		{
			get { return fCreature; }
			set { fCreature = value; }
		}
		string fCreature = "Creature";


		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string GettingStarted
		{
			get { return fGettingStarted; }
			set { fGettingStarted = value; }
		}
		string fGettingStarted = "Getting Started";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LoadingProject
		{
			get { return fLoadingProject; }
			set { fLoadingProject = value; }
		}
		string fLoadingProject = "Loading project";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string New
		{
			get { return fNew; }
			set { fNew = value; }
		}
		string fNew = "new";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Open
		{
			get { return fOpen; }
			set { fOpen = value; }
		}
		string fOpen = "open";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Last
		{
			get { return fLast; }
			set { fLast = value; }
		}
		string fLast = "last";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Delve
		{
			get { return fDelve; }
			set { fDelve = value; }
		}
		string fDelve = "delve";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Genesis
		{
			get { return fGenesis; }
			set { fGenesis = value; }
		}
		string fGenesis = "genesis";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NewCreature
		{
			get { return fNewCreature; }
			set { fNewCreature = value; }
		}
		string fNewCreature = "New Creature";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Exodus
		{
			get { return fExodus; }
			set { fExodus = value; }
		}
		string fExodus = "exodus";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NewTemplate
		{
			get { return fNewTemplate; }
			set { fNewTemplate = value; }
		}
		string fNewTemplate = "New Template";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Minos
		{
			get { return fMinos; }
			set { fMinos = value; }
		}
		string fMinos = "minos";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NewTrap
		{
			get { return fNewTrap; }
			set { fNewTrap = value; }
		}
		string fNewTrap = "New Trap";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Excalibur
		{
			get { return fExcalibur; }
			set { fExcalibur = value; }
		}
		string fExcalibur = "excalibur";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NewMagicItem
		{
			get { return fNewMagicItem; }
			set { fNewMagicItem = value; }
		}
		string fNewMagicItem = "New Magic Item";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Indiana
		{
			get { return fIndiana; }
			set { fIndiana = value; }
		}
		string fIndiana = "indiana";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NewArtifact
		{
			get { return fNewArtifact; }
			set { fNewArtifact = value; }
		}
		string fNewArtifact = "New Artifact";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MainMenu
		{
			get { return fMainMenu; }
			set { fMainMenu = value; }
		}
		string fMainMenu = "Main Menu";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Reopen
		{
			get { return fReopen; }
			set { fReopen = value; }
		}
		string fReopen = "Reopen";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CreateNewAdventureProject
		{
			get { return fCreateNewAdventureProject; }
			set { fCreateNewAdventureProject = value; }
		}
		string fCreateNewAdventureProject = "Create a new adventure project";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string OpenExistingProject
		{
			get { return fOpenExistingProject; }
			set { fOpenExistingProject = value; }
		}
		string fOpenExistingProject = "Open an existing project";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string GenerateRandomDungeonDelve
		{
			get { return fGenerateRandomDungeonDelve; }
			set { fGenerateRandomDungeonDelve = value; }
		}
		string fGenerateRandomDungeonDelve = "Generate a random dungeon delve";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ReadManual
		{
			get { return fReadManual; }
			set { fReadManual = value; }
		}
		string fReadManual = "Read the Masterplan user manual";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string None
		{
			get { return fNone; }
			set { fNone = value; }
		}
		string fNone = "none";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string XP
		{
			get { return fXP; }
			set { fXP = value; }
		}
		string fXP = "XP";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Difficulty
		{
			get { return fDifficulty; }
			set { fDifficulty = value; }
		}
		string fDifficulty = "Difficulty";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoMapSelected
		{
			get { return fNoMapSelected; }
			set { fNoMapSelected = value; }
		}
		string fNoMapSelected = "no map selected";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelDoubleClickSetLocation
		{
			get { return fLabelDoubleClickSetLocation; }
			set { fLabelDoubleClickSetLocation = value; }
		}
		string fLabelDoubleClickSetLocation = "Double-click on the map to set a location.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Location
		{
			get { return fLocation; }
			set { fLocation = value; }
		}
		string fLocation = "Location";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Dices
		{
			get { return fDices; }
			set { fDices = value; }
		}
		string fDices = "DCs";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoSkills
		{
			get { return fNoSkills; }
			set { fNoSkills = value; }
		}
		string fNoSkills = "no skills";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoCountermeasures
		{
			get { return fNoCountermeasures; }
			set { fNoCountermeasures = value; }
		}
		string fNoCountermeasures = "no countermeasures";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoHeroes
		{
			get { return fNoHeroes; }
			set { fNoHeroes = value; }
		}
		string fNoHeroes = "no heroes";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Total
		{
			get { return fTotal; }
			set { fTotal = value; }
		}
		string fTotal = "Total";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoCalendar
		{
			get { return fNoCalendar; }
			set { fNoCalendar = value; }
		}
		string fNoCalendar = "no calendar";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string StartOf
		{
			get { return fStartOf; }
			set { fStartOf = value; }
		}
		string fStartOf = "Start of";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoCards
		{
			get { return fNoCards; }
			set { fNoCards = value; }
		}
		string fNoCards = "no cards";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelClickOnCardMoveFront
		{
			get { return fLabelClickOnCardMoveFront; }
			set { fLabelClickOnCardMoveFront = value; }
		}
		string fLabelClickOnCardMoveFront = "Click on a card to move it to the front of the deck.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MoreCards
		{
			get { return fMoreCards; }
			set { fMoreCards = value; }
		}
		string fMoreCards = "more cards";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoDeck
		{
			get { return fNoDeck; }
			set { fNoDeck = value; }
		}
		string fNoDeck = "no deck";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SoldierBrute
		{
			get { return fSoldierBrute; }
			set { fSoldierBrute = value; }
		}
		string fSoldierBrute = "Sldr / Brute";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Lower
		{
			get { return fLower; }
			set { fLower = value; }
		}
		string fLower = "Lower";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Higher
		{
			get { return fHigher; }
			set { fHigher = value; }
		}
		string fHigher = "Higher";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Lvl
		{
			get { return fLvl; }
			set { fLvl = value; }
		}
		string fLvl = "Lvl";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Cards
		{
			get { return fCards; }
			set { fCards = value; }
		}
		string fCards = "cards";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Artillery
		{
			get { return fArtillery; }
			set { fArtillery = value; }
		}
		string fArtillery = "Artillery";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Brute
		{
			get { return fBrute; }
			set { fBrute = value; }
		}
		string fBrute = "Brute";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Controller
		{
			get { return fController; }
			set { fController = value; }
		}
		string fController = "Controller";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Lurker
		{
			get { return fLurker; }
			set { fLurker = value; }
		}
		string fLurker = "Lurker";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Skirmisher
		{
			get { return fSkirmisher; }
			set { fSkirmisher = value; }
		}
		string fSkirmisher = "Skirmisher";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Soldier
		{
			get { return fSoldier; }
			set { fSoldier = value; }
		}
		string fSoldier = "Soldier";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Blaster
		{
			get { return fBlaster; }
			set { fBlaster = value; }
		}
		string fBlaster = "Blaster";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Obstacle
		{
			get { return fObstacle; }
			set { fObstacle = value; }
		}
		string fObstacle = "Obstacle";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Warder
		{
			get { return fWarder; }
			set { fWarder = value; }
		}
		string fWarder = "Warder";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Standard
		{
			get { return fStandard; }
			set { fStandard = value; }
		}
		string fStandard = "Standard";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Solo
		{
			get { return fSolo; }
			set { fSolo = value; }
		}
		string fSolo = "Solo";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Minion
		{
			get { return fMinion; }
			set { fMinion = value; }
		}
		string fMinion = "Minion";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Leader
		{
			get { return fLeader; }
			set { fLeader = value; }
		}
		string fLeader = "Leader";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Collapse
		{
			get { return fCollapse; }
			set { fCollapse = value; }
		}
		string fCollapse = "Collapse";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Expand
		{
			get { return fExpand; }
			set { fExpand = value; }
		}
		string fExpand = "Expand";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Name
		{
			get { return fName; }
			set { fName = value; }
		}
		string fName = "Name";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Category
		{
			get { return fCategory; }
			set { fCategory = value; }
		}
		string fCategory = "Category";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Role
		{
			get { return fRole; }
			set { fRole = value; }
		}
		string fRole = "Role";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Type
		{
			get { return fType; }
			set { fType = value; }
		}
		string fType = "Type";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Origin
		{
			get { return fOrigin; }
			set { fOrigin = value; }
		}
		string fOrigin = "Origin";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Keywords
		{
			get { return fKeywords; }
			set { fKeywords = value; }
		}
		string fKeywords = "Keywords";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AppropriateOnly
		{
			get { return fAppropriateOnly; }
			set { fAppropriateOnly = value; }
		}
		string fAppropriateOnly = "appropriate only";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Source
		{
			get { return fSource; }
			set { fSource = value; }
		}
		string fSource = "Source";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Easy
		{
			get { return fEasy; }
			set { fEasy = value; }
		}
		string fEasy = "Easy";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DC
		{
			get { return fDC; }
			set { fDC = value; }
		}
		string fDC = "DC";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Moderate
		{
			get { return fModerate; }
			set { fModerate = value; }
		}
		string fModerate = "Moderate";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Hard
		{
			get { return fHard; }
			set { fHard = value; }
		}
		string fHard = "Hard";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AidAnother
		{
			get { return fAidAnother; }
			set { fAidAnother = value; }
		}
		string fAidAnother = "Aid Another";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelAgainstSingleTarget
		{
			get { return fLabelAgainstSingleTarget; }
			set { fLabelAgainstSingleTarget = value; }
		}
		string fLabelAgainstSingleTarget = "Against a single target";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelAgainstMultipleTargets
		{
			get { return fLabelAgainstMultipleTargets; }
			set { fLabelAgainstMultipleTargets = value; }
		}
		string fLabelAgainstMultipleTargets = "Against multiple targets";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelFromMinion
		{
			get { return fLabelFromMinion; }
			set { fLabelFromMinion = value; }
		}
		string fLabelFromMinion = "From a minion";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Aberrant
		{
			get { return fAberrant; }
			set { fAberrant = value; }
		}
		string fAberrant = "Aberrant";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Dungeoneering
		{
			get { return fDungeoneering; }
			set { fDungeoneering = value; }
		}
		string fDungeoneering = "Dungeoneering";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Elemental
		{
			get { return fElemental; }
			set { fElemental = value; }
		}
		string fElemental = "Elemental";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Arcana
		{
			get { return fArcana; }
			set { fArcana = value; }
		}
		string fArcana = "Arcana";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Fey
		{
			get { return fFey; }
			set { fFey = value; }
		}
		string fFey = "Fey";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Immortal
		{
			get { return fImmortal; }
			set { fImmortal = value; }
		}
		string fImmortal = "Immortal";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Religion
		{
			get { return fReligion; }
			set { fReligion = value; }
		}
		string fReligion = "Religion";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Natural
		{
			get { return fNatural; }
			set { fNatural = value; }
		}
		string fNatural = "Natural";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Nature
		{
			get { return fNature; }
			set { fNature = value; }
		}
		string fNature = "Nature";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Shadow
		{
			get { return fShadow; }
			set { fShadow = value; }
		}
		string fShadow = "Shadow";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string UndeadKeyword
		{
			get { return fUndeadKeyword; }
			set { fUndeadKeyword = value; }
		}
		string fUndeadKeyword = "Undead keyword";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Strength
		{
			get { return fStrength; }
			set { fStrength = value; }
		}
		string fStrength = "Strength";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Constitution
		{
			get { return fConstitution; }
			set { fConstitution = value; }
		}
		string fConstitution = "Constitution";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Dexterity
		{
			get { return fDexterity; }
			set { fDexterity = value; }
		}
		string fDexterity = "Dexterity";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Intelligence
		{
			get { return fIntelligence; }
			set { fIntelligence = value; }
		}
		string fIntelligence = "Intelligence";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Wisdom
		{
			get { return fWisdom; }
			set { fWisdom = value; }
		}
		string fWisdom = "Wisdom";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Charisma
		{
			get { return fCharisma; }
			set { fCharisma = value; }
		}
		string fCharisma = "Charisma";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp1
		{
			get { return fLabelLibHelp1; }
			set { fLabelLibHelp1 = value; }
		}
		string fLabelLibHelp1 = "This is the Libraries screen.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp2A
		{
			get { return fLabelLibHelp2A; }
			set { fLabelLibHelp2A = value; }
		}
		string fLabelLibHelp2A = "What is a library?";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp2B
		{
			get { return fLabelLibHelp2B; }
			set { fLabelLibHelp2B = value; }
		}
		string fLabelLibHelp2B = "A library is a file containing a collection of reusable items such as creatures, traps and hazards, magic items and map tiles. On the left you can see the list of libraries that are currently installed. When you select one of these libraries you can see the items it contains.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp3A
		{
			get { return fLabelLibHelp3A; }
			set { fLabelLibHelp3A = value; }
		}
		string fLabelLibHelp3A = "I have a library file, how do I install it?";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp3B
		{
			get { return fLabelLibHelp3B; }
			set { fLabelLibHelp3B = value; }
		}
		string fLabelLibHelp3B = "First, find the folder containing Masterplan; there will be a sub-folder called Libraries. Move your library file into this folder, and restart Masterplan.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp4A
		{
			get { return fLabelLibHelp4A; }
			set { fLabelLibHelp4A = value; }
		}
		string fLabelLibHelp4A = "How do I import a creature from Adventure Tools?";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp4B
		{
			get { return fLabelLibHelp4B; }
			set { fLabelLibHelp4B = value; }
		}
		string fLabelLibHelp4B = "If you have exported a .monster file from Adventure Tools you can import them into a library. Choose the library you want to add the creature to, and select it on the left. On the Creatures tab, press the down-arrow beside the Add button, and select Import from Adventure Tools to bring up a file browser. Select the .monster file, and it will be imported into your library.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp5A
		{
			get { return fLabelLibHelp5A; }
			set { fLabelLibHelp5A = value; }
		}
		string fLabelLibHelp5A = "How do I create map tiles from image files?";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelLibHelp5B
		{
			get { return fLabelLibHelp5B; }
			set { fLabelLibHelp5B = value; }
		}
		string fLabelLibHelp5B = "If you have a selection of image files that you want to use as map tiles, you can import them into a library. Choose the library you want to add the tiles to, and select it on the left. On the Map Tiles tab, press the Add button to bring up a file browser. Select the image files to import them into your library. Masterplan will try to work out the dimensions of each tile, but you can edit any that are incorrect by right-clicking on the tile and selecting Set Size. You can also set the category of each tile – this is particularly useful if you want to use the Map AutoBuild feature to build random dungeon maps automatically.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap1
		{
			get { return fLabelMapViewCap1; }
			set { fLabelMapViewCap1 = value; }
		}
		string fLabelMapViewCap1 = "To create map areas (rooms etc), right-click on the map and drag.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap2
		{
			get { return fLabelMapViewCap2; }
			set { fLabelMapViewCap2 = value; }
		}
		string fLabelMapViewCap2 = "You need to give this map a name.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap3
		{
			get { return fLabelMapViewCap3; }
			set { fLabelMapViewCap3 = value; }
		}
		string fLabelMapViewCap3 = "To begin, drag tiles from the list on the right onto the blueprint.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap4
		{
			get { return fLabelMapViewCap4; }
			set { fLabelMapViewCap4 = value; }
		}
		string fLabelMapViewCap4 = "Map is in scroll / zoom mode; double-click to return to tactical mode.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap5
		{
			get { return fLabelMapViewCap5; }
			set { fLabelMapViewCap5 = value; }
		}
		string fLabelMapViewCap5 = "Map is in drawing mode; double-click to return to tactical mode.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap6
		{
			get { return fLabelMapViewCap6; }
			set { fLabelMapViewCap6 = value; }
		}
		string fLabelMapViewCap6 = "Map is in line of sight mode; select tokens to check sightlines, or double-click to return to tactical mode.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap7
		{
			get { return fLabelMapViewCap7; }
			set { fLabelMapViewCap7 = value; }
		}
		string fLabelMapViewCap7 = "Release here to create a link.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMapViewCap8
		{
			get { return fLabelMapViewCap8; }
			set { fLabelMapViewCap8 = value; }
		}
		string fLabelMapViewCap8 = "Release here to remove the";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Link
		{
			get { return fLink; }
			set { fLink = value; }
		}
		string fLink = "link";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoProject
		{
			get { return fNoProject; }
			set { fNoProject = value; }
		}
		string fNoProject = "no project";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoPlotPoints
		{
			get { return fNoPlotPoints; }
			set { fNoPlotPoints = value; }
		}
		string fNoPlotPoints = "no plot points";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MajorQuest
		{
			get { return fMajorQuest; }
			set { fMajorQuest = value; }
		}
		string fMajorQuest = "Major quest";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MinorQuest
		{
			get { return fMinorQuest; }
			set { fMinorQuest = value; }
		}
		string fMinorQuest = "Minor quest";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AdventureDesignStudio
		{
			get { return fAdventureDesignStudio; }
			set { fAdventureDesignStudio = value; }
		}
		string fAdventureDesignStudio = "Adventure Design Studio";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string OrLower
		{
			get { return fOrLower; }
			set { fOrLower = value; }
		}
		string fOrLower = "or lower";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SaveEnds
		{
			get { return fSaveEnds; }
			set { fSaveEnds = value; }
		}
		string fSaveEnds = "save ends";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string With
		{
			get { return fWith; }
			set { fWith = value; }
		}
		string fWith = "with";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Mod
		{
			get { return fMod; }
			set { fMod = value; }
		}
		string fMod = "mod";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SomeoneElses
		{
			get { return fSomeoneElses; }
			set { fSomeoneElses = value; }
		}
		string fSomeoneElses = "someone else's";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ComaS
		{
			get { return fComaS; }
			set { fComaS = value; }
		}
		string fComaS = "'s";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string My
		{
			get { return fMy; }
			set { fMy = value; }
		}
		string fMy = "my";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string UntilStartOf
		{
			get { return fUntilStartOf; }
			set { fUntilStartOf = value; }
		}
		string fUntilStartOf = "until the start of";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string UntilEndOf
		{
			get { return fUntilEndOf; }
			set { fUntilEndOf = value; }
		}
		string fUntilEndOf = "until the end of";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NextTurn
		{
			get { return fNextTurn; }
			set { fNextTurn = value; }
		}
		string fNextTurn = "next turn";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string UnknownCreature
		{
			get { return fUnknownCreature; }
			set { fUnknownCreature = value; }
		}
		string fUnknownCreature = "unknown creature";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AdjustedFrom
		{
			get { return fAdjustedFrom; }
			set { fAdjustedFrom = value; }
		}
		string fAdjustedFrom = "adjusted from";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Was
		{
			get { return fWas; }
			set { fWas = value; }
		}
		string fWas = "was";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Round
		{
			get { return fRound; }
			set { fRound = value; }
		}
		string fRound = "Round";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string StartTurn
		{
			get { return fStartTurn; }
			set { fStartTurn = value; }
		}
		string fStartTurn = "Start turn";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Takes
		{
			get { return fTakes; }
			set { fTakes = value; }
		}
		string fTakes = "takes";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Heals
		{
			get { return fHeals; }
			set { fHeals = value; }
		}
		string fHeals = "heals";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Is
		{
			get { return fIs; }
			set { fIs = value; }
		}
		string fIs = "is";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NotBloodied
		{
			get { return fNotBloodied; }
			set { fNotBloodied = value; }
		}
		string fNotBloodied = "not bloodied";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Gained
		{
			get { return fGained; }
			set { fGained = value; }
		}
		string fGained = "gained";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Lost
		{
			get { return fLost; }
			set { fLost = value; }
		}
		string fLost = "lost";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Used
		{
			get { return fUsed; }
			set { fUsed = value; }
		}
		string fUsed = "used";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Recharged
		{
			get { return fRecharged; }
			set { fRecharged = value; }
		}
		string fRecharged = "recharged";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string GainedSuccess
		{
			get { return fGainedSuccess; }
			set { fGainedSuccess = value; }
		}
		string fGainedSuccess = "gained a success";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string IncurredFailure
		{
			get { return fIncurredFailure; }
			set { fIncurredFailure = value; }
		}
		string fIncurredFailure = "incurred a failure";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Moves
		{
			get { return fMoves; }
			set { fMoves = value; }
		}
		string fMoves = "moves";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SQ
		{
			get { return fSQ; }
			set { fSQ = value; }
		}
		string fSQ = "sq";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Paused
		{
			get { return fPaused; }
			set { fPaused = value; }
		}
		string fPaused = "Paused";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Resumed
		{
			get { return fResumed; }
			set { fResumed = value; }
		}
		string fResumed = "Resumed";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string PCs
		{
			get { return fPCs; }
			set { fPCs = value; }
		}
		string fPCs = "PCs";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Allies
		{
			get { return fAllies; }
			set { fAllies = value; }
		}
		string fAllies = "Allies";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Neutral
		{
			get { return fNeutral; }
			set { fNeutral = value; }
		}
		string fNeutral = "Neutral";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Enemies
		{
			get { return fEnemies; }
			set { fEnemies = value; }
		}
		string fEnemies = "Enemies";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string GameElement
		{
			get { return fGameElement; }
			set { fGameElement = value; }
		}
		string fGameElement = "game element";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Trap
		{
			get { return fTrap; }
			set { fTrap = value; }
		}
		string fTrap = "trap";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Hazard
		{
			get { return fHazard; }
			set { fHazard = value; }
		}
		string fHazard = "hazard";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string This
		{
			get { return fThis; }
			set { fThis = value; }
		}
		string fThis = "This";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelTooEasy
		{
			get { return fLabelTooEasy; }
			set { fLabelTooEasy = value; }
		}
		string fLabelTooEasy = "is too easy for a party of level";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelTooDifficult
		{
			get { return fLabelTooDifficult; }
			set { fLabelTooDifficult = value; }
		}
		string fLabelTooDifficult = "is too difficult for a party of level";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMoreThanFourLevels
		{
			get { return fLabelMoreThanFourLevels; }
			set { fLabelMoreThanFourLevels = value; }
		}
		string fLabelMoreThanFourLevels = "is more than four levels";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelMoreThanFiveLevels
		{
			get { return fLabelMoreThanFiveLevels; }
			set { fLabelMoreThanFiveLevels = value; }
		}
		string fLabelMoreThanFiveLevels = "is more than five levels";
		

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelThanPartyLevel
		{
			get { return fLabelThanPartyLevel; }
			set { fLabelThanPartyLevel = value; }
		}
		string fLabelThanPartyLevel = "than the party level.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoSkillDefined
		{
			get { return fNoSkillDefined; }
			set { fNoSkillDefined = value; }
		}
		string fNoSkillDefined = "No skills are defined for this skill challenge.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string TreasureParcelIn
		{
			get { return fTreasureParcelIn; }
			set { fTreasureParcelIn = value; }
		}
		string fTreasureParcelIn = "A treasure parcel in";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string IsUndefined
		{
			get { return fIsUndefined; }
			set { fIsUndefined = value; }
		}
		string fIsUndefined = "is undefined";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string TooFewXp
		{
			get { return fTooFewXp; }
			set { fTooFewXp = value; }
		}
		string fTooFewXp = "Too few treasure parcels are available, compared to the amount of XP given.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string TooManyXp
		{
			get { return fTooManyXp; }
			set { fTooManyXp = value; }
		}
		string fTooManyXp = "Too many treasure parcels are available, compared to the amount of XP given.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ThisPlot
		{
			get { return fThisPlot; }
			set { fThisPlot = value; }
		}
		string fThisPlot = "This plot";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AndSubPlots
		{
			get { return fAndSubPlots; }
			set { fAndSubPlots = value; }
		}
		string fAndSubPlots = "and its subplots";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ShouldContain
		{
			get { return fShouldContain; }
			set { fShouldContain = value; }
		}
		string fShouldContain = "should contain";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Parcels
		{
			get { return fParcels; }
			set { fParcels = value; }
		}
		string fParcels = "parcels";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Currently
		{
			get { return fCurrently; }
			set { fCurrently = value; }
		}
		string fCurrently = "currently";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AreAvailable
		{
			get { return fAreAvailable; }
			set { fAreAvailable = value; }
		}
		string fAreAvailable = "are available";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string BlancNote
		{
			get { return fBlancNote; }
			set { fBlancNote = value; }
		}
		string fBlancNote = "blank note";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NPCs
		{
			get { return fNPCs; }
			set { fNPCs = value; }
		}
		string fNPCs = "NPCs";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MeleeWeapon
		{
			get { return fMeleeWeapon; }
			set { fMeleeWeapon = value; }
		}
		string fMeleeWeapon = "Melee weapon";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Effect
		{
			get { return fEffect; }
			set { fEffect = value; }
		}
		string fEffect = "Effect";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Common
		{
			get { return fCommon; }
			set { fCommon = value; }
		}
		string fCommon = "Common";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ThLevel
		{
			get { return fThLevel; }
			set { fThLevel = value; }
		}
		string fThLevel = "th level";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string StLevel
		{
			get { return fStLevel; }
			set { fStLevel = value; }
		}
		string fStLevel = "st level";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Empty
		{
			get { return fEmpty; }
			set { fEmpty = value; }
		}
		string fEmpty = "empty";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG1
		{
			get { return fProjectDefaultBG1; }
			set { fProjectDefaultBG1 = value; }
		}
		string fProjectDefaultBG1 = "Introduction";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG2
		{
			get { return fProjectDefaultBG2; }
			set { fProjectDefaultBG2 = value; }
		}
		string fProjectDefaultBG2 = "Adventure Synopsis";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG3
		{
			get { return fProjectDefaultBG3; }
			set { fProjectDefaultBG3 = value; }
		}
		string fProjectDefaultBG3 = "Adventure Background";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG4
		{
			get { return fProjectDefaultBG4; }
			set { fProjectDefaultBG4 = value; }
		}
		string fProjectDefaultBG4 = "DM Information";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG5
		{
			get { return fProjectDefaultBG5; }
			set { fProjectDefaultBG5 = value; }
		}
		string fProjectDefaultBG5 = "Player Introduction";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG6
		{
			get { return fProjectDefaultBG6; }
			set { fProjectDefaultBG6 = value; }
		}
		string fProjectDefaultBG6 = "Character Hooks";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG7
		{
			get { return fProjectDefaultBG7; }
			set { fProjectDefaultBG7 = value; }
		}
		string fProjectDefaultBG7 = "Treasure Preparation";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProjectDefaultBG8
		{
			get { return fProjectDefaultBG8; }
			set { fProjectDefaultBG8 = value; }
		}
		string fProjectDefaultBG8 = "Continuing the Story";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SuccessesBeforeFailure
		{
			get { return fSuccessesBeforeFailure; }
			set { fSuccessesBeforeFailure = value; }
		}
		string fSuccessesBeforeFailure = "successes before 3 failures";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Perception
		{
			get { return fPerception; }
			set { fPerception = value; }
		}
		string fPerception = "Perception";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelAddins1
		{
			get { return fLabelAddins1; }
			set { fLabelAddins1 = value; }
		}
		string fLabelAddins1 = "The add-in";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelAddins2
		{
			get { return fLabelAddins2; }
			set { fLabelAddins2 = value; }
		}
		string fLabelAddins2 = "could not be loaded; contact the developer for an updated version.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string RecommendedFeats
		{
			get { return fRecommendedFeats; }
			set { fRecommendedFeats = value; }
		}
		string fRecommendedFeats = "Recommended Feats";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Details
		{
			get { return fDetails; }
			set { fDetails = value; }
		}
		string fDetails = "Details";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Ok
		{
			get { return fOk; }
			set { fOk = value; }
		}
		string fOk = "Ok";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AssociatedSkills
		{
			get { return fAssociatedSkills; }
			set { fAssociatedSkills = value; }
		}
		string fAssociatedSkills = "Associated Skills";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ClassFeatures
		{
			get { return fClassFeatures; }
			set { fClassFeatures = value; }
		}
		string fClassFeatures = "Class Features";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HeroicTier
		{
			get { return fHeroicTier; }
			set { fHeroicTier = value; }
		}
		string fHeroicTier = "Heroic Tier";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ParagonTier
		{
			get { return fParagonTier; }
			set { fParagonTier = value; }
		}
		string fParagonTier = "Paragon Tier";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string EpicTier
		{
			get { return fEpicTier; }
			set { fEpicTier = value; }
		}
		string fEpicTier = "Epic Tier";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string PowerSource
		{
			get { return fPowerSource; }
			set { fPowerSource = value; }
		}
		string fPowerSource = "Power Source";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string General
		{
			get { return fGeneral; }
			set { fGeneral = value; }
		}
		string fGeneral = "General";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HealingSurges
		{
			get { return fHealingSurges; }
			set { fHealingSurges = value; }
		}
		string fHealingSurges = "Healing Surges";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HPPerLevel
		{
			get { return fHPPerLevel; }
			set { fHPPerLevel = value; }
		}
		string fHPPerLevel = "HP (per level)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HPFirstLevel
		{
			get { return fHPFirstLevel; }
			set { fHPFirstLevel = value; }
		}
		string fHPFirstLevel = "HP (first level)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string KeyAbilities
		{
			get { return fKeyAbilities; }
			set { fKeyAbilities = value; }
		}
		string fKeyAbilities = "Key Abilities";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Proficiencies
		{
			get { return fProficiencies; }
			set { fProficiencies = value; }
		}
		string fProficiencies = "Proficiencies";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string TrainedSkills
		{
			get { return fTrainedSkills; }
			set { fTrainedSkills = value; }
		}
		string fTrainedSkills = "Trained Skills";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Defences
		{
			get { return fDefences; }
			set { fDefences = value; }
		}
		string fDefences = "Defences";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Implements
		{
			get { return fImplements; }
			set { fImplements = value; }
		}
		string fImplements = "Implements";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string WeaponProficiencies
		{
			get { return fWeaponProficiencies; }
			set { fWeaponProficiencies = value; }
		}
		string fWeaponProficiencies = "Weapon Proficiencies";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ArmourProficiencies
		{
			get { return fArmourProficiencies; }
			set { fArmourProficiencies = value; }
		}
		string fArmourProficiencies = "Armour Proficiencies";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Description
		{
			get { return fDescription; }
			set { fDescription = value; }
		}
		string fDescription = "Description";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Quote
		{
			get { return fQuote; }
			set { fQuote = value; }
		}
		string fQuote = "Quote";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Overview
		{
			get { return fOverview; }
			set { fOverview = value; }
		}
		string fOverview = "Overview";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Characteristics
		{
			get { return fCharacteristics; }
			set { fCharacteristics = value; }
		}
		string fCharacteristics = "Characteristics";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Levels
		{
			get { return fLevels; }
			set { fLevels = value; }
		}
		string fLevels = "Levels";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CreatureName
		{
			get { return fCreatureName; }
			set { fCreatureName = value; }
		}
		string fCreatureName = "Creature Name";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SkillName
		{
			get { return fSkillName; }
			set { fSkillName = value; }
		}
		string fSkillName = "Skill Name";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DiseaseLevels
		{
			get { return fDiseaseLevels; }
			set { fDiseaseLevels = value; }
		}
		string fDiseaseLevels = "Disease Levels";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MaintainDC
		{
			get { return fMaintainDC; }
			set { fMaintainDC = value; }
		}
		string fMaintainDC = "Maintain DC";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ImproveDC
		{
			get { return fImproveDC; }
			set { fImproveDC = value; }
		}
		string fImproveDC = "Improve DC";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LevelDetails
		{
			get { return fLevelDetails; }
			set { fLevelDetails = value; }
		}
		string fLevelDetails = "Level Details";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DiseaseLevel
		{
			get { return fDiseaseLevel; }
			set { fDiseaseLevel = value; }
		}
		string fDiseaseLevel = "Disease Level";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Immortality
		{
			get { return fImmortality; }
			set { fImmortality = value; }
		}
		string fImmortality = "Immortality";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Prerequisites
		{
			get { return fPrerequisites; }
			set { fPrerequisites = value; }
		}
		string fPrerequisites = "Prerequisites";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Benefit
		{
			get { return fBenefit; }
			set { fBenefit = value; }
		}
		string fBenefit = "Benefit";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Tier
		{
			get { return fTier; }
			set { fTier = value; }
		}
		string fTier = "Tier";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Feature
		{
			get { return fFeature; }
			set { fFeature = value; }
		}
		string fFeature = "Tier";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SkillDC
		{
			get { return fSkillDC; }
			set { fSkillDC = value; }
		}
		string fSkillDC = "Skill DC";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Features
		{
			get { return fFeatures; }
			set { fFeatures = value; }
		}
		string fFeatures = "Features";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Powers
		{
			get { return fPowers; }
			set { fPowers = value; }
		}
		string fPowers = "Powers";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Power
		{
			get { return fPower; }
			set { fPower = value; }
		}
		string fPower = "Power";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Sections
		{
			get { return fSections; }
			set { fSections = value; }
		}
		string fSections = "Sections";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Section
		{
			get { return fSection; }
			set { fSection = value; }
		}
		string fSection = "Section";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Up
		{
			get { return fUp; }
			set { fUp = value; }
		}
		string fUp = "Up";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Down
		{
			get { return fDown; }
			set { fDown = value; }
		}
		string fDown = "Down";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Left
		{
			get { return fLeft; }
			set { fLeft = value; }
		}
		string fLeft = "Left";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Right
		{
			get { return fRight; }
			set { fRight = value; }
		}
		string fRight = "Right";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ReadAloudText
		{
			get { return fReadAloudText; }
			set { fReadAloudText = value; }
		}
		string fReadAloudText = "Read-Aloud Text";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ReadAloud
		{
			get { return fReadAloud; }
			set { fReadAloud = value; }
		}
		string fReadAloud = "Read-Aloud";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Header
		{
			get { return fHeader; }
			set { fHeader = value; }
		}
		string fHeader = "Header";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string RacialTraits
		{
			get { return fRacialTraits; }
			set { fRacialTraits = value; }
		}
		string fRacialTraits = "Racial Traits";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SkillBonuses
		{
			get { return fSkillBonuses; }
			set { fSkillBonuses = value; }
		}
		string fSkillBonuses = "Skill Bonuses";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Languages
		{
			get { return fLanguages; }
			set { fLanguages = value; }
		}
		string fLanguages = "Languages";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Vision
		{
			get { return fVision; }
			set { fVision = value; }
		}
		string fVision = "Vision";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Speed
		{
			get { return fSpeed; }
			set { fSpeed = value; }
		}
		string fSpeed = "Speed";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AbilityScores
		{
			get { return fAbilityScores; }
			set { fAbilityScores = value; }
		}
		string fAbilityScores = "Ability Scores";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AverageWeight
		{
			get { return fAverageWeight; }
			set { fAverageWeight = value; }
		}
		string fAverageWeight = "Average Weight";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AverageHeight
		{
			get { return fAverageHeight; }
			set { fAverageHeight = value; }
		}
		string fAverageHeight = "Average Height";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Duration
		{
			get { return fDuration; }
			set { fDuration = value; }
		}
		string fDuration = "Duration";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string KeySkill
		{
			get { return fKeySkill; }
			set { fKeySkill = value; }
		}
		string fKeySkill = "Key Skill";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MarketPrice
		{
			get { return fMarketPrice; }
			set { fMarketPrice = value; }
		}
		string fMarketPrice = "Market Price";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ComponentCost
		{
			get { return fComponentCost; }
			set { fComponentCost = value; }
		}
		string fComponentCost = "Component Cost";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Time
		{
			get { return fTime; }
			set { fTime = value; }
		}
		string fTime = "Time";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SecondaryRole
		{
			get { return fSecondaryRole; }
			set { fSecondaryRole = value; }
		}
		string fSecondaryRole = "Secondary Role";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string GrantedPower
		{
			get { return fGrantedPower; }
			set { fGrantedPower = value; }
		}
		string fGrantedPower = "Granted Power";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MustBeTwoHanded
		{
			get { return fMustBeTwoHanded; }
			set { fMustBeTwoHanded = value; }
		}
		string fMustBeTwoHanded = "Must be wielded two-handed";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Proficiency
		{
			get { return fProficiency; }
			set { fProficiency = value; }
		}
		string fProficiency = "Proficiency";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Price
		{
			get { return fPrice; }
			set { fPrice = value; }
		}
		string fPrice = "Price";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Weight
		{
			get { return fWeight; }
			set { fWeight = value; }
		}
		string fWeight = "Weight";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Properties
		{
			get { return fProperties; }
			set { fProperties = value; }
		}
		string fProperties = "Properties";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Group
		{
			get { return fGroup; }
			set { fGroup = value; }
		}
		string fGroup = "Group";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ProductName
		{
			get { return fProductName; }
			set { fProductName = value; }
		}
		string fProductName = "Product Name";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ArtifactBuilder
		{
			get { return fArtifactBuilder; }
			set { fArtifactBuilder = value; }
		}
		string fArtifactBuilder = "Artifact Builder";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Rule
		{
			get { return fRule; }
			set { fRule = value; }
		}
		string fRule = "Rule";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Value
		{
			get { return fValue; }
			set { fValue = value; }
		}
		string fValue = "Value";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ArtifactConcordanceRule
		{
			get { return fArtifactConcordanceRule; }
			set { fArtifactConcordanceRule = value; }
		}
		string fArtifactConcordanceRule = "Artifact Concordance Rule";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ArtifactDetails
		{
			get { return fArtifactDetails; }
			set { fArtifactDetails = value; }
		}
		string fArtifactDetails = "Artifact Details";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Artifact
		{
			get { return fArtifact; }
			set { fArtifact = value; }
		}
		string fArtifact = "Artifact";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Info
		{
			get { return fInfo; }
			set { fInfo = value; }
		}
		string fInfo = "Info";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SelectArtifact
		{
			get { return fSelectArtifact; }
			set { fSelectArtifact = value; }
		}
		string fSelectArtifact = "Select an Artifact";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Close
		{
			get { return fClose; }
			set { fClose = value; }
		}
		string fClose = "Close";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Target
		{
			get { return fTarget; }
			set { fTarget = value; }
		}
		string fTarget = "Target";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Roll
		{
			get { return fRoll; }
			set { fRoll = value; }
		}
		string fRoll = "Roll";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Bonus
		{
			get { return fBonus; }
			set { fBonus = value; }
		}
		string fBonus = "Bonus";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AttackRolls
		{
			get { return fAttackRolls; }
			set { fAttackRolls = value; }
		}
		string fAttackRolls = "Attack Rolls";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AttackRoll
		{
			get { return fAttackRoll; }
			set { fAttackRoll = value; }
		}
		string fAttackRoll = "Attack Roll";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DamageRolls
		{
			get { return fDamageRolls; }
			set { fDamageRolls = value; }
		}
		string fDamageRolls = "Damage Rolls";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Reroll
		{
			get { return fReroll; }
			set { fReroll = value; }
		}
		string fReroll = "Reroll";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Miss
		{
			get { return fMiss; }
			set { fMiss = value; }
		}
		string fMiss = "[miss]";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Crit
		{
			get { return fCrit; }
			set { fCrit = value; }
		}
		string fCrit = "[crit]";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string MissHalf
		{
			get { return fMissHalf; }
			set { fMissHalf = value; }
		}
		string fMissHalf = "On Miss(half)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CriticalMax
		{
			get { return fCriticalMax; }
			set { fCriticalMax = value; }
		}
		string fCriticalMax = "On Critical(max)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string OnHit
		{
			get { return fOnHit; }
			set { fOnHit = value; }
		}
		string fOnHit = "On Hit";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DMG
		{
			get { return fDMG; }
			set { fDMG = value; }
		}
		string fDMG = "[dmg]";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DamageOnClose
		{
			get { return fDamageOnClose; }
			set { fDamageOnClose = value; }
		}
		string fDamageOnClose = "Apply damage on close";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Template
		{
			get { return fTemplate; }
			set { fTemplate = value; }
		}
		string fTemplate = "Template";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Creatures
		{
			get { return fCreatures; }
			set { fCreatures = value; }
		}
		string fCreatures = "Creatures";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AllCategories
		{
			get { return fAllCategories; }
			set { fAllCategories = value; }
		}
		string fAllCategories = "All Categories";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AutoBuildOptions
		{
			get { return fAutoBuildOptions; }
			set { fAutoBuildOptions = value; }
		}
		string fAutoBuildOptions = "AutoBuild Options";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Title
		{
			get { return fTitle; }
			set { fTitle = value; }
		}
		string fTitle = "Title";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string EnterDetailsHere
		{
			get { return fEnterDetailsHere; }
			set { fEnterDetailsHere = value; }
		}
		string fEnterDetailsHere = "(enter details here)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NoteHtmlTags
		{
			get { return fNoteHtmlTags; }
			set { fNoteHtmlTags = value; }
		}
		string fNoteHtmlTags = "Note: HTML tags are supported here.";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string BackgroundItem
		{
			get { return fBackgroundItem; }
			set { fBackgroundItem = value; }
		}
		string fBackgroundItem = "Background Item";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Month
		{
			get { return fMonth; }
			set { fMonth = value; }
		}
		string fMonth = "Month";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Day
		{
			get { return fDay; }
			set { fDay = value; }
		}
		string fDay = "Day";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Event
		{
			get { return fEvent; }
			set { fEvent = value; }
		}
		string fEvent = "Event";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CampaignYear
		{
			get { return fCampaignYear; }
			set { fCampaignYear = value; }
		}
		string fCampaignYear = "Campaign Year";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Months
		{
			get { return fMonths; }
			set { fMonths = value; }
		}
		string fMonths = "Months";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Days
		{
			get { return fDays; }
			set { fDays = value; }
		}
		string fDays = "Days";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Seasons
		{
			get { return fSeasons; }
			set { fSeasons = value; }
		}
		string fSeasons = "Seasons";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Season
		{
			get { return fSeason; }
			set { fSeason = value; }
		}
		string fSeason = "Season";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Date
		{
			get { return fDate; }
			set { fDate = value; }
		}
		string fDate = "Date";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Events
		{
			get { return fEvents; }
			set { fEvents = value; }
		}
		string fEvents = "Events";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Satellites
		{
			get { return fSatellites; }
			set { fSatellites = value; }
		}
		string fSatellites = "Satellites";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Satellite
		{
			get { return fSatellite; }
			set { fSatellite = value; }
		}
		string fSatellite = "Satellite";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Calendar
		{
			get { return fCalendar; }
			set { fCalendar = value; }
		}
		string fCalendar = "Calendar";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Year
		{
			get { return fYear; }
			set { fYear = value; }
		}
		string fYear = "Year";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HPPercent
		{
			get { return fHPPercent; }
			set { fHPPercent = value; }
		}
		string fHPPercent = "Hit Points(%)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AttackBonus
		{
			get { return fAttackBonus; }
			set { fAttackBonus = value; }
		}
		string fAttackBonus = "Attack Bonus";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LabelSettingsApply
		{
			get { return fLabelSettingsApply; }
			set { fLabelSettingsApply = value; }
		}
		string fLabelSettingsApply = "These settings will apply to all the creatures, traps and hazards in the campaign";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string OtherDefences
		{
			get { return fOtherDefences; }
			set { fOtherDefences = value; }
		}
		string fOtherDefences = "Other Defences";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string XPPointsPercent
		{
			get { return fXPPointsPercent; }
			set { fXPPointsPercent = value; }
		}
		string fXPPointsPercent = "Experience Points(%)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DamageMultPercent
		{
			get { return fDamageMultPercent; }
			set { fDamageMultPercent = value; }
		}
		string fDamageMultPercent	 = "Damage Multiplier(%)";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SelectAll
		{
			get { return fSelectAll; }
			set { fSelectAll = value; }
		}
		string fSelectAll = "Select All";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DeselectAll
		{
			get { return fDeselectAll; }
			set { fDeselectAll = value; }
		}
		string fDeselectAll = "Deselect All";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Categories
		{
			get { return fCategories; }
			set { fCategories = value; }
		}
		string fCategories = "Categories";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Traps
		{
			get { return fTraps; }
			set { fTraps = value; }
		}
		string fTraps = "Traps";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SelectCombatant
		{
			get { return fSelectCombatant; }
			set { fSelectCombatant = value; }
		}
		string fSelectCombatant = "Select Combatant";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string OngoingConditions
		{
			get { return fOngoingConditions; }
			set { fOngoingConditions = value; }
		}
		string fOngoingConditions = "Ongoing Conditions";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Initiative
		{
			get { return fInitiative; }
			set { fInitiative = value; }
		}
		string fInitiative = "Initiative";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Saves
		{
			get { return fSaves; }
			set { fSaves = value; }
		}
		string fSaves = "Saves";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string TempHP
		{
			get { return fTempHP; }
			set { fTempHP = value; }
		}
		string fTempHP = "Temp HP";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Label
		{
			get { return fLabel; }
			set { fLabel = value; }
		}
		string fLabel = "Label";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Altitude
		{
			get { return fAltitude; }
			set { fAltitude = value; }
		}
		string fAltitude = "Altitude";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Combatant
		{
			get { return fCombatant; }
			set { fCombatant = value; }
		}
		string fCombatant = "Combatant";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Combatants
		{
			get { return fCombatants; }
			set { fCombatants = value; }
		}
		string fCombatants = "Combatants";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DelayedReadied
		{
			get { return fDelayedReadied; }
			set { fDelayedReadied = value; }
		}
		string fDelayedReadied = "Delayed / Readied";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string SkillChallenges
		{
			get { return fSkillChallenges; }
			set { fSkillChallenges = value; }
		}
		string fSkillChallenges = "Skill Challenges";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CustomTokensOverlays
		{
			get { return fCustomTokensOverlays; }
			set { fCustomTokensOverlays = value; }
		}
		string fCustomTokensOverlays = "Custom Tokens and Overlays";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string NotInPlay
		{
			get { return fNotInPlay; }
			set { fNotInPlay = value; }
		}
		string fNotInPlay = "Not In Play";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Defeated
		{
			get { return fDefeated; }
			set { fDefeated = value; }
		}
		string fDefeated = "Defeated";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Predefined
		{
			get { return fPredefined; }
			set { fPredefined = value; }
		}
		string fPredefined = "Predefined";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CustomTokens
		{
			get { return fCustomTokens; }
			set { fCustomTokens = value; }
		}
		string fCustomTokens = "Custom Tokens";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string CustomOverlays
		{
			get { return fCustomOverlays; }
			set { fCustomOverlays = value; }
		}
		string fCustomOverlays = "Custom Overlays";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Heal
		{
			get { return fHeal; }
			set { fHeal = value; }
		}
		string fHeal = "Heal";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AddEffect
		{
			get { return fAddEffect; }
			set { fAddEffect = value; }
		}
		string fAddEffect = "Heal";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string DelayAction
		{
			get { return fDelayAction; }
			set { fDelayAction = value; }
		}
		string fDelayAction = "Delay Action";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AddCombatant
		{
			get { return fAddCombatant; }
			set { fAddCombatant = value; }
		}
		string fAddCombatant = "Add Combatant...";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AddMapToken
		{
			get { return fAddMapToken; }
			set { fAddMapToken = value; }
		}
		string fAddMapToken = "Add Map Token...";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AddMapOverlay
		{
			get { return fAddMapOverlay; }
			set { fAddMapOverlay = value; }
		}
		string fAddMapOverlay = "Add Map Overlay...";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Waves
		{
			get { return fWaves; }
			set { fWaves = value; }
		}
		string fWaves = "Waves";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string RemoveSelected
		{
			get { return fRemoveSelected; }
			set { fRemoveSelected = value; }
		}
		string fRemoveSelected = "Remove Selected";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HideAll
		{
			get { return fHideAll; }
			set { fHideAll = value; }
		}
		string fHideAll = "Hide All";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ShowAll
		{
			get { return fShowAll; }
			set { fShowAll = value; }
		}
		string fShowAll = "Show All";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Map
		{
			get { return fMap; }
			set { fMap = value; }
		}
		string fMap = "Map";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string FogOfWar
		{
			get { return fFogOfWar; }
			set { fFogOfWar = value; }
		}
		string fFogOfWar = "Fog of War";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AllCreatures
		{
			get { return fAllCreatures; }
			set { fAllCreatures = value; }
		}
		string fAllCreatures = "All Creatures";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string VisibleCreaturesOnly
		{
			get { return fVisibleCreaturesOnly; }
			set { fVisibleCreaturesOnly = value; }
		}
		string fVisibleCreaturesOnly = "Visible Creatures Only";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Hide
		{
			get { return fHide; }
			set { fHide = value; }
		}
		string fHide = "Hide";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string LineOfSight
		{
			get { return fLineOfSight; }
			set { fLineOfSight = value; }
		}
		string fLineOfSight = "Line of Sight";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Grid
		{
			get { return fGrid; }
			set { fGrid = value; }
		}
		string fGrid = "Grid";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string GridLabels
		{
			get { return fGridLabels; }
			set { fGridLabels = value; }
		}
		string fGridLabels = "Grid Labels";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string HealthBars
		{
			get { return fHealthBars; }
			set { fHealthBars = value; }
		}
		string fHealthBars = "Health Bars";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string Conditions
		{
			get { return fConditions; }
			set { fConditions = value; }
		}
		string fConditions = "Conditions";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string PictureTokens
		{
			get { return fPictureTokens; }
			set { fPictureTokens = value; }
		}
		string fPictureTokens = "Picture Tokens";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ScrollZoom
		{
			get { return fScrollZoom; }
			set { fScrollZoom = value; }
		}
		string fScrollZoom = "Scroll and Zoom";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ResetView
		{
			get { return fResetView; }
			set { fResetView = value; }
		}
		string fResetView = "Reset View";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string AllowDrawing
		{
			get { return fAllowDrawing; }
			set { fAllowDrawing = value; }
		}
		string fAllowDrawing = "Allow Drawing";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ClearDrawings
		{
			get { return fClearDrawings; }
			set { fClearDrawings = value; }
		}
		string fClearDrawings = "Clear Drawings";

		/// <summary>
		/// No Comment default value.
		/// Controls/WelcomePanel.cs
		/// </summary>
		public string ExportScreenshot
		{
			get { return fExportScreenshot; }
			set { fExportScreenshot = value; }
		}
		string fExportScreenshot = "Export Screenshot";

		


	}
}

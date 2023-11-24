using System.ComponentModel;
using System.Windows.Forms;
using BrightIdeasSoftware;
using BulkCrapUninstaller.Controls;
using BulkCrapUninstaller.Functions.Tracking;

namespace BulkCrapUninstaller.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));
            splitContainer1 = new SplitContainer();
            advancedFilters1 = new AdvancedFilters();
            splitContainerListAndMap = new SplitContainer();
            listViewPanel = new Panel();
            uninstallerObjectListView = new ObjectListView();
            olvColumnDisplayName = new OLVColumn();
            olvColumnPublisher = new OLVColumn();
            olvColumnInstallDate = new OLVColumn();
            olvColumnSize = new OLVColumn();
            olvColumnDisplayVersion = new OLVColumn();
            olvColumnInstallSource = new OLVColumn();
            olvColumnInstallLocation = new OLVColumn();
            treeMap1 = new SimpleTreeMap.TreeMap();
            toolStrip = new ToolStrip();
            statusStrip1 = new StatusStrip();
            toolStripLabelStatus = new ToolStripStatusLabel();
            toolStripLabelSize = new ToolStripStatusLabel();
            toolStripLabelTotal = new ToolStripStatusLabel();
            settingsSidebarPanel = new Panel();
            propertiesSidebar = new PropertiesSidebar();
            groupBox1 = new GroupBox();
            buttonAdvFiltering = new Button();
            filterEditor1 = new UninstallTools.Controls.FilterEditor();
            uninstallListContextMenuStrip = new ContextMenuStrip(components);
            uninstallContextMenuStripItem = new ToolStripMenuItem();
            quietUninstallContextMenuStripItem = new ToolStripMenuItem();
            manualUninstallToolStripMenuItem1 = new ToolStripMenuItem();
            uninstallUsingMsiExecContextMenuStripItem = new ToolStripMenuItem();
            msiInstallContextMenuStripItem = new ToolStripMenuItem();
            msiUninstallContextMenuStripItem = new ToolStripMenuItem();
            msiQuietUninstallContextMenuStripItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            excludeToolStripMenuItem = new ToolStripMenuItem();
            includeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparatorFiltering = new ToolStripSeparator();
            runToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            copyToClipboardContextMenuStripItem = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            fullInformationCopyContextMenuStripItem = new ToolStripMenuItem();
            programNameCopyContextMenuStripItem = new ToolStripMenuItem();
            gUIDProductCodeCopyContextMenuStripItem = new ToolStripMenuItem();
            fullRegistryPathCopyContextMenuStripItem = new ToolStripMenuItem();
            uninstallStringCopyContextMenuStripItem = new ToolStripMenuItem();
            deleteRegistryEntryContextMenuStripItem = new ToolStripMenuItem();
            renameContextMenuStripItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            openInExplorerContextMenuStripItem = new ToolStripMenuItem();
            installLocationOpenInExplorerContextMenuStripItem = new ToolStripMenuItem();
            uninstallerLocationOpenInExplorerContextMenuStripItem = new ToolStripMenuItem();
            sourceLocationOpenInExplorerContextMenuStripItem = new ToolStripMenuItem();
            openWebPageContextMenuStripItem = new ToolStripMenuItem();
            lookUpOnlineToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem15 = new ToolStripMenuItem();
            toolStripMenuItem16 = new ToolStripMenuItem();
            slantcoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator26 = new ToolStripSeparator();
            fossHubcomToolStripMenuItem = new ToolStripMenuItem();
            sourceForgecomToolStripMenuItem = new ToolStripMenuItem();
            gitHubcomToolStripMenuItem = new ToolStripMenuItem();
            fileHippocomToolStripMenuItem = new ToolStripMenuItem();
            rateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            propertiesContextMenuStripItem = new ToolStripMenuItem();
            exportDialog = new SaveFileDialog();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            reloadUninstallersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            loadUninstallerListToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator30 = new ToolStripSeparator();
            exportSelectedToolStripMenuItem = new ToolStripMenuItem();
            exportToABatchUninstallScriptToolStripMenuItem = new ToolStripMenuItem();
            exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            showColorLegendToolStripMenuItem = new ToolStripMenuItem();
            displayToolbarToolStripMenuItem = new ToolStripMenuItem();
            showTreemapToolStripMenuItem = new ToolStripMenuItem();
            displaySettingsToolStripMenuItem = new ToolStripMenuItem();
            displayStatusbarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator12 = new ToolStripSeparator();
            useSystemThemeToolStripMenuItem = new ToolStripMenuItem();
            filteringToolStripMenuItem = new ToolStripMenuItem();
            advancedApplicationsToolStripMenuItem = new ToolStripMenuItem();
            basicApplicationsToolStripMenuItem = new ToolStripMenuItem();
            systemComponentsToolStripMenuItem = new ToolStripMenuItem();
            everythingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator20 = new ToolStripSeparator();
            automaticallyStartedToolStripMenuItem = new ToolStripMenuItem();
            onlyWebBrowsersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator31 = new ToolStripSeparator();
            viewTweaksToolStripMenuItem = new ToolStripMenuItem();
            viewUnregisteredToolStripMenuItem = new ToolStripMenuItem();
            viewUpdatesToolStripMenuItem = new ToolStripMenuItem();
            viewWindowsFeaturesToolStripMenuItem = new ToolStripMenuItem();
            viewWindowsStoreAppsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator28 = new ToolStripSeparator();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            openStartupManagerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator25 = new ToolStripSeparator();
            cleanUpProgramFilesToolStripMenuItem = new ToolStripMenuItem();
            targetMenuItem = new ToolStripMenuItem();
            uninstallFromDirectoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator13 = new ToolStripSeparator();
            troubleshootUninstallProblemsToolStripMenuItem = new ToolStripMenuItem();
            startDiskCleanupToolStripMenuItem = new ToolStripMenuItem();
            tryToInstallNETV35ToolStripMenuItem = new ToolStripMenuItem();
            createRestorePointToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator29 = new ToolStripSeparator();
            openProgramsAndFeaturesToolStripMenuItem = new ToolStripMenuItem();
            openSystemRestoreToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator19 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            openHelpToolStripMenuItem = new ToolStripMenuItem();
            startSetupWizardToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator16 = new ToolStripSeparator();
            checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
            submitFeedbackToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator18 = new ToolStripSeparator();
            resetSettingsToolStripMenuItem = new ToolStripMenuItem();
            uninstallBCUninstallToolstripMenuItem = new ToolStripMenuItem();
            toolStripSeparator17 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            debugToolStripMenuItem = new ToolStripMenuItem();
            createBackupFileDialog = new SaveFileDialog();
            globalHotkeys1 = new Klocman.Subsystems.GlobalHotkeys();
            splashScreen1 = new Klocman.Forms.SplashScreen();
            usageTracker = new UsageTracker();
            toolStripButtonUninstall = new ToolStripButton();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((ISupportInitialize)splitContainerListAndMap).BeginInit();
            splitContainerListAndMap.Panel1.SuspendLayout();
            splitContainerListAndMap.Panel2.SuspendLayout();
            splitContainerListAndMap.SuspendLayout();
            listViewPanel.SuspendLayout();
            ((ISupportInitialize)uninstallerObjectListView).BeginInit();
            toolStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            settingsSidebarPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            uninstallListContextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(advancedFilters1);
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainerListAndMap);
            splitContainer1.Panel2.Controls.Add(toolStrip);
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            // 
            // advancedFilters1
            // 
            resources.ApplyResources(advancedFilters1, "advancedFilters1");
            advancedFilters1.Name = "advancedFilters1";
            advancedFilters1.SelectedEntryGetter = null;
            // 
            // splitContainerListAndMap
            // 
            resources.ApplyResources(splitContainerListAndMap, "splitContainerListAndMap");
            splitContainerListAndMap.FixedPanel = FixedPanel.Panel2;
            splitContainerListAndMap.Name = "splitContainerListAndMap";
            // 
            // splitContainerListAndMap.Panel1
            // 
            splitContainerListAndMap.Panel1.Controls.Add(listViewPanel);
            // 
            // splitContainerListAndMap.Panel2
            // 
            splitContainerListAndMap.Panel2.Controls.Add(treeMap1);
            // 
            // listViewPanel
            // 
            listViewPanel.BorderStyle = BorderStyle.FixedSingle;
            listViewPanel.Controls.Add(uninstallerObjectListView);
            resources.ApplyResources(listViewPanel, "listViewPanel");
            listViewPanel.Name = "listViewPanel";
            // 
            // uninstallerObjectListView
            // 
            uninstallerObjectListView.AllColumns.Add(olvColumnDisplayName);
            uninstallerObjectListView.AllColumns.Add(olvColumnPublisher);
            uninstallerObjectListView.AllColumns.Add(olvColumnInstallDate);
            uninstallerObjectListView.AllColumns.Add(olvColumnSize);
            uninstallerObjectListView.AllColumns.Add(olvColumnDisplayVersion);
            uninstallerObjectListView.AllowColumnReorder = true;
            uninstallerObjectListView.BorderStyle = BorderStyle.None;
            uninstallerObjectListView.CellEditActivation = ObjectListView.CellEditActivateMode.DoubleClick;
            uninstallerObjectListView.CellEditUseWholeCell = false;
            uninstallerObjectListView.CheckBoxes = false;
            uninstallerObjectListView.Columns.AddRange(new ColumnHeader[] { olvColumnDisplayName, olvColumnPublisher, olvColumnInstallDate, olvColumnSize, olvColumnDisplayVersion});
            resources.ApplyResources(uninstallerObjectListView, "uninstallerObjectListView");
            uninstallerObjectListView.FullRowSelect = true;
            uninstallerObjectListView.GridLines = true;
            uninstallerObjectListView.Name = "uninstallerObjectListView";
            uninstallerObjectListView.ShowGroups = false;
            uninstallerObjectListView.ShowImagesOnSubItems = true;
            uninstallerObjectListView.ShowItemToolTips = true;
            uninstallerObjectListView.SortGroupItemsByPrimaryColumn = false;
            uninstallerObjectListView.UseCompatibleStateImageBehavior = false;
            uninstallerObjectListView.UseFilterIndicator = true;
            uninstallerObjectListView.UseHyperlinks = true;
            uninstallerObjectListView.View = View.Details;
            uninstallerObjectListView.VirtualMode = true;
            uninstallerObjectListView.CellEditStarting += uninstallerObjectListView_CellEditStarting;
            uninstallerObjectListView.CellRightClick += uninstallerObjectListView_CellRightClick;
            uninstallerObjectListView.ItemsChanged += RefreshStatusbarTotalLabel;
            uninstallerObjectListView.SelectionChanged += uninstallerObjectListView_SelectedChanged;
            uninstallerObjectListView.ItemChecked += uninstallerObjectListView_SelectedChanged;
            uninstallerObjectListView.Click += uninstallerObjectListView_Click;
            uninstallerObjectListView.KeyDown += uninstallerObjectListView_KeyDown;
            uninstallerObjectListView.KeyUp += HandleListViewMenuKeystroke;
            // 
            // olvColumnDisplayName
            // 
            olvColumnDisplayName.Hideable = false;
            resources.ApplyResources(olvColumnDisplayName, "olvColumnDisplayName");
            // 
            // olvColumnPublisher
            // 
            resources.ApplyResources(olvColumnPublisher, "olvColumnPublisher");
            // 
            // olvColumnInstallDate
            // 
            olvColumnInstallDate.IsEditable = false;
            resources.ApplyResources(olvColumnInstallDate, "olvColumnInstallDate");
            // 
            // olvColumnSize
            // 
            olvColumnSize.Searchable = false;
            resources.ApplyResources(olvColumnSize, "olvColumnSize");
            // 
            // olvColumnDisplayVersion
            // 
            resources.ApplyResources(olvColumnDisplayVersion, "olvColumnDisplayVersion");
            // 
            // olvColumnInstallSource
            // 
            resources.ApplyResources(olvColumnInstallSource, "olvColumnInstallSource");
            // 
            // olvColumnInstallLocation
            // 
            resources.ApplyResources(olvColumnInstallLocation, "olvColumnInstallLocation");
            // 
            // treeMap1
            // 
            resources.ApplyResources(treeMap1, "treeMap1");
            treeMap1.Name = "treeMap1";
            treeMap1.ShowToolTip = false;
            treeMap1.UseLogValueScaling = false;
            // 
            // toolStrip
            // 
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            resources.ApplyResources(toolStrip, "toolStrip");
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonUninstall });
            toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip.Name = "toolStrip";
            toolStrip.TabStop = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelStatus, toolStripLabelSize, toolStripLabelTotal });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            // 
            // toolStripLabelStatus
            // 
            toolStripLabelStatus.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripLabelStatus.BorderStyle = Border3DStyle.Sunken;
            toolStripLabelStatus.Name = "toolStripLabelStatus";
            resources.ApplyResources(toolStripLabelStatus, "toolStripLabelStatus");
            toolStripLabelStatus.Spring = true;
            toolStripLabelStatus.TextChanged += toolStripLabelStatus_TextChanged;
            // 
            // toolStripLabelSize
            // 
            resources.ApplyResources(toolStripLabelSize, "toolStripLabelSize");
            toolStripLabelSize.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripLabelSize.BorderStyle = Border3DStyle.Sunken;
            toolStripLabelSize.Name = "toolStripLabelSize";
            // 
            // toolStripLabelTotal
            // 
            resources.ApplyResources(toolStripLabelTotal, "toolStripLabelTotal");
            toolStripLabelTotal.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripLabelTotal.BorderStyle = Border3DStyle.Sunken;
            toolStripLabelTotal.Name = "toolStripLabelTotal";
            // 
            // settingsSidebarPanel
            // 
            resources.ApplyResources(settingsSidebarPanel, "settingsSidebarPanel");
            settingsSidebarPanel.Controls.Add(propertiesSidebar);
            settingsSidebarPanel.Controls.Add(groupBox1);
            settingsSidebarPanel.Name = "settingsSidebarPanel";
            // 
            // propertiesSidebar
            // 
            resources.ApplyResources(propertiesSidebar, "propertiesSidebar");
            propertiesSidebar.Name = "propertiesSidebar";
            propertiesSidebar.OrphansEnabled = true;
            propertiesSidebar.ProtectedEnabled = true;
            propertiesSidebar.ShowTweaksEnabled = true;
            propertiesSidebar.StoreAppsEnabled = true;
            propertiesSidebar.SysCompEnabled = true;
            propertiesSidebar.UpdatesEnabled = true;
            propertiesSidebar.WinFeaturesEnabled = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(buttonAdvFiltering);
            groupBox1.Controls.Add(filterEditor1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // buttonAdvFiltering
            // 
            resources.ApplyResources(buttonAdvFiltering, "buttonAdvFiltering");
            buttonAdvFiltering.Name = "buttonAdvFiltering";
            buttonAdvFiltering.UseVisualStyleBackColor = true;
            buttonAdvFiltering.Click += buttonAdvFiltering_Click;
            // 
            // filterEditor1
            // 
            resources.ApplyResources(filterEditor1, "filterEditor1");
            filterEditor1.Name = "filterEditor1";
            filterEditor1.ShowAsSearch = true;
            filterEditor1.FocusSearchTarget += filterEditor1_FocusSearchTarget;
            // 
            // uninstallListContextMenuStrip
            // 
            uninstallListContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            uninstallListContextMenuStrip.Items.AddRange(new ToolStripItem[] { uninstallContextMenuStripItem, quietUninstallContextMenuStripItem, manualUninstallToolStripMenuItem1, uninstallUsingMsiExecContextMenuStripItem, toolStripSeparator3, excludeToolStripMenuItem, includeToolStripMenuItem, toolStripSeparatorFiltering, runToolStripMenuItem, toolStripSeparator8, copyToClipboardContextMenuStripItem, deleteRegistryEntryContextMenuStripItem, renameContextMenuStripItem, toolStripSeparator6, openInExplorerContextMenuStripItem, openWebPageContextMenuStripItem, lookUpOnlineToolStripMenuItem, rateToolStripMenuItem, toolStripSeparator7, propertiesContextMenuStripItem });
            uninstallListContextMenuStrip.Name = "uninstallListContextMenuStrip";
            resources.ApplyResources(uninstallListContextMenuStrip, "uninstallListContextMenuStrip");
            uninstallListContextMenuStrip.Opening += UpdateUninstallListContextMenuStrip;
            // 
            // uninstallContextMenuStripItem
            // 
            resources.ApplyResources(uninstallContextMenuStripItem, "uninstallContextMenuStripItem");
            uninstallContextMenuStripItem.Name = "uninstallContextMenuStripItem";
            uninstallContextMenuStripItem.Click += RunLoudUninstall;
            // 
            // quietUninstallContextMenuStripItem
            // 
            resources.ApplyResources(quietUninstallContextMenuStripItem, "quietUninstallContextMenuStripItem");
            quietUninstallContextMenuStripItem.Name = "quietUninstallContextMenuStripItem";
            quietUninstallContextMenuStripItem.Click += RunQuietUninstall;
            // 
            // manualUninstallToolStripMenuItem1
            // 
            manualUninstallToolStripMenuItem1.Name = "manualUninstallToolStripMenuItem1";
            resources.ApplyResources(manualUninstallToolStripMenuItem1, "manualUninstallToolStripMenuItem1");
            manualUninstallToolStripMenuItem1.Click += RunAdvancedUninstall;
            // 
            // uninstallUsingMsiExecContextMenuStripItem
            // 
            uninstallUsingMsiExecContextMenuStripItem.DropDownItems.AddRange(new ToolStripItem[] { msiInstallContextMenuStripItem, msiUninstallContextMenuStripItem, msiQuietUninstallContextMenuStripItem });
            uninstallUsingMsiExecContextMenuStripItem.Name = "uninstallUsingMsiExecContextMenuStripItem";
            resources.ApplyResources(uninstallUsingMsiExecContextMenuStripItem, "uninstallUsingMsiExecContextMenuStripItem");
            // 
            // msiInstallContextMenuStripItem
            // 
            msiInstallContextMenuStripItem.Name = "msiInstallContextMenuStripItem";
            resources.ApplyResources(msiInstallContextMenuStripItem, "msiInstallContextMenuStripItem");
            msiInstallContextMenuStripItem.Click += msiInstallContextMenuStripItem_Click;
            // 
            // msiUninstallContextMenuStripItem
            // 
            msiUninstallContextMenuStripItem.Name = "msiUninstallContextMenuStripItem";
            resources.ApplyResources(msiUninstallContextMenuStripItem, "msiUninstallContextMenuStripItem");
            msiUninstallContextMenuStripItem.Click += msiUninstallContextMenuStripItem_Click;
            // 
            // msiQuietUninstallContextMenuStripItem
            // 
            msiQuietUninstallContextMenuStripItem.Name = "msiQuietUninstallContextMenuStripItem";
            resources.ApplyResources(msiQuietUninstallContextMenuStripItem, "msiQuietUninstallContextMenuStripItem");
            msiQuietUninstallContextMenuStripItem.Click += msiQuietUninstallContextMenuStripItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // excludeToolStripMenuItem
            // 
            excludeToolStripMenuItem.Name = "excludeToolStripMenuItem";
            resources.ApplyResources(excludeToolStripMenuItem, "excludeToolStripMenuItem");
            excludeToolStripMenuItem.Click += excludeToolStripMenuItem_Click;
            // 
            // includeToolStripMenuItem
            // 
            includeToolStripMenuItem.Name = "includeToolStripMenuItem";
            resources.ApplyResources(includeToolStripMenuItem, "includeToolStripMenuItem");
            includeToolStripMenuItem.Click += includeToolStripMenuItem_Click;
            // 
            // toolStripSeparatorFiltering
            // 
            toolStripSeparatorFiltering.Name = "toolStripSeparatorFiltering";
            resources.ApplyResources(toolStripSeparatorFiltering, "toolStripSeparatorFiltering");
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            resources.ApplyResources(runToolStripMenuItem, "runToolStripMenuItem");
            runToolStripMenuItem.DropDownItemClicked += runToolStripMenuItem_DropDownItemClicked;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(toolStripSeparator8, "toolStripSeparator8");
            // 
            // copyToClipboardContextMenuStripItem
            // 
            copyToClipboardContextMenuStripItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem9, toolStripSeparator9, fullInformationCopyContextMenuStripItem, programNameCopyContextMenuStripItem, gUIDProductCodeCopyContextMenuStripItem, fullRegistryPathCopyContextMenuStripItem, uninstallStringCopyContextMenuStripItem });
            resources.ApplyResources(copyToClipboardContextMenuStripItem, "copyToClipboardContextMenuStripItem");
            copyToClipboardContextMenuStripItem.Name = "copyToClipboardContextMenuStripItem";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(toolStripMenuItem9, "toolStripMenuItem9");
            toolStripMenuItem9.Click += OpenAdvancedClipboardCopy;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(toolStripSeparator9, "toolStripSeparator9");
            // 
            // fullInformationCopyContextMenuStripItem
            // 
            fullInformationCopyContextMenuStripItem.Name = "fullInformationCopyContextMenuStripItem";
            resources.ApplyResources(fullInformationCopyContextMenuStripItem, "fullInformationCopyContextMenuStripItem");
            fullInformationCopyContextMenuStripItem.Click += ClipboardCopyFullInformation;
            // 
            // programNameCopyContextMenuStripItem
            // 
            programNameCopyContextMenuStripItem.Name = "programNameCopyContextMenuStripItem";
            resources.ApplyResources(programNameCopyContextMenuStripItem, "programNameCopyContextMenuStripItem");
            programNameCopyContextMenuStripItem.Click += ClipboardCopyProgramName;
            // 
            // gUIDProductCodeCopyContextMenuStripItem
            // 
            gUIDProductCodeCopyContextMenuStripItem.Name = "gUIDProductCodeCopyContextMenuStripItem";
            resources.ApplyResources(gUIDProductCodeCopyContextMenuStripItem, "gUIDProductCodeCopyContextMenuStripItem");
            gUIDProductCodeCopyContextMenuStripItem.Click += ClipboardCopyGuids;
            // 
            // fullRegistryPathCopyContextMenuStripItem
            // 
            fullRegistryPathCopyContextMenuStripItem.Name = "fullRegistryPathCopyContextMenuStripItem";
            resources.ApplyResources(fullRegistryPathCopyContextMenuStripItem, "fullRegistryPathCopyContextMenuStripItem");
            fullRegistryPathCopyContextMenuStripItem.Click += ClipboardCopyRegistryPath;
            // 
            // uninstallStringCopyContextMenuStripItem
            // 
            uninstallStringCopyContextMenuStripItem.Name = "uninstallStringCopyContextMenuStripItem";
            resources.ApplyResources(uninstallStringCopyContextMenuStripItem, "uninstallStringCopyContextMenuStripItem");
            uninstallStringCopyContextMenuStripItem.Click += ClipboardCopyUninstallString;
            // 
            // deleteRegistryEntryContextMenuStripItem
            // 
            deleteRegistryEntryContextMenuStripItem.Name = "deleteRegistryEntryContextMenuStripItem";
            resources.ApplyResources(deleteRegistryEntryContextMenuStripItem, "deleteRegistryEntryContextMenuStripItem");
            deleteRegistryEntryContextMenuStripItem.Click += DeleteRegistryEntries;
            // 
            // renameContextMenuStripItem
            // 
            renameContextMenuStripItem.Name = "renameContextMenuStripItem";
            resources.ApplyResources(renameContextMenuStripItem, "renameContextMenuStripItem");
            renameContextMenuStripItem.Click += RenameEntries;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            // 
            // openInExplorerContextMenuStripItem
            // 
            openInExplorerContextMenuStripItem.DropDownItems.AddRange(new ToolStripItem[] { installLocationOpenInExplorerContextMenuStripItem, uninstallerLocationOpenInExplorerContextMenuStripItem, sourceLocationOpenInExplorerContextMenuStripItem });
            resources.ApplyResources(openInExplorerContextMenuStripItem, "openInExplorerContextMenuStripItem");
            openInExplorerContextMenuStripItem.Name = "openInExplorerContextMenuStripItem";
            // 
            // installLocationOpenInExplorerContextMenuStripItem
            // 
            installLocationOpenInExplorerContextMenuStripItem.Name = "installLocationOpenInExplorerContextMenuStripItem";
            resources.ApplyResources(installLocationOpenInExplorerContextMenuStripItem, "installLocationOpenInExplorerContextMenuStripItem");
            installLocationOpenInExplorerContextMenuStripItem.Click += OpenInstallLocation;
            // 
            // uninstallerLocationOpenInExplorerContextMenuStripItem
            // 
            uninstallerLocationOpenInExplorerContextMenuStripItem.Name = "uninstallerLocationOpenInExplorerContextMenuStripItem";
            resources.ApplyResources(uninstallerLocationOpenInExplorerContextMenuStripItem, "uninstallerLocationOpenInExplorerContextMenuStripItem");
            uninstallerLocationOpenInExplorerContextMenuStripItem.Click += OpenUninstallerLocation;
            // 
            // sourceLocationOpenInExplorerContextMenuStripItem
            // 
            sourceLocationOpenInExplorerContextMenuStripItem.Name = "sourceLocationOpenInExplorerContextMenuStripItem";
            resources.ApplyResources(sourceLocationOpenInExplorerContextMenuStripItem, "sourceLocationOpenInExplorerContextMenuStripItem");
            sourceLocationOpenInExplorerContextMenuStripItem.Click += OpenInstallationSource;
            // 
            // openWebPageContextMenuStripItem
            // 
            openWebPageContextMenuStripItem.Name = "openWebPageContextMenuStripItem";
            resources.ApplyResources(openWebPageContextMenuStripItem, "openWebPageContextMenuStripItem");
            openWebPageContextMenuStripItem.Click += OpenAssociatedWebPage;
            // 
            // lookUpOnlineToolStripMenuItem
            // 
            lookUpOnlineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem15, toolStripMenuItem16, slantcoToolStripMenuItem, toolStripSeparator26, fossHubcomToolStripMenuItem, sourceForgecomToolStripMenuItem, gitHubcomToolStripMenuItem, fileHippocomToolStripMenuItem });
            resources.ApplyResources(lookUpOnlineToolStripMenuItem, "lookUpOnlineToolStripMenuItem");
            lookUpOnlineToolStripMenuItem.Name = "lookUpOnlineToolStripMenuItem";
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            resources.ApplyResources(toolStripMenuItem15, "toolStripMenuItem15");
            toolStripMenuItem15.Click += googleToolStripMenuItem_Click;
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            resources.ApplyResources(toolStripMenuItem16, "toolStripMenuItem16");
            toolStripMenuItem16.Click += alternativeToToolStripMenuItem_Click;
            // 
            // slantcoToolStripMenuItem
            // 
            slantcoToolStripMenuItem.Name = "slantcoToolStripMenuItem";
            resources.ApplyResources(slantcoToolStripMenuItem, "slantcoToolStripMenuItem");
            slantcoToolStripMenuItem.Click += slantcoToolStripMenuItem_Click;
            // 
            // toolStripSeparator26
            // 
            toolStripSeparator26.Name = "toolStripSeparator26";
            resources.ApplyResources(toolStripSeparator26, "toolStripSeparator26");
            // 
            // fossHubcomToolStripMenuItem
            // 
            fossHubcomToolStripMenuItem.Name = "fossHubcomToolStripMenuItem";
            resources.ApplyResources(fossHubcomToolStripMenuItem, "fossHubcomToolStripMenuItem");
            fossHubcomToolStripMenuItem.Click += fossHubcomToolStripMenuItem_Click;
            // 
            // sourceForgecomToolStripMenuItem
            // 
            sourceForgecomToolStripMenuItem.Name = "sourceForgecomToolStripMenuItem";
            resources.ApplyResources(sourceForgecomToolStripMenuItem, "sourceForgecomToolStripMenuItem");
            sourceForgecomToolStripMenuItem.Click += sourceForgecomToolStripMenuItem_Click;
            // 
            // gitHubcomToolStripMenuItem
            // 
            gitHubcomToolStripMenuItem.Name = "gitHubcomToolStripMenuItem";
            resources.ApplyResources(gitHubcomToolStripMenuItem, "gitHubcomToolStripMenuItem");
            gitHubcomToolStripMenuItem.Click += gitHubcomToolStripMenuItem_Click;
            // 
            // fileHippocomToolStripMenuItem
            // 
            fileHippocomToolStripMenuItem.Name = "fileHippocomToolStripMenuItem";
            resources.ApplyResources(fileHippocomToolStripMenuItem, "fileHippocomToolStripMenuItem");
            fileHippocomToolStripMenuItem.Click += fileHippocomToolStripMenuItem_Click;
            // 
            // rateToolStripMenuItem
            // 
            rateToolStripMenuItem.Image = Properties.Resources.star;
            rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            resources.ApplyResources(rateToolStripMenuItem, "rateToolStripMenuItem");
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(toolStripSeparator7, "toolStripSeparator7");
            // 
            // propertiesContextMenuStripItem
            // 
            resources.ApplyResources(propertiesContextMenuStripItem, "propertiesContextMenuStripItem");
            propertiesContextMenuStripItem.Image = Properties.Resources.magnifybrowse;
            propertiesContextMenuStripItem.Name = "propertiesContextMenuStripItem";
            propertiesContextMenuStripItem.Click += OpenProperties;
            // 
            // exportDialog
            // 
            exportDialog.DefaultExt = "txt";
            exportDialog.FileName = "New BCUninstaller Export";
            resources.ApplyResources(exportDialog, "exportDialog");
            exportDialog.RestoreDirectory = true;
            exportDialog.FileOk += exportDialog_FileOk;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, filteringToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, debugToolStripMenuItem });
            resources.ApplyResources(menuStrip, "menuStrip");
            menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reloadUninstallersToolStripMenuItem, toolStripSeparator1, loadUninstallerListToolStripMenuItem, toolStripSeparator30, exportSelectedToolStripMenuItem, exportToABatchUninstallScriptToolStripMenuItem, exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem, toolStripSeparator10, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            fileToolStripMenuItem.DropDownOpening += fileToolStripMenuItem_DropDownOpening;
            // 
            // reloadUninstallersToolStripMenuItem
            // 
            resources.ApplyResources(reloadUninstallersToolStripMenuItem, "reloadUninstallersToolStripMenuItem");
            reloadUninstallersToolStripMenuItem.Name = "reloadUninstallersToolStripMenuItem";
            reloadUninstallersToolStripMenuItem.Click += ReloadUninstallers;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // loadUninstallerListToolStripMenuItem
            // 
            resources.ApplyResources(loadUninstallerListToolStripMenuItem, "loadUninstallerListToolStripMenuItem");
            loadUninstallerListToolStripMenuItem.Name = "loadUninstallerListToolStripMenuItem";
            loadUninstallerListToolStripMenuItem.Click += OpenUninstallLists;
            // 
            // toolStripSeparator30
            // 
            toolStripSeparator30.Name = "toolStripSeparator30";
            resources.ApplyResources(toolStripSeparator30, "toolStripSeparator30");
            // 
            // exportSelectedToolStripMenuItem
            // 
            exportSelectedToolStripMenuItem.Name = "exportSelectedToolStripMenuItem";
            resources.ApplyResources(exportSelectedToolStripMenuItem, "exportSelectedToolStripMenuItem");
            exportSelectedToolStripMenuItem.Click += exportSelectedToolStripMenuItem_Click;
            // 
            // exportToABatchUninstallScriptToolStripMenuItem
            // 
            exportToABatchUninstallScriptToolStripMenuItem.Name = "exportToABatchUninstallScriptToolStripMenuItem";
            resources.ApplyResources(exportToABatchUninstallScriptToolStripMenuItem, "exportToABatchUninstallScriptToolStripMenuItem");
            exportToABatchUninstallScriptToolStripMenuItem.Click += exportToABatchUninstallScriptToolStripMenuItem_Click;
            // 
            // exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem
            // 
            exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem.Name = "exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem";
            resources.ApplyResources(exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem, "exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem");
            exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem.Click += exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(toolStripSeparator10, "toolStripSeparator10");
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showColorLegendToolStripMenuItem, displayToolbarToolStripMenuItem, showTreemapToolStripMenuItem, displaySettingsToolStripMenuItem, displayStatusbarToolStripMenuItem, toolStripSeparator12, useSystemThemeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            viewToolStripMenuItem.DropDownOpening += viewToolStripMenuItem_DropDownOpening;
            // 
            // showColorLegendToolStripMenuItem
            // 
            showColorLegendToolStripMenuItem.Name = "showColorLegendToolStripMenuItem";
            resources.ApplyResources(showColorLegendToolStripMenuItem, "showColorLegendToolStripMenuItem");
            // 
            // displayToolbarToolStripMenuItem
            // 
            displayToolbarToolStripMenuItem.Checked = true;
            displayToolbarToolStripMenuItem.CheckState = CheckState.Checked;
            displayToolbarToolStripMenuItem.Name = "displayToolbarToolStripMenuItem";
            resources.ApplyResources(displayToolbarToolStripMenuItem, "displayToolbarToolStripMenuItem");
            // 
            // showTreemapToolStripMenuItem
            // 
            showTreemapToolStripMenuItem.Name = "showTreemapToolStripMenuItem";
            resources.ApplyResources(showTreemapToolStripMenuItem, "showTreemapToolStripMenuItem");
            // 
            // displaySettingsToolStripMenuItem
            // 
            displaySettingsToolStripMenuItem.Checked = true;
            displaySettingsToolStripMenuItem.CheckState = CheckState.Checked;
            displaySettingsToolStripMenuItem.Name = "displaySettingsToolStripMenuItem";
            resources.ApplyResources(displaySettingsToolStripMenuItem, "displaySettingsToolStripMenuItem");
            // 
            // displayStatusbarToolStripMenuItem
            // 
            displayStatusbarToolStripMenuItem.Checked = true;
            displayStatusbarToolStripMenuItem.CheckState = CheckState.Checked;
            displayStatusbarToolStripMenuItem.Name = "displayStatusbarToolStripMenuItem";
            resources.ApplyResources(displayStatusbarToolStripMenuItem, "displayStatusbarToolStripMenuItem");
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(toolStripSeparator12, "toolStripSeparator12");
            // 
            // useSystemThemeToolStripMenuItem
            // 
            useSystemThemeToolStripMenuItem.Checked = true;
            useSystemThemeToolStripMenuItem.CheckState = CheckState.Checked;
            useSystemThemeToolStripMenuItem.Name = "useSystemThemeToolStripMenuItem";
            resources.ApplyResources(useSystemThemeToolStripMenuItem, "useSystemThemeToolStripMenuItem");
            // 
            // filteringToolStripMenuItem
            // 
            filteringToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { advancedApplicationsToolStripMenuItem, basicApplicationsToolStripMenuItem, systemComponentsToolStripMenuItem, everythingToolStripMenuItem, toolStripSeparator20, automaticallyStartedToolStripMenuItem, onlyWebBrowsersToolStripMenuItem, toolStripSeparator31, viewTweaksToolStripMenuItem, viewUnregisteredToolStripMenuItem, viewUpdatesToolStripMenuItem, viewWindowsFeaturesToolStripMenuItem, viewWindowsStoreAppsToolStripMenuItem, toolStripSeparator28, searchToolStripMenuItem });
            filteringToolStripMenuItem.Name = "filteringToolStripMenuItem";
            resources.ApplyResources(filteringToolStripMenuItem, "filteringToolStripMenuItem");
            filteringToolStripMenuItem.DropDownOpening += filteringToolStripMenuItem_DropDownOpening;
            // 
            // advancedApplicationsToolStripMenuItem
            // 
            advancedApplicationsToolStripMenuItem.Image = Properties.Resources.filter;
            advancedApplicationsToolStripMenuItem.Name = "advancedApplicationsToolStripMenuItem";
            resources.ApplyResources(advancedApplicationsToolStripMenuItem, "advancedApplicationsToolStripMenuItem");
            advancedApplicationsToolStripMenuItem.Click += advancedApplicationsToolStripMenuItem_Click;
            // 
            // basicApplicationsToolStripMenuItem
            // 
            basicApplicationsToolStripMenuItem.Name = "basicApplicationsToolStripMenuItem";
            resources.ApplyResources(basicApplicationsToolStripMenuItem, "basicApplicationsToolStripMenuItem");
            basicApplicationsToolStripMenuItem.Click += basicApplicationsToolStripMenuItem_Click;
            // 
            // systemComponentsToolStripMenuItem
            // 
            systemComponentsToolStripMenuItem.Name = "systemComponentsToolStripMenuItem";
            resources.ApplyResources(systemComponentsToolStripMenuItem, "systemComponentsToolStripMenuItem");
            systemComponentsToolStripMenuItem.Click += systemComponentsToolStripMenuItem_Click;
            // 
            // everythingToolStripMenuItem
            // 
            everythingToolStripMenuItem.Name = "everythingToolStripMenuItem";
            resources.ApplyResources(everythingToolStripMenuItem, "everythingToolStripMenuItem");
            everythingToolStripMenuItem.Click += everythingToolStripMenuItem_Click;
            // 
            // toolStripSeparator20
            // 
            toolStripSeparator20.Name = "toolStripSeparator20";
            resources.ApplyResources(toolStripSeparator20, "toolStripSeparator20");
            // 
            // automaticallyStartedToolStripMenuItem
            // 
            automaticallyStartedToolStripMenuItem.Image = Properties.Resources.timer;
            automaticallyStartedToolStripMenuItem.Name = "automaticallyStartedToolStripMenuItem";
            resources.ApplyResources(automaticallyStartedToolStripMenuItem, "automaticallyStartedToolStripMenuItem");
            automaticallyStartedToolStripMenuItem.Click += automaticallyStartedToolStripMenuItem_Click;
            // 
            // onlyWebBrowsersToolStripMenuItem
            // 
            onlyWebBrowsersToolStripMenuItem.Name = "onlyWebBrowsersToolStripMenuItem";
            resources.ApplyResources(onlyWebBrowsersToolStripMenuItem, "onlyWebBrowsersToolStripMenuItem");
            onlyWebBrowsersToolStripMenuItem.Click += onlyWebBrowsersToolStripMenuItem_Click;
            // 
            // toolStripSeparator31
            // 
            toolStripSeparator31.Name = "toolStripSeparator31";
            resources.ApplyResources(toolStripSeparator31, "toolStripSeparator31");
            // 
            // viewTweaksToolStripMenuItem
            // 
            viewTweaksToolStripMenuItem.Name = "viewTweaksToolStripMenuItem";
            resources.ApplyResources(viewTweaksToolStripMenuItem, "viewTweaksToolStripMenuItem");
            viewTweaksToolStripMenuItem.Click += viewTweaksToolStripMenuItem_Click;
            // 
            // viewUnregisteredToolStripMenuItem
            // 
            viewUnregisteredToolStripMenuItem.Name = "viewUnregisteredToolStripMenuItem";
            resources.ApplyResources(viewUnregisteredToolStripMenuItem, "viewUnregisteredToolStripMenuItem");
            viewUnregisteredToolStripMenuItem.Click += viewUnregisteredToolStripMenuItem_Click;
            // 
            // viewUpdatesToolStripMenuItem
            // 
            viewUpdatesToolStripMenuItem.Name = "viewUpdatesToolStripMenuItem";
            resources.ApplyResources(viewUpdatesToolStripMenuItem, "viewUpdatesToolStripMenuItem");
            viewUpdatesToolStripMenuItem.Click += viewUpdatesToolStripMenuItem_Click;
            // 
            // viewWindowsFeaturesToolStripMenuItem
            // 
            viewWindowsFeaturesToolStripMenuItem.Name = "viewWindowsFeaturesToolStripMenuItem";
            resources.ApplyResources(viewWindowsFeaturesToolStripMenuItem, "viewWindowsFeaturesToolStripMenuItem");
            viewWindowsFeaturesToolStripMenuItem.Click += viewWindowsFeaturesToolStripMenuItem_Click;
            // 
            // viewWindowsStoreAppsToolStripMenuItem
            // 
            viewWindowsStoreAppsToolStripMenuItem.Name = "viewWindowsStoreAppsToolStripMenuItem";
            resources.ApplyResources(viewWindowsStoreAppsToolStripMenuItem, "viewWindowsStoreAppsToolStripMenuItem");
            viewWindowsStoreAppsToolStripMenuItem.Click += viewWindowsStoreAppsToolStripMenuItem_Click;
            // 
            // toolStripSeparator28
            // 
            toolStripSeparator28.Name = "toolStripSeparator28";
            resources.ApplyResources(toolStripSeparator28, "toolStripSeparator28");
            // 
            // searchToolStripMenuItem
            // 
            resources.ApplyResources(searchToolStripMenuItem, "searchToolStripMenuItem");
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openStartupManagerToolStripMenuItem, toolStripSeparator25, cleanUpProgramFilesToolStripMenuItem, targetMenuItem, uninstallFromDirectoryToolStripMenuItem, toolStripSeparator13, troubleshootUninstallProblemsToolStripMenuItem, startDiskCleanupToolStripMenuItem, tryToInstallNETV35ToolStripMenuItem, createRestorePointToolStripMenuItem, toolStripSeparator29, openProgramsAndFeaturesToolStripMenuItem, openSystemRestoreToolStripMenuItem, toolStripSeparator19, settingsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(toolsToolStripMenuItem, "toolsToolStripMenuItem");
            toolsToolStripMenuItem.DropDownOpening += toolsToolStripMenuItem_DropDownOpening;
            // 
            // openStartupManagerToolStripMenuItem
            // 
            resources.ApplyResources(openStartupManagerToolStripMenuItem, "openStartupManagerToolStripMenuItem");
            openStartupManagerToolStripMenuItem.Name = "openStartupManagerToolStripMenuItem";
            openStartupManagerToolStripMenuItem.Click += openStartupManagerToolStripMenuItem_Click;
            // 
            // toolStripSeparator25
            // 
            toolStripSeparator25.Name = "toolStripSeparator25";
            resources.ApplyResources(toolStripSeparator25, "toolStripSeparator25");
            // 
            // cleanUpProgramFilesToolStripMenuItem
            // 
            resources.ApplyResources(cleanUpProgramFilesToolStripMenuItem, "cleanUpProgramFilesToolStripMenuItem");
            cleanUpProgramFilesToolStripMenuItem.Name = "cleanUpProgramFilesToolStripMenuItem";
            cleanUpProgramFilesToolStripMenuItem.Click += cleanUpProgramFilesToolStripMenuItem_Click;
            // 
            // targetMenuItem
            // 
            targetMenuItem.Image = Properties.Resources.target;
            resources.ApplyResources(targetMenuItem, "targetMenuItem");
            targetMenuItem.Name = "targetMenuItem";
            targetMenuItem.Click += OpenTargetWindow;
            // 
            // uninstallFromDirectoryToolStripMenuItem
            // 
            uninstallFromDirectoryToolStripMenuItem.Name = "uninstallFromDirectoryToolStripMenuItem";
            resources.ApplyResources(uninstallFromDirectoryToolStripMenuItem, "uninstallFromDirectoryToolStripMenuItem");
            uninstallFromDirectoryToolStripMenuItem.Click += uninstallFromDirectoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(toolStripSeparator13, "toolStripSeparator13");
            // 
            // troubleshootUninstallProblemsToolStripMenuItem
            // 
            troubleshootUninstallProblemsToolStripMenuItem.Name = "troubleshootUninstallProblemsToolStripMenuItem";
            resources.ApplyResources(troubleshootUninstallProblemsToolStripMenuItem, "troubleshootUninstallProblemsToolStripMenuItem");
            troubleshootUninstallProblemsToolStripMenuItem.Click += troubleshootUninstallProblemsToolStripMenuItem_Click;
            // 
            // startDiskCleanupToolStripMenuItem
            // 
            startDiskCleanupToolStripMenuItem.Name = "startDiskCleanupToolStripMenuItem";
            resources.ApplyResources(startDiskCleanupToolStripMenuItem, "startDiskCleanupToolStripMenuItem");
            startDiskCleanupToolStripMenuItem.Click += startDiskCleanupToolStripMenuItem_Click;
            // 
            // tryToInstallNETV35ToolStripMenuItem
            // 
            tryToInstallNETV35ToolStripMenuItem.Name = "tryToInstallNETV35ToolStripMenuItem";
            resources.ApplyResources(tryToInstallNETV35ToolStripMenuItem, "tryToInstallNETV35ToolStripMenuItem");
            tryToInstallNETV35ToolStripMenuItem.Click += tryToInstallNETV35ToolStripMenuItem_Click;
            // 
            // createRestorePointToolStripMenuItem
            // 
            createRestorePointToolStripMenuItem.Name = "createRestorePointToolStripMenuItem";
            resources.ApplyResources(createRestorePointToolStripMenuItem, "createRestorePointToolStripMenuItem");
            createRestorePointToolStripMenuItem.Click += createRestorePointToolStripMenuItem_Click;
            // 
            // toolStripSeparator29
            // 
            toolStripSeparator29.Name = "toolStripSeparator29";
            resources.ApplyResources(toolStripSeparator29, "toolStripSeparator29");
            // 
            // openProgramsAndFeaturesToolStripMenuItem
            // 
            openProgramsAndFeaturesToolStripMenuItem.Name = "openProgramsAndFeaturesToolStripMenuItem";
            resources.ApplyResources(openProgramsAndFeaturesToolStripMenuItem, "openProgramsAndFeaturesToolStripMenuItem");
            openProgramsAndFeaturesToolStripMenuItem.Click += openProgramsAndFeaturesToolStripMenuItem_Click;
            // 
            // openSystemRestoreToolStripMenuItem
            // 
            openSystemRestoreToolStripMenuItem.Name = "openSystemRestoreToolStripMenuItem";
            resources.ApplyResources(openSystemRestoreToolStripMenuItem, "openSystemRestoreToolStripMenuItem");
            openSystemRestoreToolStripMenuItem.Click += openSystemRestoreToolStripMenuItem_Click;
            // 
            // toolStripSeparator19
            // 
            toolStripSeparator19.Name = "toolStripSeparator19";
            resources.ApplyResources(toolStripSeparator19, "toolStripSeparator19");
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openHelpToolStripMenuItem, startSetupWizardToolStripMenuItem, toolStripSeparator16, checkForUpdatesToolStripMenuItem, submitFeedbackToolStripMenuItem, toolStripSeparator18, resetSettingsToolStripMenuItem, uninstallBCUninstallToolstripMenuItem, toolStripSeparator17, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.DropDownOpening += helpToolStripMenuItem_DropDownOpening;
            // 
            // openHelpToolStripMenuItem
            // 
            openHelpToolStripMenuItem.Image = Properties.Resources.information_circle;
            openHelpToolStripMenuItem.Name = "openHelpToolStripMenuItem";
            resources.ApplyResources(openHelpToolStripMenuItem, "openHelpToolStripMenuItem");
            openHelpToolStripMenuItem.Click += openHelpToolStripMenuItem_Click;
            // 
            // startSetupWizardToolStripMenuItem
            // 
            startSetupWizardToolStripMenuItem.Name = "startSetupWizardToolStripMenuItem";
            resources.ApplyResources(startSetupWizardToolStripMenuItem, "startSetupWizardToolStripMenuItem");
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            resources.ApplyResources(toolStripSeparator16, "toolStripSeparator16");
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            checkForUpdatesToolStripMenuItem.Click += checkForUpdatesToolStripMenuItem_Click;
            // 
            // submitFeedbackToolStripMenuItem
            // 
            /*resources.ApplyResources(submitFeedbackToolStripMenuItem, "submitFeedbackToolStripMenuItem");
            submitFeedbackToolStripMenuItem.Name = "submitFeedbackToolStripMenuItem";
            //submitFeedbackToolStripMenuItem.Click += OpenSubmitFeedbackWindow;*/
            // 
            // toolStripSeparator18
            // 
            toolStripSeparator18.Name = "toolStripSeparator18";
            resources.ApplyResources(toolStripSeparator18, "toolStripSeparator18");
            // 
            // resetSettingsToolStripMenuItem
            // 
            resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            resources.ApplyResources(resetSettingsToolStripMenuItem, "resetSettingsToolStripMenuItem");
            resetSettingsToolStripMenuItem.Click += ResetSettingsDialog;
            // 
            // uninstallBCUninstallToolstripMenuItem
            // 
            uninstallBCUninstallToolstripMenuItem.Name = "uninstallBCUninstallToolstripMenuItem";
            resources.ApplyResources(uninstallBCUninstallToolstripMenuItem, "uninstallBCUninstallToolstripMenuItem");
            uninstallBCUninstallToolstripMenuItem.Click += uninstallBCUninstallToolstripMenuItem_Click;
            // 
            // toolStripSeparator17
            // 
            toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(toolStripSeparator17, "toolStripSeparator17");
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            resources.ApplyResources(debugToolStripMenuItem, "debugToolStripMenuItem");
            debugToolStripMenuItem.Click += OpenDebugWindow;
            // 
            // createBackupFileDialog
            // 
            createBackupFileDialog.DefaultExt = "reg";
            createBackupFileDialog.FileName = "New Uninstaller Backup";
            resources.ApplyResources(createBackupFileDialog, "createBackupFileDialog");
            createBackupFileDialog.FileOk += createBackupFileDialog_FileOk;
            // 
            // globalHotkeys1
            // 
            globalHotkeys1.ContainerControl = this;
            globalHotkeys1.StopWhenFormIsDisabled = true;
            globalHotkeys1.SuppressKeyPresses = true;
            // 
            // splashScreen1
            // 
            splashScreen1.AutomaticallyClose = false;
            splashScreen1.ContainerControl = this;
            splashScreen1.SplashScreenImage = Properties.Resources._bcu_logo;
            // 
            // usageTracker
            // 
            usageTracker.ContainerControl = this;
            // 
            // toolStripButtonUninstall
            // 
            resources.ApplyResources(toolStripButtonUninstall, "toolStripButtonUninstall");
            toolStripButtonUninstall.Name = "toolStripButtonUninstall";
            toolStripButtonUninstall.Click += RunLoudUninstall;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(settingsSidebarPanel);
            Controls.Add(menuStrip);
            KeyPreview = true;
            Name = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            FormClosed += MainWindow_FormClosed;
            Shown += MainWindow_Shown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainerListAndMap.Panel1.ResumeLayout(false);
            splitContainerListAndMap.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainerListAndMap).EndInit();
            splitContainerListAndMap.ResumeLayout(false);
            listViewPanel.ResumeLayout(false);
            ((ISupportInitialize)uninstallerObjectListView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            settingsSidebarPanel.ResumeLayout(false);
            settingsSidebarPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            uninstallListContextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        internal ObjectListView uninstallerObjectListView;
        internal OLVColumn olvColumnDisplayName;
        internal OLVColumn olvColumnPublisher;
        internal OLVColumn olvColumnDisplayVersion;
        internal OLVColumn olvColumnUninstallString;
        internal OLVColumn olvColumnInstallDate;
        internal OLVColumn olvColumnIs64;
        internal OLVColumn olvColumnGuid;
        internal OLVColumn olvColumnSize;
        internal OLVColumn olvColumnInstallSource;
        internal OLVColumn olvColumnInstallLocation;
        internal OLVColumn olvColumnUninstallerKind;
        internal OLVColumn olvColumnAbout;
        internal OLVColumn olvColumnRegistryKeyName;
        internal OLVColumn olvColumnSystemComponent;
        internal OLVColumn olvColumnQuietUninstallString;
        internal OLVColumn olvColumnProtected;
        private SaveFileDialog exportDialog;
        private ContextMenuStrip uninstallListContextMenuStrip;
        private ToolStripMenuItem uninstallContextMenuStripItem;
        private ToolStripMenuItem propertiesContextMenuStripItem;
        private Panel settingsSidebarPanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem reloadUninstallersToolStripMenuItem;
        private ToolStripMenuItem exportSelectedToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem displayToolbarToolStripMenuItem;
        private ToolStripMenuItem displaySettingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openHelpToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripMenuItem resetSettingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip;
        private SaveFileDialog createBackupFileDialog;
        private ToolStripMenuItem quietUninstallContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem copyToClipboardContextMenuStripItem;
        private ToolStripMenuItem fullInformationCopyContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem programNameCopyContextMenuStripItem;
        private ToolStripMenuItem gUIDProductCodeCopyContextMenuStripItem;
        private ToolStripMenuItem fullRegistryPathCopyContextMenuStripItem;
        private ToolStripMenuItem uninstallStringCopyContextMenuStripItem;
        private ToolStripMenuItem deleteRegistryEntryContextMenuStripItem;
        private ToolStripMenuItem renameContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem openInExplorerContextMenuStripItem;
        private ToolStripMenuItem installLocationOpenInExplorerContextMenuStripItem;
        private ToolStripMenuItem uninstallerLocationOpenInExplorerContextMenuStripItem;
        private ToolStripMenuItem sourceLocationOpenInExplorerContextMenuStripItem;
        private ToolStripMenuItem openWebPageContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem uninstallUsingMsiExecContextMenuStripItem;
        private ToolStripMenuItem msiInstallContextMenuStripItem;
        private ToolStripMenuItem msiUninstallContextMenuStripItem;
        private ToolStripMenuItem msiQuietUninstallContextMenuStripItem;
        private ToolStripMenuItem useSystemThemeToolStripMenuItem;
        private ToolStripMenuItem submitFeedbackToolStripMenuItem;
        private ToolStripMenuItem loadUninstallerListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem lookUpOnlineToolStripMenuItem;
        private PropertiesSidebar propertiesSidebar;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem uninstallBCUninstallToolstripMenuItem;
        private UsageTracker usageTracker;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripLabelStatus;
        private ToolStripStatusLabel toolStripLabelSize;
        private ToolStripStatusLabel toolStripLabelTotal;
        private ToolStripMenuItem displayStatusbarToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem openProgramsAndFeaturesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem manualUninstallToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripMenuItem startSetupWizardToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem cleanUpProgramFilesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator20;
        private ToolStripMenuItem searchToolStripMenuItem;
        internal Klocman.Subsystems.GlobalHotkeys globalHotkeys1;
        private ToolStripMenuItem showColorLegendToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripMenuItem openStartupManagerToolStripMenuItem;

        private Panel listViewPanel;
        internal OLVColumn olvColumnRating;
        private ToolStripMenuItem rateToolStripMenuItem;
        private ToolStripMenuItem viewWindowsStoreAppsToolStripMenuItem;
        internal UninstallTools.Controls.FilterEditor filterEditor1;
        private Button buttonAdvFiltering;
        private AdvancedFilters advancedFilters1;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem viewWindowsFeaturesToolStripMenuItem;
        private ToolStripMenuItem uninstallFromDirectoryToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem openSystemRestoreToolStripMenuItem;
        private Klocman.Forms.SplashScreen splashScreen1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem viewUpdatesToolStripMenuItem;
        private ToolStripMenuItem targetMenuItem;
        private ToolStripSeparator toolStripSeparator25;
        private ToolStripSeparator toolStripSeparator26;
        private ToolStripMenuItem fossHubcomToolStripMenuItem;
        private ToolStripMenuItem sourceForgecomToolStripMenuItem;
        private ToolStripMenuItem fileHippocomToolStripMenuItem;
        private ToolStripMenuItem gitHubcomToolStripMenuItem;
        private ToolStripMenuItem excludeToolStripMenuItem;
        private ToolStripMenuItem includeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparatorFiltering;
        private SplitContainer splitContainerListAndMap;
        private SimpleTreeMap.TreeMap treeMap1;
        private ToolStripMenuItem showTreemapToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator28;
        private ToolStripMenuItem viewUnregisteredToolStripMenuItem;
        private ToolStripMenuItem tryToInstallNETV35ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator29;
        private ToolStripMenuItem startDiskCleanupToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator30;
        private ToolStripMenuItem exportStoreAppsToPowerShellRemoveScriptToolStripMenuItem;
        private ToolStripMenuItem exportToABatchUninstallScriptToolStripMenuItem;
        private ToolStripMenuItem troubleshootUninstallProblemsToolStripMenuItem;
        private ToolStripMenuItem filteringToolStripMenuItem;
        private ToolStripMenuItem basicApplicationsToolStripMenuItem;
        private ToolStripMenuItem advancedApplicationsToolStripMenuItem;
        private ToolStripMenuItem systemComponentsToolStripMenuItem;
        private ToolStripMenuItem automaticallyStartedToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator31;
        private ToolStripMenuItem everythingToolStripMenuItem;
        private ToolStripMenuItem onlyWebBrowsersToolStripMenuItem;
        private ToolStripMenuItem viewTweaksToolStripMenuItem;
        private ToolStripMenuItem slantcoToolStripMenuItem;
        private ToolStripMenuItem createRestorePointToolStripMenuItem;
        private ToolStripButton toolStripButtonUninstall;
    }
}


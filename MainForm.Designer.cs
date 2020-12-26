namespace NalivARM10
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ПТХН");
            this.menuMainStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveConfigAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrintFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrinter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsersList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWaggons = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWaggonList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWorkLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWorklogFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTunings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCommonTuning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSounds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiNodesTree = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServerParams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComPorts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiStopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRiserConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLink = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPLC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiADC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlarmLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbServerRun = new System.Windows.Forms.ToolStripButton();
            this.tsbServerStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLogin = new System.Windows.Forms.ToolStripButton();
            this.tsbLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbRisersList = new System.Windows.Forms.ToolStripComboBox();
            this.tsbTask = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbClearAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAllTasks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRunAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStopAll = new System.Windows.Forms.ToolStripButton();
            this.lvLog = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvRails = new System.Windows.Forms.TreeView();
            this.panRisers = new System.Windows.Forms.Panel();
            this.menuMainStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainStrip
            // 
            this.menuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiUsers,
            this.tsmiWaggons,
            this.tsmiLogs,
            this.tsmiTunings});
            this.menuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.menuMainStrip.Name = "menuMainStrip";
            this.menuMainStrip.Size = new System.Drawing.Size(967, 24);
            this.menuMainStrip.TabIndex = 0;
            this.menuMainStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadConfig,
            this.tsmiSaveConfig,
            this.tsmiSaveConfigAs,
            this.toolStripMenuItem1,
            this.tsmiPrintFormat,
            this.tsmiPrinter,
            this.toolStripMenuItem2,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiLoadConfig
            // 
            this.tsmiLoadConfig.Enabled = false;
            this.tsmiLoadConfig.Name = "tsmiLoadConfig";
            this.tsmiLoadConfig.Size = new System.Drawing.Size(250, 22);
            this.tsmiLoadConfig.Text = "Загрузить конфигурацию";
            // 
            // tsmiSaveConfig
            // 
            this.tsmiSaveConfig.Enabled = false;
            this.tsmiSaveConfig.Name = "tsmiSaveConfig";
            this.tsmiSaveConfig.Size = new System.Drawing.Size(250, 22);
            this.tsmiSaveConfig.Text = "Сохранить конфигурацию";
            // 
            // tsmiSaveConfigAs
            // 
            this.tsmiSaveConfigAs.Enabled = false;
            this.tsmiSaveConfigAs.Name = "tsmiSaveConfigAs";
            this.tsmiSaveConfigAs.Size = new System.Drawing.Size(250, 22);
            this.tsmiSaveConfigAs.Text = "Сохранить конфигурацию как...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiPrintFormat
            // 
            this.tsmiPrintFormat.Name = "tsmiPrintFormat";
            this.tsmiPrintFormat.Size = new System.Drawing.Size(250, 22);
            this.tsmiPrintFormat.Text = "Формат печати...";
            // 
            // tsmiPrinter
            // 
            this.tsmiPrinter.Name = "tsmiPrinter";
            this.tsmiPrinter.Size = new System.Drawing.Size(250, 22);
            this.tsmiPrinter.Text = "Принтер...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(250, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogin,
            this.tsmiLogout,
            this.tsmiCurrentUser,
            this.tsmiUsersList});
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(97, 20);
            this.tsmiUsers.Text = "Пользователи";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(132, 22);
            this.tsmiLogin.Text = "Войти...";
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(132, 22);
            this.tsmiLogout.Text = "Выйти...";
            // 
            // tsmiCurrentUser
            // 
            this.tsmiCurrentUser.Name = "tsmiCurrentUser";
            this.tsmiCurrentUser.Size = new System.Drawing.Size(132, 22);
            this.tsmiCurrentUser.Text = "Текущий...";
            // 
            // tsmiUsersList
            // 
            this.tsmiUsersList.Name = "tsmiUsersList";
            this.tsmiUsersList.Size = new System.Drawing.Size(132, 22);
            this.tsmiUsersList.Text = "Список";
            this.tsmiUsersList.Click += new System.EventHandler(this.tsmiUsersList_Click);
            // 
            // tsmiWaggons
            // 
            this.tsmiWaggons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTypes,
            this.tsmiWaggonList});
            this.tsmiWaggons.Name = "tsmiWaggons";
            this.tsmiWaggons.Size = new System.Drawing.Size(75, 20);
            this.tsmiWaggons.Text = "Цистерны";
            // 
            // tsmiTypes
            // 
            this.tsmiTypes.Name = "tsmiTypes";
            this.tsmiTypes.Size = new System.Drawing.Size(115, 22);
            this.tsmiTypes.Text = "Типы";
            // 
            // tsmiWaggonList
            // 
            this.tsmiWaggonList.Name = "tsmiWaggonList";
            this.tsmiWaggonList.Size = new System.Drawing.Size(115, 22);
            this.tsmiWaggonList.Text = "Список";
            // 
            // tsmiLogs
            // 
            this.tsmiLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWorkLog,
            this.tsmiWorklogFilter});
            this.tsmiLogs.Name = "tsmiLogs";
            this.tsmiLogs.Size = new System.Drawing.Size(72, 20);
            this.tsmiLogs.Text = "Журналы";
            // 
            // tsmiWorkLog
            // 
            this.tsmiWorkLog.Name = "tsmiWorkLog";
            this.tsmiWorkLog.Size = new System.Drawing.Size(187, 22);
            this.tsmiWorkLog.Text = "Лог работы";
            // 
            // tsmiWorklogFilter
            // 
            this.tsmiWorklogFilter.Name = "tsmiWorklogFilter";
            this.tsmiWorklogFilter.Size = new System.Drawing.Size(187, 22);
            this.tsmiWorklogFilter.Text = "Фильтр лога работы";
            // 
            // tsmiTunings
            // 
            this.tsmiTunings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCommonTuning,
            this.tsmiSounds,
            this.toolStripMenuItem3,
            this.tsmiSelectServer,
            this.toolStripMenuItem4,
            this.tsmiNodesTree,
            this.tsmiServerParams,
            this.tsmiComPorts,
            this.toolStripMenuItem5,
            this.tsmiStopServer,
            this.toolStripMenuItem6,
            this.tsmiRiserConfig,
            this.toolStripMenuItem7,
            this.tsmiShowNodes});
            this.tsmiTunings.Name = "tsmiTunings";
            this.tsmiTunings.Size = new System.Drawing.Size(79, 20);
            this.tsmiTunings.Text = "Настройки";
            // 
            // tsmiCommonTuning
            // 
            this.tsmiCommonTuning.Name = "tsmiCommonTuning";
            this.tsmiCommonTuning.Size = new System.Drawing.Size(194, 22);
            this.tsmiCommonTuning.Text = "Общие...";
            // 
            // tsmiSounds
            // 
            this.tsmiSounds.Name = "tsmiSounds";
            this.tsmiSounds.Size = new System.Drawing.Size(194, 22);
            this.tsmiSounds.Text = "Звуки...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiSelectServer
            // 
            this.tsmiSelectServer.Name = "tsmiSelectServer";
            this.tsmiSelectServer.Size = new System.Drawing.Size(194, 22);
            this.tsmiSelectServer.Text = "Выбор сервера...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiNodesTree
            // 
            this.tsmiNodesTree.Enabled = false;
            this.tsmiNodesTree.Name = "tsmiNodesTree";
            this.tsmiNodesTree.Size = new System.Drawing.Size(194, 22);
            this.tsmiNodesTree.Text = "Дерево устройств...";
            // 
            // tsmiServerParams
            // 
            this.tsmiServerParams.Name = "tsmiServerParams";
            this.tsmiServerParams.Size = new System.Drawing.Size(194, 22);
            this.tsmiServerParams.Text = "Параметры сервера...";
            // 
            // tsmiComPorts
            // 
            this.tsmiComPorts.Enabled = false;
            this.tsmiComPorts.Name = "tsmiComPorts";
            this.tsmiComPorts.Size = new System.Drawing.Size(194, 22);
            this.tsmiComPorts.Text = "COM порты...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiStopServer
            // 
            this.tsmiStopServer.Name = "tsmiStopServer";
            this.tsmiStopServer.Size = new System.Drawing.Size(194, 22);
            this.tsmiStopServer.Text = "Остановить сервер";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiRiserConfig
            // 
            this.tsmiRiserConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLink,
            this.tsmiPLC,
            this.tsmiADC,
            this.tsmiAlarmLevel,
            this.tsmiProductLevel,
            this.toolStripMenuItem8,
            this.tsmiStatus});
            this.tsmiRiserConfig.Name = "tsmiRiserConfig";
            this.tsmiRiserConfig.Size = new System.Drawing.Size(194, 22);
            this.tsmiRiserConfig.Text = "Конфигурация стояка";
            // 
            // tsmiLink
            // 
            this.tsmiLink.Name = "tsmiLink";
            this.tsmiLink.Size = new System.Drawing.Size(225, 22);
            this.tsmiLink.Text = "Связь...";
            // 
            // tsmiPLC
            // 
            this.tsmiPLC.Name = "tsmiPLC";
            this.tsmiPLC.Size = new System.Drawing.Size(225, 22);
            this.tsmiPLC.Text = "PLC...";
            // 
            // tsmiADC
            // 
            this.tsmiADC.Name = "tsmiADC";
            this.tsmiADC.Size = new System.Drawing.Size(225, 22);
            this.tsmiADC.Text = "ADC...";
            // 
            // tsmiAlarmLevel
            // 
            this.tsmiAlarmLevel.Name = "tsmiAlarmLevel";
            this.tsmiAlarmLevel.Size = new System.Drawing.Size(225, 22);
            this.tsmiAlarmLevel.Text = "Сигнализатор аварийный...";
            // 
            // tsmiProductLevel
            // 
            this.tsmiProductLevel.Name = "tsmiProductLevel";
            this.tsmiProductLevel.Size = new System.Drawing.Size(225, 22);
            this.tsmiProductLevel.Text = "Сигнализатор уровня...";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(222, 6);
            // 
            // tsmiStatus
            // 
            this.tsmiStatus.Name = "tsmiStatus";
            this.tsmiStatus.Size = new System.Drawing.Size(225, 22);
            this.tsmiStatus.Text = "Состояние...";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiShowNodes
            // 
            this.tsmiShowNodes.Name = "tsmiShowNodes";
            this.tsmiShowNodes.Size = new System.Drawing.Size(194, 22);
            this.tsmiShowNodes.Text = "Просмотр устройств";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbServerRun,
            this.tsbServerStop,
            this.toolStripSeparator2,
            this.tsbLogin,
            this.tsbLogout,
            this.toolStripSeparator3,
            this.tscbRisersList,
            this.tsbTask,
            this.tsbClear,
            this.tsbClearAll,
            this.toolStripSeparator4,
            this.tsbAllTasks,
            this.toolStripSeparator5,
            this.tsbRunAll,
            this.toolStripSeparator6,
            this.tsbStopAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(967, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbServerRun
            // 
            this.tsbServerRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbServerRun.Enabled = false;
            this.tsbServerRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbServerRun.Image")));
            this.tsbServerRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServerRun.Name = "tsbServerRun";
            this.tsbServerRun.Size = new System.Drawing.Size(23, 22);
            this.tsbServerRun.Text = "Запустить сервер";
            // 
            // tsbServerStop
            // 
            this.tsbServerStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbServerStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbServerStop.Image")));
            this.tsbServerStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServerStop.Name = "tsbServerStop";
            this.tsbServerStop.Size = new System.Drawing.Size(23, 22);
            this.tsbServerStop.Text = "Остановить сервер";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLogin
            // 
            this.tsbLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogin.Image")));
            this.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(23, 22);
            this.tsbLogin.Text = "Вход пользователя";
            // 
            // tsbLogout
            // 
            this.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogout.Image")));
            this.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.Size = new System.Drawing.Size(23, 22);
            this.tsbLogout.Text = "Выход пользователя";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tscbRisersList
            // 
            this.tscbRisersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbRisersList.Name = "tscbRisersList";
            this.tscbRisersList.Size = new System.Drawing.Size(121, 25);
            this.tscbRisersList.ToolTipText = "Список стояков группы";
            // 
            // tsbTask
            // 
            this.tsbTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbTask.Image = ((System.Drawing.Image)(resources.GetObject("tsbTask.Image")));
            this.tsbTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTask.Name = "tsbTask";
            this.tsbTask.Size = new System.Drawing.Size(59, 22);
            this.tsbTask.Text = "Задание";
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(66, 22);
            this.tsbClear.Text = "Очистить";
            // 
            // tsbClearAll
            // 
            this.tsbClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbClearAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearAll.Image")));
            this.tsbClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearAll.Name = "tsbClearAll";
            this.tsbClearAll.Size = new System.Drawing.Size(89, 22);
            this.tsbClearAll.Text = "Очистить все";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAllTasks
            // 
            this.tsbAllTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAllTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAllTasks.Image = ((System.Drawing.Image)(resources.GetObject("tsbAllTasks.Image")));
            this.tsbAllTasks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAllTasks.Name = "tsbAllTasks";
            this.tsbAllTasks.Size = new System.Drawing.Size(82, 22);
            this.tsbAllTasks.Text = "Все задания";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRunAll
            // 
            this.tsbRunAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRunAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbRunAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbRunAll.Image")));
            this.tsbRunAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRunAll.Name = "tsbRunAll";
            this.tsbRunAll.Size = new System.Drawing.Size(91, 22);
            this.tsbRunAll.Text = "Запустить все";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbStopAll
            // 
            this.tsbStopAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStopAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbStopAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbStopAll.Image")));
            this.tsbStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStopAll.Name = "tsbStopAll";
            this.tsbStopAll.Size = new System.Drawing.Size(101, 22);
            this.tsbStopAll.Text = "Остановить все";
            // 
            // lvLog
            // 
            this.lvLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(0, 308);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(967, 142);
            this.lvLog.TabIndex = 2;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvRails);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panRisers);
            this.splitContainer1.Size = new System.Drawing.Size(967, 259);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 3;
            // 
            // tvRails
            // 
            this.tvRails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvRails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRails.FullRowSelect = true;
            this.tvRails.HideSelection = false;
            this.tvRails.Location = new System.Drawing.Point(0, 0);
            this.tvRails.Name = "tvRails";
            treeNode1.Name = "Node0";
            treeNode1.Text = "ПТХН";
            this.tvRails.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvRails.Size = new System.Drawing.Size(171, 259);
            this.tvRails.TabIndex = 0;
            // 
            // panRisers
            // 
            this.panRisers.AutoScroll = true;
            this.panRisers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRisers.Location = new System.Drawing.Point(0, 0);
            this.panRisers.Name = "panRisers";
            this.panRisers.Size = new System.Drawing.Size(792, 259);
            this.panRisers.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuMainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Naliv ARM v10.00";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMainStrip.ResumeLayout(false);
            this.menuMainStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiWaggons;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogs;
        private System.Windows.Forms.ToolStripMenuItem tsmiTunings;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveConfigAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrinter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbServerRun;
        private System.Windows.Forms.ToolStripButton tsbServerStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbLogin;
        private System.Windows.Forms.ToolStripButton tsbLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsersList;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvRails;
        private System.Windows.Forms.Panel panRisers;
        private System.Windows.Forms.ToolStripComboBox tscbRisersList;
        private System.Windows.Forms.ToolStripButton tsbTask;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbClearAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAllTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbRunAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbStopAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiWaggonList;
        private System.Windows.Forms.ToolStripMenuItem tsmiWorkLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiWorklogFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommonTuning;
        private System.Windows.Forms.ToolStripMenuItem tsmiSounds;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectServer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiNodesTree;
        private System.Windows.Forms.ToolStripMenuItem tsmiServerParams;
        private System.Windows.Forms.ToolStripMenuItem tsmiComPorts;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiStopServer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem tsmiRiserConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowNodes;
        private System.Windows.Forms.ToolStripMenuItem tsmiLink;
        private System.Windows.Forms.ToolStripMenuItem tsmiPLC;
        private System.Windows.Forms.ToolStripMenuItem tsmiADC;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarmLevel;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatus;
    }
}


/*
 * Crée avec SharpDevelop.
 * Utilisateur: dodoritfort
 * Date: 17/05/2015
 * Heure: 17:11
 * 
 */
namespace SearchFilesEngine
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbSearchFileName;
		private System.Windows.Forms.TextBox tbSearchFileName;
		private System.Windows.Forms.Label lbSearchFilePath;
		private System.Windows.Forms.TextBox tbSearchFilePath;
		private System.Windows.Forms.DataGridView dgvResultat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Repertoire;
		private System.Windows.Forms.DataGridViewTextBoxColumn Taille;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Modifie;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cree;
		private System.Windows.Forms.DataGridViewTextBoxColumn DernierAccess;
		private System.Windows.Forms.Button btnSearchStart;
		private System.Windows.Forms.Button btnSearchStop;
		private System.Windows.Forms.Label lbSearchFileExtension;
		private System.Windows.Forms.TextBox tbSearchFileExtension;
		private System.Windows.Forms.Label lbFoundResult;
		private System.Windows.Forms.Label lbSearchFileFound;
		private System.Windows.Forms.ComboBox lstSearchSizeType;
		private System.Windows.Forms.Button btnSearchSizeUpperThan;
		private System.Windows.Forms.Button btnSearchSizeLowerThan;
		private System.Windows.Forms.TextBox tbSearchSizeUpperThan;
		private System.Windows.Forms.Button btnSearchDateModifiedAfter;
		private System.Windows.Forms.Button btnSearchDateModifiedBefore;
		private System.Windows.Forms.TextBox tbSearchDateModifiedBefore;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFileExit;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unite;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusResult;
		private System.Windows.Forms.CheckBox chkbxSearchFileSubfolder;
		private System.Windows.Forms.Button btnFolderSelect;
		private System.ComponentModel.BackgroundWorker bgWorker;
		private System.Windows.Forms.TextBox tbSearchDateLastAccessBefore;
		private System.Windows.Forms.Button btnSearchDateLastAccessAfter;
		private System.Windows.Forms.TextBox tbSearchDateLastAccessAfter;
		private System.Windows.Forms.Button btnSearchDateLastAccessBefore;
		private System.Windows.Forms.TextBox tbSearchDateCreatedBefore;
		private System.Windows.Forms.Button btnSearchDateCreatedAfter;
		private System.Windows.Forms.TextBox tbSearchDateCreatedAfter;
		private System.Windows.Forms.Button btnSearchDateCreatedBefore;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label lbTimeElapsed;
		private System.Windows.Forms.Label lbSearchFileTime;
		private System.Windows.Forms.ToolStripMenuItem menuTools;
		private System.Windows.Forms.ToolStripMenuItem menuToolsLanguagesFrench;
		private System.Windows.Forms.ToolStripMenuItem menuToolsLanguagesEnglish;
		private System.Windows.Forms.ToolStripMenuItem menuToolsLanguagesRussian;
		private System.Windows.Forms.ToolStripMenuItem menuToolsLanguages;
		private System.Windows.Forms.ToolStripMenuItem menuFileNewSearch;
		private System.Windows.Forms.ToolStripMenuItem menuFileExportResult;
		private System.Windows.Forms.GroupBox grpbxSearchFile;
		private System.Windows.Forms.GroupBox grpbxSearchSize;
		private System.Windows.Forms.GroupBox grpbxSearchDateModified;
		private System.Windows.Forms.GroupBox grpbxSearchDateCreated;
		private System.Windows.Forms.GroupBox grpbxSearchDateLastAccess;
		private System.Windows.Forms.TextBox tbSearchSizeLowerThan;
		private System.Windows.Forms.TextBox tbSearchDateModifiedAfter;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lbSearchFileName = new System.Windows.Forms.Label();
			this.tbSearchFileName = new System.Windows.Forms.TextBox();
			this.lbSearchFilePath = new System.Windows.Forms.Label();
			this.tbSearchFilePath = new System.Windows.Forms.TextBox();
			this.dgvResultat = new System.Windows.Forms.DataGridView();
			this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Repertoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unite = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Modifie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cree = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DernierAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearchStart = new System.Windows.Forms.Button();
			this.btnSearchStop = new System.Windows.Forms.Button();
			this.lbSearchFileExtension = new System.Windows.Forms.Label();
			this.tbSearchFileExtension = new System.Windows.Forms.TextBox();
			this.lbTimeElapsed = new System.Windows.Forms.Label();
			this.lbSearchFileTime = new System.Windows.Forms.Label();
			this.lbFoundResult = new System.Windows.Forms.Label();
			this.lbSearchFileFound = new System.Windows.Forms.Label();
			this.lstSearchSizeType = new System.Windows.Forms.ComboBox();
			this.btnSearchSizeUpperThan = new System.Windows.Forms.Button();
			this.btnSearchSizeLowerThan = new System.Windows.Forms.Button();
			this.tbSearchSizeUpperThan = new System.Windows.Forms.TextBox();
			this.tbSearchSizeLowerThan = new System.Windows.Forms.TextBox();
			this.btnSearchDateModifiedAfter = new System.Windows.Forms.Button();
			this.btnSearchDateModifiedBefore = new System.Windows.Forms.Button();
			this.tbSearchDateModifiedAfter = new System.Windows.Forms.TextBox();
			this.tbSearchDateModifiedBefore = new System.Windows.Forms.TextBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileNewSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileExportResult = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToolsLanguages = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToolsLanguagesFrench = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToolsLanguagesEnglish = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToolsLanguagesRussian = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusResult = new System.Windows.Forms.ToolStripStatusLabel();
			this.chkbxSearchFileSubfolder = new System.Windows.Forms.CheckBox();
			this.btnFolderSelect = new System.Windows.Forms.Button();
			this.tbSearchDateLastAccessBefore = new System.Windows.Forms.TextBox();
			this.btnSearchDateLastAccessAfter = new System.Windows.Forms.Button();
			this.tbSearchDateLastAccessAfter = new System.Windows.Forms.TextBox();
			this.btnSearchDateLastAccessBefore = new System.Windows.Forms.Button();
			this.tbSearchDateCreatedBefore = new System.Windows.Forms.TextBox();
			this.btnSearchDateCreatedAfter = new System.Windows.Forms.Button();
			this.tbSearchDateCreatedAfter = new System.Windows.Forms.TextBox();
			this.btnSearchDateCreatedBefore = new System.Windows.Forms.Button();
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.grpbxSearchFile = new System.Windows.Forms.GroupBox();
			this.grpbxSearchSize = new System.Windows.Forms.GroupBox();
			this.grpbxSearchDateModified = new System.Windows.Forms.GroupBox();
			this.grpbxSearchDateCreated = new System.Windows.Forms.GroupBox();
			this.grpbxSearchDateLastAccess = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.grpbxSearchFile.SuspendLayout();
			this.grpbxSearchSize.SuspendLayout();
			this.grpbxSearchDateModified.SuspendLayout();
			this.grpbxSearchDateCreated.SuspendLayout();
			this.grpbxSearchDateLastAccess.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbSearchFileName
			// 
			this.lbSearchFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbSearchFileName.Location = new System.Drawing.Point(6, 19);
			this.lbSearchFileName.Name = "lbSearchFileName";
			this.lbSearchFileName.Size = new System.Drawing.Size(100, 20);
			this.lbSearchFileName.TabIndex = 0;
			this.lbSearchFileName.Text = "Nom de fichier :";
			// 
			// tbSearchFileName
			// 
			this.tbSearchFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearchFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchFileName.Location = new System.Drawing.Point(112, 19);
			this.tbSearchFileName.Name = "tbSearchFileName";
			this.tbSearchFileName.Size = new System.Drawing.Size(142, 20);
			this.tbSearchFileName.TabIndex = 1;
			// 
			// lbSearchFilePath
			// 
			this.lbSearchFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbSearchFilePath.Location = new System.Drawing.Point(6, 71);
			this.lbSearchFilePath.Name = "lbSearchFilePath";
			this.lbSearchFilePath.Size = new System.Drawing.Size(100, 20);
			this.lbSearchFilePath.TabIndex = 2;
			this.lbSearchFilePath.Text = "Répertoire :";
			// 
			// tbSearchFilePath
			// 
			this.tbSearchFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearchFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchFilePath.Location = new System.Drawing.Point(112, 71);
			this.tbSearchFilePath.Name = "tbSearchFilePath";
			this.tbSearchFilePath.Size = new System.Drawing.Size(142, 20);
			this.tbSearchFilePath.TabIndex = 3;
			// 
			// dgvResultat
			// 
			this.dgvResultat.AllowUserToAddRows = false;
			this.dgvResultat.AllowUserToDeleteRows = false;
			this.dgvResultat.AllowUserToResizeRows = false;
			this.dgvResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvResultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvResultat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Nom,
			this.Repertoire,
			this.Taille,
			this.Unite,
			this.Type,
			this.Modifie,
			this.Cree,
			this.DernierAccess});
			this.dgvResultat.Location = new System.Drawing.Point(278, 27);
			this.dgvResultat.Name = "dgvResultat";
			this.dgvResultat.ReadOnly = true;
			this.dgvResultat.Size = new System.Drawing.Size(846, 558);
			this.dgvResultat.TabIndex = 4;
			this.dgvResultat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultatCellDoubleClick);
			// 
			// Nom
			// 
			this.Nom.HeaderText = "Nom";
			this.Nom.Name = "Nom";
			this.Nom.ReadOnly = true;
			this.Nom.Width = 170;
			// 
			// Repertoire
			// 
			this.Repertoire.HeaderText = "Répertoire";
			this.Repertoire.Name = "Repertoire";
			this.Repertoire.ReadOnly = true;
			this.Repertoire.Width = 170;
			// 
			// Taille
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N0";
			dataGridViewCellStyle5.NullValue = null;
			this.Taille.DefaultCellStyle = dataGridViewCellStyle5;
			this.Taille.HeaderText = "Taille";
			this.Taille.Name = "Taille";
			this.Taille.ReadOnly = true;
			this.Taille.Width = 50;
			// 
			// Unite
			// 
			this.Unite.HeaderText = "Unité";
			this.Unite.Name = "Unite";
			this.Unite.ReadOnly = true;
			this.Unite.Width = 50;
			// 
			// Type
			// 
			this.Type.HeaderText = "Type";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			this.Type.Width = 50;
			// 
			// Modifie
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Format = "G";
			dataGridViewCellStyle6.NullValue = null;
			this.Modifie.DefaultCellStyle = dataGridViewCellStyle6;
			this.Modifie.HeaderText = "Modifié le";
			this.Modifie.Name = "Modifie";
			this.Modifie.ReadOnly = true;
			this.Modifie.Width = 120;
			// 
			// Cree
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Format = "G";
			dataGridViewCellStyle7.NullValue = null;
			this.Cree.DefaultCellStyle = dataGridViewCellStyle7;
			this.Cree.HeaderText = "Créé le";
			this.Cree.Name = "Cree";
			this.Cree.ReadOnly = true;
			this.Cree.Width = 120;
			// 
			// DernierAccess
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Format = "G";
			dataGridViewCellStyle8.NullValue = null;
			this.DernierAccess.DefaultCellStyle = dataGridViewCellStyle8;
			this.DernierAccess.HeaderText = "Dernier accès";
			this.DernierAccess.Name = "DernierAccess";
			this.DernierAccess.ReadOnly = true;
			this.DernierAccess.Width = 120;
			// 
			// btnSearchStart
			// 
			this.btnSearchStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchStart.Location = new System.Drawing.Point(12, 556);
			this.btnSearchStart.Name = "btnSearchStart";
			this.btnSearchStart.Size = new System.Drawing.Size(76, 23);
			this.btnSearchStart.TabIndex = 5;
			this.btnSearchStart.Text = "Chercher";
			this.btnSearchStart.UseVisualStyleBackColor = true;
			this.btnSearchStart.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// btnSearchStop
			// 
			this.btnSearchStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchStop.Location = new System.Drawing.Point(196, 556);
			this.btnSearchStop.Name = "btnSearchStop";
			this.btnSearchStop.Size = new System.Drawing.Size(76, 23);
			this.btnSearchStop.TabIndex = 6;
			this.btnSearchStop.Text = "Arrêter";
			this.btnSearchStop.UseVisualStyleBackColor = true;
			this.btnSearchStop.Click += new System.EventHandler(this.BtnStopClick);
			// 
			// lbSearchFileExtension
			// 
			this.lbSearchFileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbSearchFileExtension.Location = new System.Drawing.Point(6, 45);
			this.lbSearchFileExtension.Name = "lbSearchFileExtension";
			this.lbSearchFileExtension.Size = new System.Drawing.Size(100, 20);
			this.lbSearchFileExtension.TabIndex = 7;
			this.lbSearchFileExtension.Text = "Extension :";
			// 
			// tbSearchFileExtension
			// 
			this.tbSearchFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearchFileExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchFileExtension.Location = new System.Drawing.Point(112, 45);
			this.tbSearchFileExtension.Name = "tbSearchFileExtension";
			this.tbSearchFileExtension.Size = new System.Drawing.Size(142, 20);
			this.tbSearchFileExtension.TabIndex = 8;
			// 
			// lbTimeElapsed
			// 
			this.lbTimeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTimeElapsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbTimeElapsed.Location = new System.Drawing.Point(1045, 590);
			this.lbTimeElapsed.Name = "lbTimeElapsed";
			this.lbTimeElapsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbTimeElapsed.Size = new System.Drawing.Size(79, 20);
			this.lbTimeElapsed.TabIndex = 3;
			this.lbTimeElapsed.Text = "0";
			this.lbTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbSearchFileTime
			// 
			this.lbSearchFileTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbSearchFileTime.Location = new System.Drawing.Point(968, 590);
			this.lbSearchFileTime.Name = "lbSearchFileTime";
			this.lbSearchFileTime.Size = new System.Drawing.Size(71, 20);
			this.lbSearchFileTime.TabIndex = 2;
			this.lbSearchFileTime.Text = "Temps (ms) :";
			this.lbSearchFileTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbFoundResult
			// 
			this.lbFoundResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbFoundResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbFoundResult.Location = new System.Drawing.Point(883, 590);
			this.lbFoundResult.Name = "lbFoundResult";
			this.lbFoundResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbFoundResult.Size = new System.Drawing.Size(79, 20);
			this.lbFoundResult.TabIndex = 1;
			this.lbFoundResult.Text = "0";
			this.lbFoundResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbSearchFileFound
			// 
			this.lbSearchFileFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbSearchFileFound.Location = new System.Drawing.Point(810, 590);
			this.lbSearchFileFound.Name = "lbSearchFileFound";
			this.lbSearchFileFound.Size = new System.Drawing.Size(67, 20);
			this.lbSearchFileFound.TabIndex = 0;
			this.lbSearchFileFound.Text = "Trouvé(s):";
			this.lbSearchFileFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lstSearchSizeType
			// 
			this.lstSearchSizeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lstSearchSizeType.FormattingEnabled = true;
			this.lstSearchSizeType.Items.AddRange(new object[] {
			"Taille (octet)",
			"Taille (ko)",
			"Taille (mo)",
			"Taille (go)"});
			this.lstSearchSizeType.Location = new System.Drawing.Point(112, 19);
			this.lstSearchSizeType.Name = "lstSearchSizeType";
			this.lstSearchSizeType.Size = new System.Drawing.Size(142, 21);
			this.lstSearchSizeType.TabIndex = 10;
			this.lstSearchSizeType.Text = "Taille (ko)";
			// 
			// btnSearchSizeUpperThan
			// 
			this.btnSearchSizeUpperThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchSizeUpperThan.Location = new System.Drawing.Point(6, 46);
			this.btnSearchSizeUpperThan.Name = "btnSearchSizeUpperThan";
			this.btnSearchSizeUpperThan.Size = new System.Drawing.Size(54, 20);
			this.btnSearchSizeUpperThan.TabIndex = 11;
			this.btnSearchSizeUpperThan.Text = "≥";
			this.btnSearchSizeUpperThan.UseVisualStyleBackColor = true;
			this.btnSearchSizeUpperThan.Click += new System.EventHandler(this.BtnSupOrEqualClick);
			// 
			// btnSearchSizeLowerThan
			// 
			this.btnSearchSizeLowerThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchSizeLowerThan.Location = new System.Drawing.Point(6, 72);
			this.btnSearchSizeLowerThan.Name = "btnSearchSizeLowerThan";
			this.btnSearchSizeLowerThan.Size = new System.Drawing.Size(54, 20);
			this.btnSearchSizeLowerThan.TabIndex = 12;
			this.btnSearchSizeLowerThan.Text = "≤";
			this.btnSearchSizeLowerThan.UseVisualStyleBackColor = true;
			this.btnSearchSizeLowerThan.Click += new System.EventHandler(this.BtnInfOrEqualClick);
			// 
			// tbSearchSizeUpperThan
			// 
			this.tbSearchSizeUpperThan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchSizeUpperThan.Enabled = false;
			this.tbSearchSizeUpperThan.Location = new System.Drawing.Point(112, 46);
			this.tbSearchSizeUpperThan.Name = "tbSearchSizeUpperThan";
			this.tbSearchSizeUpperThan.Size = new System.Drawing.Size(142, 20);
			this.tbSearchSizeUpperThan.TabIndex = 13;
			// 
			// tbSearchSizeLowerThan
			// 
			this.tbSearchSizeLowerThan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchSizeLowerThan.Enabled = false;
			this.tbSearchSizeLowerThan.Location = new System.Drawing.Point(112, 72);
			this.tbSearchSizeLowerThan.Name = "tbSearchSizeLowerThan";
			this.tbSearchSizeLowerThan.Size = new System.Drawing.Size(142, 20);
			this.tbSearchSizeLowerThan.TabIndex = 14;
			// 
			// btnSearchDateModifiedAfter
			// 
			this.btnSearchDateModifiedAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchDateModifiedAfter.Location = new System.Drawing.Point(6, 19);
			this.btnSearchDateModifiedAfter.Name = "btnSearchDateModifiedAfter";
			this.btnSearchDateModifiedAfter.Size = new System.Drawing.Size(54, 20);
			this.btnSearchDateModifiedAfter.TabIndex = 16;
			this.btnSearchDateModifiedAfter.Text = "≥";
			this.btnSearchDateModifiedAfter.UseVisualStyleBackColor = true;
			this.btnSearchDateModifiedAfter.Click += new System.EventHandler(this.BtnModifiedAfterClick);
			// 
			// btnSearchDateModifiedBefore
			// 
			this.btnSearchDateModifiedBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchDateModifiedBefore.Location = new System.Drawing.Point(6, 45);
			this.btnSearchDateModifiedBefore.Name = "btnSearchDateModifiedBefore";
			this.btnSearchDateModifiedBefore.Size = new System.Drawing.Size(54, 20);
			this.btnSearchDateModifiedBefore.TabIndex = 17;
			this.btnSearchDateModifiedBefore.Text = "≤";
			this.btnSearchDateModifiedBefore.UseVisualStyleBackColor = true;
			this.btnSearchDateModifiedBefore.Click += new System.EventHandler(this.BtnModifiedBeforeClick);
			// 
			// tbSearchDateModifiedAfter
			// 
			this.tbSearchDateModifiedAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchDateModifiedAfter.Enabled = false;
			this.tbSearchDateModifiedAfter.Location = new System.Drawing.Point(112, 19);
			this.tbSearchDateModifiedAfter.Name = "tbSearchDateModifiedAfter";
			this.tbSearchDateModifiedAfter.Size = new System.Drawing.Size(142, 20);
			this.tbSearchDateModifiedAfter.TabIndex = 18;
			// 
			// tbSearchDateModifiedBefore
			// 
			this.tbSearchDateModifiedBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchDateModifiedBefore.Enabled = false;
			this.tbSearchDateModifiedBefore.Location = new System.Drawing.Point(112, 45);
			this.tbSearchDateModifiedBefore.Name = "tbSearchDateModifiedBefore";
			this.tbSearchDateModifiedBefore.Size = new System.Drawing.Size(142, 20);
			this.tbSearchDateModifiedBefore.TabIndex = 19;
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuFile,
			this.menuTools});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1136, 24);
			this.menuStrip.TabIndex = 20;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuFileNewSearch,
			this.menuFileExportResult,
			this.menuFileExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(54, 20);
			this.menuFile.Text = "Fichier";
			// 
			// menuFileNewSearch
			// 
			this.menuFileNewSearch.Name = "menuFileNewSearch";
			this.menuFileNewSearch.Size = new System.Drawing.Size(176, 22);
			this.menuFileNewSearch.Text = "Nouvelle recherche";
			this.menuFileNewSearch.Click += new System.EventHandler(this.NouvelleRechercheToolStripMenuItemClick);
			// 
			// menuFileExportResult
			// 
			this.menuFileExportResult.Name = "menuFileExportResult";
			this.menuFileExportResult.Size = new System.Drawing.Size(176, 22);
			this.menuFileExportResult.Text = "Exporter le résultat";
			this.menuFileExportResult.Click += new System.EventHandler(this.ExportResultToolStripMenuItemClick);
			// 
			// menuFileExit
			// 
			this.menuFileExit.Name = "menuFileExit";
			this.menuFileExit.Size = new System.Drawing.Size(176, 22);
			this.menuFileExit.Text = "Quitter";
			this.menuFileExit.Click += new System.EventHandler(this.QuitterToolStripMenuItemClick);
			// 
			// menuTools
			// 
			this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolsLanguages});
			this.menuTools.Name = "menuTools";
			this.menuTools.Size = new System.Drawing.Size(50, 20);
			this.menuTools.Text = "Outils";
			// 
			// menuToolsLanguages
			// 
			this.menuToolsLanguages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolsLanguagesFrench,
			this.menuToolsLanguagesEnglish,
			this.menuToolsLanguagesRussian});
			this.menuToolsLanguages.Name = "menuToolsLanguages";
			this.menuToolsLanguages.Size = new System.Drawing.Size(152, 22);
			this.menuToolsLanguages.Text = "Langues";
			// 
			// menuToolsLanguagesFrench
			// 
			this.menuToolsLanguagesFrench.Image = ((System.Drawing.Image)(resources.GetObject("menuToolsLanguagesFrench.Image")));
			this.menuToolsLanguagesFrench.Name = "menuToolsLanguagesFrench";
			this.menuToolsLanguagesFrench.Size = new System.Drawing.Size(152, 22);
			this.menuToolsLanguagesFrench.Text = "&Français";
			this.menuToolsLanguagesFrench.Click += new System.EventHandler(this.FrenchToolStripMenuItem1Click);
			// 
			// menuToolsLanguagesEnglish
			// 
			this.menuToolsLanguagesEnglish.Image = ((System.Drawing.Image)(resources.GetObject("menuToolsLanguagesEnglish.Image")));
			this.menuToolsLanguagesEnglish.Name = "menuToolsLanguagesEnglish";
			this.menuToolsLanguagesEnglish.Size = new System.Drawing.Size(152, 22);
			this.menuToolsLanguagesEnglish.Text = "&English";
			this.menuToolsLanguagesEnglish.Click += new System.EventHandler(this.EnglishToolStripMenuItem1Click);
			// 
			// menuToolsLanguagesRussian
			// 
			this.menuToolsLanguagesRussian.Image = ((System.Drawing.Image)(resources.GetObject("menuToolsLanguagesRussian.Image")));
			this.menuToolsLanguagesRussian.Name = "menuToolsLanguagesRussian";
			this.menuToolsLanguagesRussian.Size = new System.Drawing.Size(152, 22);
			this.menuToolsLanguagesRussian.Text = "&Pусский";
			this.menuToolsLanguagesRussian.Click += new System.EventHandler(this.MenuToolsLanguagesRussianClick);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusResult});
			this.statusStrip.Location = new System.Drawing.Point(0, 588);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1136, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 21;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusResult
			// 
			this.toolStripStatusResult.Name = "toolStripStatusResult";
			this.toolStripStatusResult.Size = new System.Drawing.Size(28, 17);
			this.toolStripStatusResult.Text = "Prêt";
			// 
			// chkbxSearchFileSubfolder
			// 
			this.chkbxSearchFileSubfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkbxSearchFileSubfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkbxSearchFileSubfolder.Location = new System.Drawing.Point(157, 97);
			this.chkbxSearchFileSubfolder.Name = "chkbxSearchFileSubfolder";
			this.chkbxSearchFileSubfolder.Size = new System.Drawing.Size(97, 24);
			this.chkbxSearchFileSubfolder.TabIndex = 22;
			this.chkbxSearchFileSubfolder.Text = "Sous-dossier";
			this.chkbxSearchFileSubfolder.UseVisualStyleBackColor = true;
			// 
			// btnFolderSelect
			// 
			this.btnFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFolderSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFolderSelect.Location = new System.Drawing.Point(6, 98);
			this.btnFolderSelect.Name = "btnFolderSelect";
			this.btnFolderSelect.Size = new System.Drawing.Size(92, 23);
			this.btnFolderSelect.TabIndex = 23;
			this.btnFolderSelect.Text = "Sélectionner";
			this.btnFolderSelect.UseVisualStyleBackColor = true;
			this.btnFolderSelect.Click += new System.EventHandler(this.BtnFolderSelectClick);
			// 
			// tbSearchDateLastAccessBefore
			// 
			this.tbSearchDateLastAccessBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchDateLastAccessBefore.Enabled = false;
			this.tbSearchDateLastAccessBefore.Location = new System.Drawing.Point(111, 45);
			this.tbSearchDateLastAccessBefore.Name = "tbSearchDateLastAccessBefore";
			this.tbSearchDateLastAccessBefore.Size = new System.Drawing.Size(142, 20);
			this.tbSearchDateLastAccessBefore.TabIndex = 29;
			// 
			// btnSearchDateLastAccessAfter
			// 
			this.btnSearchDateLastAccessAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchDateLastAccessAfter.Location = new System.Drawing.Point(6, 19);
			this.btnSearchDateLastAccessAfter.Name = "btnSearchDateLastAccessAfter";
			this.btnSearchDateLastAccessAfter.Size = new System.Drawing.Size(54, 20);
			this.btnSearchDateLastAccessAfter.TabIndex = 26;
			this.btnSearchDateLastAccessAfter.Text = "≥";
			this.btnSearchDateLastAccessAfter.UseVisualStyleBackColor = true;
			this.btnSearchDateLastAccessAfter.Click += new System.EventHandler(this.BtnLastAccessAfterClick);
			// 
			// tbSearchDateLastAccessAfter
			// 
			this.tbSearchDateLastAccessAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchDateLastAccessAfter.Enabled = false;
			this.tbSearchDateLastAccessAfter.Location = new System.Drawing.Point(111, 19);
			this.tbSearchDateLastAccessAfter.Name = "tbSearchDateLastAccessAfter";
			this.tbSearchDateLastAccessAfter.Size = new System.Drawing.Size(142, 20);
			this.tbSearchDateLastAccessAfter.TabIndex = 28;
			// 
			// btnSearchDateLastAccessBefore
			// 
			this.btnSearchDateLastAccessBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchDateLastAccessBefore.Location = new System.Drawing.Point(6, 45);
			this.btnSearchDateLastAccessBefore.Name = "btnSearchDateLastAccessBefore";
			this.btnSearchDateLastAccessBefore.Size = new System.Drawing.Size(54, 20);
			this.btnSearchDateLastAccessBefore.TabIndex = 27;
			this.btnSearchDateLastAccessBefore.Text = "≤";
			this.btnSearchDateLastAccessBefore.UseVisualStyleBackColor = true;
			this.btnSearchDateLastAccessBefore.Click += new System.EventHandler(this.BtnLastAccessBeforeClick);
			// 
			// tbSearchDateCreatedBefore
			// 
			this.tbSearchDateCreatedBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchDateCreatedBefore.Enabled = false;
			this.tbSearchDateCreatedBefore.Location = new System.Drawing.Point(111, 45);
			this.tbSearchDateCreatedBefore.Name = "tbSearchDateCreatedBefore";
			this.tbSearchDateCreatedBefore.Size = new System.Drawing.Size(142, 20);
			this.tbSearchDateCreatedBefore.TabIndex = 24;
			// 
			// btnSearchDateCreatedAfter
			// 
			this.btnSearchDateCreatedAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchDateCreatedAfter.Location = new System.Drawing.Point(6, 19);
			this.btnSearchDateCreatedAfter.Name = "btnSearchDateCreatedAfter";
			this.btnSearchDateCreatedAfter.Size = new System.Drawing.Size(54, 20);
			this.btnSearchDateCreatedAfter.TabIndex = 21;
			this.btnSearchDateCreatedAfter.Text = "≥";
			this.btnSearchDateCreatedAfter.UseVisualStyleBackColor = true;
			this.btnSearchDateCreatedAfter.Click += new System.EventHandler(this.BtnCreatedAfterClick);
			// 
			// tbSearchDateCreatedAfter
			// 
			this.tbSearchDateCreatedAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearchDateCreatedAfter.Enabled = false;
			this.tbSearchDateCreatedAfter.Location = new System.Drawing.Point(111, 19);
			this.tbSearchDateCreatedAfter.Name = "tbSearchDateCreatedAfter";
			this.tbSearchDateCreatedAfter.Size = new System.Drawing.Size(142, 20);
			this.tbSearchDateCreatedAfter.TabIndex = 23;
			// 
			// btnSearchDateCreatedBefore
			// 
			this.btnSearchDateCreatedBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchDateCreatedBefore.Location = new System.Drawing.Point(6, 45);
			this.btnSearchDateCreatedBefore.Name = "btnSearchDateCreatedBefore";
			this.btnSearchDateCreatedBefore.Size = new System.Drawing.Size(54, 20);
			this.btnSearchDateCreatedBefore.TabIndex = 22;
			this.btnSearchDateCreatedBefore.Text = "≤";
			this.btnSearchDateCreatedBefore.UseVisualStyleBackColor = true;
			this.btnSearchDateCreatedBefore.Click += new System.EventHandler(this.BtnCreatedBeforeClick);
			// 
			// bgWorker
			// 
			this.bgWorker.WorkerSupportsCancellation = true;
			this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
			this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.CheckFileExists = true;
			// 
			// grpbxSearchFile
			// 
			this.grpbxSearchFile.Controls.Add(this.btnFolderSelect);
			this.grpbxSearchFile.Controls.Add(this.lbSearchFilePath);
			this.grpbxSearchFile.Controls.Add(this.chkbxSearchFileSubfolder);
			this.grpbxSearchFile.Controls.Add(this.lbSearchFileName);
			this.grpbxSearchFile.Controls.Add(this.lbSearchFileExtension);
			this.grpbxSearchFile.Controls.Add(this.tbSearchFilePath);
			this.grpbxSearchFile.Controls.Add(this.tbSearchFileName);
			this.grpbxSearchFile.Controls.Add(this.tbSearchFileExtension);
			this.grpbxSearchFile.Location = new System.Drawing.Point(12, 27);
			this.grpbxSearchFile.Name = "grpbxSearchFile";
			this.grpbxSearchFile.Size = new System.Drawing.Size(260, 130);
			this.grpbxSearchFile.TabIndex = 28;
			this.grpbxSearchFile.TabStop = false;
			this.grpbxSearchFile.Text = "Fichier";
			// 
			// grpbxSearchSize
			// 
			this.grpbxSearchSize.Controls.Add(this.lstSearchSizeType);
			this.grpbxSearchSize.Controls.Add(this.btnSearchSizeLowerThan);
			this.grpbxSearchSize.Controls.Add(this.tbSearchSizeLowerThan);
			this.grpbxSearchSize.Controls.Add(this.btnSearchSizeUpperThan);
			this.grpbxSearchSize.Controls.Add(this.tbSearchSizeUpperThan);
			this.grpbxSearchSize.Location = new System.Drawing.Point(12, 164);
			this.grpbxSearchSize.Name = "grpbxSearchSize";
			this.grpbxSearchSize.Size = new System.Drawing.Size(260, 100);
			this.grpbxSearchSize.TabIndex = 29;
			this.grpbxSearchSize.TabStop = false;
			this.grpbxSearchSize.Text = "Taille";
			// 
			// grpbxSearchDateModified
			// 
			this.grpbxSearchDateModified.Controls.Add(this.tbSearchDateModifiedAfter);
			this.grpbxSearchDateModified.Controls.Add(this.btnSearchDateModifiedBefore);
			this.grpbxSearchDateModified.Controls.Add(this.btnSearchDateModifiedAfter);
			this.grpbxSearchDateModified.Controls.Add(this.tbSearchDateModifiedBefore);
			this.grpbxSearchDateModified.Location = new System.Drawing.Point(12, 271);
			this.grpbxSearchDateModified.Name = "grpbxSearchDateModified";
			this.grpbxSearchDateModified.Size = new System.Drawing.Size(260, 74);
			this.grpbxSearchDateModified.TabIndex = 30;
			this.grpbxSearchDateModified.TabStop = false;
			this.grpbxSearchDateModified.Text = "Modifié le";
			// 
			// grpbxSearchDateCreated
			// 
			this.grpbxSearchDateCreated.Controls.Add(this.tbSearchDateCreatedAfter);
			this.grpbxSearchDateCreated.Controls.Add(this.tbSearchDateCreatedBefore);
			this.grpbxSearchDateCreated.Controls.Add(this.btnSearchDateCreatedAfter);
			this.grpbxSearchDateCreated.Controls.Add(this.btnSearchDateCreatedBefore);
			this.grpbxSearchDateCreated.Location = new System.Drawing.Point(13, 351);
			this.grpbxSearchDateCreated.Name = "grpbxSearchDateCreated";
			this.grpbxSearchDateCreated.Size = new System.Drawing.Size(259, 73);
			this.grpbxSearchDateCreated.TabIndex = 31;
			this.grpbxSearchDateCreated.TabStop = false;
			this.grpbxSearchDateCreated.Text = "Créé le";
			// 
			// grpbxSearchDateLastAccess
			// 
			this.grpbxSearchDateLastAccess.Controls.Add(this.tbSearchDateLastAccessAfter);
			this.grpbxSearchDateLastAccess.Controls.Add(this.tbSearchDateLastAccessBefore);
			this.grpbxSearchDateLastAccess.Controls.Add(this.btnSearchDateLastAccessBefore);
			this.grpbxSearchDateLastAccess.Controls.Add(this.btnSearchDateLastAccessAfter);
			this.grpbxSearchDateLastAccess.Location = new System.Drawing.Point(13, 431);
			this.grpbxSearchDateLastAccess.Name = "grpbxSearchDateLastAccess";
			this.grpbxSearchDateLastAccess.Size = new System.Drawing.Size(259, 84);
			this.grpbxSearchDateLastAccess.TabIndex = 32;
			this.grpbxSearchDateLastAccess.TabStop = false;
			this.grpbxSearchDateLastAccess.Text = "Dernier accès le";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 610);
			this.Controls.Add(this.lbTimeElapsed);
			this.Controls.Add(this.grpbxSearchDateLastAccess);
			this.Controls.Add(this.lbSearchFileTime);
			this.Controls.Add(this.grpbxSearchDateCreated);
			this.Controls.Add(this.lbFoundResult);
			this.Controls.Add(this.grpbxSearchDateModified);
			this.Controls.Add(this.lbSearchFileFound);
			this.Controls.Add(this.grpbxSearchSize);
			this.Controls.Add(this.grpbxSearchFile);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.btnSearchStop);
			this.Controls.Add(this.btnSearchStart);
			this.Controls.Add(this.dgvResultat);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(719, 300);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Files Engine";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.grpbxSearchFile.ResumeLayout(false);
			this.grpbxSearchFile.PerformLayout();
			this.grpbxSearchSize.ResumeLayout(false);
			this.grpbxSearchSize.PerformLayout();
			this.grpbxSearchDateModified.ResumeLayout(false);
			this.grpbxSearchDateModified.PerformLayout();
			this.grpbxSearchDateCreated.ResumeLayout(false);
			this.grpbxSearchDateCreated.PerformLayout();
			this.grpbxSearchDateLastAccess.ResumeLayout(false);
			this.grpbxSearchDateLastAccess.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

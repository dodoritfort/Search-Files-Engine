/*
 * Crée avec SharpDevelop.
 * Utilisateur: dodoritfort
 * Date: 17/05/2015
 * Heure: 17:11
 * 
 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using System;
//using System.Security.AccessControl;
//using System.Threading;
//using System.Windows;
//using System.Reflection;
//using System.Drawing;

namespace SearchFilesEngine
{
	
	public partial class MainForm : Form
	{
        ResourceManager resManager;
        CultureInfo cultInfo;
        
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
            resManager = new ResourceManager("SearchFilesEngine.Resources.Languages.Res", typeof(MainForm).Assembly);
            switch_language("fr");
		}
		
		Stopwatch stopW = new Stopwatch();

/*######################################################################################################################################################
 * 
 * LANGUAGES
 * 
 ######################################################################################################################################################*/

        void switch_language(string culture)
        {
			cultInfo = CultureInfo.CreateSpecificCulture(culture);
            
			grpbxSearchFile.Text = resManager.GetString("grpbxSearchFile", cultInfo);
			lbSearchFileName.Text = resManager.GetString("lbSearchFileName", cultInfo);
			lbSearchFileExtension.Text = resManager.GetString("lbSearchFileExtension", cultInfo);
			lbSearchFilePath.Text = resManager.GetString("lbSearchFilePath", cultInfo);
			
			grpbxSearchSize.Text = resManager.GetString("grpbxSearchSize", cultInfo);
			grpbxSearchDateModified.Text = resManager.GetString("grpbxSearchDateModified", cultInfo);
			grpbxSearchDateCreated.Text = resManager.GetString("grpbxSearchDateCreated", cultInfo);
			grpbxSearchDateLastAccess.Text = resManager.GetString("grpbxSearchDateLastAccess", cultInfo);
			
			btnSearchStart.Text = resManager.GetString("btnSearchStart", cultInfo);
			btnSearchStop.Text = resManager.GetString("btnSearchStop", cultInfo);
			
			btnFolderSelect.Text = resManager.GetString("btnFolderSelect", cultInfo);
			chkbxSearchFileSubfolder.Text = resManager.GetString("chkbxSearchFileSubfolder", cultInfo);
			
			lbSearchFileFound.Text = resManager.GetString("lbSearchFileFound", cultInfo);
			lbSearchFileTime.Text = resManager.GetString("lbSearchFileTime", cultInfo);
			
			menuFile.Text = resManager.GetString("menuFile", cultInfo);
			menuFileNewSearch.Text = resManager.GetString("menuFileNewSearch", cultInfo);
			menuFileExportResult.Text = resManager.GetString("menuFileExportResult", cultInfo);
			menuFileExit.Text = resManager.GetString("menuFileExit", cultInfo);
			menuTools.Text = resManager.GetString("menuTools", cultInfo);
			menuToolsLanguages.Text = resManager.GetString("menuToolsLanguages", cultInfo);
			
			dgvResultat.Columns[0].HeaderText = resManager.GetString("dgvResultat.Columns[0]", cultInfo);
			dgvResultat.Columns[1].HeaderText = resManager.GetString("dgvResultat.Columns[1]", cultInfo);
			dgvResultat.Columns[2].HeaderText = resManager.GetString("dgvResultat.Columns[2]", cultInfo);
			dgvResultat.Columns[3].HeaderText = resManager.GetString("dgvResultat.Columns[3]", cultInfo);
			dgvResultat.Columns[4].HeaderText = resManager.GetString("dgvResultat.Columns[4]", cultInfo);
			dgvResultat.Columns[5].HeaderText = resManager.GetString("dgvResultat.Columns[5]", cultInfo);
			dgvResultat.Columns[6].HeaderText = resManager.GetString("dgvResultat.Columns[6]", cultInfo);
			dgvResultat.Columns[7].HeaderText = resManager.GetString("dgvResultat.Columns[7]", cultInfo);
        }

		void FrenchToolStripMenuItem1Click(object sender, EventArgs e)
		{
            switch_language("fr");
		}

		void EnglishToolStripMenuItem1Click(object sender, EventArgs e)
		{
            switch_language("en");
		}
		
		void MenuToolsLanguagesRussianClick(object sender, EventArgs e)
		{
            switch_language("ru");
		}

/*######################################################################################################################################################
 * 
 * CLASSE
 * 
 ######################################################################################################################################################*/
		
		public class File
		{			
			public string FileName { get; set; }
			public DirectoryInfo FileDirectory { get; set; }
			public decimal FileSize { get; set; }
			public string FileExtension { get; set; }
			public DateTime FileModified { get; set; }
			public DateTime FileCreated { get; set; }
			public DateTime FileLastAccess { get; set; }
		}

/*######################################################################################################################################################
 * 
 * METHODE
 * 
 ######################################################################################################################################################*/
		
		private static List<File> GetSearchFile(string fileDirectory, string fileName, string fileExtension, string subDirectorySearch)
		{
			List<File> listFile = new List<File>();
		    SearchFile(listFile, fileDirectory, fileName, fileExtension, subDirectorySearch);
		    return listFile;
		}
				
		private static void SearchFile(List<File> listFile, string fileDirectory, string fileName, string fileExtension, string subDirectorySearch)
		{
			try 
			{
				DirectoryInfo topDir = new DirectoryInfo(fileDirectory);
				foreach (var fi in topDir.GetFiles(fileName + fileExtension, SearchOption.TopDirectoryOnly))
				{
					listFile.Add(new File() {FileName=fi.Name, FileDirectory=fi.Directory, FileSize=fi.Length, FileExtension=fi.Extension, FileModified=fi.LastWriteTime, FileCreated=fi.CreationTime,FileLastAccess=fi.LastAccessTime});
				}
				if (subDirectorySearch == "true")
				{
					foreach (var directory in Directory.GetDirectories(fileDirectory))
					{
						SearchFile(listFile, directory, fileName, fileExtension, subDirectorySearch);
					}
				}
			} 
			catch (UnauthorizedAccessException) { }
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

/*######################################################################################################################################################
 * 
 * BACKGROUND WORKER
 * 
 ######################################################################################################################################################*/
		
		private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker bgWorker = sender as BackgroundWorker;
			List<object> bgWorkerArgs = e.Argument as List<object>;
				string fileDirectory = bgWorkerArgs[0].ToString();
				string fileName = bgWorkerArgs[1].ToString();
				string fileExtension = bgWorkerArgs[2].ToString();
				string subDirectorySearch = bgWorkerArgs[3].ToString();
			e.Result = bgTreatment(bgWorker, e, fileDirectory, fileName, fileExtension, subDirectorySearch);
			if (bgWorker.CancellationPending)
			{
				e.Cancel = true;
			}
		}
		
		public List<File> bgTreatment(BackgroundWorker worker, DoWorkEventArgs e, string fileDirectory, string fileName, string fileExtension, string subDirectorySearch)
		{
			if (worker.CancellationPending)
			{
				e.Cancel = true;
				return null;
			}
			else
			{
				List<File> listFile = new List<File>(GetSearchFile(fileDirectory, fileName, fileExtension, subDirectorySearch));
				return listFile;
			}
		}
		
		private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show(e.Error.Message);
			}
			else if (e.Cancelled)
			{
				MessageBox.Show("Opération annulée !");
				toolStripStatusResult.Text = "Prêt";
				statusStrip.Refresh();
			}
			else
			{
				int i = 1;
				List<File> listFile = (List<File>)e.Result;
				foreach (File fi in listFile)
				{
					switch (lstSearchSizeType.Text)
					{
						case "Taille (octet)":
							if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == false) {
								if (fi.FileSize < Convert.ToDecimal(tbSearchSizeUpperThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == false && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize < Convert.ToDecimal(tbSearchSizeUpperThan.Text) || fi.FileSize > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							}
							break;
						case "Taille (ko)":
							if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == false) {
								if (fi.FileSize / 1024 < Convert.ToDecimal(tbSearchSizeUpperThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == false && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize / 1024 > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize / 1024 < Convert.ToDecimal(tbSearchSizeUpperThan.Text) || fi.FileSize / 1024 > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							}
							break;
						case "Taille (mo)":
							if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == false) {
								if (fi.FileSize / 1048576 < Convert.ToDecimal(tbSearchSizeUpperThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == false && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize / 1048576 > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize / 1048576 < Convert.ToDecimal(tbSearchSizeUpperThan.Text) || fi.FileSize / 1048576 > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							}
							break;
						case "Taille (go)":
							if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == false) {
								if (fi.FileSize / 1073741824 < Convert.ToDecimal(tbSearchSizeUpperThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == false && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize / 1073741824 > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							} else if (tbSearchSizeUpperThan.Enabled == true && tbSearchSizeLowerThan.Enabled == true) {
								if (fi.FileSize / 1073741824 < Convert.ToDecimal(tbSearchSizeUpperThan.Text) || fi.FileSize / 1073741824 > Convert.ToDecimal(tbSearchSizeLowerThan.Text)) { continue; }
							}
							break;
						default:
							goto case "Taille (ko)";
					}
					
					if (tbSearchDateModifiedAfter.Enabled == true && tbSearchDateModifiedBefore.Enabled == false) {
						DateTime dtModifiedAfter = DateTime.ParseExact(tbSearchDateModifiedAfter.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileModified.Date < dtModifiedAfter.Date) { continue; }
					} else if (tbSearchDateModifiedAfter.Enabled == false && tbSearchDateModifiedBefore.Enabled == true) {
						DateTime dtModifiedBefore = DateTime.ParseExact(tbSearchDateModifiedBefore.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileModified.Date > dtModifiedBefore.Date) { continue; }
					}  else if (tbSearchDateModifiedAfter.Enabled == true && tbSearchDateModifiedBefore.Enabled == true) {
						DateTime dtModifiedAfter = DateTime.ParseExact(tbSearchDateModifiedAfter.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						DateTime dtModifiedBefore = DateTime.ParseExact(tbSearchDateModifiedBefore.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileModified.Date < dtModifiedAfter.Date || fi.FileModified.Date > dtModifiedBefore.Date) { continue; }
					}
					
					if (tbSearchDateCreatedAfter.Enabled == true && tbSearchDateCreatedBefore.Enabled == false) {
						DateTime dtCreatedAfter = DateTime.ParseExact(tbSearchDateCreatedAfter.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileCreated.Date < dtCreatedAfter.Date) { continue; }
					} else if (tbSearchDateCreatedAfter.Enabled == false && tbSearchDateCreatedBefore.Enabled == true) {
						DateTime dtCreatedBefore = DateTime.ParseExact(tbSearchDateCreatedBefore.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileCreated.Date > dtCreatedBefore.Date) { continue; }
					}  else if (tbSearchDateCreatedAfter.Enabled == true && tbSearchDateCreatedBefore.Enabled == true) {
						DateTime dtCreatedAfter = DateTime.ParseExact(tbSearchDateCreatedAfter.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						DateTime dtCreatedBefore = DateTime.ParseExact(tbSearchDateCreatedBefore.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileCreated.Date < dtCreatedAfter.Date || fi.FileCreated.Date > dtCreatedBefore.Date) { continue; }
					}
					
					if (tbSearchDateLastAccessAfter.Enabled == true && tbSearchDateLastAccessBefore.Enabled == false) {
						DateTime dtLastAccessAfter = DateTime.ParseExact(tbSearchDateLastAccessAfter.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileLastAccess.Date < dtLastAccessAfter.Date) { continue; }
					} else if (tbSearchDateLastAccessAfter.Enabled == false && tbSearchDateLastAccessBefore.Enabled == true) {
						DateTime dtLastAccessBefore = DateTime.ParseExact(tbSearchDateLastAccessBefore.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileLastAccess.Date > dtLastAccessBefore.Date) { continue; }
					}  else if (tbSearchDateLastAccessAfter.Enabled == true && tbSearchDateLastAccessBefore.Enabled == true) {
						DateTime dtLastAccessAfter = DateTime.ParseExact(tbSearchDateLastAccessAfter.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						DateTime dtLastAccessBefore = DateTime.ParseExact(tbSearchDateLastAccessBefore.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						if (fi.FileLastAccess.Date < dtLastAccessAfter.Date || fi.FileLastAccess.Date > dtLastAccessBefore.Date) { continue; }
					}
					
					dgvResultat.Rows.Add(fi.FileName, fi.FileDirectory, fi.FileSize/1024, "ko", fi.FileExtension, fi.FileModified, fi.FileCreated, fi.FileLastAccess);
					this.Text = i.ToString() + " fichiers trouvés" + " - Search Files Engine";
					toolStripStatusResult.Text = i.ToString() + " fichiers trouvés";
					statusStrip.Refresh();
					lbFoundResult.Text = i.ToString();
					lbTimeElapsed.Text = stopW.ElapsedMilliseconds.ToString();
					lbFoundResult.Refresh();
					i++;
				}
			}
			
			dgvResultat.Update();
			dgvResultat.Refresh();
			btnSearchStart.Enabled = true;
			btnSearchStart.Text = "Chercher";
		}
		
/*######################################################################################################################################################
 * 
 * BOUTON
 * 
 ######################################################################################################################################################*/
		
		void BtnSearchClick(object sender, EventArgs e)
		{
			stopW.Start();
			
			dgvResultat.Rows.Clear();
			lbFoundResult.Text = "0";
			lbTimeElapsed.Text = "0";
			
			string fileName;
			string fileExtension;
			string fileDirectory = tbSearchFilePath.Text;
			string subDirectorySearch;
			decimal fileSizeMin;
			decimal fileSizeMax;
			
			if (!string.IsNullOrEmpty(tbSearchFileName.Text)) {
				fileName = "*" + tbSearchFileName.Text + "*";
			} else {
				fileName = "*";
			}
			
			if (!string.IsNullOrEmpty(tbSearchFileExtension.Text)) {
				fileExtension = "." + tbSearchFileExtension.Text;
			} else {
				fileExtension = ".*";
			}
			
			if (!string.IsNullOrEmpty(tbSearchFilePath.Text)) {
				fileDirectory = tbSearchFilePath.Text;
			} else {
				fileDirectory = @"C:\";
			}
			
			if (chkbxSearchFileSubfolder.Checked == true) {
				subDirectorySearch = "true";
			} else {
				subDirectorySearch = "false";
			}
			
			if (!string.IsNullOrEmpty(tbSearchSizeUpperThan.Text)) {
				fileSizeMin = Convert.ToDecimal(tbSearchSizeUpperThan.Text);
			} else {
				fileSizeMin = 0;
			}
			
			if (!string.IsNullOrEmpty(tbSearchSizeLowerThan.Text)) {
				fileSizeMax = Convert.ToDecimal(tbSearchSizeLowerThan.Text);
			} else {
				fileSizeMax = 0;
			}
			
			try
			{
				if (btnSearchStart.Text.Equals("Chercher"))
				{
					List<object> bgWorkerArgs = new List<object>();
					bgWorkerArgs.Add(fileDirectory);
						bgWorkerArgs.Add(fileName);
						bgWorkerArgs.Add(fileExtension);
						bgWorkerArgs.Add(subDirectorySearch);
					bgWorker.RunWorkerAsync(bgWorkerArgs);
					btnSearchStart.Enabled = false;
					btnSearchStart.Text = "En cours...";
					lbFoundResult.Text = "0";
					toolStripStatusResult.Text = "Recherche en cours...";
					statusStrip.Refresh();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
			
			stopW.Stop();
		}
		
		void BtnStopClick(object sender, EventArgs e)
		{
			stopW.Stop();
			lbFoundResult.Text = "0";
			lbTimeElapsed.Text = "0";
			
			if (btnSearchStart.Text.Equals("En cours..."))
			{
				bgWorker.CancelAsync();
				btnSearchStart.Enabled = true;
				btnSearchStart.Text = "Chercher";
				lbFoundResult.Text = "0";
				toolStripStatusResult.Text = "Opération annulée !";
				statusStrip.Refresh();
			}
		}
		
		void BtnSupOrEqualClick(object sender, EventArgs e)
		{
			if (tbSearchSizeUpperThan.Enabled == false) {
				tbSearchSizeUpperThan.Enabled = true;
			} else {
				tbSearchSizeUpperThan.Enabled = false;
			}
		}
		
		void BtnInfOrEqualClick(object sender, EventArgs e)
		{
			if (tbSearchSizeLowerThan.Enabled == false) {
				tbSearchSizeLowerThan.Enabled = true;
			} else {
				tbSearchSizeLowerThan.Enabled = false;
			}
		}
		
		void BtnFolderSelectClick(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				tbSearchFilePath.Text = folderBrowserDialog.SelectedPath;
			}
		}
		
		void BtnModifiedAfterClick(object sender, EventArgs e)
		{
			if (tbSearchDateModifiedAfter.Enabled == false) {
				tbSearchDateModifiedAfter.Enabled = true;
			} else {
				tbSearchDateModifiedAfter.Enabled = false;
			}
		}
		
		void BtnModifiedBeforeClick(object sender, EventArgs e)
		{
			if (tbSearchDateModifiedBefore.Enabled == false) {
				tbSearchDateModifiedBefore.Enabled = true;
			} else {
				tbSearchDateModifiedBefore.Enabled = false;
			}
		}
		
		void BtnCreatedAfterClick(object sender, EventArgs e)
		{
			if (tbSearchDateCreatedAfter.Enabled == false) {
				tbSearchDateCreatedAfter.Enabled = true;
			} else {
				tbSearchDateCreatedAfter.Enabled = false;
			}
		}
		
		void BtnCreatedBeforeClick(object sender, EventArgs e)
		{
			if (tbSearchDateCreatedBefore.Enabled == false) {
				tbSearchDateCreatedBefore.Enabled = true;
			} else {
				tbSearchDateCreatedBefore.Enabled = false;
			}
		}
		
		void BtnLastAccessAfterClick(object sender, EventArgs e)
		{
			if (tbSearchDateLastAccessAfter.Enabled == false) {
				tbSearchDateLastAccessAfter.Enabled = true;
			} else {
				tbSearchDateLastAccessAfter.Enabled = false;
			}
		}
		
		void BtnLastAccessBeforeClick(object sender, EventArgs e)
		{
			if (tbSearchDateLastAccessBefore.Enabled == false) {
				tbSearchDateLastAccessBefore.Enabled = true;
			} else {
				tbSearchDateLastAccessBefore.Enabled = false;
			}
		}
		
		void BtnDatesClearAllClick(object sender, EventArgs e)
		{
			tbSearchDateCreatedAfter.Text = null;
			tbSearchDateCreatedAfter.Enabled = false;
			tbSearchDateCreatedBefore.Text = null;
			tbSearchDateCreatedBefore.Enabled = false;
			tbSearchDateModifiedAfter.Text = null;
			tbSearchDateModifiedAfter.Enabled = false;
			tbSearchDateModifiedBefore.Text = null;
			tbSearchDateModifiedBefore.Enabled = false;
			tbSearchDateLastAccessAfter.Text = null;
			tbSearchDateLastAccessAfter.Enabled = false;
			tbSearchDateLastAccessBefore.Text = null;
			tbSearchDateLastAccessBefore.Enabled = false;
		}

/*######################################################################################################################################################
 * 
 * DATAGRID VIEW
 * 
 ######################################################################################################################################################*/

		void DgvResultatCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int colIndex = dgvResultat.CurrentCell.ColumnIndex;
			string directoryName = dgvResultat.CurrentRow.Cells[1].FormattedValue.ToString();
			string fileName = dgvResultat.CurrentCell.FormattedValue.ToString();

			try
			{
				switch (colIndex)
				{
					case 0:
						Process.Start(Path.Combine(directoryName, fileName));
						break;
					case 1:
						Process.Start(directoryName);
						break;
					case 4:
						Process.Start("http://fr.wikipedia.org/wiki/Liste_d%27extensions_de_fichiers");
						break;
					default:
						break;
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

/*######################################################################################################################################################
 * 
 * TOOL STRIP MENU
 * 
 ######################################################################################################################################################*/
		
		void NouvelleRechercheToolStripMenuItemClick(object sender, EventArgs e)
		{
			tbSearchFileName.Text = null;
			tbSearchFileExtension.Text = null;
			tbSearchFilePath.Text = null;
			tbSearchSizeUpperThan.Text = null;
			tbSearchSizeLowerThan.Text = null;
			tbSearchDateCreatedAfter.Text = null;
			tbSearchDateCreatedBefore.Text = null;
			tbSearchDateModifiedAfter.Text = null;
			tbSearchDateModifiedBefore.Text = null;
			tbSearchDateLastAccessAfter.Text = null;
			tbSearchDateLastAccessBefore.Text = null;
			lbFoundResult.Text = "0";
			lbTimeElapsed.Text = "0";
			tbSearchDateCreatedAfter.Enabled = false;
			tbSearchDateCreatedBefore.Enabled = false;
			tbSearchDateModifiedAfter.Enabled = false;
			tbSearchDateModifiedBefore.Enabled = false;
			tbSearchDateLastAccessAfter.Enabled = false;
			tbSearchDateLastAccessBefore.Enabled = false;
			chkbxSearchFileSubfolder.Checked = false;
			dgvResultat.Rows.Clear();
			this.Text = "Search Files Engine";
			toolStripStatusResult.Text = "Prêt";
			statusStrip.Refresh();
		}
		
		void ExportResultToolStripMenuItemClick(object sender, EventArgs e)
		{
			string saveFile;
			try
			{
			    SaveFileDialog saveFileDialog = new SaveFileDialog();
			    saveFileDialog.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv"  ;
			    saveFileDialog.FilterIndex = 2 ;
			    saveFileDialog.RestoreDirectory = true ;
			
			    if(saveFileDialog.ShowDialog() == DialogResult.OK)
			    {
			    	saveFile = saveFileDialog.FileName;
					TextWriter sw = new StreamWriter(saveFile);
					
					switch (saveFileDialog.FilterIndex)
					{
						case 1:
							for (int j = 0; j < dgvResultat.Columns.Count; j++) {
								sw.Write(" " + dgvResultat.Columns[j].HeaderText + " " + "|");
							}
							sw.Write("\r\n");
							for (int i = 0; i < dgvResultat.Rows.Count - 1; i++)
							{
								for (int j = 0; j < dgvResultat.Columns.Count; j++)
								{
									sw.Write(" " + dgvResultat.Rows[i].Cells[j].Value + " " + "|");
								}
								sw.Write("\r\n");
							}
							break;
						case 2:
							for (int j = 0; j < dgvResultat.Columns.Count; j++) {
								sw.Write(dgvResultat.Columns[j].HeaderText + ";");
							}
							sw.Write("\r\n");
							for (int i = 0; i < dgvResultat.Rows.Count - 1; i++)
							{
								for (int j = 0; j < dgvResultat.Columns.Count; j++)
								{
									sw.Write(dgvResultat.Rows[i].Cells[j].Value.ToString() + ";");
								}
								sw.Write("\r\n");
							}
							break;
					}
					
					sw.Close();
					Process.Start(Path.Combine(saveFile));
			    }
			} catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		
		void QuitterToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
/*######################################################################################################################################################
 * 
 * TEXTBOX
 * 
 ######################################################################################################################################################*/
		
		void tbSearchFileSizeUpperThanKeyPress(object sender, KeyPressEventArgs e)
		{
			// Autorise la saisie de chiffre uniquement
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !=',') {
				e.Handled=true;
			}
			
			// Autorise à entrer une virgule ',' et une seule  pour les décimales
			if(e.KeyChar == ',' && tbSearchSizeUpperThan.Text.IndexOf(',')>-1) {
				e.Handled=true;
			}
		}
		
		void tbSearchFileSizeLowerThanKeyPress(object sender, KeyPressEventArgs e)
		{
			// Autorise la saisie de chiffre uniquement
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !=',') {
				e.Handled = true;
			}
			
			// Autorise à entrer une virgule ',' et une seule  pour les décimales
			if(e.KeyChar == ',' && tbSearchSizeLowerThan.Text.IndexOf(',') > -1) {
				e.Handled = true;
			}
		}
		
		void tbSearchFileExtensionKeyPress(object sender, KeyPressEventArgs e)
		{
			// N'autoriser que la saisie de lettre
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) {
				e.Handled = true;
			}
		}

	}
	
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace DynamicFileName
{    

    public partial class Form1 : Form
    {
        public int oldIndex = -1;
        public System.Data.DataTable AllFiles = new System.Data.DataTable("FilePaths");    

        public Form1()
        {
            InitializeComponent();
            DataColumn col1 = AllFiles.Columns.Add("Parent Directory", typeof(string));
            DataColumn col2 = AllFiles.Columns.Add("Current Name", typeof(string));
            DataColumn col3 = AllFiles.Columns.Add("Preview", typeof(string));
            DataColumn col4 = AllFiles.Columns.Add("File Type", typeof(string));
            DataColumn col5 = AllFiles.Columns.Add("Result", typeof(string));
            DataColumn col6 = AllFiles.Columns.Add("Full Directory", typeof(string));
            DataColumn col7 = AllFiles.Columns.Add("MemoryForUndo", typeof(string));            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiles(false);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();

            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    lstOld.Items.Add(Path.GetFileName(openFile.FileName.ToString()));
            //}
        }

        private void OpenFiles(bool isAdd)
        {
            //if (!isAdd)
            //{
            //    ClearListBoxes();
            //}

            //FolderBrowserDialog openFolder = new FolderBrowserDialog();
            //DirectoryInfo dinfo;

            //if (openFolder.ShowDialog() == DialogResult.OK)
            //{
            //    dinfo = new DirectoryInfo(openFolder.SelectedPath.ToString());
            //    FileInfo fi = new FileInfo(dinfo);

            //    bool fileExists = false;
            //    foreach (DataRow row in AllFiles.Rows)
            //    {
            //        if (Files.DirectoryName.ToString() == row[0].ToString() && Files.Name.ToString() == row[1].ToString())
            //            fileExists = true;
            //    }

            //    if (!fileExists)
            //        AllFiles.Rows.Add(Files.DirectoryName.ToString(), Path.GetFileNameWithoutExtension(Files.Name).ToString(), "", Files.Extension.ToString());
            //}            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //OpenFiles(true);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgFiles.Rows.Count < 1)
                return;

            DialogResult result = new DialogResult();
            if (dgFiles.SelectedRows.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to remove selected files, changes may be lost?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("No rows selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgFiles.SelectedRows)
                {
                    dgFiles.Rows.RemoveAt(row.Index);
                }
            }
            else
                return;

            lblCount.Text = dgFiles.Rows.Count.ToString() + " Files";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dgFiles.SelectAll();
        }

        private void Replace(bool isNewBatch)
        {
            string newName;
            string oldString = txtOldString.Text;
            string newString = txtNewString.Text;
            string oldFileName;

            try
            {
                if (oldString != "")
                {
                    foreach (DataGridViewRow r in dgFiles.SelectedRows)
                    {
                        if (!isNewBatch && r.Cells[4].Value.ToString() == "success")
                            continue;

                        if (r.Cells[2].Value.ToString() != "")
                            oldFileName = r.Cells[2].Value.ToString();
                        else
                            oldFileName = r.Cells[1].Value.ToString();

                        if (chkCase.Checked)
                            newName = oldFileName.Replace(oldString, newString);
                        else
                            newName = Regex.Replace(oldFileName, oldString, newString, RegexOptions.IgnoreCase);
                        
                        r.Cells[2].Value = newName;
                        //This is for memory and Undo
                        r.Cells[6].Value = oldFileName;
                        btnUndo.Enabled = true;
                        r.Cells[2].Style.BackColor = Color.Yellow;
                    }
                }

                //ClearAll(1);
            }
            catch (Exception ex)
            {
            }
        }

        private void Insert(bool isNewBatch)
        {
            string newName;
            string insertString = txtInsert.Text;
            int insertPos;
            int fileNameLength;
            string FileNameWithoutClipboard;
            string SubStr1;
            string SubStr2;
            string oldFileName;            

            try
            {

                if (txtLeftPos.Text != "")
                    insertPos = int.Parse(txtLeftPos.Text);
                else
                {
                    MessageBox.Show("Need to enter a starting position");
                    return;
                }

                foreach (DataGridViewRow r in dgFiles.SelectedRows)
                {
                    if (!isNewBatch && r.Cells[4].Value.ToString() == "success")
                        continue;

                    if (r.Cells[2].Value.ToString() != "")
                        oldFileName = r.Cells[2].Value.ToString();
                    else
                        oldFileName = r.Cells[1].Value.ToString();

                    fileNameLength = oldFileName.Length;
                    if (chkUseClipBoard.Checked)
                    {
                        insertPos = int.Parse(txtToPos.Text);// -int.Parse(txtSubEnd.Text);
                        insertString = Clipboard(oldFileName);

                        FileNameWithoutClipboard = oldFileName.Replace(insertString, "");

                        if (chkDelete.Checked == true)
                            newName = FileNameWithoutClipboard;
                        else
                        {
                            SubStr1 = FileNameWithoutClipboard.Substring(0, insertPos);
                            SubStr2 = FileNameWithoutClipboard.Substring(insertPos, (FileNameWithoutClipboard.Length - insertPos));

                            newName = SubStr1 + insertString + SubStr2;
                        }
                    }
                    else
                    {
                        newName = oldFileName.Substring(0, insertPos) + insertString + oldFileName.Substring(insertPos, (fileNameLength - insertPos));
                    }
                    r.Cells[2].Value = newName;
                    //This is for memory and Undo
                    r.Cells[6].Value = oldFileName;
                    btnUndo.Enabled = true;
                    r.Cells[2].Style.BackColor = Color.Yellow;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Append(bool isNewBatch)
        {
            string appendString = txtAppend.Text;
            string newName;
            string oldFileName;

            try
            {
                if (appendString != "")
                {
                     foreach (DataGridViewRow r in dgFiles.SelectedRows)
                    {
                        if (!isNewBatch && r.Cells[4].Value.ToString() == "success")
                            continue;

                        if (r.Cells[2].Value.ToString() != "")
                            oldFileName = r.Cells[2].Value.ToString();
                        else
                            oldFileName = r.Cells[1].Value.ToString();

                        newName = oldFileName + appendString;

                        r.Cells[2].Value = newName;
                        //This is for memory and Undo
                        r.Cells[6].Value = oldFileName;
                        btnUndo.Enabled = true;
                        r.Cells[2].Style.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (dgFiles.SelectedRows.Count > 0)
                RenameFiles();
        }

        private void chkUseClipBoard_CheckedChanged(object sender, EventArgs e)
        {
            ValidateCheckBox();
        }

        private void ValidateCheckBox()
        {
            if (chkUseClipBoard.Checked)
            {
                lblAt.Visible = false;
                txtLeftPos.Visible = false;
                lblTo.Visible = true;
                txtToPos.Visible = true;
            }
            else
            {
                lblAt.Visible = true;
                txtLeftPos.Visible = true;
                lblTo.Visible = false;
                txtToPos.Visible = false;
            }

            if (chkUseClipBoard.Checked && chkInsert.Checked)
            {
                txtInsert.Text = "";
                txtInsert.Enabled = false;
                grpClipboard.Enabled = true;
            }
            else
                txtInsert.Enabled = true;

            if (!chkUseClipBoard.Checked)
                grpClipboard.Enabled = false;
        }

        private void chkAppendClipboard_CheckedChanged(object sender, EventArgs e)
        {
            ValidateCheckBox();
        }

        private string Clipboard(string oldFileName)
        {
            string subString;            
            try
            {
                int startPos = int.Parse(txtSubStart.Text);
                int subLength = int.Parse(txtSubEnd.Text);

                subString = oldFileName.Substring(startPos, subLength);
                return subString;
            }
            catch
            {
                return "";
            }
        }

        private void chkReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReplace.Checked)
                grpReplace.Enabled = true;
            else
                grpReplace.Enabled = false;
        }

        private void chkInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInsert.Checked)
            {
                grpInsert.Enabled = true;
                grpInsertAll.Enabled = true;
            }
            else
            {
                chkUseClipBoard.Checked = false;
                grpInsert.Enabled = false;
                grpInsertAll.Enabled = false;
            }
        }

        private void chkAppend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAppend.Checked)
            {
                grpAppend.Enabled = true;
            }
            else
            {
                grpAppend.Enabled = false;
            }
        }

        private void RenameFiles()
        {
            string OldName = "";
            string NewName = "";
            string directoryPath;
            DataColumn col5 = new DataColumn();
            bool isNewBatch = true;

            try
            {
                if (dgFiles.Columns[4].Visible == true)
                    isNewBatch = false;

                //for (int i = 0; i < dgFiles.Rows.Count; i++)
                foreach (DataGridViewRow row in dgFiles.SelectedRows)
                {
                    if (!isNewBatch && row.Cells[4].Value.ToString() == "success")
                        continue;

                    directoryPath = row.Cells[5].Value.ToString();

                    OldName = directoryPath + @"\" + row.Cells[1].Value.ToString() + row.Cells[3].Value.ToString();
                    NewName = directoryPath + @"\" + row.Cells[2].Value.ToString() + row.Cells[3].Value.ToString();

                    if (NewName == OldName || row.Cells[2].Value.ToString() == "")
                    {
                        row.Cells[4].Value = "skipped";                       
                        continue;
                    }

                    try
                    {
                        File.Move(OldName, NewName);
                        row.Cells[4].Value = "success";
                        row.Cells[4].Style.BackColor = Color.Green;
                        row.Cells[4].Style.ForeColor = Color.White;
                    }
                    catch (Exception ex)
                    {
                        row.Cells[4].Value = "failed";
                        row.Cells[4].Style.BackColor = Color.Red;
                        row.Cells[4].Style.BackColor = Color.Red;
                    }
                }

                dgFiles.Columns[4].Visible = true;
                dgFiles.Columns[0].Width = 100;
                dgFiles.Columns[1].Width = 225;
                dgFiles.Columns[2].Width = 225;
                dgFiles.ClearSelection();
            }
            catch (Exception ex)
            {
            }
        }

        private void Preview(int command)
        {
            bool isNewBatch = true;

            if (dgFiles.SelectedRows.Count < 1)
            {
                MessageBox.Show("You have not selected any rows to modify.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (dgFiles.Columns.Count > 4)
                isNewBatch = false;

            switch (command)
            {
                case 1:
                    Replace(isNewBatch);
                    break;

                case 2:
                    Insert(isNewBatch);
                    break;

                case 3:
                    Append(isNewBatch);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkCase.Checked = true;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Preview(1);
            //grpReplace.Enabled = false;
            //chkReplace.Checked = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Preview(2);
            //grpInsertAll.Enabled = false;
            //chkInsert.Checked = false;
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            Preview(3);
            //grpAppend.Enabled = false;
            //chkAppend.Checked = false;
        }

        private void ClearAll()
        {
                    lblListCount.Text = "";

                    //CLEAR ALL REPLACED
                    chkReplace.Checked = false;
                    txtNewString.Text = "";
                    txtOldString.Text = "";

                    //CLEAR ALL INPUT
                    chkInsert.Checked = false;
                    txtInsert.Text = "";
                    chkUseClipBoard.Checked = false;
                    txtLeftPos.Text = "0";
                    txtSubStart.Text = "0";
                    txtSubEnd.Text = "0";
                    chkDelete.Checked = false;

                    //CLEAR ALL APPEND
                    chkAppend.Checked = false;
                    txtAppend.Text = "";

                    btnUndo.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgFiles.ClearSelection();
        }

        private void lstOld_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FillTable(string path, DragEventArgs e)
        {
            string[] files;

            if (path == "")
                files = (string[])e.Data.GetData(DataFormats.FileDrop);
            else
                files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo fi = new FileInfo(files[i]);
                bool fileExists = false;
                foreach (DataRow row in AllFiles.Rows)
                {
                    if (fi.FullName.ToString() == row[5].ToString() + "\\" + row[1].ToString() + row[3].ToString())
                    {
                        fileExists = true;
                        break;
                    }
                }

                if (!fileExists && fi.Name != ".DS_Store")
                    AllFiles.Rows.Add(fi.Directory.Root.ToString() +  "..." + fi.Directory.Name.ToString(), Path.GetFileNameWithoutExtension(fi.Name).ToString(), "", fi.Extension.ToString(), "",fi.DirectoryName.ToString());
            }
        }

        private void lstOld_DragDrop(object sender, DragEventArgs e)
        {
            string Directory = "";
            FileInfo info = new FileInfo(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);

            if (info.Extension == "")
                Directory = Path.GetFullPath(info.ToString());

            FillTable(Directory, e);

            dgFiles.DataSource = AllFiles;
            lblCount.Text = "( " + dgFiles.Rows.Count.ToString() + " Files )";        
            DataGridColumnHeaderStyle();
        }

        private void DataGridColumnHeaderStyle()
        {
            dgFiles.Columns[0].ReadOnly = true;
            dgFiles.Columns[1].ReadOnly = true;
            dgFiles.Columns[3].ReadOnly = true;
            dgFiles.Columns[4].ReadOnly = true;
            dgFiles.Columns[0].Width = 100;
            dgFiles.Columns[1].Width = 225;
            dgFiles.Columns[2].Width = 100;
            dgFiles.Columns[3].Width = 50;
            dgFiles.Columns[4].Visible = false;
            dgFiles.Columns[5].Visible = false;
            dgFiles.Columns[6].Visible = false;
        }

        private void ClearDataTable()
        {
            AllFiles.Clear();
            DataGridColumnHeaderStyle();
            lblCount.Text = dgFiles.Rows.Count.ToString() + " Files";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            if (dgFiles.Rows.Count > 0)
                result = MessageBox.Show("Are you sure you want to remove all files, changes may be lost?", "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                ClearDataTable();
            else if (result == DialogResult.Cancel)
                return;

            ClearAll();
        }

        private void txtLeftPos_TextChanged(object sender, EventArgs e)
        {
            //ShowPos();
        }

        public void ShowPos()
        {
            //int position;
            //if (!int.TryParse(txtLeftPos.Text, out position))
            //    return;

            //string substring1;
            //string substring2;
            //int sublength;

            //foreach (int i in lstOld.SelectedIndices)
            //{
            //    sublength = (lstNew.Items[i].ToString().Length) - position;

            //    substring1 = lstNew.Items[i].ToString().Substring(0, position);
            //    substring2 = lstNew.Items[i].ToString().Substring(position, sublength);

            //    lstNew.Items.RemoveAt(i);
            //    lstNew.Items.Insert(i, new ListBoxItem(Color.Red, substring1) + substring2);
            //}
        }


        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked == true)
            {
                txtToPos.Text = "0";
                txtToPos.Enabled = false;
            }
            else
                txtToPos.Enabled = true;
        }

        private void excelImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Excel Documents|*.xls;*xlsx";
            string conn;
            string filename;
            DataSet ds = new DataSet();
            System.Data.DataTable excelTable = new System.Data.DataTable();

            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    filename = fd.FileName;
                    conn = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + filename + "; Extended Properties=Excel 8.0");
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", conn);

                    adapter.Fill(ds, "WorkSheet");

                    excelTable = ds.Tables["WorkSheet"];

                    UpdateDataGrid(excelTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void UpdateDataGrid(System.Data.DataTable excelTable)
        {
            try
            {
                foreach (DataGridViewRow gridRow in dgFiles.Rows)
                {
                    string folderName = gridRow.Cells[0].Value.ToString().ToLower();
                    string galleryType;
                    string oldName;
                    string newName;

                    if (folderName.Contains("ext"))
                    {
                        for (int i = 0; i <= excelTable.Rows.Count - 1; i++)
                        {
                            oldName = (string)excelTable.Rows[i][1].ToString().Trim().ToLower();
                            newName = (string)excelTable.Rows[i][2].ToString().Trim().ToLower();
                            galleryType = (string)excelTable.Rows[i][0].ToString().Trim().ToLower();

                            if (galleryType.Contains("ext") && oldName == gridRow.Cells[1].Value.ToString().ToLower())                                
                                gridRow.Cells[2].Value = newName;
                        }
                    }
                    else if (folderName.Contains("int"))
                    {
                        for (int i = 0; i <= excelTable.Rows.Count - 1; i++)
                        {
                            oldName = (string)excelTable.Rows[i][1].ToString().Trim().ToLower();
                            newName = (string)excelTable.Rows[i][2].ToString().Trim().ToLower();
                            galleryType = (string)excelTable.Rows[i][0].ToString().Trim().ToLower();

                            if (galleryType.Contains("int") && oldName == gridRow.Cells[1].Value.ToString().ToLower())
                                gridRow.Cells[2].Value = newName;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgFiles.Rows)
            {
                if (r.Cells[6].Value.ToString() != "")
                    r.Cells[2].Value = r.Cells[6].Value;

                r.Cells[6].Value = "";
                btnUndo.Enabled = false;
            }
        }

        private void seperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgFiles.Rows.Count < 1)
            {
                MessageBox.Show("There are no files in your list", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
                
            string promptValue = Prompt.ShowDialog("default : ' _ '", "Enter Seperator", "_");
            setOrder(promptValue);

        }

        private void setOrder(string seperator)
        {
            string newName;
            string oldFileName;

            try
            {
                for (int i = 1; i <= dgFiles.Rows.Count; i++)
                {
                    var r = dgFiles.Rows[i-1];

                    if (r.Cells[2].Value.ToString() != "")
                        oldFileName = r.Cells[2].Value.ToString();
                    else
                        oldFileName = r.Cells[1].Value.ToString();

                    newName = i + seperator + oldFileName;

                    r.Cells[2].Value = newName;

                    //This is for memory and Undo
                    r.Cells[6].Value = oldFileName;
                    btnUndo.Enabled = true;
                    r.Cells[2].Style.BackColor = Color.Yellow;
                };
            }
            catch (Exception ex)
            {
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string label, string caption, string defaultValue)
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 150;
                prompt.Text = caption;
                Label textLabel = new Label() { Left = 50, Top = 20, Text = label };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Go", Left = 350, Width = 100, Top = 70 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.ShowDialog();

                if (textBox.Text != "")
                    return textBox.Text;
                else
                    return defaultValue;

                
            }
        }
    }
}

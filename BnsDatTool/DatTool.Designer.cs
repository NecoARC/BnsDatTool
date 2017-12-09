﻿namespace BnsDatTool
{
    partial class BnsDatTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BnsDatTool));
            this.bntSearchDat = new System.Windows.Forms.Button();
            this.bntSearchOut = new System.Windows.Forms.Button();
            this.bntUnpack = new System.Windows.Forms.Button();
            this.txbDatFile = new System.Windows.Forms.TextBox();
            this.txbRpFolder = new System.Windows.Forms.TextBox();
            this.cB_output = new System.Windows.Forms.CheckBox();
            this.btnRepack = new System.Windows.Forms.Button();
            this.lbDat = new System.Windows.Forms.Label();
            this.lbRfolder = new System.Windows.Forms.Label();
            this.Cb_back = new System.Windows.Forms.CheckBox();
            this.richOut = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CB_AutoClose = new System.Windows.Forms.CheckBox();
            this.CB_AutoReCompress = new System.Windows.Forms.CheckBox();
            this.CB_ChangeItem = new System.Windows.Forms.CheckBox();
            this.CB_SkillChange = new System.Windows.Forms.CheckBox();
            this.CB_OpenBox = new System.Windows.Forms.CheckBox();
            this.CB_AverageScore = new System.Windows.Forms.CheckBox();
            this.CB_AutoChangeDPS = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeaarchBin = new System.Windows.Forms.Button();
            this.txbBinFile = new System.Windows.Forms.TextBox();
            this.cboxGetBinFolder = new System.Windows.Forms.CheckBox();
            this.btnDump = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutBin = new System.Windows.Forms.Button();
            this.txbBinFolder = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_textract = new System.Windows.Forms.Button();
            this.txb_tlocal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SearchtLocal = new System.Windows.Forms.Button();
            this.btn_pack = new System.Windows.Forms.Button();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.btnExportTranslate = new System.Windows.Forms.Button();
            this.btnMergeTranslate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchTranslateFile = new System.Windows.Forms.Button();
            this.txbImportTranslate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbExportTranslate = new System.Windows.Forms.TextBox();
            this.cboxtbackup = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntSearchDat
            // 
            this.bntSearchDat.Location = new System.Drawing.Point(378, 4);
            this.bntSearchDat.Name = "bntSearchDat";
            this.bntSearchDat.Size = new System.Drawing.Size(57, 21);
            this.bntSearchDat.TabIndex = 0;
            this.bntSearchDat.Text = "Search";
            this.bntSearchDat.UseVisualStyleBackColor = true;
            this.bntSearchDat.Click += new System.EventHandler(this.bntSearchDat_Click);
            // 
            // bntSearchOut
            // 
            this.bntSearchOut.Location = new System.Drawing.Point(378, 28);
            this.bntSearchOut.Name = "bntSearchOut";
            this.bntSearchOut.Size = new System.Drawing.Size(57, 21);
            this.bntSearchOut.TabIndex = 1;
            this.bntSearchOut.Text = "Search";
            this.bntSearchOut.UseVisualStyleBackColor = true;
            this.bntSearchOut.Click += new System.EventHandler(this.bnSearchOut_Click);
            // 
            // bntUnpack
            // 
            this.bntUnpack.Location = new System.Drawing.Point(378, 53);
            this.bntUnpack.Name = "bntUnpack";
            this.bntUnpack.Size = new System.Drawing.Size(57, 21);
            this.bntUnpack.TabIndex = 2;
            this.bntUnpack.Text = "Unpack";
            this.bntUnpack.UseVisualStyleBackColor = true;
            this.bntUnpack.Click += new System.EventHandler(this.BntStart_Click);
            // 
            // txbDatFile
            // 
            this.txbDatFile.Location = new System.Drawing.Point(94, 6);
            this.txbDatFile.Name = "txbDatFile";
            this.txbDatFile.Size = new System.Drawing.Size(278, 22);
            this.txbDatFile.TabIndex = 3;
            // 
            // txbRpFolder
            // 
            this.txbRpFolder.Location = new System.Drawing.Point(94, 30);
            this.txbRpFolder.Name = "txbRpFolder";
            this.txbRpFolder.Size = new System.Drawing.Size(278, 22);
            this.txbRpFolder.TabIndex = 4;
            // 
            // cB_output
            // 
            this.cB_output.AutoSize = true;
            this.cB_output.Checked = true;
            this.cB_output.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_output.Location = new System.Drawing.Point(11, 54);
            this.cB_output.Name = "cB_output";
            this.cB_output.Size = new System.Drawing.Size(113, 16);
            this.cB_output.TabIndex = 14;
            this.cB_output.Text = "Get Folder location";
            this.cB_output.UseVisualStyleBackColor = true;
            // 
            // btnRepack
            // 
            this.btnRepack.Location = new System.Drawing.Point(378, 78);
            this.btnRepack.Name = "btnRepack";
            this.btnRepack.Size = new System.Drawing.Size(57, 21);
            this.btnRepack.TabIndex = 15;
            this.btnRepack.Text = "Repack";
            this.btnRepack.UseVisualStyleBackColor = true;
            this.btnRepack.Click += new System.EventHandler(this.btnRepack_Click);
            // 
            // lbDat
            // 
            this.lbDat.AutoSize = true;
            this.lbDat.Location = new System.Drawing.Point(8, 8);
            this.lbDat.Name = "lbDat";
            this.lbDat.Size = new System.Drawing.Size(45, 12);
            this.lbDat.TabIndex = 17;
            this.lbDat.Text = ".dat File:";
            // 
            // lbRfolder
            // 
            this.lbRfolder.AutoSize = true;
            this.lbRfolder.Location = new System.Drawing.Point(8, 32);
            this.lbRfolder.Name = "lbRfolder";
            this.lbRfolder.Size = new System.Drawing.Size(76, 12);
            this.lbRfolder.TabIndex = 18;
            this.lbRfolder.Text = "Repack Folder:";
            // 
            // Cb_back
            // 
            this.Cb_back.AutoSize = true;
            this.Cb_back.Checked = true;
            this.Cb_back.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_back.Location = new System.Drawing.Point(132, 54);
            this.Cb_back.Name = "Cb_back";
            this.Cb_back.Size = new System.Drawing.Size(96, 16);
            this.Cb_back.TabIndex = 20;
            this.Cb_back.Text = "Bakup Original";
            this.Cb_back.UseVisualStyleBackColor = true;
            // 
            // richOut
            // 
            this.richOut.AccessibleRole = System.Windows.Forms.AccessibleRole.HotkeyField;
            this.richOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richOut.BackColor = System.Drawing.SystemColors.Control;
            this.richOut.HideSelection = false;
            this.richOut.Location = new System.Drawing.Point(6, 18);
            this.richOut.Name = "richOut";
            this.richOut.Size = new System.Drawing.Size(441, 83);
            this.richOut.TabIndex = 21;
            this.richOut.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richOut);
            this.groupBox2.Location = new System.Drawing.Point(9, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 106);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 230);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CB_AutoClose);
            this.tabPage1.Controls.Add(this.lbDat);
            this.tabPage1.Controls.Add(this.bntSearchDat);
            this.tabPage1.Controls.Add(this.txbDatFile);
            this.tabPage1.Controls.Add(this.CB_AutoReCompress);
            this.tabPage1.Controls.Add(this.CB_ChangeItem);
            this.tabPage1.Controls.Add(this.CB_SkillChange);
            this.tabPage1.Controls.Add(this.CB_OpenBox);
            this.tabPage1.Controls.Add(this.CB_AverageScore);
            this.tabPage1.Controls.Add(this.CB_AutoChangeDPS);
            this.tabPage1.Controls.Add(this.cB_output);
            this.tabPage1.Controls.Add(this.bntUnpack);
            this.tabPage1.Controls.Add(this.Cb_back);
            this.tabPage1.Controls.Add(this.btnRepack);
            this.tabPage1.Controls.Add(this.lbRfolder);
            this.tabPage1.Controls.Add(this.bntSearchOut);
            this.tabPage1.Controls.Add(this.txbRpFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dat Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CB_AutoClose
            // 
            this.CB_AutoClose.AutoSize = true;
            this.CB_AutoClose.Checked = true;
            this.CB_AutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_AutoClose.Location = new System.Drawing.Point(132, 142);
            this.CB_AutoClose.Name = "CB_AutoClose";
            this.CB_AutoClose.Size = new System.Drawing.Size(108, 16);
            this.CB_AutoClose.TabIndex = 21;
            this.CB_AutoClose.Text = "壓縮完關閉程式";
            this.CB_AutoClose.UseVisualStyleBackColor = true;
            // 
            // CB_AutoReCompress
            // 
            this.CB_AutoReCompress.AutoSize = true;
            this.CB_AutoReCompress.Checked = true;
            this.CB_AutoReCompress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_AutoReCompress.Location = new System.Drawing.Point(132, 120);
            this.CB_AutoReCompress.Name = "CB_AutoReCompress";
            this.CB_AutoReCompress.Size = new System.Drawing.Size(72, 16);
            this.CB_AutoReCompress.TabIndex = 14;
            this.CB_AutoReCompress.Text = "自動壓縮";
            this.CB_AutoReCompress.UseVisualStyleBackColor = true;
            // 
            // CB_ChangeItem
            // 
            this.CB_ChangeItem.AutoSize = true;
            this.CB_ChangeItem.Checked = true;
            this.CB_ChangeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ChangeItem.Location = new System.Drawing.Point(10, 120);
            this.CB_ChangeItem.Name = "CB_ChangeItem";
            this.CB_ChangeItem.Size = new System.Drawing.Size(84, 16);
            this.CB_ChangeItem.TabIndex = 14;
            this.CB_ChangeItem.Text = "秒轉換物品";
            this.CB_ChangeItem.UseVisualStyleBackColor = true;
            // 
            // CB_SkillChange
            // 
            this.CB_SkillChange.AutoSize = true;
            this.CB_SkillChange.Checked = true;
            this.CB_SkillChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_SkillChange.Location = new System.Drawing.Point(132, 98);
            this.CB_SkillChange.Name = "CB_SkillChange";
            this.CB_SkillChange.Size = new System.Drawing.Size(120, 16);
            this.CB_SkillChange.TabIndex = 14;
            this.CB_SkillChange.Text = "縮短技能更改時間";
            this.CB_SkillChange.UseVisualStyleBackColor = true;
            // 
            // CB_OpenBox
            // 
            this.CB_OpenBox.AutoSize = true;
            this.CB_OpenBox.Checked = true;
            this.CB_OpenBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_OpenBox.Location = new System.Drawing.Point(10, 98);
            this.CB_OpenBox.Name = "CB_OpenBox";
            this.CB_OpenBox.Size = new System.Drawing.Size(72, 16);
            this.CB_OpenBox.TabIndex = 14;
            this.CB_OpenBox.Text = "秒開箱子";
            this.CB_OpenBox.UseVisualStyleBackColor = true;
            // 
            // CB_AverageScore
            // 
            this.CB_AverageScore.AutoSize = true;
            this.CB_AverageScore.Checked = true;
            this.CB_AverageScore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_AverageScore.Location = new System.Drawing.Point(132, 76);
            this.CB_AverageScore.Name = "CB_AverageScore";
            this.CB_AverageScore.Size = new System.Drawing.Size(108, 16);
            this.CB_AverageScore.TabIndex = 14;
            this.CB_AverageScore.Text = "顯示戰場平均分";
            this.CB_AverageScore.UseVisualStyleBackColor = true;
            // 
            // CB_AutoChangeDPS
            // 
            this.CB_AutoChangeDPS.AutoSize = true;
            this.CB_AutoChangeDPS.Checked = true;
            this.CB_AutoChangeDPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_AutoChangeDPS.Location = new System.Drawing.Point(10, 76);
            this.CB_AutoChangeDPS.Name = "CB_AutoChangeDPS";
            this.CB_AutoChangeDPS.Size = new System.Drawing.Size(92, 16);
            this.CB_AutoChangeDPS.TabIndex = 14;
            this.CB_AutoChangeDPS.Text = "自動修改DPS";
            this.CB_AutoChangeDPS.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnSeaarchBin);
            this.tabPage2.Controls.Add(this.txbBinFile);
            this.tabPage2.Controls.Add(this.cboxGetBinFolder);
            this.tabPage2.Controls.Add(this.btnDump);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnOutBin);
            this.tabPage2.Controls.Add(this.txbBinFolder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bin Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = ".bin File:";
            // 
            // btnSeaarchBin
            // 
            this.btnSeaarchBin.Location = new System.Drawing.Point(378, 4);
            this.btnSeaarchBin.Name = "btnSeaarchBin";
            this.btnSeaarchBin.Size = new System.Drawing.Size(57, 21);
            this.btnSeaarchBin.TabIndex = 21;
            this.btnSeaarchBin.Text = "Search";
            this.btnSeaarchBin.UseVisualStyleBackColor = true;
            this.btnSeaarchBin.Click += new System.EventHandler(this.btnSeaarchBin_Click);
            // 
            // txbBinFile
            // 
            this.txbBinFile.Location = new System.Drawing.Point(94, 6);
            this.txbBinFile.Name = "txbBinFile";
            this.txbBinFile.Size = new System.Drawing.Size(278, 22);
            this.txbBinFile.TabIndex = 24;
            // 
            // cboxGetBinFolder
            // 
            this.cboxGetBinFolder.AutoSize = true;
            this.cboxGetBinFolder.Checked = true;
            this.cboxGetBinFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxGetBinFolder.Location = new System.Drawing.Point(11, 54);
            this.cboxGetBinFolder.Name = "cboxGetBinFolder";
            this.cboxGetBinFolder.Size = new System.Drawing.Size(113, 16);
            this.cboxGetBinFolder.TabIndex = 26;
            this.cboxGetBinFolder.Text = "Get Folder location";
            this.cboxGetBinFolder.UseVisualStyleBackColor = true;
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(378, 53);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(57, 21);
            this.btnDump.TabIndex = 23;
            this.btnDump.Text = "Dump";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "Output Folder:";
            // 
            // btnOutBin
            // 
            this.btnOutBin.Location = new System.Drawing.Point(378, 28);
            this.btnOutBin.Name = "btnOutBin";
            this.btnOutBin.Size = new System.Drawing.Size(57, 21);
            this.btnOutBin.TabIndex = 22;
            this.btnOutBin.Text = "Search";
            this.btnOutBin.UseVisualStyleBackColor = true;
            this.btnOutBin.Click += new System.EventHandler(this.btnOutBin_Click);
            // 
            // txbBinFolder
            // 
            this.txbBinFolder.Location = new System.Drawing.Point(94, 30);
            this.txbBinFolder.Name = "txbBinFolder";
            this.txbBinFolder.Size = new System.Drawing.Size(278, 22);
            this.txbBinFolder.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_textract);
            this.tabPage3.Controls.Add(this.txb_tlocal);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btn_SearchtLocal);
            this.tabPage3.Controls.Add(this.btn_pack);
            this.tabPage3.Controls.Add(this.btn_Translate);
            this.tabPage3.Controls.Add(this.btnExportTranslate);
            this.tabPage3.Controls.Add(this.btnMergeTranslate);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnSearchTranslateFile);
            this.tabPage3.Controls.Add(this.txbImportTranslate);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txbExportTranslate);
            this.tabPage3.Controls.Add(this.cboxtbackup);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(443, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Translate";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_textract
            // 
            this.btn_textract.Location = new System.Drawing.Point(378, 4);
            this.btn_textract.Name = "btn_textract";
            this.btn_textract.Size = new System.Drawing.Size(57, 21);
            this.btn_textract.TabIndex = 51;
            this.btn_textract.Text = "Extract";
            this.btn_textract.UseVisualStyleBackColor = true;
            this.btn_textract.Click += new System.EventHandler(this.btn_textract_Click);
            // 
            // txb_tlocal
            // 
            this.txb_tlocal.Location = new System.Drawing.Point(94, 6);
            this.txb_tlocal.Name = "txb_tlocal";
            this.txb_tlocal.Size = new System.Drawing.Size(209, 22);
            this.txb_tlocal.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "local File:";
            // 
            // btn_SearchtLocal
            // 
            this.btn_SearchtLocal.Location = new System.Drawing.Point(309, 4);
            this.btn_SearchtLocal.Name = "btn_SearchtLocal";
            this.btn_SearchtLocal.Size = new System.Drawing.Size(63, 21);
            this.btn_SearchtLocal.TabIndex = 48;
            this.btn_SearchtLocal.Text = "Search";
            this.btn_SearchtLocal.UseVisualStyleBackColor = true;
            this.btn_SearchtLocal.Click += new System.EventHandler(this.btn_SearchtLocal_Click);
            // 
            // btn_pack
            // 
            this.btn_pack.Location = new System.Drawing.Point(378, 76);
            this.btn_pack.Name = "btn_pack";
            this.btn_pack.Size = new System.Drawing.Size(57, 21);
            this.btn_pack.TabIndex = 47;
            this.btn_pack.Text = "Pack";
            this.btn_pack.UseVisualStyleBackColor = true;
            this.btn_pack.Click += new System.EventHandler(this.btn_pack_Click);
            // 
            // btn_Translate
            // 
            this.btn_Translate.Location = new System.Drawing.Point(309, 76);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(63, 21);
            this.btn_Translate.TabIndex = 46;
            this.btn_Translate.Text = "Translate";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // btnExportTranslate
            // 
            this.btnExportTranslate.Location = new System.Drawing.Point(378, 28);
            this.btnExportTranslate.Name = "btnExportTranslate";
            this.btnExportTranslate.Size = new System.Drawing.Size(57, 21);
            this.btnExportTranslate.TabIndex = 44;
            this.btnExportTranslate.Text = "Export";
            this.btnExportTranslate.UseVisualStyleBackColor = true;
            this.btnExportTranslate.Click += new System.EventHandler(this.btnExportTranslate_Click);
            // 
            // btnMergeTranslate
            // 
            this.btnMergeTranslate.Location = new System.Drawing.Point(378, 52);
            this.btnMergeTranslate.Name = "btnMergeTranslate";
            this.btnMergeTranslate.Size = new System.Drawing.Size(57, 21);
            this.btnMergeTranslate.TabIndex = 43;
            this.btnMergeTranslate.Text = "Merge";
            this.btnMergeTranslate.UseVisualStyleBackColor = true;
            this.btnMergeTranslate.Click += new System.EventHandler(this.btnMergeTranslate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "Merge File:";
            // 
            // btnSearchTranslateFile
            // 
            this.btnSearchTranslateFile.Location = new System.Drawing.Point(309, 52);
            this.btnSearchTranslateFile.Name = "btnSearchTranslateFile";
            this.btnSearchTranslateFile.Size = new System.Drawing.Size(63, 21);
            this.btnSearchTranslateFile.TabIndex = 40;
            this.btnSearchTranslateFile.Text = "Search";
            this.btnSearchTranslateFile.UseVisualStyleBackColor = true;
            this.btnSearchTranslateFile.Click += new System.EventHandler(this.btnSearchTranslateFile_Click);
            // 
            // txbImportTranslate
            // 
            this.txbImportTranslate.Location = new System.Drawing.Point(94, 54);
            this.txbImportTranslate.Name = "txbImportTranslate";
            this.txbImportTranslate.Size = new System.Drawing.Size(209, 22);
            this.txbImportTranslate.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "Export Folder:";
            // 
            // txbExportTranslate
            // 
            this.txbExportTranslate.Location = new System.Drawing.Point(94, 30);
            this.txbExportTranslate.Name = "txbExportTranslate";
            this.txbExportTranslate.Size = new System.Drawing.Size(278, 22);
            this.txbExportTranslate.TabIndex = 37;
            // 
            // cboxtbackup
            // 
            this.cboxtbackup.AutoSize = true;
            this.cboxtbackup.Checked = true;
            this.cboxtbackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxtbackup.Location = new System.Drawing.Point(11, 79);
            this.cboxtbackup.Name = "cboxtbackup";
            this.cboxtbackup.Size = new System.Drawing.Size(96, 16);
            this.cboxtbackup.TabIndex = 33;
            this.cboxtbackup.Text = "Bakup Original";
            this.cboxtbackup.UseVisualStyleBackColor = true;
            // 
            // BnsDatTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BnsDatTool";
            this.Text = "BnsDatTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BnsDatTool_FormClosing);
            this.Load += new System.EventHandler(this.BnsDatTool_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.BnsDatTool_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.BnsDatTool_DragEnter);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSearchDat;
        private System.Windows.Forms.Button bntSearchOut;
        private System.Windows.Forms.Button bntUnpack;
        private System.Windows.Forms.TextBox txbDatFile;
        private System.Windows.Forms.TextBox txbRpFolder;
        private System.Windows.Forms.CheckBox cB_output;
        private System.Windows.Forms.Button btnRepack;
        private System.Windows.Forms.Label lbDat;
        private System.Windows.Forms.Label lbRfolder;
        private System.Windows.Forms.CheckBox Cb_back;
        private System.Windows.Forms.RichTextBox richOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeaarchBin;
        private System.Windows.Forms.TextBox txbBinFile;
        private System.Windows.Forms.CheckBox cboxGetBinFolder;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.CheckBox is64Bin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutBin;
        private System.Windows.Forms.TextBox txbBinFolder;
        private System.Windows.Forms.Button btnExportTranslate;
        private System.Windows.Forms.Button btnMergeTranslate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchTranslateFile;
        private System.Windows.Forms.TextBox txbImportTranslate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbExportTranslate;
        private System.Windows.Forms.CheckBox cboxtbackup;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_pack;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.TextBox txb_tlocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SearchtLocal;
        private System.Windows.Forms.Button btn_textract;
        private System.Windows.Forms.CheckBox CB_AutoChangeDPS;
        private System.Windows.Forms.CheckBox CB_ChangeItem;
        private System.Windows.Forms.CheckBox CB_SkillChange;
        private System.Windows.Forms.CheckBox CB_OpenBox;
        private System.Windows.Forms.CheckBox CB_AverageScore;
        private System.Windows.Forms.CheckBox CB_AutoReCompress;
        private System.Windows.Forms.CheckBox CB_AutoClose;
    }
}


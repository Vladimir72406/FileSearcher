
namespace FileSearcher.View
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
            this.components = new System.ComponentModel.Container();
            this.txtStartDir = new System.Windows.Forms.TextBox();
            this.btnSelectStartDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemplateFileName = new System.Windows.Forms.TextBox();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentDir = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lblTimeOfSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.timerSerchFile = new System.Windows.Forms.Timer(this.components);
            this.btnPauseSearch = new System.Windows.Forms.Button();
            this.btnContinueSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartDir
            // 
            this.txtStartDir.Location = new System.Drawing.Point(12, 31);
            this.txtStartDir.Multiline = true;
            this.txtStartDir.Name = "txtStartDir";
            this.txtStartDir.Size = new System.Drawing.Size(628, 25);
            this.txtStartDir.TabIndex = 0;
            // 
            // btnSelectStartDir
            // 
            this.btnSelectStartDir.Location = new System.Drawing.Point(646, 33);
            this.btnSelectStartDir.Name = "btnSelectStartDir";
            this.btnSelectStartDir.Size = new System.Drawing.Size(142, 23);
            this.btnSelectStartDir.TabIndex = 1;
            this.btnSelectStartDir.Text = "Выбрать директорию";
            this.btnSelectStartDir.UseVisualStyleBackColor = true;
            this.btnSelectStartDir.Click += new System.EventHandler(this.btnSelectStartDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Стартовая директория:";
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.Location = new System.Drawing.Point(646, 89);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(142, 25);
            this.btnStartSearch.TabIndex = 3;
            this.btnStartSearch.Text = "Начать поиск";
            this.btnStartSearch.UseVisualStyleBackColor = true;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шаблон для поиска :";
            // 
            // txtTemplateFileName
            // 
            this.txtTemplateFileName.Location = new System.Drawing.Point(12, 85);
            this.txtTemplateFileName.Multiline = true;
            this.txtTemplateFileName.Name = "txtTemplateFileName";
            this.txtTemplateFileName.Size = new System.Drawing.Size(628, 25);
            this.txtTemplateFileName.TabIndex = 5;
            // 
            // tvMain
            // 
            this.tvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMain.Location = new System.Drawing.Point(16, 256);
            this.tvMain.Name = "tvMain";
            this.tvMain.Size = new System.Drawing.Size(783, 247);
            this.tvMain.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текущая директория :";
            // 
            // lblCurrentDir
            // 
            this.lblCurrentDir.AutoSize = true;
            this.lblCurrentDir.Location = new System.Drawing.Point(151, 174);
            this.lblCurrentDir.Name = "lblCurrentDir";
            this.lblCurrentDir.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentDir.TabIndex = 8;
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(13, 201);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(85, 13);
            this.lblt.TabIndex = 9;
            this.lblt.Text = "Время поиска :";
            // 
            // lblTimeOfSearch
            // 
            this.lblTimeOfSearch.AutoSize = true;
            this.lblTimeOfSearch.Location = new System.Drawing.Point(151, 201);
            this.lblTimeOfSearch.Name = "lblTimeOfSearch";
            this.lblTimeOfSearch.Size = new System.Drawing.Size(0, 13);
            this.lblTimeOfSearch.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во найденных/всего файлов :";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(237, 228);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 13);
            this.lblFileCount.TabIndex = 12;
            // 
            // timerSerchFile
            // 
            this.timerSerchFile.Tick += new System.EventHandler(this.timerSerchFile_Tick);
            // 
            // btnPauseSearch
            // 
            this.btnPauseSearch.Enabled = false;
            this.btnPauseSearch.Location = new System.Drawing.Point(646, 121);
            this.btnPauseSearch.Name = "btnPauseSearch";
            this.btnPauseSearch.Size = new System.Drawing.Size(142, 23);
            this.btnPauseSearch.TabIndex = 13;
            this.btnPauseSearch.Text = "Остановить";
            this.btnPauseSearch.UseVisualStyleBackColor = true;
            this.btnPauseSearch.Click += new System.EventHandler(this.btnPauseSearch_Click);
            // 
            // btnContinueSearch
            // 
            this.btnContinueSearch.Enabled = false;
            this.btnContinueSearch.Location = new System.Drawing.Point(646, 151);
            this.btnContinueSearch.Name = "btnContinueSearch";
            this.btnContinueSearch.Size = new System.Drawing.Size(142, 23);
            this.btnContinueSearch.TabIndex = 14;
            this.btnContinueSearch.Text = "Продолжить";
            this.btnContinueSearch.UseVisualStyleBackColor = true;
            this.btnContinueSearch.Click += new System.EventHandler(this.btnContinueSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 520);
            this.Controls.Add(this.btnContinueSearch);
            this.Controls.Add(this.btnPauseSearch);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimeOfSearch);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lblCurrentDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tvMain);
            this.Controls.Add(this.txtTemplateFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectStartDir);
            this.Controls.Add(this.txtStartDir);
            this.Name = "MainForm";
            this.Text = "Файловый поисковик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartDir;
        private System.Windows.Forms.Button btnSelectStartDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemplateFileName;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentDir;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lblTimeOfSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Timer timerSerchFile;
        private System.Windows.Forms.Button btnPauseSearch;
        private System.Windows.Forms.Button btnContinueSearch;
    }
}
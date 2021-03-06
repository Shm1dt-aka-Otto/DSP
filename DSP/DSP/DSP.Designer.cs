namespace DSP
{
    partial class DSP
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSP));
            this.mainMenuDSP = new System.Windows.Forms.MenuStrip();
            this.fileMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.modelMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.analysMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuDSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuDSP
            // 
            this.mainMenuDSP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuDSP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuTool,
            this.modelMenuTool,
            this.filterMenuTool,
            this.analysMenuTool,
            this.settingsMenuTool,
            this.aboutMenuTool});
            this.mainMenuDSP.Location = new System.Drawing.Point(0, 0);
            this.mainMenuDSP.Name = "mainMenuDSP";
            this.mainMenuDSP.Size = new System.Drawing.Size(800, 30);
            this.mainMenuDSP.TabIndex = 0;
            this.mainMenuDSP.Text = "menuStrip1";
            // 
            // fileMenuTool
            // 
            this.fileMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileTool});
            this.fileMenuTool.Name = "fileMenuTool";
            this.fileMenuTool.Size = new System.Drawing.Size(59, 26);
            this.fileMenuTool.Text = "Файл";
            // 
            // openFileTool
            // 
            this.openFileTool.Name = "openFileTool";
            this.openFileTool.Size = new System.Drawing.Size(150, 26);
            this.openFileTool.Text = "Открыть";
            this.openFileTool.Click += new System.EventHandler(this.openFileTool_Click);
            // 
            // modelMenuTool
            // 
            this.modelMenuTool.Name = "modelMenuTool";
            this.modelMenuTool.Size = new System.Drawing.Size(138, 26);
            this.modelMenuTool.Text = "Моделирование";
            // 
            // filterMenuTool
            // 
            this.filterMenuTool.Name = "filterMenuTool";
            this.filterMenuTool.Size = new System.Drawing.Size(108, 26);
            this.filterMenuTool.Text = "Фильтрация";
            // 
            // analysMenuTool
            // 
            this.analysMenuTool.Name = "analysMenuTool";
            this.analysMenuTool.Size = new System.Drawing.Size(74, 26);
            this.analysMenuTool.Text = "Анализ";
            // 
            // settingsMenuTool
            // 
            this.settingsMenuTool.Name = "settingsMenuTool";
            this.settingsMenuTool.Size = new System.Drawing.Size(98, 26);
            this.settingsMenuTool.Text = "Настройки";
            // 
            // aboutMenuTool
            // 
            this.aboutMenuTool.Name = "aboutMenuTool";
            this.aboutMenuTool.Size = new System.Drawing.Size(81, 26);
            this.aboutMenuTool.Text = "Справка";
            this.aboutMenuTool.Click += new System.EventHandler(this.aboutMenuTool_Click);
            // 
            // DSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuDSP);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuDSP;
            this.Name = "DSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSP-Siben";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DSP_Load);
            this.mainMenuDSP.ResumeLayout(false);
            this.mainMenuDSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuDSP;
        private System.Windows.Forms.ToolStripMenuItem fileMenuTool;
        private System.Windows.Forms.ToolStripMenuItem modelMenuTool;
        private System.Windows.Forms.ToolStripMenuItem filterMenuTool;
        private System.Windows.Forms.ToolStripMenuItem analysMenuTool;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuTool;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuTool;
        private System.Windows.Forms.ToolStripMenuItem openFileTool;
    }
}


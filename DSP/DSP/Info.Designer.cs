namespace DSP
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.numberOfChannelsLabel = new System.Windows.Forms.Label();
            this.numberOfCountLabel = new System.Windows.Forms.Label();
            this.rateDiscretLabel = new System.Windows.Forms.Label();
            this.dateRecordLabel = new System.Windows.Forms.Label();
            this.dateEndLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoGridView = new System.Windows.Forms.DataGridView();
            this.activeLabel = new System.Windows.Forms.Label();
            this.countColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStateLabel.Location = new System.Drawing.Point(11, 9);
            this.currentStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(521, 23);
            this.currentStateLabel.TabIndex = 0;
            this.currentStateLabel.Text = "Текущее состояние многоканального сигнала";
            // 
            // numberOfChannelsLabel
            // 
            this.numberOfChannelsLabel.AutoSize = true;
            this.numberOfChannelsLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfChannelsLabel.Location = new System.Drawing.Point(11, 41);
            this.numberOfChannelsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfChannelsLabel.Name = "numberOfChannelsLabel";
            this.numberOfChannelsLabel.Size = new System.Drawing.Size(234, 20);
            this.numberOfChannelsLabel.TabIndex = 1;
            this.numberOfChannelsLabel.Text = "Общее число каналов - K";
            // 
            // numberOfCountLabel
            // 
            this.numberOfCountLabel.AutoSize = true;
            this.numberOfCountLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfCountLabel.Location = new System.Drawing.Point(11, 61);
            this.numberOfCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfCountLabel.Name = "numberOfCountLabel";
            this.numberOfCountLabel.Size = new System.Drawing.Size(289, 20);
            this.numberOfCountLabel.TabIndex = 2;
            this.numberOfCountLabel.Text = "Общее количество отсчетов – N";
            // 
            // rateDiscretLabel
            // 
            this.rateDiscretLabel.AutoSize = true;
            this.rateDiscretLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateDiscretLabel.Location = new System.Drawing.Point(11, 81);
            this.rateDiscretLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rateDiscretLabel.Name = "rateDiscretLabel";
            this.rateDiscretLabel.Size = new System.Drawing.Size(630, 20);
            this.rateDiscretLabel.TabIndex = 3;
            this.rateDiscretLabel.Text = "Частота дискретизации – 8 Гц ( шаг между отсчетами 0.1250000 сек)";
            // 
            // dateRecordLabel
            // 
            this.dateRecordLabel.AutoSize = true;
            this.dateRecordLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.dateRecordLabel.Location = new System.Drawing.Point(11, 101);
            this.dateRecordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateRecordLabel.Name = "dateRecordLabel";
            this.dateRecordLabel.Size = new System.Drawing.Size(530, 20);
            this.dateRecordLabel.TabIndex = 4;
            this.dateRecordLabel.Text = "Дата и время начала записи - ДД-ММ-ГГГГ ЧЧ:MM:CC.CCC";
            // 
            // dateEndLabel
            // 
            this.dateEndLabel.AutoSize = true;
            this.dateEndLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.dateEndLabel.Location = new System.Drawing.Point(11, 121);
            this.dateEndLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateEndLabel.Name = "dateEndLabel";
            this.dateEndLabel.Size = new System.Drawing.Size(561, 20);
            this.dateEndLabel.TabIndex = 5;
            this.dateEndLabel.Text = "Дата и время окончания записи - ДД-ММ-ГГГГ ЧЧ:MM:CC.CCC";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.summaryLabel.Location = new System.Drawing.Point(11, 141);
            this.summaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(636, 20);
            this.summaryLabel.TabIndex = 6;
            this.summaryLabel.Text = "Длительность: ДДД – суток, ЧЧ – часов, ММ – минут, СС.ССС - секунд";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.infoLabel.Location = new System.Drawing.Point(11, 161);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(216, 20);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Информация о каналах";
            // 
            // infoGridView
            // 
            this.infoGridView.AllowUserToDeleteRows = false;
            this.infoGridView.AllowUserToResizeColumns = false;
            this.infoGridView.AllowUserToResizeRows = false;
            this.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countColumn,
            this.nameColumn,
            this.sourceColumn});
            this.infoGridView.Location = new System.Drawing.Point(15, 184);
            this.infoGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.infoGridView.Name = "infoGridView";
            this.infoGridView.RowHeadersVisible = false;
            this.infoGridView.RowHeadersWidth = 51;
            this.infoGridView.RowTemplate.Height = 24;
            this.infoGridView.Size = new System.Drawing.Size(726, 189);
            this.infoGridView.TabIndex = 8;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.activeLabel.Location = new System.Drawing.Point(11, 376);
            this.activeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(674, 20);
            this.activeLabel.TabIndex = 9;
            this.activeLabel.Text = "Активный фрагмент: [начальный отсчет, конечный отсчет], всего отсчетов";
            // 
            // countColumn
            // 
            this.countColumn.HeaderText = "N";
            this.countColumn.MinimumWidth = 6;
            this.countColumn.Name = "countColumn";
            this.countColumn.Width = 47;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 338;
            // 
            // sourceColumn
            // 
            this.sourceColumn.HeaderText = "Источник";
            this.sourceColumn.MinimumWidth = 6;
            this.sourceColumn.Name = "sourceColumn";
            this.sourceColumn.Width = 338;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 403);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.infoGridView);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.dateEndLabel);
            this.Controls.Add(this.dateRecordLabel);
            this.Controls.Add(this.rateDiscretLabel);
            this.Controls.Add(this.numberOfCountLabel);
            this.Controls.Add(this.numberOfChannelsLabel);
            this.Controls.Add(this.currentStateLabel);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.Text = "Информация о сигнале";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentStateLabel;
        private System.Windows.Forms.Label numberOfChannelsLabel;
        private System.Windows.Forms.Label numberOfCountLabel;
        private System.Windows.Forms.Label rateDiscretLabel;
        private System.Windows.Forms.Label dateRecordLabel;
        private System.Windows.Forms.Label dateEndLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView infoGridView;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn countColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
    }
}
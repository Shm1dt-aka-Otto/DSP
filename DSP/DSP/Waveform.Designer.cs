namespace DSP
{
    partial class Waveform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waveform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linearBox = new System.Windows.Forms.CheckBox();
            this.circleBox = new System.Windows.Forms.CheckBox();
            this.coordinateBox = new System.Windows.Forms.CheckBox();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.plusZoomButton = new System.Windows.Forms.Button();
            this.minusZoomButton = new System.Windows.Forms.Button();
            this.degreeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.degreeButton);
            this.panel1.Controls.Add(this.minusZoomButton);
            this.panel1.Controls.Add(this.plusZoomButton);
            this.panel1.Controls.Add(this.linearBox);
            this.panel1.Controls.Add(this.circleBox);
            this.panel1.Controls.Add(this.coordinateBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 9;
            // 
            // linearBox
            // 
            this.linearBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.linearBox.AutoSize = true;
            this.linearBox.Image = ((System.Drawing.Image)(resources.GetObject("linearBox.Image")));
            this.linearBox.Location = new System.Drawing.Point(88, 0);
            this.linearBox.Name = "linearBox";
            this.linearBox.Size = new System.Drawing.Size(38, 38);
            this.linearBox.TabIndex = 12;
            this.linearBox.UseVisualStyleBackColor = true;
            this.linearBox.CheckedChanged += new System.EventHandler(this.linearBox_CheckedChanged);
            // 
            // circleBox
            // 
            this.circleBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.circleBox.AutoSize = true;
            this.circleBox.Image = ((System.Drawing.Image)(resources.GetObject("circleBox.Image")));
            this.circleBox.Location = new System.Drawing.Point(44, 0);
            this.circleBox.Name = "circleBox";
            this.circleBox.Size = new System.Drawing.Size(38, 38);
            this.circleBox.TabIndex = 11;
            this.circleBox.UseVisualStyleBackColor = true;
            this.circleBox.CheckedChanged += new System.EventHandler(this.circleBox_CheckedChanged);
            // 
            // coordinateBox
            // 
            this.coordinateBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.coordinateBox.AutoSize = true;
            this.coordinateBox.Image = ((System.Drawing.Image)(resources.GetObject("coordinateBox.Image")));
            this.coordinateBox.Location = new System.Drawing.Point(0, 0);
            this.coordinateBox.Name = "coordinateBox";
            this.coordinateBox.Size = new System.Drawing.Size(38, 38);
            this.coordinateBox.TabIndex = 10;
            this.coordinateBox.UseVisualStyleBackColor = true;
            this.coordinateBox.CheckedChanged += new System.EventHandler(this.coordinateBox_CheckedChanged);
            // 
            // graphPanel
            // 
            this.graphPanel.Location = new System.Drawing.Point(0, 34);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(800, 415);
            this.graphPanel.TabIndex = 10;
            // 
            // plusZoomButton
            // 
            this.plusZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("plusZoomButton.Image")));
            this.plusZoomButton.Location = new System.Drawing.Point(132, 0);
            this.plusZoomButton.Name = "plusZoomButton";
            this.plusZoomButton.Size = new System.Drawing.Size(38, 38);
            this.plusZoomButton.TabIndex = 0;
            this.plusZoomButton.UseVisualStyleBackColor = true;
            // 
            // minusZoomButton
            // 
            this.minusZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("minusZoomButton.Image")));
            this.minusZoomButton.Location = new System.Drawing.Point(176, 0);
            this.minusZoomButton.Name = "minusZoomButton";
            this.minusZoomButton.Size = new System.Drawing.Size(38, 38);
            this.minusZoomButton.TabIndex = 13;
            this.minusZoomButton.UseVisualStyleBackColor = true;
            // 
            // degreeButton
            // 
            this.degreeButton.Image = ((System.Drawing.Image)(resources.GetObject("degreeButton.Image")));
            this.degreeButton.Location = new System.Drawing.Point(220, -1);
            this.degreeButton.Name = "degreeButton";
            this.degreeButton.Size = new System.Drawing.Size(38, 38);
            this.degreeButton.TabIndex = 14;
            this.degreeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(264, -1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(38, 38);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(308, -1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(38, 38);
            this.saveButton.TabIndex = 1;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Waveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Waveform";
            this.Text = "Осцилограмма";
            this.Load += new System.EventHandler(this.Waveform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox linearBox;
        private System.Windows.Forms.CheckBox circleBox;
        private System.Windows.Forms.CheckBox coordinateBox;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button degreeButton;
        private System.Windows.Forms.Button minusZoomButton;
        private System.Windows.Forms.Button plusZoomButton;
    }
}
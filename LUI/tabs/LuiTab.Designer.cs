﻿namespace LUI.tabs
{
    partial class LuiTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label GainLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuiTab));
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.CommonObjectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DummyWidth = new System.Windows.Forms.Panel();
            this.CameraBox = new LUI.controls.ObjectCommandPanel();
            this.CameraCommands = new System.Windows.Forms.Panel();
            this.CameraGain = new System.Windows.Forms.NumericUpDown();
            this.BeamFlagBox = new LUI.controls.ObjectCommandPanel();
            this.BeamFlagCommands = new System.Windows.Forms.Panel();
            this.CloseLamp = new System.Windows.Forms.Button();
            this.OpenLaser = new System.Windows.Forms.Button();
            this.OpenLamp = new System.Windows.Forms.Button();
            this.CloseLaser = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.StatusProgress = new System.Windows.Forms.ProgressBar();
            this.CommandsBox = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NScan = new System.Windows.Forms.NumericUpDown();
            this.Collect = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.ChildArea = new System.Windows.Forms.Panel();
            this.Graph = new LUI.controls.GraphControl();
            GainLabel = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.CommonObjectPanel.SuspendLayout();
            this.CameraBox.Flow.SuspendLayout();
            this.CameraCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraGain)).BeginInit();
            this.BeamFlagBox.Flow.SuspendLayout();
            this.BeamFlagCommands.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.CommandsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NScan)).BeginInit();
            this.SuspendLayout();
            // 
            // GainLabel
            // 
            GainLabel.AutoSize = true;
            GainLabel.Location = new System.Drawing.Point(1, 6);
            GainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GainLabel.Name = "GainLabel";
            GainLabel.Size = new System.Drawing.Size(95, 17);
            GainLabel.TabIndex = 10;
            GainLabel.Text = "Camera Gain:";
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.CommonObjectPanel);
            this.ParentPanel.Controls.Add(this.StatusBox);
            this.ParentPanel.Controls.Add(this.CommandsBox);
            this.ParentPanel.Controls.Add(this.ChildArea);
            this.ParentPanel.Controls.Add(this.Graph);
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(0, 0);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(1476, 821);
            this.ParentPanel.TabIndex = 0;
            // 
            // CommonObjectPanel
            // 
            this.CommonObjectPanel.AutoSize = true;
            this.CommonObjectPanel.Controls.Add(this.DummyWidth);
            this.CommonObjectPanel.Controls.Add(this.CameraBox);
            this.CommonObjectPanel.Controls.Add(this.BeamFlagBox);
            this.CommonObjectPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CommonObjectPanel.Location = new System.Drawing.Point(1105, 532);
            this.CommonObjectPanel.Name = "CommonObjectPanel";
            this.CommonObjectPanel.Size = new System.Drawing.Size(500, 357);
            this.CommonObjectPanel.TabIndex = 14;
            // 
            // DummyWidth
            // 
            this.DummyWidth.Location = new System.Drawing.Point(3, 3);
            this.DummyWidth.Name = "DummyWidth";
            this.DummyWidth.Size = new System.Drawing.Size(361, 0);
            this.DummyWidth.TabIndex = 14;
            // 
            // CameraBox
            // 
            this.CameraBox.AutoSize = true;
            this.CameraBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CameraBox.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // CameraBox.Flow
            // 
            this.CameraBox.Flow.AutoSize = true;
            this.CameraBox.Flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CameraBox.Flow.Controls.Add(this.CameraCommands);
            this.CameraBox.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraBox.Flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CameraBox.Flow.Location = new System.Drawing.Point(3, 18);
            this.CameraBox.Flow.Name = "Flow";
            this.CameraBox.Flow.Size = new System.Drawing.Size(355, 73);
            this.CameraBox.Flow.TabIndex = 0;
            this.CameraBox.Location = new System.Drawing.Point(3, 9);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Object = null;
            this.CameraBox.SelectedObject = null;
            this.CameraBox.Size = new System.Drawing.Size(361, 94);
            this.CameraBox.TabIndex = 13;
            this.CameraBox.Text = "Camera";
            // 
            // CameraCommands
            // 
            this.CameraCommands.AutoSize = true;
            this.CameraCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CameraCommands.Controls.Add(GainLabel);
            this.CameraCommands.Controls.Add(this.CameraGain);
            this.CameraCommands.Location = new System.Drawing.Point(3, 40);
            this.CameraCommands.Name = "CameraCommands";
            this.CameraCommands.Size = new System.Drawing.Size(187, 30);
            this.CameraCommands.TabIndex = 1;
            // 
            // CameraGain
            // 
            this.CameraGain.Location = new System.Drawing.Point(104, 4);
            this.CameraGain.Margin = new System.Windows.Forms.Padding(4);
            this.CameraGain.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.CameraGain.Name = "CameraGain";
            this.CameraGain.Size = new System.Drawing.Size(79, 22);
            this.CameraGain.TabIndex = 9;
            this.CameraGain.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // BeamFlagBox
            // 
            this.BeamFlagBox.AutoSize = true;
            this.BeamFlagBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BeamFlagBox.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // BeamFlagBox.Flow
            // 
            this.BeamFlagBox.Flow.AutoSize = true;
            this.BeamFlagBox.Flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BeamFlagBox.Flow.Controls.Add(this.BeamFlagCommands);
            this.BeamFlagBox.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BeamFlagBox.Flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BeamFlagBox.Flow.Location = new System.Drawing.Point(3, 18);
            this.BeamFlagBox.Flow.Name = "Flow";
            this.BeamFlagBox.Flow.Size = new System.Drawing.Size(355, 129);
            this.BeamFlagBox.Flow.TabIndex = 0;
            this.BeamFlagBox.Location = new System.Drawing.Point(3, 109);
            this.BeamFlagBox.Name = "BeamFlagBox";
            this.BeamFlagBox.Object = null;
            this.BeamFlagBox.SelectedObject = null;
            this.BeamFlagBox.Size = new System.Drawing.Size(361, 150);
            this.BeamFlagBox.TabIndex = 0;
            this.BeamFlagBox.Text = "Beam Flags";
            // 
            // BeamFlagCommands
            // 
            this.BeamFlagCommands.AutoSize = true;
            this.BeamFlagCommands.Controls.Add(this.CloseLamp);
            this.BeamFlagCommands.Controls.Add(this.OpenLaser);
            this.BeamFlagCommands.Controls.Add(this.OpenLamp);
            this.BeamFlagCommands.Controls.Add(this.CloseLaser);
            this.BeamFlagCommands.Location = new System.Drawing.Point(3, 40);
            this.BeamFlagCommands.Name = "BeamFlagCommands";
            this.BeamFlagCommands.Size = new System.Drawing.Size(288, 86);
            this.BeamFlagCommands.TabIndex = 1;
            // 
            // CloseLamp
            // 
            this.CloseLamp.Location = new System.Drawing.Point(148, 48);
            this.CloseLamp.Margin = new System.Windows.Forms.Padding(4);
            this.CloseLamp.Name = "CloseLamp";
            this.CloseLamp.Size = new System.Drawing.Size(136, 34);
            this.CloseLamp.TabIndex = 7;
            this.CloseLamp.Text = "Close Lamp";
            this.CloseLamp.UseVisualStyleBackColor = true;
            // 
            // OpenLaser
            // 
            this.OpenLaser.Location = new System.Drawing.Point(4, 6);
            this.OpenLaser.Margin = new System.Windows.Forms.Padding(4);
            this.OpenLaser.Name = "OpenLaser";
            this.OpenLaser.Size = new System.Drawing.Size(136, 34);
            this.OpenLaser.TabIndex = 4;
            this.OpenLaser.Text = "Open Laser";
            this.OpenLaser.UseVisualStyleBackColor = true;
            // 
            // OpenLamp
            // 
            this.OpenLamp.Location = new System.Drawing.Point(148, 6);
            this.OpenLamp.Margin = new System.Windows.Forms.Padding(4);
            this.OpenLamp.Name = "OpenLamp";
            this.OpenLamp.Size = new System.Drawing.Size(136, 34);
            this.OpenLamp.TabIndex = 6;
            this.OpenLamp.Text = "Open Lamp";
            this.OpenLamp.UseVisualStyleBackColor = true;
            // 
            // CloseLaser
            // 
            this.CloseLaser.Location = new System.Drawing.Point(4, 48);
            this.CloseLaser.Margin = new System.Windows.Forms.Padding(4);
            this.CloseLaser.Name = "CloseLaser";
            this.CloseLaser.Size = new System.Drawing.Size(136, 34);
            this.CloseLaser.TabIndex = 5;
            this.CloseLaser.Text = "Close Laser";
            this.CloseLaser.UseVisualStyleBackColor = true;
            // 
            // StatusBox
            // 
            this.StatusBox.Controls.Add(this.ProgressLabel);
            this.StatusBox.Controls.Add(this.StatusProgress);
            this.StatusBox.Location = new System.Drawing.Point(1105, 4);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(4);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Padding = new System.Windows.Forms.Padding(4);
            this.StatusBox.Size = new System.Drawing.Size(361, 257);
            this.StatusBox.TabIndex = 9;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "Status";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLabel.Location = new System.Drawing.Point(65, 100);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(39, 20);
            this.ProgressLabel.TabIndex = 7;
            this.ProgressLabel.Text = "Idle";
            // 
            // StatusProgress
            // 
            this.StatusProgress.Location = new System.Drawing.Point(69, 123);
            this.StatusProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusProgress.Name = "StatusProgress";
            this.StatusProgress.Size = new System.Drawing.Size(227, 34);
            this.StatusProgress.TabIndex = 6;
            // 
            // CommandsBox
            // 
            this.CommandsBox.Controls.Add(this.Clear);
            this.CommandsBox.Controls.Add(this.label1);
            this.CommandsBox.Controls.Add(this.NScan);
            this.CommandsBox.Controls.Add(this.Collect);
            this.CommandsBox.Controls.Add(this.Abort);
            this.CommandsBox.Location = new System.Drawing.Point(1105, 268);
            this.CommandsBox.Margin = new System.Windows.Forms.Padding(4);
            this.CommandsBox.Name = "CommandsBox";
            this.CommandsBox.Padding = new System.Windows.Forms.Padding(4);
            this.CommandsBox.Size = new System.Drawing.Size(361, 257);
            this.CommandsBox.TabIndex = 10;
            this.CommandsBox.TabStop = false;
            this.CommandsBox.Text = "Commands";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(7, 149);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(136, 34);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear Graph";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scans";
            // 
            // NScan
            // 
            this.NScan.Location = new System.Drawing.Point(151, 30);
            this.NScan.Margin = new System.Windows.Forms.Padding(4);
            this.NScan.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.NScan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NScan.Name = "NScan";
            this.NScan.Size = new System.Drawing.Size(48, 22);
            this.NScan.TabIndex = 3;
            this.NScan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Collect
            // 
            this.Collect.Location = new System.Drawing.Point(8, 23);
            this.Collect.Margin = new System.Windows.Forms.Padding(4);
            this.Collect.Name = "Collect";
            this.Collect.Size = new System.Drawing.Size(136, 34);
            this.Collect.TabIndex = 2;
            this.Collect.Text = "Collect UV/vis";
            this.Collect.UseVisualStyleBackColor = true;
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(8, 65);
            this.Abort.Margin = new System.Windows.Forms.Padding(4);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(91, 34);
            this.Abort.TabIndex = 1;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            // 
            // ChildArea
            // 
            this.ChildArea.Location = new System.Drawing.Point(0, 532);
            this.ChildArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChildArea.Name = "ChildArea";
            this.ChildArea.Size = new System.Drawing.Size(1099, 239);
            this.ChildArea.TabIndex = 12;
            // 
            // Graph
            // 
            this.Graph.AxesColor = System.Drawing.Color.Blue;
            this.Graph.AxesFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graph.AxesFontColor = System.Drawing.Color.Black;
            this.Graph.ColorOrder = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("Graph.ColorOrder")));
            this.Graph.InitialScaleHeight = 0F;
            this.Graph.InitialXLeft = 0F;
            this.Graph.InitialXRight = 1023F;
            this.Graph.InitialYMax = float.NegativeInfinity;
            this.Graph.InitialYMin = float.PositiveInfinity;
            this.Graph.Location = new System.Drawing.Point(0, 2);
            this.Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graph.Marker = "*";
            this.Graph.MarkerColor = System.Drawing.Color.Blue;
            this.Graph.MarkerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graph.Name = "Graph";
            this.Graph.NXTicks = 10;
            this.Graph.NYTicks = 10;
            this.Graph.PadBottom = 0.01F;
            this.Graph.PadLeft = 0.01F;
            this.Graph.PadRight = 0.01F;
            this.Graph.PadTop = 0.01F;
            this.Graph.ScaleHeight = 0F;
            this.Graph.Size = new System.Drawing.Size(1099, 524);
            this.Graph.TabIndex = 13;
            this.Graph.XAxisHeight = 0.1F;
            this.Graph.XLabelFormat = "f0";
            this.Graph.XLeft = 0F;
            this.Graph.XRight = 1023F;
            this.Graph.YAxisWidth = 0.05F;
            this.Graph.YLabelFormat = "n3";
            this.Graph.YMax = float.NegativeInfinity;
            this.Graph.YMin = float.PositiveInfinity;
            // 
            // LuiTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParentPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LuiTab";
            this.Size = new System.Drawing.Size(1476, 821);
            this.ParentPanel.ResumeLayout(false);
            this.ParentPanel.PerformLayout();
            this.CommonObjectPanel.ResumeLayout(false);
            this.CommonObjectPanel.PerformLayout();
            this.CameraBox.Flow.ResumeLayout(false);
            this.CameraBox.Flow.PerformLayout();
            this.CameraCommands.ResumeLayout(false);
            this.CameraCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraGain)).EndInit();
            this.BeamFlagBox.Flow.ResumeLayout(false);
            this.BeamFlagBox.Flow.PerformLayout();
            this.BeamFlagCommands.ResumeLayout(false);
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.CommandsBox.ResumeLayout(false);
            this.CommandsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel ParentPanel;
        protected System.Windows.Forms.GroupBox StatusBox;
        protected System.Windows.Forms.Label ProgressLabel;
        protected System.Windows.Forms.ProgressBar StatusProgress;
        protected System.Windows.Forms.GroupBox CommandsBox;
        protected System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown NScan;
        protected System.Windows.Forms.Button Collect;
        protected System.Windows.Forms.Button Abort;
        protected System.Windows.Forms.Button CloseLamp;
        protected System.Windows.Forms.Button OpenLamp;
        protected System.Windows.Forms.Button CloseLaser;
        protected System.Windows.Forms.Button OpenLaser;
        protected System.Windows.Forms.Panel ChildArea;
        protected controls.GraphControl Graph;
        private System.Windows.Forms.Panel BeamFlagCommands;
        protected System.Windows.Forms.FlowLayoutPanel CommonObjectPanel;
        protected controls.ObjectCommandPanel BeamFlagBox;
        protected controls.ObjectCommandPanel CameraBox;
        private System.Windows.Forms.Panel DummyWidth;
        private System.Windows.Forms.Panel CameraCommands;
        protected System.Windows.Forms.NumericUpDown CameraGain;


    }
}

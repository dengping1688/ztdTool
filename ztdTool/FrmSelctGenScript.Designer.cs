﻿namespace ztdTool
{
    partial class FrmSelctGenScript
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_GEN_SCRIPT = new System.Windows.Forms.Button();
            this.btn_GEN_GRID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.me_SQL = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_PREVIEW = new DevExpress.XtraGrid.GridControl();
            this.gv_PREVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_SQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PREVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PREVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_GEN_SCRIPT);
            this.panelControl1.Controls.Add(this.btn_GEN_GRID);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.me_SQL);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(957, 294);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_GEN_SCRIPT
            // 
            this.btn_GEN_SCRIPT.Enabled = false;
            this.btn_GEN_SCRIPT.Location = new System.Drawing.Point(779, 102);
            this.btn_GEN_SCRIPT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GEN_SCRIPT.Name = "btn_GEN_SCRIPT";
            this.btn_GEN_SCRIPT.Size = new System.Drawing.Size(117, 26);
            this.btn_GEN_SCRIPT.TabIndex = 14;
            this.btn_GEN_SCRIPT.Text = "生成脚本";
            this.btn_GEN_SCRIPT.UseVisualStyleBackColor = true;
            this.btn_GEN_SCRIPT.Click += new System.EventHandler(this.btn_GEN_SCRIPT_Click);
            // 
            // btn_GEN_GRID
            // 
            this.btn_GEN_GRID.Location = new System.Drawing.Point(779, 58);
            this.btn_GEN_GRID.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GEN_GRID.Name = "btn_GEN_GRID";
            this.btn_GEN_GRID.Size = new System.Drawing.Size(117, 26);
            this.btn_GEN_GRID.TabIndex = 12;
            this.btn_GEN_GRID.Text = "查询并生成GridView";
            this.btn_GEN_GRID.UseVisualStyleBackColor = true;
            this.btn_GEN_GRID.Click += new System.EventHandler(this.btn_GEN_GRID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询SQL:";
            // 
            // me_SQL
            // 
            this.me_SQL.Location = new System.Drawing.Point(125, 27);
            this.me_SQL.Margin = new System.Windows.Forms.Padding(2);
            this.me_SQL.Name = "me_SQL";
            this.me_SQL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me_SQL.Properties.Appearance.Options.UseFont = true;
            this.me_SQL.Size = new System.Drawing.Size(626, 263);
            this.me_SQL.TabIndex = 0;
            this.me_SQL.UseOptimizedRendering = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_PREVIEW);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 294);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(957, 177);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_PREVIEW
            // 
            this.gc_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PREVIEW.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_PREVIEW.Location = new System.Drawing.Point(2, 2);
            this.gc_PREVIEW.MainView = this.gv_PREVIEW;
            this.gc_PREVIEW.Margin = new System.Windows.Forms.Padding(2);
            this.gc_PREVIEW.Name = "gc_PREVIEW";
            this.gc_PREVIEW.Size = new System.Drawing.Size(953, 173);
            this.gc_PREVIEW.TabIndex = 1;
            this.gc_PREVIEW.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PREVIEW});
            // 
            // gv_PREVIEW
            // 
            this.gv_PREVIEW.GridControl = this.gc_PREVIEW;
            this.gv_PREVIEW.Name = "gv_PREVIEW";
            this.gv_PREVIEW.OptionsView.ColumnAutoWidth = false;
            this.gv_PREVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // FrmSelctGenScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 471);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSelctGenScript";
            this.Load += new System.EventHandler(this.FrmSelctGenScript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_SQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PREVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PREVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_PREVIEW;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PREVIEW;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit me_SQL;
        private System.Windows.Forms.Button btn_GEN_GRID;
        private System.Windows.Forms.Button btn_GEN_SCRIPT;
    }
}
﻿/*****************************************************************************
 * 
 * ReoGrid - .NET 表計算スプレッドシートコンポーネント
 * https://reogrid.net/jp
 *
 * ReoGrid 日本語版デモプロジェクトは MIT ライセンスでリリースされています。
 * 
 * このソフトウェアは無保証であり、このソフトウェアの使用により生じた直接・間接の損害に対し、
 * 著作権者は補償を含むあらゆる責任を負いません。 
 * 
 * Copyright (c) 2012-2025 UNVELL Inc., All Rights Reserved.
 * https://unvell.com/
 * 
 ****************************************************************************/

namespace unvell.ReoGrid.Demo.WorksheetDemo
{
	partial class ClipboardEventDemo
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
			this.grid = new unvell.ReoGrid.ReoGridControl();
			this.chkPreventPasteEvent = new System.Windows.Forms.CheckBox();
			this.chkCustomizePaste = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grid
			// 
			this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.grid.ColumnHeaderContextMenuStrip = null;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.LeadHeaderContextMenuStrip = null;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.Name = "grid";
			this.grid.RowHeaderContextMenuStrip = null;
			this.grid.Script = null;
			this.grid.SheetTabContextMenuStrip = null;
			this.grid.SheetTabNewButtonVisible = true;
			this.grid.SheetTabVisible = true;
			this.grid.SheetTabWidth = 400;
			this.grid.ShowScrollEndSpacing = true;
			this.grid.Size = new System.Drawing.Size(680, 456);
			this.grid.TabIndex = 2;
			this.grid.Text = "reoGridControl1";
			// 
			// chkPreventPasteEvent
			// 
			this.chkPreventPasteEvent.AutoSize = true;
			this.chkPreventPasteEvent.Location = new System.Drawing.Point(14, 25);
			this.chkPreventPasteEvent.Name = "chkPreventPasteEvent";
			this.chkPreventPasteEvent.Size = new System.Drawing.Size(134, 17);
			this.chkPreventPasteEvent.TabIndex = 3;
			this.chkPreventPasteEvent.Text = "貼り付ける操作を禁止";
			this.chkPreventPasteEvent.UseVisualStyleBackColor = true;
			// 
			// chkCustomizePaste
			// 
			this.chkCustomizePaste.AutoSize = true;
			this.chkCustomizePaste.Location = new System.Drawing.Point(14, 63);
			this.chkCustomizePaste.Name = "chkCustomizePaste";
			this.chkCustomizePaste.Size = new System.Drawing.Size(164, 17);
			this.chkCustomizePaste.TabIndex = 4;
			this.chkCustomizePaste.Text = "貼り付ける操作をカスタマイズ";
			this.chkCustomizePaste.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chkCustomizePaste);
			this.panel1.Controls.Add(this.chkPreventPasteEvent);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(680, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(190, 456);
			this.panel1.TabIndex = 5;
			// 
			// ClipboardEventDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grid);
			this.Controls.Add(this.panel1);
			this.Name = "ClipboardEventDemo";
			this.Size = new System.Drawing.Size(870, 456);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ReoGridControl grid;
		private System.Windows.Forms.CheckBox chkPreventPasteEvent;
		private System.Windows.Forms.CheckBox chkCustomizePaste;
		private System.Windows.Forms.Panel panel1;
	}
}
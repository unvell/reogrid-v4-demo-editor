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

namespace unvell.ReoGrid.Demo.DocumentDemo
{
	partial class InvoiceExcelDocDemo
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
			this.reoGridControl = new unvell.ReoGrid.ReoGridControl();
			this.SuspendLayout();
			// 
			// reoGridControl
			// 
			this.reoGridControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.reoGridControl.ColumnHeaderContextMenuStrip = null;
			this.reoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reoGridControl.LeadHeaderContextMenuStrip = null;
			this.reoGridControl.Location = new System.Drawing.Point(0, 0);
			this.reoGridControl.Name = "reoGridControl";
			this.reoGridControl.RowHeaderContextMenuStrip = null;
			this.reoGridControl.Script = null;
			this.reoGridControl.SheetTabContextMenuStrip = null;
			this.reoGridControl.SheetTabWidth = 400;
			this.reoGridControl.Size = new System.Drawing.Size(604, 473);
			this.reoGridControl.TabIndex = 1;
			this.reoGridControl.Text = "reoGridControl1";
			// 
			// ProjectSummaryDocDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.reoGridControl);
			this.Name = "ProjectSummaryDocDemo";
			this.Size = new System.Drawing.Size(604, 473);
			this.ResumeLayout(false);

		}

		#endregion

		private ReoGridControl reoGridControl;
	}
}

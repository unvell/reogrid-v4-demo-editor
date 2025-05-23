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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace unvell.ReoGrid.Demo.DocumentDemo
{
	public partial class MazeDocDemo : UserControl
	{
		public MazeDocDemo()
		{
			InitializeComponent();

			// get first worksheet instance
			var sheet = reoGridControl.Worksheets[0];

			// load tepmlate from RGF file.
			// RGF file is a file format that contains worksheet information, 
			// such as data, styles, borders, formula and etc, RGF file can 
			// be saved and loaded by ReoGrid and ReoGridEditor.
			//
			// https://reogrid.net/document/rgf-format
			// 
			sheet.LoadRGF("_Templates\\RGF\\Maze.rgf");

			// hide sheet tab control
			reoGridControl.SetSettings(WorkbookSettings.View_ShowSheetTabControl, false);

			// hide row header and column header
			sheet.SetSettings(WorksheetSettings.View_ShowHeaders, false);

			// set entire worksheet read-only
			sheet.SetSettings(WorksheetSettings.Edit_Readonly, true);

			// disable sheet selection
			sheet.SelectionMode = WorksheetSelectionMode.None;
		}
	}
}

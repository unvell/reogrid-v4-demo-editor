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
using System.Windows.Forms;

namespace unvell.ReoGrid.Demo.WorksheetDemo.EdgeFreeze
{
	public partial class TopFreezeDemo : UserControl
	{
		public TopFreezeDemo()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			var worksheet = reoGridControl.CurrentWorksheet;

			// freeze to top
			worksheet.FreezeToCell(10, 0, FreezeArea.Top);

			worksheet[5, 5] = "frozen region";
			worksheet[12, 5] = "active region";
		}
	}
}

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
using unvell.ReoGrid.Demo.PerformanceDemo;

namespace unvell.ReoGrid.Demo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DemoItemsForm());

			//var form = new Form();
			//form.Controls.Add(new LazyLoadPerformanceDemo()
			//{
			//	Dock = DockStyle.Fill,
			//});
			//form.WindowState = FormWindowState.Maximized;
			//Application.Run(form);
		}
	}
}

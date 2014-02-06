using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Presentation = Microsoft.Office.Interop.PowerPoint.Presentation;
using Office = Microsoft.Office.Core;





namespace ContextDiffLearningSystem
{
    public partial class ThisAddIn
    {
		 /* * 
		  * 
		  *  ThisAddInクラスでは，
		  *  様々なイベント処理を行う．
		  * 
		  * */
		 
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
			registAllEvents();
			
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
			
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion

		//イベントに対応するメソッドを登録
		private void registAllEvents()
		{
			var _app = new PowerPoint.Application();

			//通常のパワーポイントを利用しているときのイベント
			((PowerPoint.EApplication_Event)_app).NewPresentation += NewPresentation;
			_app.PresentationBeforeClose += PresentationBeforeClose;
			_app.PresentationBeforeSave += PresentationBeforeSave;
			_app.PresentationCloseFinal += PresentationCloseFinal;
			_app.PresentationOpen += PresentationOpen;
			_app.PresentationClose += PresentationClose;
			_app.AfterNewPresentation += AfterNewPresentation;
			_app.AfterPresentationOpen += AfterPresentationOpen;

			_app.PresentationNewSlide += PresentationNewSlide;
			_app.PresentationPrint += PresentationPrint;
			_app.PresentationSave += PresentationSave;
			_app.PresentationSync +=PresentationSync;

			_app.WindowActivate += WindowActivate;
			_app.WindowBeforeDoubleClick += WindowBeforeDoubleClick;
			_app.WindowBeforeRightClick += WindowBeforeRightClick;
			_app.WindowDeactivate += WindowDeactivate;
			_app.WindowSelectionChange += WindowSelectionChange;

			_app.SlideSelectionChanged += SlideSelectionChanged;

			_app.ColorSchemeChanged += ColorSchemeChanged;

			//権限上，編集ができないPPTを利用しているときのイベント
			_app.ProtectedViewWindowActivate += ProtectedViewWindowActivate;
			_app.ProtectedViewWindowBeforeClose += ProtectedViewWindowBeforeClose;
			_app.ProtectedViewWindowBeforeEdit += ProtectedViewWindowBeforeEdit;
			_app.ProtectedViewWindowDeactivate += ProtectedViewWindowDeactivate;
			_app.ProtectedViewWindowOpen += ProtectedViewWindowOpen;
			
			//スライドショーを使用中のイベント
			_app.SlideShowBegin += SlideShowBegin;
			_app.SlideShowEnd += SlideShowEnd;
			_app.SlideShowNextBuild += SlideShowNextBuild;
			_app.SlideShowNextClick += SlideShowNextClick;
			_app.SlideShowNextSlide += SlideShowNextSlide;
			_app.SlideShowOnNext += SlideShowOnNext;
			_app.SlideShowOnPrevious += SlideShowOnPrevious;

		}


		/* *
		 * 
		 * 
		 * */


		// プレゼンテーションを開いた時のイベントハンドラ
		private void PresentationOpen(Presentation Presen)
		{
			Console.WriteLine("PresentationOpen\n");
		}

		// プレゼンテーションを閉じた時のイベントハンドラ
		private void PresentationClose(Presentation Presen)
		{
			Console.WriteLine("PresentationClose\n");
		}


		private void AfterNewPresentation(Presentation Presen)
		{
			
		}

		private void AfterPresentationOpen(Presentation Presen)
		{

		}

		private void ColorSchemeChanged(PowerPoint.SlideRange slideRange)
		{

		}

		private void NewPresentation(Presentation Presen)
		{

		}

		private void PresentationBeforeClose(PowerPoint.Presentation Pres, ref bool Cancel)
		{

		}

		private void PresentationBeforeSave(Presentation Presen, ref Boolean cancel)
		{


		}


		private void WindowBeforeRightClick(PowerPoint.Selection sel, ref Boolean cancel)
		{


		}

		private void WindowBeforeDoubleClick(PowerPoint.Selection sel, ref Boolean cancel)
		{

		}

		private void SlideSelectionChanged(PowerPoint.SlideRange slideRange)
		{

		}

		private void PresentationSync(Presentation Presen, Office.MsoSyncEventType type)
		{


		}

		private void PresentationSave(Presentation Presen)
		{

		}

		private void PresentationPrint(Presentation Presen)
		{


		}

		private void PresentationNewSlide(PowerPoint.Slide slide)
		{


		}

		private void WindowBeforeDoubleClick()
		{


		}

		private void WindowActivate(Presentation Presen, PowerPoint.DocumentWindow Window)
		{


		}

		private void WindowDeactivate(Presentation Presen, PowerPoint.DocumentWindow Window)
		{


		}

		private void WindowSelectionChange(PowerPoint.Selection Sel)
		{


		}


		/* *
		 * 
		 * 
		 * */
		
		


		private void SlideShowOnPrevious(PowerPoint.SlideShowWindow window)
		{


		}

		private void SlideShowOnNext(PowerPoint.SlideShowWindow window)
		{


		}

		private void SlideShowNextSlide(PowerPoint.SlideShowWindow window)
		{


		}

		private void SlideShowNextClick(PowerPoint.SlideShowWindow window, PowerPoint.Effect effect)
		{


		}

		private void SlideShowNextBuild(PowerPoint.SlideShowWindow window)
		{


		}

		private void SlideShowEnd(Presentation Presen)
		{


		}

		private void SlideShowBegin(PowerPoint.SlideShowWindow window)
		{


		}

		/* *
		 * 
		 * 
		 * */

		void ProtectedViewWindowOpen(PowerPoint.ProtectedViewWindow ProtViewWindow)
		{
		   
		}

		void ProtectedViewWindowDeactivate(PowerPoint.ProtectedViewWindow ProtViewWindow)
		{

		}

		void ProtectedViewWindowBeforeEdit(PowerPoint.ProtectedViewWindow ProtViewWindow, ref bool Cancel)
		{

		}

		void ProtectedViewWindowBeforeClose(PowerPoint.ProtectedViewWindow ProtViewWindow, PowerPoint.PpProtectedViewCloseReason ProtectedViewCloseReason, ref bool Cancel)
		{

		}

		void ProtectedViewWindowActivate(PowerPoint.ProtectedViewWindow ProtViewWindow)
		{

		}

		void PresentationCloseFinal(PowerPoint.Presentation Pres)
		{

		}

		 


    }
}

namespace ContextDiffLearningSystem.ViewController
{
   partial class AddInMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
   {
	  /// <summary>
	  /// デザイナー変数が必要です。
	  /// </summary>
	  private System.ComponentModel.IContainer components = null;

	  public AddInMenu()
		 : base(Globals.Factory.GetRibbonFactory())
	  {
		 InitializeComponent();
	  }

	  /// <summary> 
	  /// 使用中のリソースをすべてクリーンアップします。
	  /// </summary>
	  /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
	  protected override void Dispose(bool disposing)
	  {
		 if (disposing && (components != null))
		 {
			components.Dispose();
		 }
		 base.Dispose(disposing);
	  }

	  #region コンポーネント デザイナーで生成されたコード

	  /// <summary>
	  /// デザイナーのサポートに必要なメソッドです。
	  /// このメソッドの内容をコード エディターで変更しないでください。
	  /// </summary>
	  private void InitializeComponent()
	  {
		 this.tab1 = this.Factory.CreateRibbonTab();
		 this.ContextDiffLearningMenuGroup = this.Factory.CreateRibbonGroup();
		 this.tab1.SuspendLayout();
		 // 
		 // tab1
		 // 
		 this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
		 this.tab1.Groups.Add(this.ContextDiffLearningMenuGroup);
		 this.tab1.Label = "TabAddIns";
		 this.tab1.Name = "tab1";
		 // 
		 // ContextDiffLearningMenuGroup
		 // 
		 this.ContextDiffLearningMenuGroup.Label = "メニュー";
		 this.ContextDiffLearningMenuGroup.Name = "ContextDiffLearningMenuGroup";
		 // 
		 // AddInMenu
		 // 
		 this.Name = "AddInMenu";
		 this.RibbonType = "Microsoft.PowerPoint.Presentation";
		 this.Tabs.Add(this.tab1);
		 this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AddInMenu_Load);
		 this.tab1.ResumeLayout(false);
		 this.tab1.PerformLayout();

	  }

	  #endregion

	  internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
	  internal Microsoft.Office.Tools.Ribbon.RibbonGroup ContextDiffLearningMenuGroup;
   }

   partial class ThisRibbonCollection
   {
	  internal AddInMenu AddInMenu
	  {
		 get { return this.GetRibbon<AddInMenu>(); }
	  }
   }
}

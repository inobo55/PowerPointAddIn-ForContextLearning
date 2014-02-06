namespace ContextDiffLearningSystem.View
{
   partial class Schema
   {
	  /// <summary> 
	  /// 必要なデザイナー変数です。
	  /// </summary>
	  private System.ComponentModel.IContainer components = null;

	  /// <summary> 
	  /// 使用中のリソースをすべてクリーンアップします。
	  /// </summary>
	  /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
	  /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
	  /// コード エディターで変更しないでください。
	  /// </summary>
	  private void InitializeComponent()
	  {
		 this.SchemaTreeView = new System.Windows.Forms.TreeView();
		 this.SuspendLayout();
		 // 
		 // SchemaTreeView
		 // 
		 this.SchemaTreeView.Location = new System.Drawing.Point(0, 0);
		 this.SchemaTreeView.Name = "SchemaTreeView";
		 this.SchemaTreeView.Size = new System.Drawing.Size(169, 598);
		 this.SchemaTreeView.TabIndex = 0;
		 this.SchemaTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SchemaTreeView_AfterSelect);
		 // 
		 // Schema
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.Controls.Add(this.SchemaTreeView);
		 this.Name = "Schema";
		 this.Size = new System.Drawing.Size(169, 601);
		 this.ResumeLayout(false);

	  }

	  #endregion

	  private System.Windows.Forms.TreeView SchemaTreeView;
   }
}

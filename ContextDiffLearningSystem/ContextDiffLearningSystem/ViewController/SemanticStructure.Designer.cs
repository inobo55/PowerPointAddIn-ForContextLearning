namespace ContextDiffLearningSystem.View
{
   partial class SemanticStructure
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
		 this.SemanticTreeView = new System.Windows.Forms.TreeView();
		 this.CheckAnswerBtn = new System.Windows.Forms.Button();
		 this.ShowMemoBtn = new System.Windows.Forms.Button();
		 this.showCorrectPanelBtn = new System.Windows.Forms.Button();
		 this.SuspendLayout();
		 // 
		 // SemanticTreeView
		 // 
		 this.SemanticTreeView.Location = new System.Drawing.Point(3, 32);
		 this.SemanticTreeView.Name = "SemanticTreeView";
		 this.SemanticTreeView.Size = new System.Drawing.Size(181, 542);
		 this.SemanticTreeView.TabIndex = 0;
		 this.SemanticTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SemanticTreeView_AfterSelect);
		 // 
		 // CheckAnswerBtn
		 // 
		 this.CheckAnswerBtn.Location = new System.Drawing.Point(3, 3);
		 this.CheckAnswerBtn.Name = "CheckAnswerBtn";
		 this.CheckAnswerBtn.Size = new System.Drawing.Size(75, 23);
		 this.CheckAnswerBtn.TabIndex = 1;
		 this.CheckAnswerBtn.Text = "答え合わせ";
		 this.CheckAnswerBtn.UseVisualStyleBackColor = true;
		 this.CheckAnswerBtn.Click += new System.EventHandler(this.CheckAnswerBtn_Click);
		 // 
		 // ShowMemoBtn
		 // 
		 this.ShowMemoBtn.Location = new System.Drawing.Point(124, 3);
		 this.ShowMemoBtn.Name = "ShowMemoBtn";
		 this.ShowMemoBtn.Size = new System.Drawing.Size(57, 23);
		 this.ShowMemoBtn.TabIndex = 2;
		 this.ShowMemoBtn.Text = "メモする";
		 this.ShowMemoBtn.UseVisualStyleBackColor = true;
		 this.ShowMemoBtn.Click += new System.EventHandler(this.ShowMemoBtn_Click);
		 // 
		 // showCorrectPanelBtn
		 // 
		 this.showCorrectPanelBtn.Location = new System.Drawing.Point(106, 574);
		 this.showCorrectPanelBtn.Name = "showCorrectPanelBtn";
		 this.showCorrectPanelBtn.Size = new System.Drawing.Size(75, 23);
		 this.showCorrectPanelBtn.TabIndex = 3;
		 this.showCorrectPanelBtn.Text = "解答を表示";
		 this.showCorrectPanelBtn.UseVisualStyleBackColor = true;
		 this.showCorrectPanelBtn.Click += new System.EventHandler(this.showCorrectPanelBtn_Click);
		 // 
		 // SemanticStructure
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.Controls.Add(this.showCorrectPanelBtn);
		 this.Controls.Add(this.ShowMemoBtn);
		 this.Controls.Add(this.CheckAnswerBtn);
		 this.Controls.Add(this.SemanticTreeView);
		 this.Name = "SemanticStructure";
		 this.Size = new System.Drawing.Size(184, 600);
		 this.ResumeLayout(false);

	  }

	  #endregion

	  private System.Windows.Forms.TreeView SemanticTreeView;
	  private System.Windows.Forms.Button CheckAnswerBtn;
	  private System.Windows.Forms.Button ShowMemoBtn;
	  private System.Windows.Forms.Button showCorrectPanelBtn;
   }
}

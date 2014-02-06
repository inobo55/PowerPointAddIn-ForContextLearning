using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContextDiffLearningSystem.Entity
{
   class Slide
   {
	  private int SlideIndex;
	  private string Metadata;
	  private bool Highlights;
	  private string SlideTitle;
	  private string SlideSentence;

	  //コンストラクタ
	  public Slide(int slideIndex,string metadata)
	  {
		 this.SlideIndex = slideIndex;
		 this.Metadata = metadata;

	  }

	  //アクセッサ
	  public void setSlideIndex(int index){
		 this.SlideIndex = index;
	  }
	  public void setMetadata(string meta){
		 this.Metadata = meta;
	  }
	  public void setHighlight(bool highlight){
		 this.Highlights = highlight;
	  }
	  public void setSlideTitle(string title){
		 this.SlideTitle = title;
	  }
	  public void setSlideSenttence(string sentence){
		 this.SlideSentence = sentence;
	  }
	  public int slideIndex(){
		 return this.SlideIndex;
	  }
	  public string metadata(){
		 return this.Metadata;
	  }
	  public bool highlights(){
		 return Highlights;
	  }
	  public string slideTitle(){
		 return SlideTitle;
	  }
	  public string slideSentence(){
		 return SlideSentence;
	  }
	  


   }
}

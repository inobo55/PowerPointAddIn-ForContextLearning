using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;


namespace ContextDiffLearningSystem.Entity
{
   class PDocument
   {

	  private Dictionary<string,string> FileMetaData;
	  private ArrayList Slides;
	  private bool SlidesCorrect;
	  private string PptPath;
	  private string XmlPath;

	  public static string KEY_SPEAKER = "speaker";
	  public static string KEY_GROUP = "group";
	  public static string KEY_TIME = "time";
	  public static string KEY_PLACE = "place";

	  public PDocument(Dictionary<string,string> fileMeta)
	  {
		 
		 
	  }

	  //未付与を作成．
	  private void initSlideMeta()
	  {
		 

	  }

	  public string getFMDElementWithKey(string key)
	  {
		 Dictionary<string, string> fmd = fileMetadata();
		 string value;
		 if (fmd.TryGetValue(key, out value))
			return value;
		 return null;
	  }
	  public void setFMDElementWith(string value, string key)
	  {
		 Dictionary<string, string> fmd = fileMetadata();
		 fmd.Add(key, value);
		 setFileMetadata(fmd);
	  }

	  //アクセッサ
	  public void setFileMetadata(Dictionary<string,string> fileMeta)
	  {
		 this.FileMetaData = fileMeta;
	  }
	  public void setSlides(ArrayList slides)
	  {
		this.Slides = slides;
	  }
	  public void setSlidesCorrect(bool slidesCorrect)
	  {
		 this.SlidesCorrect = slidesCorrect;
	  }
	  public void setPptPath(string pptPath)
	  {
		 this.PptPath = pptPath;
	  }
	  public void setXmlPath(string xmlPath)
	  {
		 this.XmlPath = xmlPath;
	  }
	  public Dictionary<string,string> fileMetadata()
	  {
		 return FileMetaData;
	  }
	  public bool slidesCorrect()
	  {
		 return this.SlidesCorrect;
	  }
	  public string xmlPath()
	  {
		 return this.XmlPath;
	  }
	  public string pptPath()
	  {
		 return this.PptPath;
	  }


   }
}

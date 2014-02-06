using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Office.Interop.PowerPoint;


namespace ContextDiffLearningSystem.Model
{
   /* *
    * XMLに関する処理を担うクラス
    * 
    * XMLの読み込み，保存などを行う．
    * */

   class XML
   {
	  //意味的構造XML＝＞ArrayList
	  public void readSemanticXml(string semantic_path)
	  {
		 if(semantic_path == null) return;

		 XmlDocument xmldoc = new XmlDocument();
		 xmldoc.LoadXml(semantic_path);

		 Dictionary<string,string> fileMetadata = new Dictionary<string,string>();

		 setFileMetadata(xmldoc,fileMetadata);



	  }

	  private void setFileMetadata(XmlDocument xmldoc , Dictionary<string,string> fileMD)
	  {
		 string time=null,speaker=null,group=null,place=null;

		 foreach (XmlNode rt in xmldoc.GetElementsByTagName("Time"))
			time = rt.InnerXml;
		 foreach (XmlNode sp in xmldoc.GetElementsByTagName("Speaker"))
			speaker = sp.InnerXml;
		 foreach (XmlNode gr in xmldoc.GetElementsByTagName("Group"))
			group = gr.InnerXml;
		 foreach (XmlNode pl in xmldoc.GetElementsByTagName("Place"))
			place = pl.InnerXml;

		 fileMD.Add(Entity.PDocument.KEY_TIME, time);
		 fileMD.Add(Entity.PDocument.KEY_SPEAKER, speaker);
		 fileMD.Add(Entity.PDocument.KEY_GROUP, group);
		 fileMD.Add(Entity.PDocument.KEY_PLACE, place);
		 
	  }

	  
	  /** ここまでがreadSemanticXMLに使用するメソッド  **/


	  //スキーマXML＝＞ArrayList
	  public void readSchemaXml(string schema_path)
	  {
		 if(schema_path == null) return;

	  }

	  //
	  public void saveSemanticXml(string path)
	  {


	  }

	  //
	  public void createSemanticXml()
	  {
		 

	  }

	  private void createFileMD()
	  {
		 

	  }

	  private void createSlideMD()
	  {
		 

	  }

   }
}
